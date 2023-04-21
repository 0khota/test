﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTTaxiDriver.AspMvc.Controllers.Account
{
    using TAccessModel = Logic.Models.Account.Role;
    using TViewModel = AspMvc.Models.Account.IdentityRole;
    using TFilterModel = AspMvc.Models.Account.IdentityRoleFilter;
    using TAccessContract = Logic.Contracts.Account.IRolesAccess<Logic.Models.Account.Role>;

    public partial class IdentityRolesController : Controllers.FilterGenericController<TAccessModel, TViewModel, TFilterModel, TAccessContract>
    {
        ///
        /// Generated by the generator
        ///
        static IdentityRolesController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        protected override string ControllerName => "IdentityRoles";
        ///
        /// Generated by the generator
        ///
        public IdentityRolesController(TAccessContract other)
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
    }
}
#endif
//MdEnd
