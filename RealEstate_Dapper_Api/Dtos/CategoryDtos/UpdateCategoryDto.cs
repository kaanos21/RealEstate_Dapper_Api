﻿namespace RealEstate_Dapper_Api.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
