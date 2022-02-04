#pragma warning disable 162,168,649,660,661,1522

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Trinity;
using Trinity.Storage;
using Trinity.TSL;
using Trinity.TSL.Lib;
namespace BTTN4KNFE
{
    /// <summary>
    /// Exposes Load/Save/New operations of <see cref="Trinity.Storage.ICell"/> and Use operation on <see cref="Trinity.Storage.ICellAccessor"/> on <see cref="Trinity.Storage.LocalMemoryStorage"/> and <see cref="Trinity.Storage.MemoryCloud"/>.
    /// </summary>
    internal class GenericCellOperations : IGenericCellOperations
    {
        #region LocalMemoryStorage operations
        /// <inheritdoc/>
        public void SaveGenericCell(Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions writeAheadLogOptions, ICell cell)
        {
            switch ((CellType)cell.CellType)
            {
                
                case CellType.BTTN4KNFEDirectory:
                storage.SaveBTTN4KNFEDirectory(writeAheadLogOptions, (BTTN4KNFEDirectory)cell);
                break;
                
                case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                storage.SaveBTTNFE_N4K_SealedEnvelope_Cell(writeAheadLogOptions, (BTTNFE_N4K_SealedEnvelope_Cell)cell);
                break;
                
                case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                storage.SaveBTTVerifiableCredential_SealedEnvelope_Cell(writeAheadLogOptions, (BTTVerifiableCredential_SealedEnvelope_Cell)cell);
                break;
                
            }
        }
        /// <inheritdoc/>
        public void SaveGenericCell(Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions writeAheadLogOptions, long cellId, ICell cell)
        {
            switch ((CellType)cell.CellType)
            {
                
                case CellType.BTTN4KNFEDirectory:
                storage.SaveBTTN4KNFEDirectory(writeAheadLogOptions, cellId, (BTTN4KNFEDirectory)cell);
                break;
                
                case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                storage.SaveBTTNFE_N4K_SealedEnvelope_Cell(writeAheadLogOptions, cellId, (BTTNFE_N4K_SealedEnvelope_Cell)cell);
                break;
                
                case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                storage.SaveBTTVerifiableCredential_SealedEnvelope_Cell(writeAheadLogOptions, cellId, (BTTVerifiableCredential_SealedEnvelope_Cell)cell);
                break;
                
            }
        }
        /// <inheritdoc/>
        public unsafe ICell LoadGenericCell(Trinity.Storage.LocalMemoryStorage storage, long cellId)
        {
            ushort type;
            int    size;
            byte*  cellPtr;
            int    entryIndex;
            var err = storage.GetLockedCellInfo(cellId, out size, out type, out cellPtr, out entryIndex);
            if (err != TrinityErrorCode.E_SUCCESS)
            {
                throw new CellNotFoundException("Cannot access the cell.");
            }
            try
            {
                var accessor = UseGenericCell(cellId, cellPtr, entryIndex, type);
                var cell = accessor.Deserialize();
                accessor.Dispose();
                return cell;
            }
            catch (Exception ex)
            {
                storage.ReleaseCellLock(cellId, entryIndex);
                ExceptionDispatchInfo.Capture(ex).Throw();
                throw;
            }
        }
        #endregion
        #region New operations
        /// <inheritdoc/>
        public ICell NewGenericCell(string cellType)
        {
            CellType type;
            if (!StorageSchema.cellTypeLookupTable.TryGetValue(cellType, out type))
                Throw.invalid_cell_type();
            switch (type)
            {
                
                case global::BTTN4KNFE.CellType.BTTN4KNFEDirectory:
                return new BTTN4KNFEDirectory();
                break;
                
                case global::BTTN4KNFE.CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                return new BTTNFE_N4K_SealedEnvelope_Cell();
                break;
                
                case global::BTTN4KNFE.CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                return new BTTVerifiableCredential_SealedEnvelope_Cell();
                break;
                
            }
            /* Should not reach here */
            return null;
        }
        public ICell NewGenericCell(long cellId, string cellType)
        {
            CellType type;
            if (!StorageSchema.cellTypeLookupTable.TryGetValue(cellType, out type))
                Throw.invalid_cell_type();
            switch (type)
            {
                
                case global::BTTN4KNFE.CellType.BTTN4KNFEDirectory:
                return new BTTN4KNFEDirectory(cell_id: cellId);
                
                case global::BTTN4KNFE.CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                return new BTTNFE_N4K_SealedEnvelope_Cell(cell_id: cellId);
                
                case global::BTTN4KNFE.CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                return new BTTVerifiableCredential_SealedEnvelope_Cell(cell_id: cellId);
                
            }
            /* Should not reach here */
            return null;
        }
        /// <inheritdoc/>
        public ICell NewGenericCell(string cellType, string content)
        {
            CellType type;
            if (!StorageSchema.cellTypeLookupTable.TryGetValue(cellType, out type))
                Throw.invalid_cell_type();
            switch (type)
            {
                
                case global::BTTN4KNFE.CellType.BTTN4KNFEDirectory:
                return BTTN4KNFEDirectory.Parse(content);
                
                case global::BTTN4KNFE.CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                return BTTNFE_N4K_SealedEnvelope_Cell.Parse(content);
                
                case global::BTTN4KNFE.CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                return BTTVerifiableCredential_SealedEnvelope_Cell.Parse(content);
                
            }
            /* Should not reach here */
            return null;
        }
        #endregion
        #region LocalMemoryStorage Use operations
        /// <inheritdoc/>
        public unsafe ICellAccessor UseGenericCell(Trinity.Storage.LocalMemoryStorage storage, long cellId)
        {
            ushort type;
            int    size;
            byte*  cellPtr;
            int    entryIndex;
            var err = storage.GetLockedCellInfo(cellId, out size, out type, out cellPtr, out entryIndex);
            if (err != TrinityErrorCode.E_SUCCESS)
            {
                throw new CellNotFoundException("Cannot access the cell.");
            }
            switch ((CellType)type)
            {
                
                case CellType.BTTN4KNFEDirectory:
                return BTTN4KNFEDirectory_Accessor._get()._Setup(cellId, cellPtr, entryIndex, CellAccessOptions.ThrowExceptionOnCellNotFound);
                
                case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                return BTTNFE_N4K_SealedEnvelope_Cell_Accessor._get()._Setup(cellId, cellPtr, entryIndex, CellAccessOptions.ThrowExceptionOnCellNotFound);
                
                case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Setup(cellId, cellPtr, entryIndex, CellAccessOptions.ThrowExceptionOnCellNotFound);
                
                default:
                storage.ReleaseCellLock(cellId, entryIndex);
                throw new CellTypeNotMatchException("Cannot determine cell type.");
            }
        }
        /// <inheritdoc/>
        public unsafe ICellAccessor UseGenericCell(Trinity.Storage.LocalMemoryStorage storage, long cellId, CellAccessOptions options)
        {
            ushort type;
            int    size;
            byte*  cellPtr;
            int    entryIndex;
            var err = storage.GetLockedCellInfo(cellId, out size, out type, out cellPtr, out entryIndex);
            switch (err)
            {
                case TrinityErrorCode.E_SUCCESS:
                break;
                case TrinityErrorCode.E_CELL_NOT_FOUND:
                    {
                        if ((options & CellAccessOptions.ThrowExceptionOnCellNotFound) != 0)
                        {
                            Throw.cell_not_found(cellId);
                        }
                        else if ((options & CellAccessOptions.CreateNewOnCellNotFound) != 0)
                        {
                            throw new ArgumentException("CellAccessOptions.CreateNewOnCellNotFound is not valid for this method. Cannot determine new cell type.", "options");
                        }
                        else if ((options & CellAccessOptions.ReturnNullOnCellNotFound) != 0)
                        {
                            return null;
                        }
                        else
                        {
                            Throw.cell_not_found(cellId);
                        }
                        break;
                    }
                default:
                throw new CellNotFoundException("Cannot access the cell.");
            }
            try
            {
                return UseGenericCell(cellId, cellPtr, entryIndex, type, options);
            }
            catch (Exception ex)
            {
                storage.ReleaseCellLock(cellId, entryIndex);
                ExceptionDispatchInfo.Capture(ex).Throw();
                throw;
            }
        }
        /// <inheritdoc/>
        public unsafe ICellAccessor UseGenericCell(Trinity.Storage.LocalMemoryStorage storage, long cellId, CellAccessOptions options, string cellType)
        {
            switch (cellType)
            {
                
                case "BTTN4KNFEDirectory": return BTTN4KNFEDirectory_Accessor._get()._Lock(cellId, options);
                
                case "BTTNFE_N4K_SealedEnvelope_Cell": return BTTNFE_N4K_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, options);
                
                case "BTTVerifiableCredential_SealedEnvelope_Cell": return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, options);
                
                default:
                Throw.invalid_cell_type();
                return null;
            }
        }
        #endregion
        #region LocalMemoryStorage Enumerate operations
        /// <inheritdoc/>
        public IEnumerable<ICell> EnumerateGenericCells(LocalMemoryStorage storage)
        {
            foreach (var cellInfo in Global.LocalStorage)
            {
                switch ((CellType)cellInfo.CellType)
                {
                    
                    case CellType.BTTN4KNFEDirectory:
                        {
                            var BTTN4KNFEDirectory_accessor = BTTN4KNFEDirectory_Accessor.AllocIterativeAccessor(cellInfo, null);
                            var BTTN4KNFEDirectory_cell     = (BTTN4KNFEDirectory)BTTN4KNFEDirectory_accessor;
                            BTTN4KNFEDirectory_accessor.Dispose();
                            yield return BTTN4KNFEDirectory_cell;
                            break;
                        }
                    
                    case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                        {
                            var BTTNFE_N4K_SealedEnvelope_Cell_accessor = BTTNFE_N4K_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, null);
                            var BTTNFE_N4K_SealedEnvelope_Cell_cell     = (BTTNFE_N4K_SealedEnvelope_Cell)BTTNFE_N4K_SealedEnvelope_Cell_accessor;
                            BTTNFE_N4K_SealedEnvelope_Cell_accessor.Dispose();
                            yield return BTTNFE_N4K_SealedEnvelope_Cell_cell;
                            break;
                        }
                    
                    case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                        {
                            var BTTVerifiableCredential_SealedEnvelope_Cell_accessor = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, null);
                            var BTTVerifiableCredential_SealedEnvelope_Cell_cell     = (BTTVerifiableCredential_SealedEnvelope_Cell)BTTVerifiableCredential_SealedEnvelope_Cell_accessor;
                            BTTVerifiableCredential_SealedEnvelope_Cell_accessor.Dispose();
                            yield return BTTVerifiableCredential_SealedEnvelope_Cell_cell;
                            break;
                        }
                    
                    default:
                    continue;
                }
            }
            yield break;
        }
        /// <inheritdoc/>
        public IEnumerable<ICellAccessor> EnumerateGenericCellAccessors(LocalMemoryStorage storage)
        {
            foreach (var cellInfo in Global.LocalStorage)
            {
                switch ((CellType)cellInfo.CellType)
                {
                    
                    case CellType.BTTN4KNFEDirectory:
                        {
                            var BTTN4KNFEDirectory_accessor = BTTN4KNFEDirectory_Accessor.AllocIterativeAccessor(cellInfo, null);
                            yield return BTTN4KNFEDirectory_accessor;
                            BTTN4KNFEDirectory_accessor.Dispose();
                            break;
                        }
                    
                    case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                        {
                            var BTTNFE_N4K_SealedEnvelope_Cell_accessor = BTTNFE_N4K_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, null);
                            yield return BTTNFE_N4K_SealedEnvelope_Cell_accessor;
                            BTTNFE_N4K_SealedEnvelope_Cell_accessor.Dispose();
                            break;
                        }
                    
                    case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                        {
                            var BTTVerifiableCredential_SealedEnvelope_Cell_accessor = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, null);
                            yield return BTTVerifiableCredential_SealedEnvelope_Cell_accessor;
                            BTTVerifiableCredential_SealedEnvelope_Cell_accessor.Dispose();
                            break;
                        }
                    
                    default:
                    continue;
                }
            }
            yield break;
        }
        #endregion
        #region IKeyValueStore operations
        /// <inheritdoc/>
        public void SaveGenericCell(IKeyValueStore storage, ICell cell)
        {
            switch ((CellType)cell.CellType)
            {
                
                case CellType.BTTN4KNFEDirectory:
                storage.SaveBTTN4KNFEDirectory((BTTN4KNFEDirectory)cell);
                break;
                
                case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                storage.SaveBTTNFE_N4K_SealedEnvelope_Cell((BTTNFE_N4K_SealedEnvelope_Cell)cell);
                break;
                
                case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                storage.SaveBTTVerifiableCredential_SealedEnvelope_Cell((BTTVerifiableCredential_SealedEnvelope_Cell)cell);
                break;
                
            }
        }
        /// <inheritdoc/>
        public void SaveGenericCell(IKeyValueStore storage, long cellId, ICell cell)
        {
            switch ((CellType)cell.CellType)
            {
                
                case CellType.BTTN4KNFEDirectory:
                storage.SaveBTTN4KNFEDirectory(cellId, (BTTN4KNFEDirectory)cell);
                break;
                
                case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                storage.SaveBTTNFE_N4K_SealedEnvelope_Cell(cellId, (BTTNFE_N4K_SealedEnvelope_Cell)cell);
                break;
                
                case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                storage.SaveBTTVerifiableCredential_SealedEnvelope_Cell(cellId, (BTTVerifiableCredential_SealedEnvelope_Cell)cell);
                break;
                
            }
        }
        /// <inheritdoc/>
        public unsafe ICell LoadGenericCell(IKeyValueStore storage, long cellId)
        {
            ushort type;
            byte[] buff;
            var err = storage.LoadCell(cellId, out buff, out type);
            if (err != TrinityErrorCode.E_SUCCESS)
            {
                switch (err)
                {
                    case TrinityErrorCode.E_CELL_NOT_FOUND:
                    throw new CellNotFoundException("Cannot access the cell.");
                    case TrinityErrorCode.E_NETWORK_SEND_FAILURE:
                    throw new System.IO.IOException("Network error while accessing the cell.");
                    default:
                    throw new Exception("Cannot access the cell. Error code: " + err.ToString());
                }
            }
            fixed (byte* p = buff)
            {
                var accessor = UseGenericCell(cellId, p, -1, type);
                return accessor.Deserialize();
            }
        }
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ICellAccessor UseGenericCell(long cellId, byte* cellPtr, int entryIndex, ushort cellType)
         => UseGenericCell(cellId, cellPtr, entryIndex, cellType, CellAccessOptions.ThrowExceptionOnCellNotFound);
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ICellAccessor UseGenericCell(long cellId, byte* cellBuffer, int entryIndex, ushort cellType, CellAccessOptions options)
        {
            switch ((CellType)cellType)
            {
                
                case CellType.BTTN4KNFEDirectory:
                return BTTN4KNFEDirectory_Accessor._get()._Setup(cellId, cellBuffer, entryIndex, options);
                
                case CellType.BTTNFE_N4K_SealedEnvelope_Cell:
                return BTTNFE_N4K_SealedEnvelope_Cell_Accessor._get()._Setup(cellId, cellBuffer, entryIndex, options);
                
                case CellType.BTTVerifiableCredential_SealedEnvelope_Cell:
                return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Setup(cellId, cellBuffer, entryIndex, options);
                
                default:
                throw new CellTypeNotMatchException("Cannot determine cell type.");
            }
        }
        #endregion
    }
}

#pragma warning restore 162,168,649,660,661,1522
