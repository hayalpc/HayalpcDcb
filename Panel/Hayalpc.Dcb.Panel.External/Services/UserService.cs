using Hayalpc.Dcb.Common.Helpers;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Dcb.Common.Dtos;
using Hayalpc.Dcb.Common.Enums;
using Hayalpc.Library.Common.Models;
using Hayalpc.Library.Common.Results;
using Hayalpc.Library.Common.Enums;
using Hayalpc.Library.Log;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Hayalpc.Library.Common.Helpers;

namespace Hayalpc.Dcb.Panel.External.Services
{
    public class UserService : BaseService<UserVM>, IUserService
    {
        private readonly ISessionHelper session;
        private readonly IMemoryCache memoryCache;
        private readonly IHtmlHelper htmlHelper;

        public UserService(Library.Common.Helpers.Interfaces.IHttpClientHelper clientHelper, IHpLogger logger, ISessionHelper session, IMemoryCache memoryCache, IHtmlHelper htmlHelper) : base(clientHelper, logger, "user")
        {
            this.session = session;
            this.memoryCache = memoryCache;
            this.htmlHelper = htmlHelper;
        }

        public void LoadBulletins()
        {
            var key = "UserBulletins-" + session.User.Id;
            memoryCache.GetOrCreate(key, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(3);
                var result = clientHelper.Get<DataResult<List<UserBulletinDto>>>(AppConfigHelper.ApiUrl, "user/bulletin");

                var bulletins = new List<UserBulletinDto>();
                if (result.IsSuccess && result.Data.Count > 0)
                    bulletins = result.Data;
                var user = session.User;
                user.Bulletins = bulletins;
                session.User = user;
                return result.Data;
            });
        }

        public IDataResult<Dcb.Common.Models.SessionModel> Login(LoginRequest request)
        {
            request.Password = Md5Helper.Get(request.Email + ":" + request.Password);
            var response = clientHelper.Post<LoginRequest, DataResult<Dcb.Common.Models.SessionModel>>(AppConfigHelper.ApiUrl, "user/login", request);
            return response;
        }

        public void LoadUserData()
        {
            if (session.UserData == null)
            {
                var response = clientHelper.Get<DataResult<UserDataDto>>(AppConfigHelper.ApiUrl, "user/data");
                response.Data.CarrierList = htmlHelper.GetEnumSelectList(typeof(CarrierId)).ToList();
                session.UserData = response.Data;
            }
        }

        public override IDataResult<UserVM> Update(long id, UserVM model)
        {
            var oriDat = Get(id);
            if (oriDat.IsSuccess)
            {
                var user = oriDat.Data;
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Status = model.Status;
                user.Type = model.Type;
                user.MerchantId = model.MerchantId;
                user.Title = model.Title;
                user.Phone = model.Phone;
                user.RoleIds = model.RoleIds;

                return base.Update(id, model);
            }
            else
                return oriDat;
        }
    }
}
