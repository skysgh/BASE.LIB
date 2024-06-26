﻿namespace App.Modules.Base.Substrate.Models.Contracts
{
    /// <summary>
    /// Contract for objects that have a (single) Tag
    /// </summary>
    public interface IHasTagNullable
    {
        /// <summary>
        /// The Tag
        /// </summary>
        string? Tag { get; set; }
    }
}