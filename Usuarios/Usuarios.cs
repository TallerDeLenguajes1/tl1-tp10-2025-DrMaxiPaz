namespace Usuarios
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Address
    {
        public Address(
            string street,
            string suite,
            string city,
            string zipcode,
            Geo geo
        )
        {
            this.street = street;
            this.suite = suite;
            this.city = city;
            this.zipcode = zipcode;
            this.geo = geo;
        }

        public string street { get; }
        public string suite { get; }
        public string city { get; }
        public string zipcode { get; }
        public Geo geo { get; }
    }

    public class Company
    {
        public Company(
            string name,
            string catchPhrase,
            string bs
        )
        {
            this.name = name;
            this.catchPhrase = catchPhrase;
            this.bs = bs;
        }

        public string name { get; }
        public string catchPhrase { get; }
        public string bs { get; }
    }

    public class Geo
    {
        public Geo(
            string lat,
            string lng
        )
        {
            this.lat = lat;
            this.lng = lng;
        }

        public string lat { get; }
        public string lng { get; }
    }

    public class Usuario
    {
        public Usuario(
            int? id,
            string name,
            string username,
            string email,
            Address address,
            string phone,
            string website,
            Company company
        )
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.email = email;
            this.address = address;
            this.phone = phone;
            this.website = website;
            this.company = company;
        }

        public int? id { get; }
        public string name { get; }
        public string username { get; }
        public string email { get; }
        public Address address { get; }
        public string phone { get; }
        public string website { get; }
        public Company company { get; }
    }


}