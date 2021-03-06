﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}