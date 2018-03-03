using System;
using doLittle.FluentValidation.Commands;
using FluentValidation;

namespace Domain.StaffUser.Registering
{

    public class RegisterNewDataOwnerInputValidator : NewExtendedRegistrationInputValidator<RegisterNewSystemConfigurator>
    {
        public RegisterNewDataOwnerInputValidator()
        {
            RuleFor(_ => (_ as IHaveALocation))
                .NotNull()
                .SetValidator(new HaveALocationValidator());
        }
    }
}