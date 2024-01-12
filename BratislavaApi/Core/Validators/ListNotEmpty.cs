using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace BratislavaApi.Core.Validators
{
    public class ListNotEmpty : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {

            if (value is ICollection list)
            {
                return list.Count > 0;
            }

            return false;
        }
    }
}
