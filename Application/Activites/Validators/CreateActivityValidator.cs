using System;
using System.Security.Cryptography.X509Certificates;
using Application.Activites.Commands;
using FluentValidation;


namespace Application.Activites.Validators;

public class CreateActivityValidator : AbstractValidator<CreateActivity.Command>
{
    public CreateActivityValidator()
    {
        RuleFor(x => x.ActivityDto.Title).NotEmpty().WithMessage("Title is Required");
        RuleFor(x => x.ActivityDto.Description).NotEmpty().WithMessage("Description is Required");
       
    }

}
