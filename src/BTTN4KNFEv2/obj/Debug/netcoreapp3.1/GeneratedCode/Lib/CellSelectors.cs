#pragma warning disable 162,168,649,660,661,1522

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinity;
using Trinity.TSL;
using Trinity.TSL.Lib;
using Trinity.Storage;
using System.Linq.Expressions;
using BTTN4KNFE.Linq;
using Trinity.Storage.Transaction;
namespace BTTN4KNFE
{
    
    #region Internal
    /**
     * <summary>
     * Accepts transformation from BTTN4KNFEDirectory_Accessor to T.
     * </summary>
     */
    internal class BTTN4KNFEDirectory_Accessor_local_projector<T> : IQueryable<T>
    {
        private         Expression                                   query_expression;
        private         BTTN4KNFEDirectory_Accessor_local_query_provider    query_provider;
        internal BTTN4KNFEDirectory_Accessor_local_projector(BTTN4KNFEDirectory_Accessor_local_query_provider provider, Expression expression)
        {
            this.query_expression              = expression;
            this.query_provider                = provider;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<T>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(T); }
        }
        public Expression Expression
        {
            get { return query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
    }
    /**
     * Accepts transformation from BTTN4KNFEDirectory to T.
     */
    internal class BTTN4KNFEDirectory_local_projector<T> : IQueryable<T>
    {
        private         Expression                                   query_expression;
        private         BTTN4KNFEDirectory_local_query_provider             query_provider;
        internal BTTN4KNFEDirectory_local_projector(BTTN4KNFEDirectory_local_query_provider provider, Expression expression)
        {
            this.query_expression              = expression;
            this.query_provider                = provider;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<T>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(T); }
        }
        public Expression Expression
        {
            get { return query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
    }
    internal class BTTN4KNFEDirectory_AccessorEnumerable : IEnumerable<BTTN4KNFEDirectory_Accessor>
    {
        private     LocalMemoryStorage              m_storage;
        private     LocalTransactionContext         m_tx;
        private     HashSet<long>                   m_filter_set;
        private     bool                            m_is_positive_filtering;
        private     Func<BTTN4KNFEDirectory_Accessor,bool> m_filter_predicate;
        internal BTTN4KNFEDirectory_AccessorEnumerable(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.m_storage     = storage;
            m_filter_set       = null;
            m_filter_predicate = null;
            m_tx               = tx;
        }
        internal void SetPositiveFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = true;
        }
        internal void SetNegativeFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = false;
        }
        public IEnumerator<BTTN4KNFEDirectory_Accessor> GetEnumerator()
        {
            if (m_filter_set == null)
            {
                if (m_filter_predicate == null)
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTN4KNFEDirectory)
                        {
                            var accessor = BTTN4KNFEDirectory_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            yield return accessor;
                            accessor.Dispose();
                        }
                    }
                else
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTN4KNFEDirectory)
                        {
                            var accessor = BTTN4KNFEDirectory_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                            accessor.Dispose();
                        }
                    }
            }
            else if (m_is_positive_filtering)
            {
                if (m_filter_predicate == null)
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTN4KNFEDirectory(cellID))
                        {
                            yield return accessor;
                        }
                    }
                else
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTN4KNFEDirectory(cellID))
                        {
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                        }
                    }
            }
            else
            {
                throw new NotImplementedException("Negative filtering not supported.");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal void SetPredicate(Expression aggregated_where_clause, ParameterExpression parameter)
        {
            m_filter_predicate = Expression.Lambda<Func<BTTN4KNFEDirectory_Accessor, bool>>(
                aggregated_where_clause,
                parameter
                ).Compile();
        }
    }
    internal class BTTN4KNFEDirectory_Enumerable : IEnumerable<BTTN4KNFEDirectory>
    {
        private LocalMemoryStorage      m_storage;
        private HashSet<long>           m_filter_set;
        private bool                    m_is_positive_filtering;
        private Func<BTTN4KNFEDirectory,bool>  m_filter_predicate;
        private static Type             m_cell_type = typeof(BTTN4KNFEDirectory);
        private LocalTransactionContext m_tx;
        internal BTTN4KNFEDirectory_Enumerable(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            m_storage          = storage;
            m_filter_set       = null;
            m_filter_predicate = null;
            m_tx               = tx;
        }
        internal void SetPositiveFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = true;
        }
        internal void SetNegativeFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = false;
        }
        public IEnumerator<BTTN4KNFEDirectory> GetEnumerator()
        {
            if (m_filter_set == null)
            {
                if (m_filter_predicate == null)
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTN4KNFEDirectory)
                        {
                            var accessor = BTTN4KNFEDirectory_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            yield return accessor;
                            accessor.Dispose();
                        }
                    }
                else
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTN4KNFEDirectory)
                        {
                            var accessor = BTTN4KNFEDirectory_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                            accessor.Dispose();
                        }
                    }
            }
            else if (m_is_positive_filtering)
            {
                if (m_filter_predicate == null)
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTN4KNFEDirectory(cellID))
                        {
                            yield return accessor;
                        }
                    }
                else
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTN4KNFEDirectory(cellID))
                        {
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                        }
                    }
            }
            else
            {
                throw new NotImplementedException("Negative filtering not supported.");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal void SetPredicate(Expression aggregated_where_clause, ParameterExpression parameter)
        {
            m_filter_predicate = Expression.Lambda<Func<BTTN4KNFEDirectory, bool>>(
                aggregated_where_clause,
                parameter
                ).Compile();
        }
    }
    internal class BTTN4KNFEDirectory_Accessor_local_query_provider : IQueryProvider
    {
        private static  Type                             s_accessor_type    = typeof(BTTN4KNFEDirectory_Accessor);
        private static  Type                             s_cell_type        = typeof(BTTN4KNFEDirectory);
        private static  Type                             s_ienumerable_type = typeof(IEnumerable<>);
        private         BTTN4KNFEDirectory_AccessorEnumerable   m_accessor_enumerable;
        internal BTTN4KNFEDirectory_Accessor_local_query_provider(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            m_accessor_enumerable = new BTTN4KNFEDirectory_AccessorEnumerable(storage, tx);
        }
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == s_accessor_type)
            {
                return (IQueryable<TElement>)new BTTN4KNFEDirectory_Accessor_local_selector(this, expression);
            }
            else
            {
                return new BTTN4KNFEDirectory_Accessor_local_projector<TElement>(this, expression);
            }
        }
        public TResult Execute<TResult>(Expression expression)
        {
            var  visitor              = new RewritableWhereCaluseVisitor<BTTN4KNFEDirectory_Accessor>(expression);
            var  where_clauses        = visitor.RewritableWhereClauses;
            var  queryable            = m_accessor_enumerable.AsQueryable<BTTN4KNFEDirectory_Accessor>();
            var  trimmed_expression   = visitor.InjectEnumerator(expression, queryable, typeof(BTTN4KNFEDirectory_Accessor_local_selector));
            if (where_clauses.Count != 0)
            {
                var subject_rewriter           = new PredicateSubjectRewriter<BTTN4KNFEDirectory_Accessor>();
                Expression aggregated_predicate = subject_rewriter.Visit(where_clauses.First().Body);
                foreach (var where_clause in where_clauses.Skip(1))
                {
                    Expression predicate = where_clause.Body;
                    aggregated_predicate = Expression.AndAlso(aggregated_predicate, subject_rewriter.Visit(predicate));
                }
                IndexQueryTreeGenerator<BTTN4KNFEDirectory_Accessor> query_tree_gen       = new IndexQueryTreeGenerator<BTTN4KNFEDirectory_Accessor>("BTTN4KNFEDirectory", Index.s_AccessorSubstringIndexAccessMethod, is_cell: false);
                aggregated_predicate                                               = query_tree_gen.Visit(aggregated_predicate);
                var query_tree                                                     = query_tree_gen.QueryTree;
                if (query_tree != null)
                {
                    query_tree = query_tree.Optimize();
                    var query_tree_exec = new IndexQueryTreeExecutor(Index.s_AccessorSubstringQueryMethodTable, Index.s_AccessorSubstringWildcardQueryMethodTable);
                    m_accessor_enumerable.SetPositiveFiltering(query_tree_exec.Execute(query_tree));
                }
                m_accessor_enumerable.SetPredicate(aggregated_predicate, subject_rewriter.Parameter);
            }
            if (trimmed_expression.NodeType == ExpressionType.Constant)
            {
                return (TResult)m_accessor_enumerable.GetEnumerator();
            }
            Type result_type          = typeof(TResult);
            bool result_is_enumerable = (result_type.GenericTypeArguments.Count() == 1);
            Type element_type         = result_is_enumerable ? result_type.GenericTypeArguments[0] : result_type;
            if (result_is_enumerable)
            {
                var  enumerator_type      = s_ienumerable_type.MakeGenericType(element_type);
                var  enumerator_extractor = Expression.Call(trimmed_expression, enumerator_type.GetMethod("GetEnumerator"));
                var  lambda               = Expression.Lambda<Func<TResult>>(enumerator_extractor);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
            else
            {
                var  lambda               = Expression.Lambda<Func<TResult>>(trimmed_expression);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
        }
        #region Not implemented
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }
        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    internal class BTTN4KNFEDirectory_local_query_provider : IQueryProvider
    {
        private static  Type                             s_cell_type        = typeof(BTTN4KNFEDirectory);
        private static  Type                             s_ienumerable_type = typeof(IEnumerable<>);
        private         BTTN4KNFEDirectory_Enumerable           s_cell_enumerable;
        internal BTTN4KNFEDirectory_local_query_provider(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            s_cell_enumerable = new BTTN4KNFEDirectory_Enumerable(storage, tx);
        }
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == s_cell_type)
            {
                return (IQueryable<TElement>)new BTTN4KNFEDirectory_local_selector(this, expression);
            }
            else
            {
                return new BTTN4KNFEDirectory_local_projector<TElement>(this, expression);
            }
        }
        public TResult Execute<TResult>(Expression expression)
        {
            var  visitor              = new RewritableWhereCaluseVisitor<BTTN4KNFEDirectory>(expression);
            var  where_clauses        = visitor.RewritableWhereClauses;
            var  queryable            = s_cell_enumerable.AsQueryable<BTTN4KNFEDirectory>();
            var  trimmed_expression   = visitor.InjectEnumerator(expression, queryable, typeof(BTTN4KNFEDirectory_local_selector));
            if (where_clauses.Count != 0)
            {
                var subject_rewriter           = new PredicateSubjectRewriter<BTTN4KNFEDirectory>();
                Expression aggregated_predicate = subject_rewriter.Visit(where_clauses.First().Body);
                foreach (var where_clause in where_clauses.Skip(1))
                {
                    Expression predicate = where_clause.Body;
                    aggregated_predicate = Expression.AndAlso(aggregated_predicate, subject_rewriter.Visit(predicate));
                }
                IndexQueryTreeGenerator<BTTN4KNFEDirectory> query_tree_gen       = new IndexQueryTreeGenerator<BTTN4KNFEDirectory>("BTTN4KNFEDirectory", Index.s_CellSubstringIndexAccessMethod, is_cell: true);
                aggregated_predicate                                      = query_tree_gen.Visit(aggregated_predicate);
                var query_tree                                            = query_tree_gen.QueryTree;
                if (query_tree != null)
                {
                    query_tree = query_tree.Optimize();
                    var query_tree_exec = new IndexQueryTreeExecutor(Index.s_CellSubstringQueryMethodTable, Index.s_CellSubstringWildcardQueryMethodTable);
                    s_cell_enumerable.SetPositiveFiltering(query_tree_exec.Execute(query_tree));
                }
                s_cell_enumerable.SetPredicate(aggregated_predicate, subject_rewriter.Parameter);
            }
            if (trimmed_expression.NodeType == ExpressionType.Constant)
            {
                return (TResult)s_cell_enumerable.GetEnumerator();
            }
            Type result_type          = typeof(TResult);
            bool result_is_enumerable = (result_type.GenericTypeArguments.Count() == 1);
            Type element_type         = result_is_enumerable ? result_type.GenericTypeArguments[0] : result_type;
            if (result_is_enumerable)
            {
                var  enumerator_type      = s_ienumerable_type.MakeGenericType(element_type);
                var  enumerator_extractor = Expression.Call(trimmed_expression, enumerator_type.GetMethod("GetEnumerator"));
                var  lambda               = Expression.Lambda<Func<TResult>>(enumerator_extractor);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
            else
            {
                var  lambda               = Expression.Lambda<Func<TResult>>(trimmed_expression);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
        }
        #region Not implemented
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }
        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion
    #region Public
    /// <summary>
    /// Implements System.Linq.IQueryable{BTTN4KNFEDirectory_Accessor} and accepts LINQ
    /// queries on <see cref="Trinity.Global.LocalStorage"/>.
    /// </summary>
    public class BTTN4KNFEDirectory_Accessor_local_selector : IQueryable<BTTN4KNFEDirectory_Accessor>
    {
        private         Expression                                   query_expression;
        private         BTTN4KNFEDirectory_Accessor_local_query_provider    query_provider;
        private BTTN4KNFEDirectory_Accessor_local_selector() { /* nobody should reach this method */ }
        internal BTTN4KNFEDirectory_Accessor_local_selector(Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.query_expression              = Expression.Constant(this);
            this.query_provider                = new BTTN4KNFEDirectory_Accessor_local_query_provider(storage, tx);
        }
        internal unsafe BTTN4KNFEDirectory_Accessor_local_selector(BTTN4KNFEDirectory_Accessor_local_query_provider query_provider, Expression query_expression)
        {
            this.query_expression              = query_expression;
            this.query_provider                = query_provider;
        }
        #region IQueryable<CellAccessor> interfaces
        public IEnumerator<BTTN4KNFEDirectory_Accessor> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<BTTN4KNFEDirectory_Accessor>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(BTTN4KNFEDirectory_Accessor); }
        }
        public Expression Expression
        {
            get { return this.query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
        #endregion
        #region PLINQ Wrapper
        public PLINQWrapper<BTTN4KNFEDirectory_Accessor> AsParallel()
        {
            return new PLINQWrapper<BTTN4KNFEDirectory_Accessor>(this);
        }
        #endregion
    }
    /// <summary>
    /// Implements System.Linq.IQueryable{BTTN4KNFEDirectory} and accepts LINQ
    /// queries on <see cref="Trinity.Global.LocalStorage"/>.
    /// </summary>
    public class BTTN4KNFEDirectory_local_selector : IQueryable<BTTN4KNFEDirectory>, IOrderedQueryable<BTTN4KNFEDirectory>
    {
        private         Expression                                   query_expression;
        private         BTTN4KNFEDirectory_local_query_provider             query_provider;
        private BTTN4KNFEDirectory_local_selector() { /* nobody should reach this method */ }
        internal BTTN4KNFEDirectory_local_selector(Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.query_expression              = Expression.Constant(this);
            this.query_provider                = new BTTN4KNFEDirectory_local_query_provider(storage, tx);
        }
        internal unsafe BTTN4KNFEDirectory_local_selector(BTTN4KNFEDirectory_local_query_provider query_provider, Expression query_expression)
        {
            this.query_expression              = query_expression;
            this.query_provider                = query_provider;
        }
        #region IQueryable<Cell> interfaces
        public IEnumerator<BTTN4KNFEDirectory> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<BTTN4KNFEDirectory>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<BTTN4KNFEDirectory>)this.GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(BTTN4KNFEDirectory); }
        }
        public Expression Expression
        {
            get { return this.query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
        #endregion
    }
    #endregion
    
    #region Internal
    /**
     * <summary>
     * Accepts transformation from BTTNFE_N4K_SealedEnvelope_Cell_Accessor to T.
     * </summary>
     */
    internal class BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_projector<T> : IQueryable<T>
    {
        private         Expression                                   query_expression;
        private         BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_query_provider    query_provider;
        internal BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_projector(BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_query_provider provider, Expression expression)
        {
            this.query_expression              = expression;
            this.query_provider                = provider;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<T>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(T); }
        }
        public Expression Expression
        {
            get { return query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
    }
    /**
     * Accepts transformation from BTTNFE_N4K_SealedEnvelope_Cell to T.
     */
    internal class BTTNFE_N4K_SealedEnvelope_Cell_local_projector<T> : IQueryable<T>
    {
        private         Expression                                   query_expression;
        private         BTTNFE_N4K_SealedEnvelope_Cell_local_query_provider             query_provider;
        internal BTTNFE_N4K_SealedEnvelope_Cell_local_projector(BTTNFE_N4K_SealedEnvelope_Cell_local_query_provider provider, Expression expression)
        {
            this.query_expression              = expression;
            this.query_provider                = provider;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<T>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(T); }
        }
        public Expression Expression
        {
            get { return query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
    }
    internal class BTTNFE_N4K_SealedEnvelope_Cell_AccessorEnumerable : IEnumerable<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>
    {
        private     LocalMemoryStorage              m_storage;
        private     LocalTransactionContext         m_tx;
        private     HashSet<long>                   m_filter_set;
        private     bool                            m_is_positive_filtering;
        private     Func<BTTNFE_N4K_SealedEnvelope_Cell_Accessor,bool> m_filter_predicate;
        internal BTTNFE_N4K_SealedEnvelope_Cell_AccessorEnumerable(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.m_storage     = storage;
            m_filter_set       = null;
            m_filter_predicate = null;
            m_tx               = tx;
        }
        internal void SetPositiveFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = true;
        }
        internal void SetNegativeFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = false;
        }
        public IEnumerator<BTTNFE_N4K_SealedEnvelope_Cell_Accessor> GetEnumerator()
        {
            if (m_filter_set == null)
            {
                if (m_filter_predicate == null)
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTNFE_N4K_SealedEnvelope_Cell)
                        {
                            var accessor = BTTNFE_N4K_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            yield return accessor;
                            accessor.Dispose();
                        }
                    }
                else
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTNFE_N4K_SealedEnvelope_Cell)
                        {
                            var accessor = BTTNFE_N4K_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                            accessor.Dispose();
                        }
                    }
            }
            else if (m_is_positive_filtering)
            {
                if (m_filter_predicate == null)
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTNFE_N4K_SealedEnvelope_Cell(cellID))
                        {
                            yield return accessor;
                        }
                    }
                else
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTNFE_N4K_SealedEnvelope_Cell(cellID))
                        {
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                        }
                    }
            }
            else
            {
                throw new NotImplementedException("Negative filtering not supported.");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal void SetPredicate(Expression aggregated_where_clause, ParameterExpression parameter)
        {
            m_filter_predicate = Expression.Lambda<Func<BTTNFE_N4K_SealedEnvelope_Cell_Accessor, bool>>(
                aggregated_where_clause,
                parameter
                ).Compile();
        }
    }
    internal class BTTNFE_N4K_SealedEnvelope_Cell_Enumerable : IEnumerable<BTTNFE_N4K_SealedEnvelope_Cell>
    {
        private LocalMemoryStorage      m_storage;
        private HashSet<long>           m_filter_set;
        private bool                    m_is_positive_filtering;
        private Func<BTTNFE_N4K_SealedEnvelope_Cell,bool>  m_filter_predicate;
        private static Type             m_cell_type = typeof(BTTNFE_N4K_SealedEnvelope_Cell);
        private LocalTransactionContext m_tx;
        internal BTTNFE_N4K_SealedEnvelope_Cell_Enumerable(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            m_storage          = storage;
            m_filter_set       = null;
            m_filter_predicate = null;
            m_tx               = tx;
        }
        internal void SetPositiveFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = true;
        }
        internal void SetNegativeFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = false;
        }
        public IEnumerator<BTTNFE_N4K_SealedEnvelope_Cell> GetEnumerator()
        {
            if (m_filter_set == null)
            {
                if (m_filter_predicate == null)
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTNFE_N4K_SealedEnvelope_Cell)
                        {
                            var accessor = BTTNFE_N4K_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            yield return accessor;
                            accessor.Dispose();
                        }
                    }
                else
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTNFE_N4K_SealedEnvelope_Cell)
                        {
                            var accessor = BTTNFE_N4K_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                            accessor.Dispose();
                        }
                    }
            }
            else if (m_is_positive_filtering)
            {
                if (m_filter_predicate == null)
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTNFE_N4K_SealedEnvelope_Cell(cellID))
                        {
                            yield return accessor;
                        }
                    }
                else
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTNFE_N4K_SealedEnvelope_Cell(cellID))
                        {
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                        }
                    }
            }
            else
            {
                throw new NotImplementedException("Negative filtering not supported.");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal void SetPredicate(Expression aggregated_where_clause, ParameterExpression parameter)
        {
            m_filter_predicate = Expression.Lambda<Func<BTTNFE_N4K_SealedEnvelope_Cell, bool>>(
                aggregated_where_clause,
                parameter
                ).Compile();
        }
    }
    internal class BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_query_provider : IQueryProvider
    {
        private static  Type                             s_accessor_type    = typeof(BTTNFE_N4K_SealedEnvelope_Cell_Accessor);
        private static  Type                             s_cell_type        = typeof(BTTNFE_N4K_SealedEnvelope_Cell);
        private static  Type                             s_ienumerable_type = typeof(IEnumerable<>);
        private         BTTNFE_N4K_SealedEnvelope_Cell_AccessorEnumerable   m_accessor_enumerable;
        internal BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_query_provider(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            m_accessor_enumerable = new BTTNFE_N4K_SealedEnvelope_Cell_AccessorEnumerable(storage, tx);
        }
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == s_accessor_type)
            {
                return (IQueryable<TElement>)new BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector(this, expression);
            }
            else
            {
                return new BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_projector<TElement>(this, expression);
            }
        }
        public TResult Execute<TResult>(Expression expression)
        {
            var  visitor              = new RewritableWhereCaluseVisitor<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>(expression);
            var  where_clauses        = visitor.RewritableWhereClauses;
            var  queryable            = m_accessor_enumerable.AsQueryable<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>();
            var  trimmed_expression   = visitor.InjectEnumerator(expression, queryable, typeof(BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector));
            if (where_clauses.Count != 0)
            {
                var subject_rewriter           = new PredicateSubjectRewriter<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>();
                Expression aggregated_predicate = subject_rewriter.Visit(where_clauses.First().Body);
                foreach (var where_clause in where_clauses.Skip(1))
                {
                    Expression predicate = where_clause.Body;
                    aggregated_predicate = Expression.AndAlso(aggregated_predicate, subject_rewriter.Visit(predicate));
                }
                IndexQueryTreeGenerator<BTTNFE_N4K_SealedEnvelope_Cell_Accessor> query_tree_gen       = new IndexQueryTreeGenerator<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>("BTTNFE_N4K_SealedEnvelope_Cell", Index.s_AccessorSubstringIndexAccessMethod, is_cell: false);
                aggregated_predicate                                               = query_tree_gen.Visit(aggregated_predicate);
                var query_tree                                                     = query_tree_gen.QueryTree;
                if (query_tree != null)
                {
                    query_tree = query_tree.Optimize();
                    var query_tree_exec = new IndexQueryTreeExecutor(Index.s_AccessorSubstringQueryMethodTable, Index.s_AccessorSubstringWildcardQueryMethodTable);
                    m_accessor_enumerable.SetPositiveFiltering(query_tree_exec.Execute(query_tree));
                }
                m_accessor_enumerable.SetPredicate(aggregated_predicate, subject_rewriter.Parameter);
            }
            if (trimmed_expression.NodeType == ExpressionType.Constant)
            {
                return (TResult)m_accessor_enumerable.GetEnumerator();
            }
            Type result_type          = typeof(TResult);
            bool result_is_enumerable = (result_type.GenericTypeArguments.Count() == 1);
            Type element_type         = result_is_enumerable ? result_type.GenericTypeArguments[0] : result_type;
            if (result_is_enumerable)
            {
                var  enumerator_type      = s_ienumerable_type.MakeGenericType(element_type);
                var  enumerator_extractor = Expression.Call(trimmed_expression, enumerator_type.GetMethod("GetEnumerator"));
                var  lambda               = Expression.Lambda<Func<TResult>>(enumerator_extractor);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
            else
            {
                var  lambda               = Expression.Lambda<Func<TResult>>(trimmed_expression);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
        }
        #region Not implemented
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }
        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    internal class BTTNFE_N4K_SealedEnvelope_Cell_local_query_provider : IQueryProvider
    {
        private static  Type                             s_cell_type        = typeof(BTTNFE_N4K_SealedEnvelope_Cell);
        private static  Type                             s_ienumerable_type = typeof(IEnumerable<>);
        private         BTTNFE_N4K_SealedEnvelope_Cell_Enumerable           s_cell_enumerable;
        internal BTTNFE_N4K_SealedEnvelope_Cell_local_query_provider(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            s_cell_enumerable = new BTTNFE_N4K_SealedEnvelope_Cell_Enumerable(storage, tx);
        }
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == s_cell_type)
            {
                return (IQueryable<TElement>)new BTTNFE_N4K_SealedEnvelope_Cell_local_selector(this, expression);
            }
            else
            {
                return new BTTNFE_N4K_SealedEnvelope_Cell_local_projector<TElement>(this, expression);
            }
        }
        public TResult Execute<TResult>(Expression expression)
        {
            var  visitor              = new RewritableWhereCaluseVisitor<BTTNFE_N4K_SealedEnvelope_Cell>(expression);
            var  where_clauses        = visitor.RewritableWhereClauses;
            var  queryable            = s_cell_enumerable.AsQueryable<BTTNFE_N4K_SealedEnvelope_Cell>();
            var  trimmed_expression   = visitor.InjectEnumerator(expression, queryable, typeof(BTTNFE_N4K_SealedEnvelope_Cell_local_selector));
            if (where_clauses.Count != 0)
            {
                var subject_rewriter           = new PredicateSubjectRewriter<BTTNFE_N4K_SealedEnvelope_Cell>();
                Expression aggregated_predicate = subject_rewriter.Visit(where_clauses.First().Body);
                foreach (var where_clause in where_clauses.Skip(1))
                {
                    Expression predicate = where_clause.Body;
                    aggregated_predicate = Expression.AndAlso(aggregated_predicate, subject_rewriter.Visit(predicate));
                }
                IndexQueryTreeGenerator<BTTNFE_N4K_SealedEnvelope_Cell> query_tree_gen       = new IndexQueryTreeGenerator<BTTNFE_N4K_SealedEnvelope_Cell>("BTTNFE_N4K_SealedEnvelope_Cell", Index.s_CellSubstringIndexAccessMethod, is_cell: true);
                aggregated_predicate                                      = query_tree_gen.Visit(aggregated_predicate);
                var query_tree                                            = query_tree_gen.QueryTree;
                if (query_tree != null)
                {
                    query_tree = query_tree.Optimize();
                    var query_tree_exec = new IndexQueryTreeExecutor(Index.s_CellSubstringQueryMethodTable, Index.s_CellSubstringWildcardQueryMethodTable);
                    s_cell_enumerable.SetPositiveFiltering(query_tree_exec.Execute(query_tree));
                }
                s_cell_enumerable.SetPredicate(aggregated_predicate, subject_rewriter.Parameter);
            }
            if (trimmed_expression.NodeType == ExpressionType.Constant)
            {
                return (TResult)s_cell_enumerable.GetEnumerator();
            }
            Type result_type          = typeof(TResult);
            bool result_is_enumerable = (result_type.GenericTypeArguments.Count() == 1);
            Type element_type         = result_is_enumerable ? result_type.GenericTypeArguments[0] : result_type;
            if (result_is_enumerable)
            {
                var  enumerator_type      = s_ienumerable_type.MakeGenericType(element_type);
                var  enumerator_extractor = Expression.Call(trimmed_expression, enumerator_type.GetMethod("GetEnumerator"));
                var  lambda               = Expression.Lambda<Func<TResult>>(enumerator_extractor);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
            else
            {
                var  lambda               = Expression.Lambda<Func<TResult>>(trimmed_expression);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
        }
        #region Not implemented
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }
        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion
    #region Public
    /// <summary>
    /// Implements System.Linq.IQueryable{BTTNFE_N4K_SealedEnvelope_Cell_Accessor} and accepts LINQ
    /// queries on <see cref="Trinity.Global.LocalStorage"/>.
    /// </summary>
    public class BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector : IQueryable<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>
    {
        private         Expression                                   query_expression;
        private         BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_query_provider    query_provider;
        private BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector() { /* nobody should reach this method */ }
        internal BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector(Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.query_expression              = Expression.Constant(this);
            this.query_provider                = new BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_query_provider(storage, tx);
        }
        internal unsafe BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector(BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_query_provider query_provider, Expression query_expression)
        {
            this.query_expression              = query_expression;
            this.query_provider                = query_provider;
        }
        #region IQueryable<CellAccessor> interfaces
        public IEnumerator<BTTNFE_N4K_SealedEnvelope_Cell_Accessor> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(BTTNFE_N4K_SealedEnvelope_Cell_Accessor); }
        }
        public Expression Expression
        {
            get { return this.query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
        #endregion
        #region PLINQ Wrapper
        public PLINQWrapper<BTTNFE_N4K_SealedEnvelope_Cell_Accessor> AsParallel()
        {
            return new PLINQWrapper<BTTNFE_N4K_SealedEnvelope_Cell_Accessor>(this);
        }
        #endregion
    }
    /// <summary>
    /// Implements System.Linq.IQueryable{BTTNFE_N4K_SealedEnvelope_Cell} and accepts LINQ
    /// queries on <see cref="Trinity.Global.LocalStorage"/>.
    /// </summary>
    public class BTTNFE_N4K_SealedEnvelope_Cell_local_selector : IQueryable<BTTNFE_N4K_SealedEnvelope_Cell>, IOrderedQueryable<BTTNFE_N4K_SealedEnvelope_Cell>
    {
        private         Expression                                   query_expression;
        private         BTTNFE_N4K_SealedEnvelope_Cell_local_query_provider             query_provider;
        private BTTNFE_N4K_SealedEnvelope_Cell_local_selector() { /* nobody should reach this method */ }
        internal BTTNFE_N4K_SealedEnvelope_Cell_local_selector(Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.query_expression              = Expression.Constant(this);
            this.query_provider                = new BTTNFE_N4K_SealedEnvelope_Cell_local_query_provider(storage, tx);
        }
        internal unsafe BTTNFE_N4K_SealedEnvelope_Cell_local_selector(BTTNFE_N4K_SealedEnvelope_Cell_local_query_provider query_provider, Expression query_expression)
        {
            this.query_expression              = query_expression;
            this.query_provider                = query_provider;
        }
        #region IQueryable<Cell> interfaces
        public IEnumerator<BTTNFE_N4K_SealedEnvelope_Cell> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<BTTNFE_N4K_SealedEnvelope_Cell>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<BTTNFE_N4K_SealedEnvelope_Cell>)this.GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(BTTNFE_N4K_SealedEnvelope_Cell); }
        }
        public Expression Expression
        {
            get { return this.query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
        #endregion
    }
    #endregion
    
    #region Internal
    /**
     * <summary>
     * Accepts transformation from BTTVerifiableCredential_SealedEnvelope_Cell_Accessor to T.
     * </summary>
     */
    internal class BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_projector<T> : IQueryable<T>
    {
        private         Expression                                   query_expression;
        private         BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_query_provider    query_provider;
        internal BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_projector(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_query_provider provider, Expression expression)
        {
            this.query_expression              = expression;
            this.query_provider                = provider;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<T>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(T); }
        }
        public Expression Expression
        {
            get { return query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
    }
    /**
     * Accepts transformation from BTTVerifiableCredential_SealedEnvelope_Cell to T.
     */
    internal class BTTVerifiableCredential_SealedEnvelope_Cell_local_projector<T> : IQueryable<T>
    {
        private         Expression                                   query_expression;
        private         BTTVerifiableCredential_SealedEnvelope_Cell_local_query_provider             query_provider;
        internal BTTVerifiableCredential_SealedEnvelope_Cell_local_projector(BTTVerifiableCredential_SealedEnvelope_Cell_local_query_provider provider, Expression expression)
        {
            this.query_expression              = expression;
            this.query_provider                = provider;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<T>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(T); }
        }
        public Expression Expression
        {
            get { return query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
    }
    internal class BTTVerifiableCredential_SealedEnvelope_Cell_AccessorEnumerable : IEnumerable<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>
    {
        private     LocalMemoryStorage              m_storage;
        private     LocalTransactionContext         m_tx;
        private     HashSet<long>                   m_filter_set;
        private     bool                            m_is_positive_filtering;
        private     Func<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor,bool> m_filter_predicate;
        internal BTTVerifiableCredential_SealedEnvelope_Cell_AccessorEnumerable(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.m_storage     = storage;
            m_filter_set       = null;
            m_filter_predicate = null;
            m_tx               = tx;
        }
        internal void SetPositiveFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = true;
        }
        internal void SetNegativeFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = false;
        }
        public IEnumerator<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor> GetEnumerator()
        {
            if (m_filter_set == null)
            {
                if (m_filter_predicate == null)
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell)
                        {
                            var accessor = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            yield return accessor;
                            accessor.Dispose();
                        }
                    }
                else
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell)
                        {
                            var accessor = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                            accessor.Dispose();
                        }
                    }
            }
            else if (m_is_positive_filtering)
            {
                if (m_filter_predicate == null)
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTVerifiableCredential_SealedEnvelope_Cell(cellID))
                        {
                            yield return accessor;
                        }
                    }
                else
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTVerifiableCredential_SealedEnvelope_Cell(cellID))
                        {
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                        }
                    }
            }
            else
            {
                throw new NotImplementedException("Negative filtering not supported.");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal void SetPredicate(Expression aggregated_where_clause, ParameterExpression parameter)
        {
            m_filter_predicate = Expression.Lambda<Func<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor, bool>>(
                aggregated_where_clause,
                parameter
                ).Compile();
        }
    }
    internal class BTTVerifiableCredential_SealedEnvelope_Cell_Enumerable : IEnumerable<BTTVerifiableCredential_SealedEnvelope_Cell>
    {
        private LocalMemoryStorage      m_storage;
        private HashSet<long>           m_filter_set;
        private bool                    m_is_positive_filtering;
        private Func<BTTVerifiableCredential_SealedEnvelope_Cell,bool>  m_filter_predicate;
        private static Type             m_cell_type = typeof(BTTVerifiableCredential_SealedEnvelope_Cell);
        private LocalTransactionContext m_tx;
        internal BTTVerifiableCredential_SealedEnvelope_Cell_Enumerable(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            m_storage          = storage;
            m_filter_set       = null;
            m_filter_predicate = null;
            m_tx               = tx;
        }
        internal void SetPositiveFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = true;
        }
        internal void SetNegativeFiltering(HashSet<long> set)
        {
            this.m_filter_set       = set;
            m_is_positive_filtering = false;
        }
        public IEnumerator<BTTVerifiableCredential_SealedEnvelope_Cell> GetEnumerator()
        {
            if (m_filter_set == null)
            {
                if (m_filter_predicate == null)
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell)
                        {
                            var accessor = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            yield return accessor;
                            accessor.Dispose();
                        }
                    }
                else
                    foreach (var cellInfo in m_storage)
                    {
                        if (cellInfo.CellType == (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell)
                        {
                            var accessor = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor.AllocIterativeAccessor(cellInfo, m_tx);
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                            accessor.Dispose();
                        }
                    }
            }
            else if (m_is_positive_filtering)
            {
                if (m_filter_predicate == null)
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTVerifiableCredential_SealedEnvelope_Cell(cellID))
                        {
                            yield return accessor;
                        }
                    }
                else
                    foreach (var cellID in m_filter_set)
                    {
                        using (var accessor = m_storage.UseBTTVerifiableCredential_SealedEnvelope_Cell(cellID))
                        {
                            if (m_filter_predicate(accessor))
                                yield return accessor;
                        }
                    }
            }
            else
            {
                throw new NotImplementedException("Negative filtering not supported.");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal void SetPredicate(Expression aggregated_where_clause, ParameterExpression parameter)
        {
            m_filter_predicate = Expression.Lambda<Func<BTTVerifiableCredential_SealedEnvelope_Cell, bool>>(
                aggregated_where_clause,
                parameter
                ).Compile();
        }
    }
    internal class BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_query_provider : IQueryProvider
    {
        private static  Type                             s_accessor_type    = typeof(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor);
        private static  Type                             s_cell_type        = typeof(BTTVerifiableCredential_SealedEnvelope_Cell);
        private static  Type                             s_ienumerable_type = typeof(IEnumerable<>);
        private         BTTVerifiableCredential_SealedEnvelope_Cell_AccessorEnumerable   m_accessor_enumerable;
        internal BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_query_provider(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            m_accessor_enumerable = new BTTVerifiableCredential_SealedEnvelope_Cell_AccessorEnumerable(storage, tx);
        }
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == s_accessor_type)
            {
                return (IQueryable<TElement>)new BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector(this, expression);
            }
            else
            {
                return new BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_projector<TElement>(this, expression);
            }
        }
        public TResult Execute<TResult>(Expression expression)
        {
            var  visitor              = new RewritableWhereCaluseVisitor<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>(expression);
            var  where_clauses        = visitor.RewritableWhereClauses;
            var  queryable            = m_accessor_enumerable.AsQueryable<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>();
            var  trimmed_expression   = visitor.InjectEnumerator(expression, queryable, typeof(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector));
            if (where_clauses.Count != 0)
            {
                var subject_rewriter           = new PredicateSubjectRewriter<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>();
                Expression aggregated_predicate = subject_rewriter.Visit(where_clauses.First().Body);
                foreach (var where_clause in where_clauses.Skip(1))
                {
                    Expression predicate = where_clause.Body;
                    aggregated_predicate = Expression.AndAlso(aggregated_predicate, subject_rewriter.Visit(predicate));
                }
                IndexQueryTreeGenerator<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor> query_tree_gen       = new IndexQueryTreeGenerator<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>("BTTVerifiableCredential_SealedEnvelope_Cell", Index.s_AccessorSubstringIndexAccessMethod, is_cell: false);
                aggregated_predicate                                               = query_tree_gen.Visit(aggregated_predicate);
                var query_tree                                                     = query_tree_gen.QueryTree;
                if (query_tree != null)
                {
                    query_tree = query_tree.Optimize();
                    var query_tree_exec = new IndexQueryTreeExecutor(Index.s_AccessorSubstringQueryMethodTable, Index.s_AccessorSubstringWildcardQueryMethodTable);
                    m_accessor_enumerable.SetPositiveFiltering(query_tree_exec.Execute(query_tree));
                }
                m_accessor_enumerable.SetPredicate(aggregated_predicate, subject_rewriter.Parameter);
            }
            if (trimmed_expression.NodeType == ExpressionType.Constant)
            {
                return (TResult)m_accessor_enumerable.GetEnumerator();
            }
            Type result_type          = typeof(TResult);
            bool result_is_enumerable = (result_type.GenericTypeArguments.Count() == 1);
            Type element_type         = result_is_enumerable ? result_type.GenericTypeArguments[0] : result_type;
            if (result_is_enumerable)
            {
                var  enumerator_type      = s_ienumerable_type.MakeGenericType(element_type);
                var  enumerator_extractor = Expression.Call(trimmed_expression, enumerator_type.GetMethod("GetEnumerator"));
                var  lambda               = Expression.Lambda<Func<TResult>>(enumerator_extractor);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
            else
            {
                var  lambda               = Expression.Lambda<Func<TResult>>(trimmed_expression);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
        }
        #region Not implemented
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }
        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    internal class BTTVerifiableCredential_SealedEnvelope_Cell_local_query_provider : IQueryProvider
    {
        private static  Type                             s_cell_type        = typeof(BTTVerifiableCredential_SealedEnvelope_Cell);
        private static  Type                             s_ienumerable_type = typeof(IEnumerable<>);
        private         BTTVerifiableCredential_SealedEnvelope_Cell_Enumerable           s_cell_enumerable;
        internal BTTVerifiableCredential_SealedEnvelope_Cell_local_query_provider(LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            s_cell_enumerable = new BTTVerifiableCredential_SealedEnvelope_Cell_Enumerable(storage, tx);
        }
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == s_cell_type)
            {
                return (IQueryable<TElement>)new BTTVerifiableCredential_SealedEnvelope_Cell_local_selector(this, expression);
            }
            else
            {
                return new BTTVerifiableCredential_SealedEnvelope_Cell_local_projector<TElement>(this, expression);
            }
        }
        public TResult Execute<TResult>(Expression expression)
        {
            var  visitor              = new RewritableWhereCaluseVisitor<BTTVerifiableCredential_SealedEnvelope_Cell>(expression);
            var  where_clauses        = visitor.RewritableWhereClauses;
            var  queryable            = s_cell_enumerable.AsQueryable<BTTVerifiableCredential_SealedEnvelope_Cell>();
            var  trimmed_expression   = visitor.InjectEnumerator(expression, queryable, typeof(BTTVerifiableCredential_SealedEnvelope_Cell_local_selector));
            if (where_clauses.Count != 0)
            {
                var subject_rewriter           = new PredicateSubjectRewriter<BTTVerifiableCredential_SealedEnvelope_Cell>();
                Expression aggregated_predicate = subject_rewriter.Visit(where_clauses.First().Body);
                foreach (var where_clause in where_clauses.Skip(1))
                {
                    Expression predicate = where_clause.Body;
                    aggregated_predicate = Expression.AndAlso(aggregated_predicate, subject_rewriter.Visit(predicate));
                }
                IndexQueryTreeGenerator<BTTVerifiableCredential_SealedEnvelope_Cell> query_tree_gen       = new IndexQueryTreeGenerator<BTTVerifiableCredential_SealedEnvelope_Cell>("BTTVerifiableCredential_SealedEnvelope_Cell", Index.s_CellSubstringIndexAccessMethod, is_cell: true);
                aggregated_predicate                                      = query_tree_gen.Visit(aggregated_predicate);
                var query_tree                                            = query_tree_gen.QueryTree;
                if (query_tree != null)
                {
                    query_tree = query_tree.Optimize();
                    var query_tree_exec = new IndexQueryTreeExecutor(Index.s_CellSubstringQueryMethodTable, Index.s_CellSubstringWildcardQueryMethodTable);
                    s_cell_enumerable.SetPositiveFiltering(query_tree_exec.Execute(query_tree));
                }
                s_cell_enumerable.SetPredicate(aggregated_predicate, subject_rewriter.Parameter);
            }
            if (trimmed_expression.NodeType == ExpressionType.Constant)
            {
                return (TResult)s_cell_enumerable.GetEnumerator();
            }
            Type result_type          = typeof(TResult);
            bool result_is_enumerable = (result_type.GenericTypeArguments.Count() == 1);
            Type element_type         = result_is_enumerable ? result_type.GenericTypeArguments[0] : result_type;
            if (result_is_enumerable)
            {
                var  enumerator_type      = s_ienumerable_type.MakeGenericType(element_type);
                var  enumerator_extractor = Expression.Call(trimmed_expression, enumerator_type.GetMethod("GetEnumerator"));
                var  lambda               = Expression.Lambda<Func<TResult>>(enumerator_extractor);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
            else
            {
                var  lambda               = Expression.Lambda<Func<TResult>>(trimmed_expression);
                var  func                 = (lambda).Compile();
                var  result               = func();
                return result;
            }
        }
        #region Not implemented
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }
        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion
    #region Public
    /// <summary>
    /// Implements System.Linq.IQueryable{BTTVerifiableCredential_SealedEnvelope_Cell_Accessor} and accepts LINQ
    /// queries on <see cref="Trinity.Global.LocalStorage"/>.
    /// </summary>
    public class BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector : IQueryable<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>
    {
        private         Expression                                   query_expression;
        private         BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_query_provider    query_provider;
        private BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector() { /* nobody should reach this method */ }
        internal BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector(Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.query_expression              = Expression.Constant(this);
            this.query_provider                = new BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_query_provider(storage, tx);
        }
        internal unsafe BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_query_provider query_provider, Expression query_expression)
        {
            this.query_expression              = query_expression;
            this.query_provider                = query_provider;
        }
        #region IQueryable<CellAccessor> interfaces
        public IEnumerator<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor); }
        }
        public Expression Expression
        {
            get { return this.query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
        #endregion
        #region PLINQ Wrapper
        public PLINQWrapper<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor> AsParallel()
        {
            return new PLINQWrapper<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>(this);
        }
        #endregion
    }
    /// <summary>
    /// Implements System.Linq.IQueryable{BTTVerifiableCredential_SealedEnvelope_Cell} and accepts LINQ
    /// queries on <see cref="Trinity.Global.LocalStorage"/>.
    /// </summary>
    public class BTTVerifiableCredential_SealedEnvelope_Cell_local_selector : IQueryable<BTTVerifiableCredential_SealedEnvelope_Cell>, IOrderedQueryable<BTTVerifiableCredential_SealedEnvelope_Cell>
    {
        private         Expression                                   query_expression;
        private         BTTVerifiableCredential_SealedEnvelope_Cell_local_query_provider             query_provider;
        private BTTVerifiableCredential_SealedEnvelope_Cell_local_selector() { /* nobody should reach this method */ }
        internal BTTVerifiableCredential_SealedEnvelope_Cell_local_selector(Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            this.query_expression              = Expression.Constant(this);
            this.query_provider                = new BTTVerifiableCredential_SealedEnvelope_Cell_local_query_provider(storage, tx);
        }
        internal unsafe BTTVerifiableCredential_SealedEnvelope_Cell_local_selector(BTTVerifiableCredential_SealedEnvelope_Cell_local_query_provider query_provider, Expression query_expression)
        {
            this.query_expression              = query_expression;
            this.query_provider                = query_provider;
        }
        #region IQueryable<Cell> interfaces
        public IEnumerator<BTTVerifiableCredential_SealedEnvelope_Cell> GetEnumerator()
        {
            return Provider.Execute<IEnumerator<BTTVerifiableCredential_SealedEnvelope_Cell>>(query_expression);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<BTTVerifiableCredential_SealedEnvelope_Cell>)this.GetEnumerator();
        }
        public Type ElementType
        {
            get { return typeof(BTTVerifiableCredential_SealedEnvelope_Cell); }
        }
        public Expression Expression
        {
            get { return this.query_expression; }
        }
        public IQueryProvider Provider
        {
            get { return query_provider; }
        }
        #endregion
    }
    #endregion
    
    public static class LocalStorageCellSelectorExtension
    {
        
        /// <summary>
        /// Enumerates all the BTTN4KNFEDirectory within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTN4KNFEDirectory within the local memory storage.</returns>
        public static BTTN4KNFEDirectory_local_selector BTTN4KNFEDirectory_Selector(this LocalMemoryStorage storage)
        {
            return new BTTN4KNFEDirectory_local_selector(storage, null);
        }
        /// <summary>
        /// Enumerates all the BTTN4KNFEDirectory_Accessor within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTN4KNFEDirectory_Accessor within the local memory storage.</returns>
        public static BTTN4KNFEDirectory_Accessor_local_selector BTTN4KNFEDirectory_Accessor_Selector(this LocalMemoryStorage storage)
        {
            return new BTTN4KNFEDirectory_Accessor_local_selector(storage, null);
        }
        /// <summary>
        /// Enumerates all the BTTN4KNFEDirectory within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTN4KNFEDirectory within the local memory storage.</returns>
        public static BTTN4KNFEDirectory_local_selector BTTN4KNFEDirectory_Selector(this LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            return new BTTN4KNFEDirectory_local_selector(storage, tx);
        }
        /// <summary>
        /// Enumerates all the BTTN4KNFEDirectory_Accessor within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTN4KNFEDirectory_Accessor within the local memory storage.</returns>
        public static BTTN4KNFEDirectory_Accessor_local_selector BTTN4KNFEDirectory_Accessor_Selector(this LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            return new BTTN4KNFEDirectory_Accessor_local_selector(storage, tx);
        }
        
        /// <summary>
        /// Enumerates all the BTTNFE_N4K_SealedEnvelope_Cell within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTNFE_N4K_SealedEnvelope_Cell within the local memory storage.</returns>
        public static BTTNFE_N4K_SealedEnvelope_Cell_local_selector BTTNFE_N4K_SealedEnvelope_Cell_Selector(this LocalMemoryStorage storage)
        {
            return new BTTNFE_N4K_SealedEnvelope_Cell_local_selector(storage, null);
        }
        /// <summary>
        /// Enumerates all the BTTNFE_N4K_SealedEnvelope_Cell_Accessor within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTNFE_N4K_SealedEnvelope_Cell_Accessor within the local memory storage.</returns>
        public static BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector BTTNFE_N4K_SealedEnvelope_Cell_Accessor_Selector(this LocalMemoryStorage storage)
        {
            return new BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector(storage, null);
        }
        /// <summary>
        /// Enumerates all the BTTNFE_N4K_SealedEnvelope_Cell within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTNFE_N4K_SealedEnvelope_Cell within the local memory storage.</returns>
        public static BTTNFE_N4K_SealedEnvelope_Cell_local_selector BTTNFE_N4K_SealedEnvelope_Cell_Selector(this LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            return new BTTNFE_N4K_SealedEnvelope_Cell_local_selector(storage, tx);
        }
        /// <summary>
        /// Enumerates all the BTTNFE_N4K_SealedEnvelope_Cell_Accessor within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTNFE_N4K_SealedEnvelope_Cell_Accessor within the local memory storage.</returns>
        public static BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector BTTNFE_N4K_SealedEnvelope_Cell_Accessor_Selector(this LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            return new BTTNFE_N4K_SealedEnvelope_Cell_Accessor_local_selector(storage, tx);
        }
        
        /// <summary>
        /// Enumerates all the BTTVerifiableCredential_SealedEnvelope_Cell within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTVerifiableCredential_SealedEnvelope_Cell within the local memory storage.</returns>
        public static BTTVerifiableCredential_SealedEnvelope_Cell_local_selector BTTVerifiableCredential_SealedEnvelope_Cell_Selector(this LocalMemoryStorage storage)
        {
            return new BTTVerifiableCredential_SealedEnvelope_Cell_local_selector(storage, null);
        }
        /// <summary>
        /// Enumerates all the BTTVerifiableCredential_SealedEnvelope_Cell_Accessor within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTVerifiableCredential_SealedEnvelope_Cell_Accessor within the local memory storage.</returns>
        public static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_Selector(this LocalMemoryStorage storage)
        {
            return new BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector(storage, null);
        }
        /// <summary>
        /// Enumerates all the BTTVerifiableCredential_SealedEnvelope_Cell within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTVerifiableCredential_SealedEnvelope_Cell within the local memory storage.</returns>
        public static BTTVerifiableCredential_SealedEnvelope_Cell_local_selector BTTVerifiableCredential_SealedEnvelope_Cell_Selector(this LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            return new BTTVerifiableCredential_SealedEnvelope_Cell_local_selector(storage, tx);
        }
        /// <summary>
        /// Enumerates all the BTTVerifiableCredential_SealedEnvelope_Cell_Accessor within the local memory storage.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> object.</param>
        /// <returns>All the BTTVerifiableCredential_SealedEnvelope_Cell_Accessor within the local memory storage.</returns>
        public static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_Selector(this LocalMemoryStorage storage, LocalTransactionContext tx)
        {
            return new BTTVerifiableCredential_SealedEnvelope_Cell_Accessor_local_selector(storage, tx);
        }
        
    }
}

#pragma warning restore 162,168,649,660,661,1522
