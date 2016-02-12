﻿using System;

namespace ServicesSamples.ModelServices
{
    public interface IDataService : IDisposable
    {
        #region Methods

        void RejectChanges();
        void SaveChanges(Action onSuccess = null, Action<Exception> onError = null);

        #endregion
    }
}