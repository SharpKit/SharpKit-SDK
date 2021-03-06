//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE
{
    /// <summary>
    /// This event will fire when the user make an redo of a change.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.UndoManager", Export=false)]
    public  partial class UndoManager
    {
        /// <summary>
        /// Adds a new undo level/snapshot to the undo list.
        /// </summary>
        /// <param name="l">Optional undo level object to add.</param>
        public object add(object l){return null;}
        /// <summary>
        /// Stores away a bookmark to be used when performing an undo action so that the selection is before
        /// the change has been made.
        /// </summary>
        public object beforeChange(){return null;}
        /// <summary>
        /// Removes all undo levels.
        /// </summary>
        public object clear(){return null;}
        /// <summary>
        /// Returns true/false if the undo manager has any redo levels.
        /// </summary>
        public bool hasRedo(){return false;}
        /// <summary>
        /// Returns true/false if the undo manager has any undo levels.
        /// </summary>
        public bool hasUndo(){return false;}
        /// <summary>
        /// Redoes the last action.
        /// </summary>
        public object redo(){return null;}
        /// <summary>
        /// Undoes the last action.
        /// </summary>
        public object undo(){return null;}
    }
}
