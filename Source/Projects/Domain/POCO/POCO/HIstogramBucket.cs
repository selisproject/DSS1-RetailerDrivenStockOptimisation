// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS1_RetailerDriverStockOptimisation.BO
{
    /// <summary>
    /// The HIstogramBucket class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class HIstogramBucket : IDomainModelClass
    {
        #region HIstogramBucket's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="key")]
        protected decimal? _key = 0.0M;
        [DataMember(Name="keyAsString")]
        protected string _keyAsString;
        [DataMember(Name="doc_count")]
        protected int? _doc_count;
        [DataMember(Name="avg")]
        protected double? _avg;
        [DataMember(Name="sum")]
        protected double? _sum;
        [DataMember(Name="max")]
        protected double? _max;
        [DataMember(Name="min")]
        protected double? _min;
        [DataMember(Name="failure")]
        protected int? _failure;
        [DataMember(Name="success")]
        protected int? _success;
        [DataMember(Name="error_rate")]
        protected float? _error_rate;
        #endregion
        #region HIstogramBucket's Properties
/// <summary>
/// The key property
///
/// </summary>
///
        [Key]
        public virtual decimal? key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }
/// <summary>
/// The keyAsString property
///
/// </summary>
///
        public virtual string keyAsString
        {
            get
            {
                return _keyAsString;
            }
            set
            {
                _keyAsString = value;
            }
        }
/// <summary>
/// The doc_count property
///
/// </summary>
///
        public virtual int? doc_count
        {
            get
            {
                return _doc_count;
            }
            set
            {
                _doc_count = value;
            }
        }
/// <summary>
/// The avg property
///
/// </summary>
///
        public virtual double? avg
        {
            get
            {
                return _avg;
            }
            set
            {
                _avg = value;
            }
        }
/// <summary>
/// The sum property
///
/// </summary>
///
        public virtual double? sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
            }
        }
/// <summary>
/// The max property
///
/// </summary>
///
        public virtual double? max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
            }
        }
/// <summary>
/// The min property
///
/// </summary>
///
        public virtual double? min
        {
            get
            {
                return _min;
            }
            set
            {
                _min = value;
            }
        }
/// <summary>
/// The failure property
///
/// </summary>
///
        public virtual int? failure
        {
            get
            {
                return _failure;
            }
            set
            {
                _failure = value;
            }
        }
/// <summary>
/// The success property
///
/// </summary>
///
        public virtual int? success
        {
            get
            {
                return _success;
            }
            set
            {
                _success = value;
            }
        }
/// <summary>
/// The error_rate property
///
/// </summary>
///
        public virtual float? error_rate
        {
            get
            {
                return _error_rate;
            }
            set
            {
                _error_rate = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the HIstogramBucket class
/// </summary>
/// <returns>New HIstogramBucket object</returns>
/// <remarks></remarks>
        public HIstogramBucket() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (key == null)
            {
                __errors.Add("Property 'key' is required.");
            }
            if (keyAsString != null && keyAsString.Length > 100)
            {
                __errors.Add("Length of property 'keyAsString' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'HIstogramBucket' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (key?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (keyAsString?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (doc_count?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (avg?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (sum?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (max?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (min?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (failure?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (success?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (error_rate?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [HIstogramBucket] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual HIstogramBucket Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, HIstogramBucket copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (HIstogramBucket)copiedObjects[this];
            copy = copy ?? new HIstogramBucket();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.key = this.key;
            }
            copy.keyAsString = this.keyAsString;
            copy.doc_count = this.doc_count;
            copy.avg = this.avg;
            copy.sum = this.sum;
            copy.max = this.max;
            copy.min = this.min;
            copy.failure = this.failure;
            copy.success = this.success;
            copy.error_rate = this.error_rate;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as HIstogramBucket;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

// Maintain equality operator semantics for entities.
        public static bool operator ==(HIstogramBucket x, HIstogramBucket y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(HIstogramBucket x, HIstogramBucket y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("key");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.key.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.key == default(decimal) || this.key.Equals(default(decimal));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(HIstogramBucket compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.key.Equals(compareTo.key);
        }

        #endregion


    }
}
