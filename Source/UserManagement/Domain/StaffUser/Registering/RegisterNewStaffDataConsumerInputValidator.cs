using System;
using doLittle.FluentValidation.Commands;
using FluentValidation;

namespace Domain.StaffUser.Registering
{

    public class RegisterNewStaffDataConsumerInputValidator 
                    : NewExtendedRegistrationInputValidator<RegisterNewStaffDataConsumer,StaffDataConsumer>
    {
        public RegisterNewStaffDataConsumerInputValidator()
        {
            RuleFor(_ => (_ as IHaveALocation))
                .NotNull()
                .SetValidator(new HaveALocationValidator());
        }
    }    
}