﻿using System;
using System.Collections.Generic;

namespace AplusCore.Types
{
    #region A+ Types
    public enum ATypes : byte
    {
        AInteger,
        AFloat,
        AChar,
        ASymbol,
        AArray,
        ANull,
        ABox,
        AFunc,
        AType
    }
    #endregion

    /// <summary>
    /// Base class of A+ type-system
    /// </summary>
    public interface AType : IComparable<AType>, IEnumerable<AType>
    {
        #region Properties

        #region Base

        ATypes Type { get; set; }
        int Length { get; set; }
        List<int> Shape { get; set; }
        int Rank { get; set; }

        AType NestedItem { get; }
        AValue Data { get; set; }

        #endregion

        #region Helpers

        bool IsArray { get; }
        bool IsBox { get; }
        bool IsFunctionScalar { get; }

        bool IsNumber { get; }
        bool IsTolerablyWholeNumber { get; }
        bool IsMemoryMappedFile { get; }

        #endregion

        #region Indexing

        AType this[int index] { get; set; }
        AType this[AType index] { get; set; }
        AType this[List<AType> indexers] { get; set; }

        #endregion

        #endregion

        #region Converter Properties

        int asInteger { get; }
        double asFloat { get; }
        string asString { get; }
        char asChar { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Add AType to AArray.
        /// Also updates length, shape, rank and type informations
        /// </summary>
        /// <param name="item"></param>
        void Add(AType item);

        /// <summary>
        /// Updates the array's length, shape, rank and type informations
        /// </summary>
        void UpdateInfo();

        /// <summary>
        /// Add AType to AArray without updating length, shape, rank and type informations
        /// </summary>
        /// <param name="item"></param>
        void AddWithNoUpdate(AType item);

        /// <summary>
        /// Add array of AType to AArray.
        /// Also updates length, shape, rank and type informations
        /// </summary>
        /// <param name="items"></param>
        void AddRange(IEnumerable<AType> items);

        void AddRangeWithNoUpdate(IEnumerable<AType> items);

        /// <summary>
        /// Returns the first scalar from the AType.
        /// </summary>
        /// <remarks>
        /// For most ATypes this will return the same AType. But for
        /// AArray it should return the scalar from the most inner element.
        /// </remarks>
        /// <param name="result">The resulting AType</param>
        /// <param name="strictLengthCheck">If true check if the length is 1</param>
        /// <returns>True if we found such scalar</returns>
        bool TryFirstScalar(out AType result, bool strictLengthCheck = false);

        /// <summary>
        /// Try conversion of item to integer
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if the item can be converted to integer otherwise False</returns>
        bool ConvertToRestrictedWholeNumber(out int result);

        /// <summary>
        /// Clones the AType, returning a new instance containing the same values
        /// </summary>
        /// <returns>Cloned AType</returns>
        AType Clone();

        #endregion
    }
}
