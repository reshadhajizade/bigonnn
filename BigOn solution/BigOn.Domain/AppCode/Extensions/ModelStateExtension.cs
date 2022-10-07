using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;
namespace BigOn.Domain.AppCode.Extensions
{
    public static partial class Extension
    {
        public static List<ValidationError> GetErrors( this ModelStateDictionary modelState)
        {

            var errors = (from acar in modelState.Keys

                          where modelState[acar] != null && modelState[acar].Errors.Count > 0
                          select new ValidationError(acar,  modelState[acar].Errors[0].ErrorMessage)
                       ).ToList();
             
            return errors;

        }

           public class ValidationError
        {
            public string fieldName { get; set; }   
            public string Message { get; set; }


            public ValidationError(string fieldName,string message)
            {
                this.fieldName = fieldName; 
                this.Message = message; 
            }
        }

 }  }


 