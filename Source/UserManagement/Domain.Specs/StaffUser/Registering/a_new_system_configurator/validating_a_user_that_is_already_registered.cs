using Machine.Specifications;
using Domain.StaffUser;
using Domain.StaffUser.Registering;
using System;
using FluentValidation.Results;
using given = Domain.Specs.StaffUser.UserInfo.given;

namespace Domain.Specs.StaffUser.Registering.a_new_system_configurator
{
    [Subject("Registering")]
    public class validating_a_user_that_is_already_registered
    {
        static RegisterNewSystemConfigurator register;
        static RegisterNewSystemConfiguratorBusinessRulesValidator sut;
        static StaffUserIsRegistered staff_user_is_registered;
        static CanAssignToNationalSociety can_assign_to_national_society;
        static ValidationResult validation_results;
        Establish context = () => 
        {
            register = new RegisterNewSystemConfigurator
            {
                UserDetails = given.user_info.build_valid_instance(),
                AssignedNationalSocieties = new [] { Guid.NewGuid() }
            };

            staff_user_is_registered = (id) => true;
            can_assign_to_national_society = (id) => true;

            sut = new RegisterNewSystemConfiguratorBusinessRulesValidator(staff_user_is_registered, can_assign_to_national_society);
        };

        Because of = () => validation_results = sut.Validate(register);

        It should_be_invalid = () => validation_results.ShouldBeInvalid();
        It should_have_one_invalidation = () => validation_results.ShouldHaveInvalidCountOf(1);
        It should_indicate_that_the_staff_user_id_is_invalid = () => validation_results.ShouldHaveInvalidProperty($"{nameof(register.UserDetails)}.{nameof(register.UserDetails.StaffUserId)}");
    }
}