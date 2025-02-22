﻿using System;
using System.Threading.Tasks;
using WebAPI.Application.Models.User;
using WebAPI.DomainAPI.Extensions;

namespace WebAPI.Application.Services.Queries
{
	public interface IUserQueriesUseCase
	{
		Task<UserResult> AuthenticateUser(AuthUser authUser);

		Task<CollectionResult<UserResult>> GetUsersAsync(int limit, int offset);

		Task<UserResult> GetUserByIdAsync(Guid id);
	}
}
