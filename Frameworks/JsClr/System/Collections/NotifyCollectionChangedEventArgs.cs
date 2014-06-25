//using System;
//using System.Collections.Generic;
//
//using System.Text;
//
//using SharpKit.DataModel;

//namespace SharpKit.JavaScript.Private
//{
//  [RunAtClient]
//  [JsType(Name="SharpKit.DataModel.NotifyCollectionChangedEventArgs")]
//  internal class JsImplNotifyCollectionChangedEventArgs
//  {
//  JsImplNotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
//  {
//    if(arguments.length==0)
//      return; //TODO: Support serialization constructors
//    this._Action = action;	
//    if(action=="Add")
//    {
//      this._NewItems = [changedItem];
//    }
//    else if(action=="Remove")
//    {
//      this._NewItems = [changedItem];
//    }
//    else
//      throw new Error("Not implemented");
//  }
//  OldItems : function()
//  {
//    return this._OldItems;
//  },
//  get_NewItems : function()
//  {
//    return this._NewItems;
//  },
//  get_Action : function()
//  {
//    return this._Action;
//  }
//});

//  }
//}
