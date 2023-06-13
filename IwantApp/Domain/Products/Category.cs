using Flunt.Validations;
using IWantApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace IwantApp.Domain.Products;

public class Category : Entity
{
    public string Name { get; private set; }
    public bool Active { get; private set; }

    public Category(string name, string createdBy, string editedBy)
    {
        Name = name;
        Active = true;
        CreatedBy = createdBy;
        EditedBy = editedBy;
        CreatedOn = DateTime.Now;
        EditedOn = DateTime.Now;
                
        Validate();
    }

    private void Validate()
    {
        var contract = new Contract<Category>()
        .IsNotNull(Name, "Name")
        .IsGreaterOrEqualsThan(Name, 3, "Name")
        .IsNotNullOrEmpty(CreatedBy, "CreatedBy")
        .IsNotNullOrEmpty(EditedBy, "EditedBy");
        AddNotifications(contract);
    }

    public void EditInfo(string name, bool active, string editeby)
    {
        Active = active;
        Name= name;
        EditedBy = editeby;


        Validate(); 

    }
}


