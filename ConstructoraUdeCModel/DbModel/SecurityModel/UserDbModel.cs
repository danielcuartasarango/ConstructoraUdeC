﻿using ConstructoraUdeCModel.DbModel.ParametersModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraUdeCModel.DbModel.SecurityModel
{
    public class UserDbModel : DbModelBase
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private string cellphone;

        public string Cellphone
        {
            get { return cellphone; }
            set { cellphone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int cityActionId;

        public int CityActionId
        {
            get { return cityActionId; }
            set { cityActionId = value; }
        }

        private CityDbModel cityAction;

        public CityDbModel CityAction
        {
            get { return cityAction; }
            set { cityAction = value; }
        }

        private IEnumerable<CityDbModel> cityActionList;

        public IEnumerable<CityDbModel> CityActionList
        {
            get { return cityActionList; }
            set { cityActionList = value; }
        }

        private IEnumerable<RoleDbModel> roles;

        public IEnumerable<RoleDbModel> Roles
        {
            get { return roles; }
            set { roles = value; }
        }

        private string token;

        public string Token
        {
            get { return token; }
            set { token = value; }
        }

    }
}
