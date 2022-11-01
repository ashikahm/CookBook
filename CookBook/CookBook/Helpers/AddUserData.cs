using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Helpers
{
    public class AddUserData
    {
        public List<Users> UsersList { get; set; }
        public AddUserData()
        {
            UsersList = new List<Users>()
            {
                new Users()
                {
                    Name="Kunal Kapur",
                    ImageUrl = "https://www.chefkunalkapur.com/wp-content/uploads/2021/03/KK_mouse_contactme.jpg?v=1617940673",
                    VedioUrl ="https://www.youtube.com/watch?v=Zd1q5s2J2ZU"
                },
                new Users()
                {
                    Name = "Kabita",
                    ImageUrl = "https://wikibio.in/wp-content/uploads/2022/03/Kabita-Singh-1.jpg",
                    VedioUrl ="https://www.youtube.com/watch?v=vEz2X8fXizw"
                },
                new Users()
                {
                    Name="Gordon Ramsay",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Gordon_Ramsay_colour_Allan_Warren.jpg/360px-Gordon_Ramsay_colour_Allan_Warren.jpg",
                    VedioUrl="https://www.youtube.com/watch?v=ZJy1ajvMU1k"
                },
                new Users(){
                    Name="Ranveer Brar",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Ranveer_Brar_Wiki_Image.jpg/330px-Ranveer_Brar_Wiki_Image.jpg",
                    VedioUrl="https://www.youtube.com/watch?v=7yop_KC4kPI"
                },
                new Users(){
                    Name="Vikas Kanna",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Doctorate_ceremony.jpg/330px-Doctorate_ceremony.jpg",
                    VedioUrl="https://www.youtube.com/watch?v=MNP3x3hGDfE"

                }
            };

        }
        public  List<Users> getusers()
        {
            return  UsersList;
        }
    }
}
