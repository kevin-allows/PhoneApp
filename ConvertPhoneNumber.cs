using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    public class ConvertPhoneNumber
    {
        private string countryCode, providerCode, firstPart, secondPart;

        public static string toHungarinanFormat(string phoneNumber)
        {
            ConvertPhoneNumber convertedPhoneNumber = new ConvertPhoneNumber();
            convertedPhoneNumber.countryCode = phoneNumber.Substring(0, 2);
            convertedPhoneNumber.providerCode = phoneNumber.Substring(2, 2);
            convertedPhoneNumber.firstPart = phoneNumber.Substring(4, 3);
            convertedPhoneNumber.secondPart = phoneNumber.Substring(7, 4);

            return string.Format("({0}{1})/{2}-{3}",
                convertedPhoneNumber.countryCode, convertedPhoneNumber.providerCode,
                convertedPhoneNumber.firstPart, convertedPhoneNumber.secondPart);
        }

    }
}
