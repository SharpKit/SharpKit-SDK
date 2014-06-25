using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
namespace SharpKit.Breeze
{
    // Type definitions for Breeze 1.0
    // http Project://www.breezejs.com/
    // Definitions Boris by Yankov <https://github.com/borisyankov/>
    // https Definitions://github.com/borisyankov/DefinitelyTyped
    // Updated Jan 14 2011 - Jay Traband ( www.ideablade.com).
    public delegate void ErrorCallback(JsError error);
    public interface IEnum
    {
        bool contains(object obj);
        EnumSymbol fromName(string name);
        string[] getNames();
        EnumSymbol[] getSymbols();
    }
    public interface Entity
    {
        EntityAspect entityAspect { get; set; }
        EntityType entityType { get; set; }
    }
    public interface ComplexObject
    {
        ComplexAspect complexAspect { get; set; }
        ComplexType complexType { get; set; }
    }
    public interface IProperty
    {
        string name { get; set; }
        EntityType parentEntityType { get; set; }
        Validator[] validators { get; set; }
        bool isDataProperty { get; set; }
        bool isNavigationProperty { get; set; }
    }
    public interface IStructuralType
    {
        DataProperty[] complexProperties { get; set; }
        DataProperty[] dataProperties { get; set; }
        string name { get; set; }
        string @namespace { get; set; }
        string shortName { get; set; }
        DataProperty[] unmappedProperties { get; set; }
        Validator[] validators { get; set; }
    }
    public interface DataPropertyOptions
    {
        string complexTypeName { get; set; }
        string concurrencyMode { get; set; }
        DataTypeSymbol dataType { get; set; }
        object defaultValue { get; set; }
        bool fixedLength { get; set; }
        bool isNullable { get; set; }
        bool isPartOfKey { get; set; }
        bool isUnmapped { get; set; }
        JsNumber maxLength { get; set; }
        string name { get; set; }
        string nameOnServer { get; set; }
        Validator[] validators { get; set; }
    }
    public interface DataServiceOptions
    {
        string serviceName { get; set; }
        string adapterName { get; set; }
        bool hasServerMetadata { get; set; }
        JsonResultsAdapter jsonResultsAdapter { get; set; }
        bool useJsonp { get; set; }
    }
    public interface QueryContext
    {
        string url { get; set; }
        object query { get; set; } // how to also say it could be an EntityQuery or a string
        EntityManager entityManager { get; set; }
        DataService dataService { get; set; }
        QueryOptions queryOptions { get; set; }
    }
    public interface NodeContext
    {
        string nodeType { get; set; }
    }
    public interface DataType : IEnum
    {
        DataTypeSymbol Binary { get; set; }
        DataTypeSymbol Boolean { get; set; }
        DataTypeSymbol Byte { get; set; }
        DataTypeSymbol DateTime { get; set; }
        DataTypeSymbol DateTimeOffset { get; set; }
        DataTypeSymbol Decimal { get; set; }
        DataTypeSymbol Double { get; set; }
        DataTypeSymbol Guid { get; set; }
        DataTypeSymbol Int16 { get; set; }
        DataTypeSymbol Int32 { get; set; }
        DataTypeSymbol Int64 { get; set; }
        DataTypeSymbol Single { get; set; }
        DataTypeSymbol String { get; set; }
        DataTypeSymbol Time { get; set; }
        DataTypeSymbol Undefined { get; set; }
        DataTypeSymbol toDataType(string typeName);
        JsDate parseDateFromServer(object date);
    }
    public interface EntityAction : IEnum
    {
        EntityActionSymbol AcceptChanges { get; set; }
        EntityActionSymbol Attach { get; set; }
        EntityActionSymbol AttachOnImport { get; set; }
        EntityActionSymbol AttachOnQuery { get; set; }
        EntityActionSymbol Clear { get; set; }
        EntityActionSymbol Detach { get; set; }
        EntityActionSymbol EntityStateChange { get; set; }
        EntityActionSymbol MergeOnImport { get; set; }
        EntityActionSymbol MergeOnSave { get; set; }
        EntityActionSymbol MergeOnQuery { get; set; }
        EntityActionSymbol PropertyChange { get; set; }
        EntityActionSymbol RejectChanges { get; set; }
    }
    public interface EntityManagerOptions
    {
        string serviceName { get; set; }
        DataService dataService { get; set; }
        MetadataStore metadataStore { get; set; }
        QueryOptions queryOptions { get; set; }
        SaveOptions saveOptions { get; set; }
        ValidationOptions validationOptions { get; set; }
        JsAction keyGeneratorCtor { get; set; }
    }
    public interface EntityManagerProperties
    {
        string serviceName { get; set; }
        DataService dataService { get; set; }
        QueryOptions queryOptions { get; set; }
        SaveOptions saveOptions { get; set; }
        ValidationOptions validationOptions { get; set; }
        JsAction keyGeneratorCtor { get; set; }
    }
    public delegate void ExecuteQuerySuccessCallback(object data);//: { Entity[] results; EntityQuery query; XMLHttpRequest XHR; }
    public delegate void ExecuteQueryErrorCallback(object obj);//void         (error: { EntityQuery query; XMLHttpRequest XHR; });
    public delegate void SaveChangesSuccessCallback(object saveResult);//void         (saveResult: { Entity[] entities; object keyMappings; XMLHttpRequest XHR; });
    public delegate void SaveChangesErrorCallback(object error); //{void         (error: { XMLHttpRequest XHR; });
    public interface OrderByClause
    {
    }
    public interface EntityState : IEnum
    {
        EntityStateSymbol Added { get; set; }
        EntityStateSymbol Deleted { get; set; }
        EntityStateSymbol Detached { get; set; }
        EntityStateSymbol Modified { get; set; }
        EntityStateSymbol Unchanged { get; set; }
    }
    public interface EntityTypeOptions
    {
        string shortName { get; set; }
        string @namespace { get; set; }
        AutoGeneratedKeyType autogeneratedKeyType { get; set; }
        string defaultResourceName { get; set; }
        DataProperty[] dataProperties { get; set; }
        NavigationProperty[] navigationProperties { get; set; }
    }
    public interface EntityTypeProperties
    {
        AutoGeneratedKeyType autogeneratedKeyType { get; set; }
        string defaultResourceName { get; set; }
    }
    public interface FetchStrategy : IEnum
    {
        FetchStrategySymbol FromLocalCache { get; set; }
        FetchStrategySymbol FromServer { get; set; }
    }
    public interface FilterQueryOp : IEnum
    {
        FilterQueryOpSymbol Contains { get; set; }
        FilterQueryOpSymbol EndsWith { get; set; }
        FilterQueryOpSymbol Equals { get; set; }
        FilterQueryOpSymbol GreaterThan { get; set; }
        FilterQueryOpSymbol GreaterThanOrEqual { get; set; }
        FilterQueryOpSymbol LessThan { get; set; }
        FilterQueryOpSymbol LessThanOrEqual { get; set; }
        FilterQueryOpSymbol NotEquals { get; set; }
        FilterQueryOpSymbol StartsWith { get; set; }
    }
    public interface MergeStrategy : IEnum
    {
        MergeStrategySymbol OverwriteChanges { get; set; }
        MergeStrategySymbol PreserveChanges { get; set; }
    }
    public interface MetadataStoreOptions
    {
        NamingConvention namingConvention { get; set; }
        LocalQueryComparisonOptions localQueryComparisonOptions { get; set; }
    }
    public interface NamingConventionOptions
    {
        JsFunc<string, string> serverPropertyNameToClient { get; set; }
        JsFunc<string, string> clientPropertyNameToServer { get; set; }
    }
    public interface NavigationPropertyOptions
    {
        string name { get; set; }
        string nameOnServer { get; set; }
        string entityTypeName { get; set; }
        bool isScalar { get; set; }
        string associationName { get; set; }
        string[] foreignKeyNames { get; set; }
        string[] foreignKeyNamesOnServer { get; set; }
        Validator[] validators { get; set; }
    }
    public delegate Predicate PredicateMethod(Predicate[] predicates);
    //    {
    //Predicate         (Predicate[] predicates);
    //Predicate         (params Predicate[] predicates);
    //Predicate         (string property, string @operator, object value, bool valueIsLiteral=false);
    //Predicate         (string property, FilterQueryOpSymbol @operator, object value, bool valueIsLiteral=false);
    //    }
    public interface QueryOptionsConfiguration
    {
        FetchStrategySymbol fetchStrategy { get; set; }
        MergeStrategySymbol mergeStrategy { get; set; }
    }
    public interface SaveOptionsConfiguration
    {
        bool allowConcurrentSaves { get; set; }
        string resourceName { get; set; }
        DataService dataService { get; set; }
        string tag { get; set; }
    }
    public interface ValidationOptionsConfiguration
    {
        bool validateOnAttach { get; set; }
        bool validateOnSave { get; set; }
        bool validateOnQuery { get; set; }
        bool validateOnPropertyChange { get; set; }
    }
    public delegate void ValidatorFunction(object value, ValidatorFunctionContext context);
    public interface ValidatorFunctionContext
    {
        object value { get; set; }
        string validatorName { get; set; }
        string displayName { get; set; }
        string messageTemplate { get; set; }
        string message { get; set; }
    }
    public class Enum : IEnum
    {
        public Enum(string name, object methodObj = null) { }
        public EnumSymbol addSymbol(object propertiesObj = null) { return null; }
        public bool contains(object obj) { return false; }
        public EnumSymbol fromName(string name) { return null; }
        public string[] getNames() { return null; }
        public EnumSymbol[] getSymbols() { return null; }
        public static bool isSymbol(object obj) { return false; }
        public void seal() { }
    }
    public class EnumSymbol
    {
        public IEnum parentEnum;
        public string getName() { return null; }
        public string toString() { return null; }
    }
    public class Event
    {
        protected Event()
        {
        }
        public Event(string name, object publisher, ErrorCallback defaultErrorCallback = null) { }
        public static void enable(string eventName, object target) { }
        public static void enable(string eventName, object target, bool isEnabled) { }
        public static void enable(string eventName, object target, JsFunction isEnabled) { }
        public static bool isEnabled(string eventName, object target) { return false; }
        public void publish(object data, bool publishAsync = false, ErrorCallback errorCallback = null) { }
        public void publishAsync(object data, ErrorCallback errorCallback = null) { }
        public JsNumber subscribe(JsAction<object> callback = null) { return null; }
        public bool unsubscribe(JsNumber unsubKey) { return false; }
    }
    public class AutoGeneratedKeyType
    {
        public static AutoGeneratedKeyType Identity { get; set; }
        public static AutoGeneratedKeyType KeyGenerator { get; set; }
        public static AutoGeneratedKeyType None { get; set; }
    }
    public class ComplexAspect
    {
        public ComplexObject complexObject { get; set; }
        public EntityAspect entityAspect { get; set; }
        public Object parent { get; set; }
        public DataProperty parentProperty { get; set; }
        public string propertyPath { get; set; }
        public Object originalValues { get; set; }
    }
    public class ComplexType : IStructuralType
    {
        public DataProperty[] complexProperties { get; set; }
        public DataProperty[] dataProperties { get; set; }
        public string name { get; set; }
        public string @namespace { get; set; }
        public string shortName { get; set; }
        public DataProperty[] unmappedProperties { get; set; }
        public Validator[] validators { get; set; }
        public void addProperty(DataProperty dataProperty) { }
        public DataProperty[] getProperties() { return null; }
    }
    public class DataProperty : IProperty
    {
        public string complexTypeName { get; set; }
        public string concurrencyMode { get; set; }
        public DataTypeSymbol dataType { get; set; }
        public object defaultValue { get; set; }
        public bool fixedLength { get; set; }
        public bool isComplexProperty { get; set; }
        public bool isDataProperty { get; set; }
        public bool isNavigationProperty { get; set; }
        public bool isNullable { get; set; }
        public bool isPartOfKey { get; set; }
        public bool isUnmapped { get; set; }
        public JsNumber maxLength { get; set; }
        public string name { get; set; }
        public string nameOnServer { get; set; }
        public EntityType parentEntityType { get; set; }
        public NavigationProperty relatedNavigationProperty { get; set; }
        public Validator[] validators { get; set; }
        public DataProperty(DataPropertyOptions config) { }
    }
    public class DataService
    {
        public string adapterName;
        public bool hasServerMetadata;
        public string serviceName;
        public JsonResultsAdapter jsonResultsAdapter;
        public bool useJsonp;
        public DataService(DataServiceOptions config) { }
        public DataService @using(DataServiceOptions config) { return null; }
    }
    public class JsonResultsAdapter
    {
        public string name;
        public JsAction<object> extractResults;
        //visitNode: (node: {}, QueryContext queryContext, NodeContext nodeContext) => { EntityType entityType=null; object nodeId=null; object nodeRefId=null; bool ignore=null; };
        public JsonResultsAdapter() { }
        //    config: {
        //    string name;
        //    extractResults?: (data: {}) => {};
        //    visitNode: (node: {}, QueryContext queryContext, NodeContext nodeContext) => { EntityType entityType=null; object nodeId=null; object nodeRefId=null; bool ignore=null; };
        //}) {return null;}
    }
    public class DataTypeSymbol : EnumSymbol
    {
        public object defaultValue { get; set; }
        public bool isNumeric { get; set; }
        public bool isDate { get; set; }
    }
    public class EntityActionSymbol : EnumSymbol
    {
    }
    public class EntityAspect
    {
        public Entity entity;
        public EntityManager entityManager;
        public EntityStateSymbol entityState;
        public bool isBeingSaved;
        public object originalValues;
        public PropertyChangedEvent propertyChanged;
        public ValidationErrorsChangedEvent validationErrorsChanged;
        public void acceptChanges() { }
        public void addValidationError(ValidationError validationError) { }
        public void clearValidationErrors() { }
        public EntityKey getKey(bool forceRefresh = false) { return null; }
        public ValidationError[] getValidationErrors() { return null; }
        public ValidationError[] getValidationErrors(string property) { return null; }
        public ValidationError[] getValidationErrors(IProperty property) { return null; }
        public Promise loadNavigationProperty(string navigationProperty, JsAction callback = null, JsAction errorCallback = null) { return null; }
        public Promise loadNavigationProperty(NavigationProperty navigationProperty, JsAction callback = null, JsAction errorCallback = null) { return null; }
        public void rejectChanges() { }
        public void removeValidationError(Validator validator) { }
        public void removeValidationError(Validator validator, DataProperty property) { }
        public void removeValidationError(Validator validator, NavigationProperty property) { }
        public void setDeleted() { }
        public void setModified() { }
        public void setUnchanged() { }
        public bool validateEntity() { return false; }
        public bool validateProperty(string property, object context = null) { return false; }
        public bool validateProperty(DataProperty property, object context = null) { return false; }
        public bool validateProperty(NavigationProperty property, object context = null) { return false; }
    }
    public class PropertyChangedEventArgs
    {
        public Entity entity;
        public string propertyName;
        public object oldValue;
        public object newValue;
    }
    public class PropertyChangedEvent : Event
    {
        public JsNumber subscribe(JsAction<PropertyChangedEventArgs> callback = null) { return null; }
    }
    public class ValidationErrorsChangedEventArgs
    {
        public Entity entity;
        public ValidationError[] added;
        public ValidationError[] removed;
    }
    public class ValidationErrorsChangedEvent : Event
    {
        public JsNumber subscribe(JsAction<ValidationErrorsChangedEventArgs> callback = null) { return null; }
    }
    public class EntityKey
    {
        public EntityKey(EntityType entityType, object keyValue) { }
        public EntityKey(EntityType entityType, object[] keyValues) { }
        public bool equals(EntityKey entityKey) { return false; }
        public static bool equals(EntityKey k1, EntityKey k2) { return false; }
    }
    public class EntityManager
    {
        public DataService dataService { get; set; }
        public JsAction keyGeneratorCtor { get; set; }
        public MetadataStore metadataStore { get; set; }
        public QueryOptions queryOptions { get; set; }
        public SaveOptions saveOptions { get; set; }
        public string serviceName { get; set; }
        public ValidationOptions validationOptions { get; set; }
        public EntityChangedEvent entityChanged { get; set; }
        public HasChangesChangedEvent hasChangesChanged { get; set; }
        public EntityManager(EntityManagerOptions config = null) { }
        public EntityManager(string config = null) { }
        public Entity addEntity(Entity entity) { return null; }
        public Entity attachEntity(Entity entity, EntityStateSymbol entityState = null) { return null; }
        public void clear() { }
        public EntityManager createEmptyCopy() { return null; }
        public Entity createEntity(string typeName, object config, EntityStateSymbol entityState = null) { return null; }
        public bool detachEntity(Entity entity) { return false; }
        public Promise executeQuery(string query, ExecuteQuerySuccessCallback callback = null, ExecuteQueryErrorCallback errorCallback = null) { return null; }
        public Promise executeQuery(EntityQuery query, ExecuteQuerySuccessCallback callback = null, ExecuteQueryErrorCallback errorCallback = null) { return null; }
        public Entity[] executeQueryLocally(EntityQuery query) { return null; }
        public string exportEntities(Entity[] entities = null) { return null; }
        public Promise fetchEntityByKey(string typeName, object keyValue, bool checkLocalCacheFirst = false) { return null; }
        public Promise fetchEntityByKey(string typeName, object[] keyValues, bool checkLocalCacheFirst = false) { return null; }
        public Promise fetchEntityByKey(EntityKey entityKey) { return null; }
        public Promise fetchMetadata(JsAction<object> callback = null, JsAction errorCallback = null) { return null; }
        public object generateTempKeyValue(Entity entity) { return null; }
        public Entity[] getChanges() { return null; }
        public Entity[] getChanges(string entityTypeName) { return null; }
        public Entity[] getChanges(string[] entityTypeNames) { return null; }
        public Entity[] getChanges(EntityType entityType) { return null; }
        public Entity[] getChanges(EntityType[] entityTypes) { return null; }
        public Entity[] getEntities(string entityTypeName, EntityStateSymbol entityState = null) { return null; }
        public Entity[] getEntities(string[] entityTypeNames = null, EntityStateSymbol entityState = null) { return null; }
        public Entity[] getEntities(string entityTypeName = null, EntityStateSymbol[] entityStates = null) { return null; }
        public Entity[] getEntities(string[] entityTypeNames = null, EntityStateSymbol[] entityStates = null) { return null; }
        public Entity[] getEntities(EntityType entityType, EntityStateSymbol entityState = null) { return null; }
        public Entity[] getEntities(EntityType[] entityTypes = null, EntityStateSymbol entityState = null) { return null; }
        public Entity[] getEntities(EntityType entityType = null, EntityStateSymbol[] entityStates = null) { return null; }
        public Entity[] getEntities(EntityType[] entityTypes = null, EntityStateSymbol[] entityStates = null) { return null; }
        public Entity getEntityByKey(string typeName, object keyValue) { return null; }
        public Entity getEntityByKey(string typeName, object[] keyValues) { return null; }
        public Entity getEntityByKey(EntityKey entityKey) { return null; }
        public bool hasChanges() { return false; }
        public bool hasChanges(string entityTypeName) { return false; }
        public bool hasChanges(string[] entityTypeNames) { return false; }
        public bool hasChanges(EntityType entityType) { return false; }
        public bool hasChanges(EntityType[] entityTypes) { return false; }
        public static EntityManager importEntities(string exportedString, object config = null) { return null; }
        [JsMethod(Name = "importEntities")]
        public EntityManager importEntities_(string exportedString, object config = null) { return null; }
        public Entity[] rejectChanges() { return null; }
        public Promise saveChanges(Entity[] entities = null, SaveOptions saveOptions = null, SaveChangesSuccessCallback callback = null, SaveChangesErrorCallback errorCallback = null) { return null; }
        public void setProperties(EntityManagerProperties config) { }
    }
    public class EntityChangedEventArgs
    {
        public Entity entity { get; set; }
        public EntityActionSymbol entityAction { get; set; }
        public Object args { get; set; }
    }
    public class EntityChangedEvent : Event
    {
        public JsNumber subscribe(JsAction<EntityChangedEventArgs> callback = null) { return null; }
    }
    public class HasChangesChangedEventArgs
    {
        public EntityManager entityManager { get; set; }
        public bool hasChanges { get; set; }
    }
    public class HasChangesChangedEvent : Event
    {
        public JsNumber subscribe(JsAction<HasChangesChangedEventArgs> callback = null) { return null; }
    }
    public class EntityQuery
    {
        public EntityManager entityManager { get; set; }
        public OrderByClause orderByClause { get; set; }
        public Object parameters { get; set; }
        public QueryOptions queryOptions { get; set; }
        public string resourceName { get; set; }
        public JsNumber skipCount { get; set; }
        public JsNumber takeCount { get; set; }
        public Predicate wherePredicate { get; set; }
        public void HasChangesChangedEvent(string resourceName = null) { }
        public Promise execute(ExecuteQuerySuccessCallback callback = null, ExecuteQueryErrorCallback errorCallback = null) { return null; }
        public Entity[] executeLocally() { return null; }
        public EntityQuery expand(string[] propertyPaths) { return null; }
        public EntityQuery expand(string propertyPaths) { return null; }
        public static EntityQuery from(string resourceName) { return null; }
        [JsMethod(Name = "from")]
        public EntityQuery from_(string resourceName) { return null; }
        public static EntityQuery fromEntities(Entity entity) { return null; }
        public static EntityQuery fromEntities(Entity[] entities) { return null; }
        public static EntityQuery fromEntityKey(EntityKey entityKey) { return null; }
        public static EntityQuery fromEntityNavigation(Entity entity, NavigationProperty navigationProperty) { return null; }
        public EntityQuery inlineCount(bool enabled = false) { return null; }
        public EntityQuery orderBy(string propertyPaths) { return null; }
        public EntityQuery orderBy(string[] propertyPaths) { return null; }
        public EntityQuery orderByDesc(string propertyPaths) { return null; }
        public EntityQuery orderByDesc(string[] propertyPaths) { return null; }
        public EntityQuery select(string propertyPaths) { return null; }
        public EntityQuery select(string[] propertyPaths) { return null; }
        public EntityQuery skip(JsNumber count) { return null; }
        public EntityQuery take(JsNumber count) { return null; }
        public EntityQuery top(JsNumber count) { return null; }
        public EntityQuery toType(string typeName) { return null; }
        public EntityQuery toType(EntityType type) { return null; }
        public EntityQuery @using(EntityManager obj) { return null; }
        public EntityQuery @using(DataService obj) { return null; }
        public EntityQuery @using(JsonResultsAdapter obj) { return null; }
        public EntityQuery @using(QueryOptions obj) { return null; }
        public EntityQuery @using(MergeStrategySymbol obj) { return null; }
        public EntityQuery @using(FetchStrategySymbol obj) { return null; }
        public EntityQuery where(Predicate predicate) { return null; }
        public EntityQuery where(string property, string @operator, object value) { return null; }
        public EntityQuery where(string property, FilterQueryOpSymbol @operator, object value) { return null; }
        public EntityQuery where(FilterQueryOpSymbol predicate) { return null; }
        public EntityQuery withParameters(Object @params) { return null; }
    }
    public class EntityStateSymbol : EnumSymbol
    {
        public bool isAdded() { return false; }
        public bool isAddedModifiedOrDeleted() { return false; }
        public bool isDeleted() { return false; }
        public bool isDetached() { return false; }
        public bool isModified() { return false; }
        public bool isUnchanged() { return false; }
        public bool isUnchangedOrModified() { return false; }
    }
    public class EntityType : IStructuralType
    {
        public AutoGeneratedKeyType autoGeneratedKeyType { get; set; }
        public DataProperty[] complexProperties { get; set; }
        public DataProperty[] concurrencyProperties { get; set; }
        public DataProperty[] dataProperties { get; set; }
        public string defaultResourceName { get; set; }
        public DataProperty[] foreignKeyProperties { get; set; }
        public DataProperty[] keyProperties { get; set; }
        public MetadataStore metadataStore { get; set; }
        public string name { get; set; }
        public string @namespace { get; set; }
        public NavigationProperty[] navigationProperties { get; set; }
        public string shortName { get; set; }
        public DataProperty[] unmappedProperties { get; set; }
        public Validator[] validators { get; set; }
        public EntityType(MetadataStore config) { }
        public EntityType(EntityTypeOptions config) { }
        public void addProperty(IProperty property) { }
        public void addValidator(Validator validator, IProperty property = null) { }
        public Entity createEntity(Object initialValues = null) { return null; }
        public DataProperty getDataProperty(string propertyName) { return null; }
        public JsAction getEntityCtor() { return null; }
        public NavigationProperty getNavigationProperty(string propertyName) { return null; }
        public IProperty[] getProperties() { return null; }
        public IProperty getProperty(string propertyPath, bool throwIfNotFound = false) { return null; }
        public string[] getPropertyNames() { return null; }
        public void setProperties(EntityTypeProperties config) { }
        public string toString() { return null; }
    }
    public class FetchStrategySymbol : EnumSymbol
    {
    }
    public class FilterQueryOpSymbol : EnumSymbol
    {
    }
    public class LocalQueryComparisonOptions
    {
        public static LocalQueryComparisonOptions caseInsensitiveSQL { get; set; }
        public static LocalQueryComparisonOptions defaultInstance { get; set; }
        public LocalQueryComparisonOptions(object config) { }//: { string name=null; bool isCaseSensitive=null; bool usesSql92CompliantStringComparison=null; }) {return null;}
        public void setAsDefault() { }
    }
    public class MergeStrategySymbol : EnumSymbol
    {
    }
    public class MetadataStore
    {
        public NamingConvention namingConvention;
        public MetadataStore(MetadataStoreOptions config = null) { }
        public void addDataService(DataService dataService) { }
        public void addEntityType(IStructuralType structuralType) { }
        public string exportMetadata() { return null; }
        public Promise fetchMetadata(string dataService, JsAction<object> callback = null) { return null; }//?: (data) => void , breezeCore errorCallback=null.ErrorCallback) {}
        public Promise fetchMetadata(DataService dataService, JsAction<object> callback = null) { return null; }//?: (data) => void , breezeCore errorCallback=null.ErrorCallback) {}
        public DataService getDataService(string serviceName) { return null; }
        public IStructuralType getEntityType(string entityTypeName, bool okIfNotFound = false) { return null; }
        public IStructuralType[] getEntityTypes() { return null; }
        public bool hasMetadataFor(string serviceName) { return false; }
        public static MetadataStore importMetadata(string exportedString) { return null; }
        [JsMethod(Name = "importMetadata")]
        public MetadataStore importMetadata_(string exportedString) { return null; }
        public bool isEmpty() { return false; }
        public void registerEntityTypeCtor(string entityTypeName, JsAction entityCtor, JsAction<Entity> initializationFn = null) { }
        public void trackUnmappedType(JsAction entityCtor, JsAction interceptor = null) { }
    }
    public class NamingConvention
    {
        public static NamingConvention camelCase { get; set; }
        public static NamingConvention defaultInstance { get; set; }
        public static NamingConvention none { get; set; }
        public NamingConvention(NamingConventionOptions config) { }
        public string clientPropertyNameToServer(string clientPropertyName) { return null; }
        public string clientPropertyNameToServer(string clientPropertyName, IProperty property) { return null; }
        public string serverPropertyNameToClient(string serverPropertyName) { return null; }
        public string serverPropertyNameToClient(string serverPropertyName, IProperty property) { return null; }
        public void setAsDefault() { }
    }
    public class NavigationProperty : IProperty
    {
        public string associationName { get; set; }
        public EntityType entityType { get; set; }
        public string[] foreignKeyNames { get; set; }
        public NavigationProperty inverse { get; set; }
        public bool isDataProperty { get; set; }
        public bool isNavigationProperty { get; set; }
        public bool isScalar { get; set; }
        public string name { get; set; }
        public EntityType parentEntityType { get; set; }
        public DataProperty[] relatedDataProperties { get; set; }
        public Validator[] validators { get; set; }
        public NavigationProperty(NavigationPropertyOptions config) { }
    }
    public class Predicate
    {
        public Predicate(string property, string @operator, object value, bool valueIsLiteral = false) { }
        public Predicate(string property, FilterQueryOpSymbol @operator, object value, bool valueIsLiteral = false) { }
        [JsProperty(Name = "and")]
        public PredicateMethod and_ { get; set; }
        public static PredicateMethod and;
        public static PredicateMethod create;
        public static bool isPredicate(object o) { return false; }
        public static Predicate not(Predicate predicate) { return null; }
        public Predicate not() { return null; }
        public static PredicateMethod or;
        [JsProperty(Name = "or")]
        public PredicateMethod or_ { get; set; }
        public JsAction toFunction() { return null; }
        public string toString() { return null; }
        public void validate(EntityType entityType) { }
    }
    public class Promise
    {
        public Promise fail(JsAction errorCallback) { return null; }
        public Promise fin(JsAction finallyCallback) { return null; }
        public Promise then(JsAction callback) { return null; }
    }
    public class QueryOptions
    {
        public static QueryOptions defaultInstance;
        public FetchStrategySymbol fetchStrategy;
        public MergeStrategySymbol mergeStrategy;
        public QueryOptions(QueryOptionsConfiguration config = null) { }
        public void setAsDefault() { }
        public QueryOptions @using(QueryOptionsConfiguration config) { return null; }
        public QueryOptions @using(MergeStrategySymbol config) { return null; }
        public QueryOptions @using(FetchStrategySymbol config) { return null; }
    }
    public class SaveOptions
    {
        public bool allowConcurrentSaves;
        public string resourceName;
        public DataService dataService;
        public string tag;
        public static SaveOptions defaultInstance;
        public SaveOptions(object config) { }//?: { bool allowConcurrentSaves=null; }) 
        public SaveOptions setAsDefault() { return null; }
        public SaveOptions @using(SaveOptionsConfiguration config) { return null; }
    }
    public class ValidationError
    {
        public object context;
        public string errorMessage;
        public IProperty property;
        public string propertyName;
        public Validator validator;
        public ValidationError(Validator validator, object context, string errorMessage) { }
    }
    public class ValidationOptions
    {
        public static ValidationOptions defaultInstance;
        public bool validateOnAttach;
        public bool validateOnPropertyChange;
        public bool validateOnQuery;
        public bool validateOnSave;
        public ValidationOptions(ValidationOptionsConfiguration config = null) { }
        public ValidationOptions setAsDefault() { return null; }
        public ValidationOptions @using(ValidationOptionsConfiguration config) { return null; }
    }
    public class Validator
    {
        public static object messageTemplates;
        public Validator(string name, ValidatorFunction validatorFn, object context = null) { }
        public static Validator @bool() { return null; }
        public static Validator @byte() { return null; }
        public static Validator date() { return null; }
        public static Validator duration() { return null; }
        public static Validator guid() { return null; }
        public static Validator int16() { return null; }
        public static Validator int32() { return null; }
        public static Validator int64() { return null; }
        public static Validator maxLength(object context) { return null; }//;//: { JsNumber maxLength; }) 
        public static Validator JsNumber() { return null; }
        public static Validator required() { return null; }
        public static Validator @string() { return null; }
        public static Validator stringLength(object context) { return null; }//: { JsNumber maxLength; JsNumber minLength; }) 
        public static void register(Validator validator) { }
        public static void registerFactory(JsFunc<Validator> fn, string name) { }
        public ValidationError validate(object value, object context = null) { return null; }
        public string getMessage() { return null; }
    }
}
