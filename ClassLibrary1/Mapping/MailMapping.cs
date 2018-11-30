using CityInfo.Entity;
using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Service.Mapping
{
    class MailMapping
    {
        public Mail FromMailModelToMailEntity(MailDto mailDto)
        {
            return new Mail(mailDto.Subject, mailDto.Message, mailDto._mailTo,mailDto._mailFrom);
            
        }

        public MailDto FromMailEntityToMailModel(Mail mailEntity)
        {
            return new MailDto(mailEntity.Subject, mailEntity.Message, mailEntity._mailTo, mailEntity._mailFrom);
        }
    }
}
