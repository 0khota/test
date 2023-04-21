﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTTaxiDriver.AspMvc.Controllers.Account
{
    using TAccessModel = Logic.Models.Account.User;
    using TViewModel = AspMvc.Models.Account.IdentityUser;
    using TFilterModel = AspMvc.Models.Account.IdentityUserFilter;
    using TAccessContract = Logic.Contracts.Account.IUsersAccess;
    using System.Diagnostics.Metrics;

    public partial class IdentityUsersController : Controllers.FilterGenericController<TAccessModel, TViewModel, TFilterModel, TAccessContract>
    {
        ///
        /// Generated by the generator
        ///
        static IdentityUsersController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        protected override string ControllerName => "IdentityUsers";
        ///
        /// Generated by the generator
        ///
        public IdentityUsersController(TAccessContract other)
        : base(other)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        protected override TViewModel ToViewModel(TAccessModel accessModel, ActionMode actionMode)
        {
            var handled = false;
            var result = default(TViewModel);
            BeforeToViewModel(accessModel, actionMode, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = TViewModel.Create(accessModel);
            }
            AfterToViewModel(result, actionMode);
            return BeforeView(result, actionMode);
        }
        partial void BeforeToViewModel(TAccessModel accessModel, ActionMode actionMode, ref TViewModel? viewModel, ref bool handled);
        partial void AfterToViewModel(TViewModel viewModel, ActionMode actionMode);

        // Extensions
        private Models.Account.Identity[]? identityList;
        public Models.Account.Identity[] IdentityList
        {
            get
            {
                if (identityList == null)
                {
                    var services = HttpContext.RequestServices;
                    using var ctrl = (Logic.Contracts.Account.IIdentitiesAccess)services.GetService(typeof(Logic.Contracts.Account.IIdentitiesAccess))!;

                    ctrl.SessionToken = SessionWrapper.SessionToken;

                    identityList = Task.Run(async () => await ctrl.GetAllAsync("Email asc")).Result.Select(e => Models.Account.Identity.Create(e)).ToArray();
                }
                return identityList;
            }
        }

        partial void AfterToViewModel(Models.Account.IdentityUser viewModel, ActionMode actionMode)
        {
            viewModel.IdentityList = IdentityList;
            viewModel.IdentityEmail = IdentityList.FirstOrDefault(e => e.Id == viewModel.IdentityId)?.Email ?? string.Empty;
        }
        // Extensions
    }
}
#endif
//MdEnd
