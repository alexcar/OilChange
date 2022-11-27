using AutoMapper;
using Contracts;
using EmailService;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CompanyUserService : ICompanyUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;

        public CompanyUserService(
            IRepositoryManager repository,
            IMapper mapper,
            ILoggerManager logger,            
            UserManager<User> userManager)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task CreateUserAsync(CompanyUserForCreationDto companyUserDto)
        {
            await ValidateFields(companyUserDto);
            InsertCompanyUser(companyUserDto);
            var result = await RegisterUser(companyUserDto);

            if (result.Succeeded)
            {
                await _repository.SaveAsync();
                _logger.LogInfo($"Company User {companyUserDto.FirstName} created successfully.");
            }
            else
            {
                // TODO: Gravar log dos possíveis erros ao incluir/alterar/excluir nas tabelas customer, vehicle, user e roles.
                var errors = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    errors.Append(error.Description);
                }

                throw new Exception($"Não foi possível registrar o usuário devido ao(s) seguinte(s) erro(s): {errors.ToString()} ");
            }
        }

        public async Task<bool> EmailAlreadyRegistered(string email) =>
            await _repository.Customer.EmailAlreadyRegistered(email);

        public async Task<bool> LoginAlreadyRegistered(string login) =>
            await _repository.Customer.loginAlreadyRegistered(login);

        private async Task ValidateFields(CompanyUserForCreationDto companyUserDto)
        {
            if (await EmailAlreadyRegistered(companyUserDto.Email))
                throw new Exception($"Já existe um usuário cadastrado com o email: {companyUserDto.Email.Trim()}");

            if (await LoginAlreadyRegistered(companyUserDto.Login.Trim()))
                throw new Exception($"Já existe um usuário cadastrado com o login: {companyUserDto.Login.Trim()}");
        }

        private void InsertCompanyUser(CompanyUserForCreationDto companyUserDto)
        {
            var companyUser = new CompanyUser()
            {
                FirstName = companyUserDto.FirstName,
                LastName = companyUserDto.LastName,
                Email = companyUserDto.Email,
                Login = companyUserDto.Login,
                PerfilId = Guid.Parse("6F8DB79B-39A8-42EF-A237-EC9790E63E27")
            };

            _repository.CompanyUser.CreateUser(companyUser);
        }

        private async Task<IdentityResult> RegisterUser(CompanyUserForCreationDto companyUserDto)
        {
            var userForRegistration = new UserForRegistrationDto()
            {
                FirstName = companyUserDto.FirstName,
                LastName = companyUserDto.LastName,
                UserName = companyUserDto.Login,
                Password = companyUserDto.Password,
                Email = companyUserDto.Email,                
                Roles = new List<string>
                {
                    "Administrator"
                }
            };

            var user = _mapper.Map<User>(userForRegistration);
            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            }

            return result;
        }
    }
}
