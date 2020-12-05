using System;
using System.Collections.Generic;
using System.Text;
using PADIP.Data;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PADIP
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://padip-47ef0.firebaseio.com/");
  

        public async Task<List<Gebeler>> GetAllPersons()
        {

            return (await firebase
              .Child("Gebeler")
              .OnceAsync<Gebeler>()).Select(item => new Gebeler
              {
                  Isimsoyisim = item.Object.Isimsoyisim,
                  Yas = item.Object.Yas
              }).ToList();
        }

        public async Task AddPerson(string isimsoyisim, string yas  , string boy ,string kilo, string kilogebe,string egitim)
        {

            await firebase
              .Child("Gebeler")
              .PostAsync(new Gebeler() { Isimsoyisim = isimsoyisim, Yas = yas, Boy= boy,Kilo=  kilo, Kilogebe=  kilogebe, Egitim= egitim });
        }
    }

}
