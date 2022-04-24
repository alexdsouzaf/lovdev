using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using LovDev.Models;

namespace LovDev
{

    public partial class MainPage : ContentPage
    {
        
 
        public ObservableCollection<UserModel> _Profiles = new ObservableCollection<UserModel>();

        public MainPage()
        {
            InitializeComponent();
            CardBinding();
            BindingContext = this;

        }

        public void CardBinding()
        {
            _Profiles.Add(new UserModel() { Name = "João", Age = "25",About = "...", Photo = "AvatarPlaceholder.png" });
            _Profiles.Add(new UserModel() { Name = "Maria", Age = "20", About = "...", Photo = "pic_2.jpg" });
            _Profiles.Add(new UserModel() { Name = "José", Age = "30", About = "...", Photo = "pic_1.png" });
            _Profiles.Add(new UserModel() { Name = "Fernando", Age = "18", About = "...", Photo = "AvatarPlaceholder.png" });
            _Profiles.Add(new UserModel() { Name = "Sofia", Age = "21", About = "...", Photo = "pic_2.jpg" });
            _Profiles.Add(new UserModel() { Name = "Yuno", Age = "20",  About = "...",Photo = "AvatarPlaceholder.png" });
            _Profiles.Add(new UserModel() { Name = "Alex", Age = "25",  About = "...",Photo = "pic_1.jpg" });
            _Profiles.Add(new UserModel() { Name = "Thales", Age = "23",About = "...",Photo = "pic_1.jpg" });
            _Profiles.Add(new UserModel() { Name = "Abner", Age = "32", About = "...",Photo = "AvatarPlaceholder.png" });
            _Profiles.Add(new UserModel() { Name = "Marcos", Age = "27",About = "...",Photo = "pic_1.jpg" });
            _Profiles.Add(new UserModel() { Name = "Paulo", Age = "40", About = "...",Photo = "pic_1.jpg" });
            _Profiles.Add(new UserModel() { Name = "Bruna", Age = "31", About = "...",Photo = "pic_2.jpg" });
            _Profiles.Add(new UserModel() { Name = "Janaína", Age = "24", About = "...", Photo = "AvatarPlaceholder.png" });
            _Profiles.Add(new UserModel() { Name = "Luana", Age = "22", About = "...", Photo = "pic_2.jpg" });

        }
    
        public ObservableCollection<UserModel> Profile
        {
            get => _Profiles;
            set
            {
                _Profiles = value;
            }
        }
    }
}
