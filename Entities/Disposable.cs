﻿using System;

namespace Entities
{
    public abstract class Disposable : IDisposable
    {
        protected bool IsDisposed { get; private set; }

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !IsDisposed)
            {
                OnDispose();
                IsDisposed = true;
            }
        }

        protected virtual void OnDispose() { }
    }
}
