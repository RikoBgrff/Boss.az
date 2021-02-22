using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Boss.az
{
    //exceptionlari handle ele!!!!!!!!!!!!!!!!!
    class SystemManagement
    {

        Worker worker1 = new Worker
        {
            Username = "senanmahmudov",
            Password = "senan1234",
            Age = 24,
            City = "Baku",
            Name = "Senan",
            Surname = "Mahmudov",
            Email = "senan.mahmudov@gmail.com",
            Phone = "0513214543",
            CV = new Cv
            {
                AcceptanceScore = "446",
                Education = "ADNSU Computer Technology English Section",
                Languages = new Language
                {
                    LandLanguage = "Azerbaijanian",
                    B1 = "Japan",
                    C1 = "English",
                    A2 = "Russian",
                    A1 = "Arabic"

                },
                Certificates = new Certificates
                {
                    Certificate = "Basic IT Skills",
                    CertificateII = "ICT20115",
                    Diploma5 = "IELTS 7.0",
                    AdvancedDiploma6 = "STEP IT SYSTEM ADMINISTRATING"
                },
                Specialty = "System Administrator",
                Company = new OldCompany
                {
                    StartTime = "01/02/2018",
                    EndTime = "09/11/2019",
                    CompanyName = "KATV1"
                },
                GitHubLink = "github.com/SenanMahmudov",
                Linkedln = "linkedln.com/SenanMahmudov",
                Summary = "I worked in Katv1 on IT Department,I know 3 languages,I love work with collective."
            }
        };
        Worker worker2 = new Worker
        {
            Username = "yusifNamazli",
            Password = "yusif1234",
            Age = 28,
            City = "Baku",
            Name = "Yusif",
            Email = "yusif.namazli@gmail.com",
            Surname = "Namazli",
            Phone = "0708345896",
            CV = new Cv
            {
                AcceptanceScore = "664",
                Education = "BANM",
                Languages = new Language
                {
                    C1 = "English",
                    C2 = "Russian",
                    B1 = "Spanish",
                    B2 = "French",
                    A2 = "Turkish",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {
                    Certificate = "Basic IT Skills",
                    CertificateII = "ICT20115",
                    Diploma5 = "IELTS 8.0",
                    AdvancedDiploma6 = "SOCAR OIL CERTIFICATION"
                },
                Specialty = "Oil Specialist",
                Company = new OldCompany
                {
                    StartTime = "01/10/2016",
                    EndTime = "09/11/2020",
                    CompanyName = "BPI"
                },
            }
        };
        Worker worker3 = new Worker
        {
            Username = "bagirliarif",
            Password = "arif1234",
            Age = 17,
            City = "Baku",
            Name = "Arif",
            Surname = "Bagirli",
            Email = "rikobgrff.17@gmail.com",
            Phone = "0708397309",
            CV = new Cv
            {
                AcceptanceScore = "1460",
                Education = "ODTU",
                Languages = new Language
                {
                    C2 = "English",
                    B1 = "Russian",
                    C1 = "Turkish",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {
                    Certificate = "Cisco Basic IT 6.0",
                    CertificateII = "Azerbaijan Republic English Olympics Second Place",
                    Diploma5 = "SAT",
                    AdvancedDiploma6 = "STEP IT CERTIFICATE"
                },
                Specialty = ".Net Developer",
                Company = new OldCompany
                {
                    CompanyName = "No Job Practise"
                },
            }
        };
        Worker worker4 = new Worker
        {
            Username = "elginsadiqov",
            Password = "elgin1234",
            Age = 24,
            City = "Khirdalan",
            Name = "Elgin",
            Surname = "Sadiqov",
            Email = "elgin.sadiqov@gmail.com",
            Phone = "050456213",
            CV = new Cv
            {
                AcceptanceScore = "445",
                Education = "ADNSU",
                Languages = new Language
                {
                    C1 = "English",
                    B2 = "Turkish",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {
                    CertificateII = "Azerbaijan Republic Math Olympics First Place",
                    Diploma5 = "IELTS 7.5",
                    AdvancedDiploma6 = "ADNSU Oil Specialist"
                },
                Specialty = "Oil Specialist",
                Company = new OldCompany
                {
                    CompanyName = "Has own company"
                },
            }
        };
        Worker worker5 = new Worker
        {
            Username = "aysusalahli",
            Password = "aysu1234",
            Age = 27,
            City = "Ganja",
            Name = "Aysu",
            Surname = "Salahli",
            Email = "aysusalahli@gmail.com",
            Phone = "0515456874",
            CV = new Cv
            {
                AcceptanceScore = "550",
                Education = "GDU",
                Languages = new Language
                {
                    C1 = "English",
                    B2 = "Turkish",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {
                    Certificate = "Basic Math Skills",
                    CertificateII = "Bussiness Skills",
                    Diploma5 = "IELTS 6.0",
                    AdvancedDiploma6 = "GDU Manage Business"
                },
                Specialty = "Business Manager",
                Company = new OldCompany
                {
                    CompanyName = "Ganja Bank",
                    StartTime = "01/05/2015",
                    EndTime = "04/07/2020"
                },
            }
        };
        Worker worker6 = new Worker
        {
            Username = "ayanismayilova",
            Password = "ayan1234",
            Age = 26,
            City = "Baku",
            Name = "Ayan",
            Surname = "Ismayilova",
            Phone = "050456213",
            Email = "lamanmehdiyeva123@gmail.com",
            CV = new Cv
            {
                AcceptanceScore = "512",
                Education = "ADNSU",
                Languages = new Language
                {
                    C1 = "English",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {

                    Diploma5 = "Microsoft Office 2010-2016",
                    AdvancedDiploma6 = "ADIU Bussiness Management"
                },
                Specialty = "Human Resources",
                Company = new OldCompany
                {
                    CompanyName = "Venta Company",
                    StartTime = "01/11/2017",
                    EndTime = "09/12/2019"
                },
            }
        };
        Worker worker7 = new Worker
        {
            Username = "seymuraliyev",
            Password = "seymur1234",
            Age = 24,
            City = "Lenkaran",
            Name = "Seymur",
            Surname = "Aliyev",
            Phone = "05044568",
            Email = "seymuraliyev@mail.ru",
            CV = new Cv
            {
                AcceptanceScore = "498",
                Education = "LDU",
                Languages = new Language
                {
                    B1 = "English",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {

                    Diploma5 = "Microsoft Office 2010-2016",
                    AdvancedDiploma6 = "LDU Special Certificate"
                },
                Specialty = "Accountant",
                Company = new OldCompany
                {
                    CompanyName = "Rakurs MMC",
                    StartTime = "01/03/2020",
                    EndTime = "01/02/2021"
                },
            }
        };
        Worker worker8 = new Worker
        {
            Username = "nailaselimova",
            Password = "naila1234",
            Age = 29,
            City = "Baku",
            Name = "Naila",
            Surname = "Selimova",
            Phone = "0507895641",
            Email = "naila.selimova@yahoo.com",
            CV = new Cv
            {
                AcceptanceScore = "400",
                Education = "Russian Socialist University",
                Languages = new Language
                {
                    C2 = "Russian",
                    B1 = "Azerbaijanian",
                    LandLanguage = "Russian"
                },
                Certificates = new Certificates
                {

                    Diploma5 = "Microsoft Office 2010-2016",
                    AdvancedDiploma6 = "Economics and Finance Diploma"
                },
                Specialty = "Office Manager",
                Company = new OldCompany
                {
                    CompanyName = "Royal Bank",
                    StartTime = "04/04/2014",
                    EndTime = "04/04/2020"
                },
            }
        };
        Worker worker9 = new Worker
        {
            Username = "orucmusayev",
            Password = "oruc1234",
            Age = 24,
            City = "Baku",
            Name = "Oruc",
            Surname = "Musayev",
            Phone = "05069478942",
            Email = "musayevoruj@gmail.com",
            CV = new Cv
            {
                AcceptanceScore = "95",
                Education = "YTU",
                Languages = new Language
                {
                    C2 = "English",
                    C1 = "Turkish",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {

                    Diploma5 = "ICT Professional Foundation Program",
                    AdvancedDiploma6 = "Excel Skills for Business Specialization",
                    CertificateIV = "Python Programmer"

                },
                Specialty = "Engineer",
                Company = new OldCompany
                {
                    CompanyName = "Bosch Azerbaijan",
                    StartTime = "01/07/2019",
                    EndTime = "02/02/2021"
                },
            }
        };
        Worker worker10 = new Worker
        {
            Username = "manafzeynalov",
            Password = "manaf1234",
            Age = 26,
            City = "Baku",
            Name = "Manaf",
            Surname = "Zeynalov",
            Phone = "050795438",
            Email = "zeyn4loff@gmail.com",
            CV = new Cv
            {
                AcceptanceScore = "399",
                Education = "Xarkov University",
                Languages = new Language
                {
                    C1 = "Russian",
                    LandLanguage = "Azerbaijanian"
                },
                Certificates = new Certificates
                {

                },
                Specialty = "Graphic Designer",
                Company = new OldCompany
                {
                    CompanyName = "Technote MMC",
                    StartTime = "01/07/2016",
                    EndTime = "02/02/2019"
                },
            }
        };


        public void checkUser(string username, string password)
        {

            List<User> users = new List<User>();
            users.Add(worker1);
            users.Add(worker2);
            users.Add(worker3);
            users.Add(worker4);
            users.Add(worker5);
            users.Add(worker6);
            users.Add(worker7);
            users.Add(worker8);
            users.Add(worker9);
            users.Add(worker10);
            try
            {
                var userName = users.Find(u => u.Username == username);
                if (userName != null)
                {
                    foreach (var item in users)
                    {
                        if (item.Password == password)
                        {
                            Console.WriteLine("Passed");
                            break;
                        }
                        break;                   
                    }
                    foreach (var item in users)
                    {
                        if (item.Password != password)
                            throw (new UserNotFoundException());
                        if (string.IsNullOrEmpty(password))
                        {
                            throw (new UserNotFoundException());
                        }
                    }

                    if (userName != null)
                    {
                        throw (new UserNotFoundException());
                    }
                }
        }
            catch (Exception)
            {
                Console.WriteLine("Cannot find user,try again");
                Thread.Sleep(2000);
                Console.Clear();
                Start();
    }
}
public void IfNotNullAdd(string data, List<string> list)
{
    if (!string.IsNullOrEmpty(data))
    {
        list.Add(data);
    }

}
public void CreateVacancy()
{
    Console.Write("Profession:"); string profession = Console.ReadLine();
    Console.Write("Wage:"); string wage = Console.ReadLine();
    Console.Write("City:"); string city = Console.ReadLine();
    Console.Write("Education:"); string education = Console.ReadLine();
    Console.Write("Job Practise:"); string jobPractise = Console.ReadLine();
    Console.Write("Phone:"); string phone = Console.ReadLine();
    Console.Write("Email:"); string email = Console.ReadLine();
    Console.Write("Information About Job:"); string aboutJob = Console.ReadLine();
    Console.Write("Job Requirements:"); string jobRequirements = Console.ReadLine();


}
public void Start()
{
    Console.Write("Username:"); string username = Console.ReadLine();
    Console.Write("Password:"); string password = Console.ReadLine();
    checkUser(username, password);

}
    }
}
