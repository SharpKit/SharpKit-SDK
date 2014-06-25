using SharpKit.JavaScript;

namespace SharpKit.jQuery
{
    [JsType(JsMode.Prototype, Export=false, Name="UndoManager")]
    public class UndoManager 
    {
        /// <summary>
        /// Init the undo mananger with the specific settings
        /// </summary>
        /// <param name="settings">The object with the new settings</param>
        public UndoManager(JsUndoableSettings settings)
        {

        }
        /// <summary>
        /// Update the settings for this manager
        /// </summary>
        /// <param name="settings">The object with the new settings</param>
        public void changeSettings(JsUndoableSettings settings)
        {
        }
        /// <summary>
        /// Report the function used to undo the current action
        /// </summary>
        /// <typeparam name="T">The type of the parameter</typeparam>
        /// <param name="name">The name of the action</param>
        /// <param name="func">The undo function</param>
        /// <param name="parameters">Array of parameters to the function</param>
        /// <param name="context">Context to the run the undo function</param>
        /// <param name="id">The id of action</param>
        /// <param name="add_to_queue_overwrite"></param>
        /// <returns></returns>
        [JsMethod(IgnoreGenericArguments=true, NativeOverloads=true)]
        public JsObject undoable<T>(JsString name, JsAction func, JsArray<T> parameters, JsObject context, JsString id, JsBoolean add_to_queue_overwrite) 
        {
            return null;
        }
        /// <summary>
        /// Report the function used to undo the current action
        /// </summary>
        /// <typeparam name="T">The type of the parameter</typeparam>
        /// <typeparam name="R">The type of the return value</typeparam>
        /// <param name="name">The name of the action</param>
        /// <param name="func">The undo function</param>
        /// <param name="parameters">Array of parameters to the function</param>
        /// <param name="context">Context to the run the undo function</param>
        /// <param name="id">The id of action</param>
        /// <param name="add_to_queue_overwrite"></param>
        /// <returns></returns>
        public JsObject undoable<T, R>(JsString name, JsFunc<R> func, JsArray<T> parameters, JsObject context, JsString id, JsBoolean add_to_queue_overwrite)
        {
            return null;
        }
        /// <summary>
        /// Undo the last action
        /// </summary>
        /// <returns></returns>
        public JsObject undo()
        {
            return null;
        }

        public JsObject clearUndoQueue()
        {
            return null;
        }

        public JsObject clearQueues()
        {
            return null;
        }

        /// <summary>
        /// Redo the last action undone
        /// </summary>
        /// <returns></returns>
        public JsObject redo()
        {
            return null;
        }

        /// <summary>
        /// Clear the redo queue
        /// </summary>
        /// <returns></returns>
        public JsObject clearRedoQueue()
        {
            return null;
        }

        #region Groups
        /// <summary>
        /// Start a new group
        /// </summary>
        /// <param name="name">The group name</param>
        /// <returns>The group ID</returns>
        public JsString startGroup(JsString name)
        {
            return null;
        }

        /// <summary>
        /// End the last opened group
        /// </summary>
        public JsObject endGroup()
        {
            return null;
        }

        /// <summary>
        /// Exit the currently open queue;
        /// </summary>
        /// <param name="rollback">Should the current undos be ran (rollback changes)? (Default true)</param>
        public JsObject exitGroup(JsBoolean rollback)
        {
            return null;
        }

        /// <summary>
        /// Resume a previously ended group as long as it is still in the undo/redo queue
        /// </summary>
        /// <param name="groupId">The group ID</param>
        /// <returns></returns>
        public JsObject resumeGroup(JsString groupId)
        {
            return null;
        }
        #endregion Groups
    }

    [JsType(JsMode.Json)]
    public class JsUndoableSettings
    {
        /// <summary>
        /// The number of the Undo actions in the Queue.
        /// </summary>
        public JsNumber max_undo { get; set; }
        public JsAction undoChange { get; set; }
        public JsAction redoChange { get; set; }
    }
}