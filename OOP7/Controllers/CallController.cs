using OOP7.Models;
using System.ComponentModel;

namespace OOP7.Controllers
{
    public class CallController
    {

        public BindingList<Call> calls { get; private set; }

        public CallController()
        {
            calls = new BindingList<Call>();
        }

        public bool AddRecord(string phonefrom, string phoneto, DateTime date)
        {
            try
            {
                bool exist = calls.Any(item =>
                    item.PhoneFrom == phonefrom.Trim() &&
                    item.PhoneTo == phoneto.Trim() &&
                    item.Date.ToString("dd.MM.yyyy HH:mm:ss") == date.ToString("dd.MM.yyyy HH:mm:ss")
                );
                if( !exist )
                {
                    Call call = new Call(phonefrom.Trim(), phoneto.Trim(), date);
                    calls.Add(call);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public bool RemoveRecord(Call call)
        {
            if (calls.Contains(call))
            {
                calls.Remove(call);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool EditRecord(Call call, string newphonefrom, string newphoneto, DateTime newdate)
        {
            try
            {
                bool exists = calls.Any(item =>
                    item != call &&
                    item.PhoneFrom == newphonefrom.Trim() &&
                    item.PhoneTo == newphoneto.Trim() &&
                    item.Date.ToString("dd.MM.yyyy HH:mm:ss") == newdate.ToString("dd.MM.yyyy HH:mm:ss")
                );
                if(!exists)
                {
                    call.PhoneFrom = newphonefrom;
                    call.PhoneTo = newphoneto;
                    call.Date = newdate;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void Clear()
        {
            calls.Clear();
        }

    }
}
