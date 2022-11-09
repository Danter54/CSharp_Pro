using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class House
    {
        private string? _address;

        public string? Nickname { get; set; }

        public House(string address)
        {
            this._address = address;
            this.Nickname = String.Empty;
        }

        public House(string address, string nickname)
        {
            this._address = address;
            this.Nickname = nickname;
        }

        public void ChangeAddress(string? address)
        {
            if (String.IsNullOrEmpty(address) || address.Length<5)
            {
                Console.WriteLine("Your address is null!");
                return;
            } else { _address = address; }
        }

        public void OutputAddress()
        {
            Console.WriteLine($"Address is: {_address}");
        }

        public override string ToString()
        {
            if (_address == null || Nickname == null)
            {
                return "Haven`t address or nickname";
            }
            else if (!string.IsNullOrEmpty(Nickname))
            {
                return $"Nickname is {Nickname}";
            }
            else
            { return $"Address is {_address}"; }
        }

        public override bool Equals(object? obj)
        {
            if (! (obj is House))
            {
                return false;
            }
            House other = (House)obj;
            return this._address == other._address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this);
        }

        public static bool operator ==(House house1, House house2)
        {
            return house1.Equals(house2);
        }

        public static bool operator !=(House house1, House house2)
        {
            return !(house1 == house2);
        }
    }
}
