﻿
using Core.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
        List<UserDetailDto> GetUserDetails(Expression<Func<UserDetailDto, bool>> filter = null);

        List<OperationClaim> GetClaims(User user);
    }
}
