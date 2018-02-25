using System;
using Domain.StaffUser.Commands;
using FluentValidation;

namespace Domain.StaffUser.Validators
{
    public class AddPhoneNumberToStaffUserValidator : AbstractValidator<AddPhoneNumberToStaffUser>
    {
        public AddPhoneNumberToStaffUserValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(_ => _.StaffUserId)
                .NotEmpty().WithMessage("StaffUserId cannot be empty")
                .NotEqual(Guid.Empty).WithMessage("StaffUserId cannot be Guid.Empty");

            RuleFor(_ => _.Role)
                .IsInEnum().WithMessage("Role must be defined and have a correct value");

            RuleFor(_ => _.PhoneNumber)
                .NotEmpty().WithMessage("PhoneNumber cannot be empty");
            // TODO: Add aditional rules here
        }
    }
}