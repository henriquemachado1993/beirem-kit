﻿namespace BeireMKit.Data.Interfaces
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Confirm transaction
        /// </summary>
        void Commit();

        /// <summary>
        /// Confirm async transaction
        /// </summary>
        Task CommitAsync();

        /// <summary>
        /// Release context resources
        /// </summary>
        void Dispose();
    }
}
