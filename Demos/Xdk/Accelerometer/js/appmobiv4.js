if (typeof(AppMobiInit) != 'object')
    AppMobiInit = {};

/**
 * This represents the AppMobi API itself, and provides a global namespace for accessing
 * information about the state of AppMobi.
 * @class
 */
AppMobi = {
    queue: {
        ready: true,
        commands: [],
        timer: null
    },
    _constructors: [],
	jsVersion: '4.0.0'
};

/**
 * Boolean flag indicating if the AppMobi API is available and initialized.
 */
AppMobi.isnative = false;
AppMobi.isxdk = true;
AppMobi.istest = false;
AppMobi.package = "XDK";
AppMobi.ischrome = false;
AppMobi.isweb = false;
AppMobi.isfacebook = false;
AppMobi.istablet = false;
AppMobi.isphone = false;
AppMobi.isgoogle = false;
AppMobi.isamazon = false;
AppMobi.isnook = false;
AppMobi.isintel = false;
AppMobi.available = false;
AppMobi.oauthAvailable = false;
AppMobi.paymentsAvailable = false;
AppMobi.updateAvailable = false;
AppMobi.updateMessage = "";
AppMobi.app = "";
AppMobi.release = "";
AppMobi.webRoot = "";
AppMobi.cookies = {};
AppMobi.mediacache = [];
AppMobi.notifications = [];
AppMobi.people = [];
AppMobi.picturelist = [];
AppMobi.recordinglist = [];
AppMobi.playingtrack = {};
AppMobi._hasAnalytics = false;
AppMobi._hasCaching = false;
AppMobi._hasStreaming = false;
AppMobi._hasAdvertising = false;
AppMobi._hasPush = false;
AppMobi._hasInAppPay = false;
AppMobi._hasOAuth = false;
AppMobi.hasLocalStorage = true;

/*
try {
	//!!!
	//using the local storage to emulate cookies
	for (name in localStorage)
	{
		//check for expired cookies
		var valueexpiry = localStorage.getItem(name);
		var pieces = valueexpiry.split("~~~");
		var value = pieces[0];
		var expires = pieces[1]
		
		var expiresDate, now = new Date();                     
		if(expires == "NEVER") {
			expiresDate = new Date();
			expiresDate.setDate(now.getDate()+1);
		} else {
			expiresDate = new Date(expires);
		}
		
		if(expiresDate=="Invalid Date" || expiresDate>now) {
			AppMobi.cookies[name]={"value":pieces[0]};
		} else {
			localStorage.removeItem(name);
		}
	}
}
catch(e) { }
*/
/**
 * Add an initialization function to a queue that ensures it will run and initialize
 * application constructors only once AppMobi has been initialized.
 * @param {Function} func The function callback you want run once AppMobi is initialized
 */
AppMobi.addConstructor = function(func) {
    var state = document.readyState;
    if (state == 'loaded' || state == 'complete')
        func();
    else
        AppMobi._constructors.push(func);
};


AppMobi.setReady = function() {
/*	//run constructors
	while (AppMobi._constructors.length > 0) {
		var constructor = AppMobi._constructors.shift();
		try {
			constructor();
		} catch(e) {
			if (typeof(AppMobi.debug['log']) == 'function')
				AppMobi.debug.log("Failed to run constructor: " + AppMobi.debug.processMessage(e));
			else
				alert("Failed to run constructor: " + e.message);
		}
	}
*/
    
	
	// all constructors run, now fire the deviceready event
    
    AppMobi.cache.initialize();
    
	AppMobi.available = true;
	//Autologing
	//w0ndow.parent.emulateAnalyticsLogPage("/device/start.event",'','','','',"index.html",true);
    
	AppMobi.xdkBridge.exec('emulateAnalyticsLogPage',"/device/start.event",'','','','',"index.html",true,AppMobi.app,AppMobi.release,{'model':AppMobi.device.model,'osversion':AppMobi.device.osversion,'platform':AppMobi.device.platform,'uuid':AppMobi.device.uuid });
	
    var e = document.createEvent('Events');
	e.initEvent('appMobi.device.ready',true,true);
	document.dispatchEvent(e);
    
    
    if(AppMobi._hasOAuth)
    {
       var e = document.createEvent('Events');
        e.initEvent('appMobi.oauth.setup',true,true);
        e.success = AppMobi.oauthAvailable;
        document.dispatchEvent(e);
    }
    
    if(AppMobi._hasOAuth && !AppMobi.oauthAvailable)
        //w0ndow.parent.checkJSQueue("oauth_ready",15);
        AppMobi.xdkBridge.exec("checkJSQueue","oauth_ready",15);
   	//OTAU EMULATION SUPPORT
	//w0ndow.parent.OTAU_check();
    AppMobi.xdkBridge.exec("OTAU_check");
}

/**
 * Execute a AppMobi command in a queued fashion, to ensure commands do not
 * execute with any race conditions, and only run when AppMobi is ready to
 * recieve them.
 * @param {String} command Command to be run in AppMobi, e.g. "ClassName.method"
 * @param {String[]} [args] Zero or more arguments to pass to the method
 */
AppMobi.exec = function() {
	//compatibility placeholder on android - needed for iphone
};

/**
 * Internal function used to dispatch the request to AppMobi.  This needs to be implemented per-platform to
 * ensure that methods are called on the phone in a way appropriate for that device.
 * @private
 */
AppMobi.run_command = function() {
	//compatibility placeholder on android - needed for iphone
};

/**
 * This class contains acceleration information
 * @constructor
 * @param {Number} x The force applied by the device in the x-axis.
 * @param {Number} y The force applied by the device in the y-axis.
 * @param {Number} z The force applied by the device in the z-axis.
 * @param {boolean} doRotate If true, rotate axes based on device rotation.
 */
AppMobi.Acceleration = function(x, y, z, doRotate) {
	if(doRotate) {
		var orientation = AppMobi.device.orientation;
		if(orientation==0) {
		//portrait
		} else if (orientation==90) {
		//landscape left
			var temp = y, y = -x, x = temp;
		} else if (orientation==180) {
		//upside-down portrait
			x = -x, y = -y;
		} else if (orientation==-90) {
		//landscape right
			var temp = x, x = -y, y = temp;
		}
	}
	/**
	 * The force applied by the device in the x-axis.
	 */
	this.x = x;
	/**
	 * The force applied by the device in the y-axis.
	 */
	this.y = y;
	/**
	 * The force applied by the device in the z-axis.
	 */
	this.z = z;
	/**
	 * The time that the acceleration was obtained.
	 */
	this.timestamp = new Date().getTime();
}

// Define object for receiving acceleration values
AppMobi._accel = new AppMobi.Acceleration(0, 0, 0, false);

/**
 * This class specifies the options for requesting acceleration data.
 * @constructor
 */
AppMobi.AccelerationOptions = function() {
	this.frequency = 500;
	this.adjustForRotation = false;
}

/**
 * This class provides access to device accelerometer data.
 * @constructor
 */
AppMobi.Accelerometer = function() {
}

/**
 * Asynchronously acquires the current acceleration.
 * @param {Function} successCallback The function to call when the acceleration
 * data is available
 * @param {AccelerationOptions} options The options for getting the accelerometer data
 * such as timeout.
 */
AppMobi.Accelerometer.prototype.getCurrentAcceleration = function(successCallback, options) {
	// If the acceleration is available then call success
	// If the acceleration is not available then call error
	//validate options object
	var _options = new AppMobi.AccelerationOptions();
	if(typeof(options)=="object"){
		if(typeof(options.adjustForRotation)=="boolean") _options.adjustForRotation = options.adjustForRotation;
	}
	// Created for iPhone, Iphone passes back _accel obj litteral
	if (typeof successCallback == "function") {

		//Changed for emulator
		var accel = new AppMobi.Acceleration(AppMobi._accel.x,AppMobi._accel.y,AppMobi._accel.z, _options.adjustForRotation);

		successCallback(accel);
	}
}

/**
 * Asynchronously acquires the acceleration repeatedly at a given interval.
 * @param {Function} successCallback The function to call each time the acceleration
 * data is available
 * @param {AccelerationOptions} options The options for getting the accelerometer data
 * such as timeout.
 */

AppMobi.Accelerometer.prototype.watchAcceleration = function(successCallback, options) {
	//validate options object
	var _options = new AppMobi.AccelerationOptions();
	if(typeof(options)=="object"){
		var parsedFreq = parseInt(options.frequency);
		if(typeof(parsedFreq)=="number" && !isNaN(parsedFreq)) {
			_options.frequency = parsedFreq<25?25:parsedFreq;
		}
		if(typeof(options.adjustForRotation)=="boolean") _options.adjustForRotation = options.adjustForRotation;
	}

	// This locks the accel and device when people are using an accel enabled app
	//w0ndow.parent._lockaccel = false;
	//w0ndow.parent.accelLock(); 
    AppMobi.xdkBridge.assignVar('_lockaccel',false);
    AppMobi.xdkBridge.exec('accelLock');

	// commenting out call -- AppMobiAccelerometer.start(_options.frequency);
	AppMobi.accelerometer.getCurrentAcceleration(successCallback, _options);
	return setInterval(function() {
		AppMobi.accelerometer.getCurrentAcceleration(successCallback, _options);
	}, _options.frequency);
}

/**
 * Clears the specified accelerometer watch.
 * @param {String} watchId The ID of the watch returned from #watchAcceleration.
 */
AppMobi.Accelerometer.prototype.clearWatch = function(watchId) {
	// commenting out call -- AppMobiAccelerometer.stop();
	clearInterval(watchId);
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.accelerometer == "undefined") AppMobi.accelerometer = new AppMobi.Accelerometer();
});

/**
 * This class provides access to the appMobiContacts
 * @constructor
 */

AppMobi.Contacts = function() {
};

AppMobi.Contacts.prototype.getContactList = function() {
	var contacts = [];
	for(var person in AppMobi.people) {
		contacts.push(AppMobi.people[person].id);
	}
	return contacts;
};

AppMobi.Contacts.prototype.getContactData = function(id) {
	var local = null;
	for(var person in AppMobi.people) {
		if(id==AppMobi.people[person].id) {
			local = {};
			local.id = AppMobi.people[person].id;
			local.first = AppMobi.people[person].first;
			local.last = AppMobi.people[person].last;
			local.name = AppMobi.people[person].name;
			local.phones = AppMobi.people[person].phones;
			local.emails = AppMobi.people[person].emails;
			local.addresses = AppMobi.people[person].addresses;
			break;
		}
	}
	return local;
};

AppMobi.Contacts.prototype.getContacts = function() {
    AppMobi.xdkBridge.exec('contacts.getContacts');
	//w0ndow.parent.contacts.getContacts();
}

AppMobi.Contacts.prototype.addContact = function() {
    AppMobi.xdkBridge.exec('contacts.addContact');
    //w0ndow.parent.contacts.addContact();
}

AppMobi.Contacts.prototype.chooseContact = function() {
    AppMobi.xdkBridge.exec('contacts.chooseContact');
  // w0ndow.parent.contacts.chooseContact();
}

AppMobi.Contacts.prototype.editContact = function(contactID) {
    AppMobi.xdkBridge.exec('contacts.editContact',contactID);
   //w0ndow.parent.contacts.editContact(contactID);
}

AppMobi.Contacts.prototype.removeContact = function(contactID) {
    AppMobi.xdkBridge.exec('contacts.removeContact',contactID);
    //w0ndow.parent.contacts.removeContact(contactID);
}

AppMobi.addConstructor(function() {
	if (typeof AppMobi.contacts == "undefined") AppMobi.contacts = new AppMobi.Contacts();
});

/**
 * This class provides access to the appMobiAdvertising
 * @constructor
 */
AppMobi.Advertising = function() {
};

AppMobi.Advertising.prototype.getAd = function(adpath, ident) {
    // commenting out call -- AppMobiAdvertising.getAd(adpath, ident);
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.advertising == "undefined") AppMobi.advertising = new AppMobi.Advertising();
});



/**
 * This class provides access to the appMobiAudio
 * @constructor
 */
AppMobi.Audio = function() {
};

AppMobi.Audio.prototype.startPlaying= function(recURL) {
	AppMobi.stubEvent('player.audio.error');
};

AppMobi.Audio.prototype.stopPlaying= function() {
};

AppMobi.Audio.prototype.pausePlaying= function() {
};

AppMobi.Audio.prototype.continuePlaying= function() {
};

AppMobi.Audio.prototype.startRecording= function(format, samplingRate, channels) {
};

AppMobi.Audio.prototype.stopRecording= function() {
};

AppMobi.Audio.prototype.pauseRecording= function() {
};

AppMobi.Audio.prototype.continueRecording= function() {
};

AppMobi.Audio.prototype.deleteRecording= function(recURL) {
};

AppMobi.Audio.prototype.clearRecordings= function() {
};

AppMobi.Audio.prototype.getRecordingList = function() {
	var list = [];
	for(var recording in AppMobi.recordinglist) {
		list.push(AppMobi.recordinglist[recording]);
	}
	return list;
}

AppMobi.Audio.prototype.getRecordingURL = function(filename) {
	var localURL = undefined;
	var	found = false;
	for(var recording in AppMobi.recordinglist) {
		if(filename == AppMobi.recordinglist[recording]) {
			found=true;
			break;
		}
	}
	if(found)
		localURL = AppMobi.webRoot+'_recordings/'+filename;
	return localURL;
}

if (typeof AppMobi.audio == "undefined") AppMobi.audio = new AppMobi.Audio();

/**
 * This class provides access to the appMobiPlayer
 * @constructor
 */

AppMobi.AudioInfo = function(currentTime, duration) {
    this.currentTime = currentTime;
    this.duration = duration;
};

AppMobi.Player = function() {
    this.audioInfo = new AppMobi.AudioInfo(0, 0);
    this.sounds = {};
};

AppMobi.Player.prototype.show = function() {
    //w0ndow.parent.emulateShow();
    AppMobi.xdkBridge.exec('emulateShow');
};

AppMobi.Player.prototype.hide = function() {
   //w0ndow.parent.emulateHide();
   AppMobi.xdkBridge.exec('emulateHide');
};

AppMobi.Player.prototype.playPodcast = function(strPodcastURL) {
    //w0ndow.parent.emulatePlayPodcast(strPodcastURL)
    AppMobi.xdkBridge.exec('emulatePlayPodcast',strPodcastURL);
};

AppMobi.Player.prototype.startStation = function(strNetStationID, boolResumeMode, boolShowPlayer) {
    //w0ndow.parent.emulateStartStation(strNetStationID, boolResumeMode, boolShowPlayer);
    //AppMobi.xdkBridge.exec('emulateStartStation',strNetStationID, boolResumeMode, boolShowPlayer);
    throw(new Error("Error: AppMobi.player.startStation is deprecated"));
};
AppMobi.Player.prototype.playSound = function(strRelativeFileURL) {
    
    if( strRelativeFileURL.length == 0 )
	{
		var evt = document.createEvent('Event');
		evt.initEvent('appMobi.player.sound.error', true, true);
		document.dispatchEvent(evt);
		return;
	}

	var url = location.href.substr(0,location.href.lastIndexOf("/")+1) + strRelativeFileURL;
	if( strRelativeFileURL.indexOf( "_mediacache") > -1 )
		url = "http://localhost:58888/" + strRelativeFileURL;
    strRelativeFileURL = url;
    
    
	if( typeof( AppMobi.player.sounds[strRelativeFileURL] ) == "undefined" )
	{
		AppMobi.player.sounds[strRelativeFileURL] = [];
		var soundarray = AppMobi.player.sounds[strRelativeFileURL];

		soundarray[0] = {};
		soundarray[0].player = new Audio(strRelativeFileURL);
		soundarray[0].player.load();
		soundarray[0].playing = false;
		soundarray[0].lasttime = 0;
	}

	var index = 0;
	var oldest = new Date();
	var soundarray = AppMobi.player.sounds[strRelativeFileURL];
	for( var a = 0; a < soundarray.length; a++ )
	{
		if( soundarray[a].lasttime < oldest )
		{
			index = a;
			oldest = soundarray[a].lasttime;
		}
	}
		
	soundarray[index].player.pause();
	if( soundarray[index].player.currentTime != 0 ) {
		soundarray[index].player.currentTime = 0;
	}
	soundarray[index].player.play();
	soundarray[index].lasttime = new Date();
};

AppMobi.Player.prototype.loadSound = function(strRelativeFileURL, count) {
	AppMobi.player.sounds[strRelativeFileURL] = [];
	var soundarray = AppMobi.player.sounds[strRelativeFileURL];
	for( var a = 0; a < count; a++ )
	{
		soundarray[a] = {};
		soundarray[a].player = new Audio(strRelativeFileURL);
		soundarray[a].player.load();
		soundarray[a].playing = false;
		soundarray[a].lasttime = 0;
	}
    
};

AppMobi.Player.prototype.unloadSound = function(strRelativeFileURL) {
	delete AppMobi.player.sounds[strRelativeFileURL];
};

AppMobi.Player.prototype.unloadAllSounds = function() {
	AppMobi.player.sounds = {};
};

//========================================================
//  AUDIO STUFF
//========================================================
AppMobi.Player.prototype.startAudio = function(strRelativeFileURL, loop) {
    if(loop == undefined || loop != true)
        loop = false;
    //w0ndow.parent.emulateStartAudio(strRelativeFileURL);
    //AppMobi.xdkBridge.exec('emulateStartAudio',strRelativeFileURL, loop);
    AppMobi.native.emulateStartAudio(strRelativeFileURL, loop);
};

AppMobi.Player.prototype.setAudioCurrentTime = function(timeMark) {
    //AppMobi.xdkBridge.exec('emulateSetAudioCurrentTime',timeMark);
    AppMobi.native.emulateSetAudioCurrentTime(timeMark);
};

AppMobi.Player.prototype.getAudioCurrentTime = function(successCallback) {
    AppMobi.native.populateAudioInfo();
    if (typeof successCallback == "function") {
        successCallback(AppMobi.player.audioInfo);
    }
};

AppMobi.Player.prototype.watchAudioCurrentTime = function(successCallback, frequency) {
    return setInterval(function() {
        AppMobi.player.getAudioCurrentTime(successCallback);
    }, frequency);
};

AppMobi.Player.prototype.clearAudioCurrentTimeWatch = function(watchId) {
    clearInterval(watchId);
};

AppMobi.Player.prototype.toggleAudio = function() {
    //w0ndow.parent.emulateToggleAudio();
    //AppMobi.xdkBridge.exec('emulateToggleAudio');
    AppMobi.native.emulateToggleAudio();
};

AppMobi.Player.prototype.stopAudio = function() {
    //w0ndow.parent.emulateStopAudio();
    //AppMobi.xdkBridge.exec('emulateStopAudio');
    AppMobi.native.emulateStopAudio();
};
//==========================================================

AppMobi.Player.prototype.play = function() {
    //w0ndow.parent.emulatePlay();
    AppMobi.xdkBridge.exec('emulatePlay');
};

AppMobi.Player.prototype.pause = function() {
    //w0ndow.parent.emulatePause();
     AppMobi.xdkBridge.exec('emulatePause');
};

AppMobi.Player.prototype.stop = function() {
    //w0ndow.parent.emulateStop();
    AppMobi.xdkBridge.exec('emulateStop');
};

AppMobi.Player.prototype.volume = function(iPercentage) {
    //w0ndow.parent.emulateVolume(iPercentage);
     AppMobi.xdkBridge.exec('emulateVolume', iPercentage);
};

AppMobi.Player.prototype.rewind = function() {
    //w0ndow.parent.emulateRewind();
    AppMobi.xdkBridge.exec('emulateRewind');
};

AppMobi.Player.prototype.ffwd = function() {
    //w0ndow.parent.emulateFfwd();
    AppMobi.xdkBridge.exec('emulateFfwd');
};

AppMobi.Player.prototype.setColors = function(strBackColor, strFillColor, strDoneColor, strPlayColor) {
    //w0ndow.parent.emulateSetColors(strBackColor, strFillColor, strDoneColor, strPlayColor);
    AppMobi.xdkBridge.exec('emulateSetColors', strBackColor, strFillColor, strDoneColor, strPlayColor);
};

AppMobi.Player.prototype.setPosition = function(portraitX, portraitY, landscapeX, landscapeY) {
    //w0ndow.parent.emulateSetPosition(portraitX, portraitY, landscapeX, landscapeY);
    AppMobi.xdkBridge.exec('emulateSetPosition',portraitX, portraitY, landscapeX, landscapeY);

};

AppMobi.Player.prototype.startShoutcast = function(strStationURL, boolShowPlayer) {
    //w0ndow.parent.emulateStartShoutcast(strStationURL, boolShowPlayer);
    AppMobi.xdkBridge.exec('emulateStartShoutcast',strStationURL, boolShowPlayer);
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.player == "undefined") AppMobi.player = new AppMobi.Player();
});

/**
 * This class provides access to the appMobiStats
 * @constructor
 */
AppMobi.Stats = function() {
};

AppMobi.Stats.prototype.logEvent = function(message) {
	throw(new Error("Error: AppMobi.stats.logEvent is deprecated, use AppMobi.analytics.logPageEvent."));
};


AppMobi.addConstructor(function() {
    if (typeof AppMobi.stats == "undefined") AppMobi.stats = new AppMobi.Stats();
});


/**
 * This class provides access to the appMobiAnalytics
 * @constructor
 */
AppMobi.Analytics = function() {
};

AppMobi.Analytics.prototype.logPageEvent = function(page, query, status, method, bytes, referrer) {	
    //w0ndow.parent.emulateAnalyticsLogPage(page, query, status, method, bytes, referrer, false);
    AppMobi.xdkBridge.exec('emulateAnalyticsLogPage',page, query, status, method, bytes, referrer, false, AppMobi.app,AppMobi.release,{'model':AppMobi.device.model,'osversion':AppMobi.device.osversion,'platform':AppMobi.device.platform,'uuid':AppMobi.device.uuid });
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.analytics == "undefined") AppMobi.analytics = new AppMobi.Analytics();
});


/**
 * This class provides access to the appMobiFile
 * @constructor
 */
AppMobi.File = function() {
};

AppMobi.File.prototype.uploadToServer = function(localURL, uploadURL, foldername, mimetype, updateCallback) {
	if( (localURL == undefined || localURL=='') || (uploadURL == undefined || uploadURL=='') )
	{
		throw(new Error("Error: AppMobi.file.uploadToServer has the following required parameters: localURL, uploadURL."));
	}
	if(updateCallback != null && typeof(updateCallback)!="string") throw(new Error("Error: AppMobi.file.uploadToServer updateCallback parameter must be a string which is the name of a function"));
	if(mimetype == null) mimetype = "text/plain";
	
	//w0ndow.parent.emulateFileUpload(localURL, uploadURL, foldername, mimetype, updateCallback);
    //AppMobi.xdkBridge.exec('emulateFileUpload',localURL, uploadURL, foldername, mimetype, updateCallback);
    AppMobi.native.emulateFileUpload(localURL, uploadURL, foldername, mimetype, updateCallback);
};

AppMobi.File.prototype.cancelUpload = function() {
	//w0ndow.parent.emulateFileCancelUpload();
   // AppMobi.xdkBridge.exec('emulateFileCancelUpload');
    AppMobi.native.emulateFileCancelUpload();
};

AppMobi.addConstructor(function() {
	if (typeof AppMobi.file == "undefined") AppMobi.file = new AppMobi.File();
});


/**
 * This class provides access to the appMobiCamera
 * @constructor
 */
AppMobi.Camera = function() {
};

AppMobi.Camera.prototype.takePicture = function(quality, saveToLib, picType, isFront)
{
	var eventName = "AppMobi.camera.takePicture";
    if(isFront != undefined && isFront == true)
        eventName = "AppMobi.camera.takeFrontPicture";    
    
    if(quality == undefined || quality == null)
		quality = 70; // default
	else if((quality<1) || (quality>100))
		throw(new Error("Error: "+eventName+", quality must be between 1-100."));
	
	if(saveToLib == undefined || saveToLib == null) 
		saveToLib = true;
	
	if(typeof(picType) == "undefined" || picType == null) 
		picType = "jpg";
	else {
		if(typeof(picType) != "string")
			throw(new Error("Error: "+eventName+", picType must be a string."));
		if((picType.toLowerCase() != "jpg") && (picType.toLowerCase() != "png"))
			throw(new Error("Error: "+eventName+", picType must be 'jpg' or 'png'."));
	}
	//w0ndow.parent.emulateCameraTakePicture(quality, saveToLib, picType);
    AppMobi.xdkBridge.exec('emulateCameraTakePicture',quality, saveToLib, picType);
};

AppMobi.Camera.prototype.takeFrontPicture = function(quality, saveToLib, picType)
{
    AppMobi.camera.takePicture(quality, saveToLib, picType, true);
}

AppMobi.Camera.prototype.importPicture = function() {
	//w0ndow.parent.emulateCameraImportPicture();
    AppMobi.xdkBridge.exec('emulateCameraImportPicture');
};

AppMobi.Camera.prototype.deletePicture = function(picURL) {
	if(picURL == "undefined" || picURL == null) 
		throw(new Error("Error: AppMobi.camera.deletePicture, call with a picURL"));
	if(typeof(picURL) != "string")
		throw(new Error("Error: AppMobi.camera.deletePicture, picURL must be a string."));

	//w0ndow.parent.emulateCameraDeletePicture(picURL);
     AppMobi.xdkBridge.exec('emulateCameraDeletePicture',picURL);
};

AppMobi.Camera.prototype.clearPictures = function() {
	//w0ndow.parent.emulateCameraClearPictures();
     AppMobi.xdkBridge.exec('emulateCameraClearPictures');
};

AppMobi.Camera.prototype.getPictureList = function() {
	var list = [];
	for(var picture in AppMobi.picturelist) {
		list.push(AppMobi.picturelist[picture]);
	}
	return list;
}

AppMobi.Camera.prototype.getPictureURL = function(filename) {
	var localURL = undefined;
	var	found = false;
	for(var picture in AppMobi.picturelist) {
		if(filename == AppMobi.picturelist[picture]) {
			found=true;
			break;
		}
	}
	if(found)
		//localURL = AppMobi.webRoot+'_pictures/'+filename;
        localURL = "http://localhost:58888/"+'_pictures/'+filename;
	return localURL;
}

AppMobi.addConstructor(function() {
	if (typeof AppMobi.camera == "undefined") AppMobi.camera = new AppMobi.Camera();
});

AppMobi.Cache = function() {
};

AppMobi.Cache.prototype.initialize = function() {
	if(AppMobi.hasLocalStorage)
	{
		for( cookie in localStorage )
		{
			if( cookie.indexOf(AppMobi.app + '.') == 0 )
			{
				var cookiename = cookie.replace(AppMobi.app+".","");
				var cookiedata = eval('('+localStorage[cookie]+')');

				if( typeof( cookiedata.expires) != "undefined" )
				{
					if( cookiedata.expires != -1 )
					{
						var time = new Date().getTime();
						if( time < cookiedata.expires )
						{
							AppMobi.cookies[cookiename] = cookiedata;
						}
					}
					else
					{
						AppMobi.cookies[cookiename] = cookiedata;
					}
				}
				else
				{
					AppMobi.cookies[cookiename] = cookiedata;
				}
			}
		}
	}
}

AppMobi.Cache.prototype.getCookie = function(name) {
	var cookie = undefined;
	try {
		var target = "'";
		cookie = AppMobi.cookies[name].value.replace(/\\'/g, target); // '); // fix XCode JS parsing
	} catch(e){};
	return cookie;
};

AppMobi.Cache.prototype.getCookieList = function() {
	var cookies = [];
	for(cookie in AppMobi.cookies) {
		cookies.push(cookie);
	}
	return cookies;
}

//if expires <0, the cookie does not expire
AppMobi.Cache.prototype.setCookie = function(name, value, days) {
	if(name==undefined || name.length==0)
		throw(new Error("Error: AppMobi.cache.setcookie, No cookie name specified."));
	if( name.indexOf('.') > -1 )
		throw(new Error("Error: AppMobi.cache.setcookie, No '.' allowed in cookie names."));
	var tester = "0123456789";
	if( tester.indexOf(name.charAt(0)) > -1 )
		throw(new Error("Error: AppMobi.cache.setcookie, No numbers as first character in cookie names."));

	if(typeof value == "undefined") {
		value = "";
	}

	//make sure value is a string
	value = String(value);

	AppMobi.cookies[name]={"value":value};
	if(AppMobi.hasLocalStorage && days != 0 ) {
		var time = new Date().getTime();
		time += ( days * 24 * 60 * 60 * 1000 );

		var cookiedata = { "value":value, "expires":(days>0?time:-1) };
		localStorage.setItem(AppMobi.app + '.' + name, JSON.stringify(cookiedata));
	}
};

AppMobi.Cache.prototype.removeCookie = function(name) {
	if(AppMobi.cookies&&AppMobi.cookies[name]) {
		delete AppMobi.cookies[name];

		if(AppMobi.hasLocalStorage)
		{
			localStorage.removeItem(AppMobi.app + '.' + name);
			delete localStorage[AppMobi.app + '.' + name];
		}
	}
}

AppMobi.Cache.prototype.clearAllCookies = function(name) {
	for( cookie in AppMobi.cookies )
	{
		if(AppMobi.hasLocalStorage)
		{
			localStorage.removeItem(AppMobi.app + '.' + cookie);
			delete localStorage[AppMobi.app + '.' + name];
		}

	}
	AppMobi.cookies = {};
}


AppMobi.Cache.prototype.getMediaCacheList = function() {
	var cache = [];
	for(var media in AppMobi.mediacache) {
		cache.push(AppMobi.mediacache[media]);
	}
	return cache;
}

AppMobi.Cache.prototype.getMediaCacheLocalURL = function(url) {
	var localURL = undefined;
	//check if the url is cached
	for(var file in AppMobi.mediacache) {
		if(url==AppMobi.mediacache[file]) {
			localURL = url.split('/');
			localURL = 'http://localhost:58888/_mediacache/'+localURL[localURL.length-1];
			break;
		}
	}
	return localURL;
}

AppMobi.Cache.prototype.getMediaCacheRelativePath = function(url) {
    var localURL = undefined;
    //check if the url is cached
    for(var file in AppMobi.mediacache) {
        if(url==AppMobi.mediacache[file]) {
            localURL = url.split('/');
            localURL = '_mediacache/'+localURL[localURL.length-1];
            break;
        }
    }
    return localURL;
}

AppMobi.Cache.prototype.clearMediaCache = function() {
	//w0ndow.parent.emulateClearMediaCache();
    AppMobi.xdkBridge.exec('emulateClearMediaCache');
};

AppMobi.Cache.prototype.addToMediaCache = function(url) {
	//w0ndow.parent.emulateAddToMediaCache(url);
    AppMobi.xdkBridge.exec('emulateAddToMediaCache',url);
};

AppMobi.Cache.prototype.addToMediaCacheExt = function(url,id) {
    //w0ndow.parent.emulateAddToMediaCache(url,id);
    AppMobi.xdkBridge.exec('emulateAddToMediaCache',url,id);
};

AppMobi.Cache.prototype.removeFromMediaCache = function(url) {
	//w0ndow.parent.emulateRemoveFromMediaCache(url);
    AppMobi.xdkBridge.exec('emulateRemoveFromMediaCache',url);
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.cache == "undefined") AppMobi.cache = new AppMobi.Cache();
});

/**
 * This class provides access to the appMobi native GL canvas
 * @constructor
 */
AppMobi.Canvas = function() {
	this.isHidden = true;
    
};

AppMobi.Canvas.prototype.load = function(strRelativeURL) {

    for(eventType in {"touchstart":'',"touchmove":'',"touchend":''}) //TOUCH EVEN FORWARDING CLEANUP
        document.removeEventListener(eventType, AppMobi.canvas.forwardTouchEvent, false);
        
     AppMobi.xdkBridge.exec('emulateCanvasLoad',strRelativeURL,location.href, AppMobi.xdkBridge.bridge_type);
};

AppMobi.Canvas.prototype.show = function() {
	this.isHidden = false;
    AppMobi.xdkBridge.assignVar("document.getElementById('em-cnv').style.display","block");
};

AppMobi.Canvas.prototype.hide = function() {
	this.isHidden = true;
    AppMobi.xdkBridge.assignVar("document.getElementById('em-cnv').style.display","none");
};

AppMobi.Canvas.prototype.execute = function(strJavascript) {
   AppMobi.xdkBridge.exec('executeCanvas',strJavascript, location.origin);
};

AppMobi.Canvas.prototype.eval = function(strJavascript) {
	eval(strJavascript);
};

AppMobi.Canvas.prototype.reset = function() {
    
    for(eventType in {"touchstart":'',"touchmove":'',"touchend":''}) //TOUCH EVEN FORWARDING CLEANUP
        document.removeEventListener(eventType, AppMobi.canvas.forwardTouchEvent, false);
        
    AppMobi.xdkBridge.exec('emulateCanvasReset');
};

AppMobi.Canvas.prototype.setFramesPerSecond = function(fps) {
	//compatibility stub
};

AppMobi.Canvas.prototype.setFPS = function(fps) {
	//compatibility stub
};

AppMobi.Canvas.prototype.forwardTouchEvent = function(event)
{
    if(this.fwdEvtCounter == undefined)
    this.fwdEvtCounter = 0;
    
    //if(event.target.tagName == "HTML")
	//{
		var nX = event.changedTouches[0].pageX ;
		var nY = event.changedTouches[0].pageY;
		var touchId = event.changedTouches[0].identifier;
		
        sendEvent = false;
        if(event.type == 'touchmove')
        {
            this.fwdEvtCounter++;
            if(this.fwdEvtCounter%3==0){
                sendEvent = true;
                this.fwdEvtCounter=0;
            }    
        }
        else
        {
            sendEvent = true;
        }
		if(sendEvent)
            AppMobi.canvas.execute('AppMobi._dcsupport.setMouseCoords('+event.target.clientWidth+','+event.target.clientHeight+','+nX+','+nY+',"'+event.type+'"'+','+touchId+');');
		
   //}
}

AppMobi.addConstructor(function() {
	if (typeof AppMobi.canvas == "undefined") AppMobi.canvas = new AppMobi.Canvas();
});

/**
 * This class provides access to the appMobi in-app purchasing system
 * @constructor
 */
AppMobi.Purchasing = function() {
};

AppMobi.Purchasing.prototype.purchaseProduct = function(productId, quantity, user) {
	var quan = parseInt(quantity);
	if( typeof(quan) == "undefined" ) {
		q = 1;
	}
     AppMobi.native.emulatePurchaseProduct(productId, quan, user);
};

AppMobi.addConstructor(function() {
	if (typeof AppMobi.purchasing == "undefined") AppMobi.purchasing = new AppMobi.Purchasing();
});

/**
 * This class provides access to the debugging console.
 * @constructor
 */
AppMobi.Debug = function() {
}

AppMobi.Debug.prototype.log = function(message) {
    console.log(message);
};

AppMobi.Debug.prototype.warn = function(message) {
    console.error(message);
};

AppMobi.Debug.prototype.error = function(message) {
    console.error(message);
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.debug == "undefined") AppMobi.debug = new AppMobi.Debug();
});

AppMobi.Device = function(deviceData) {
    this.available = AppMobi.available;
    this.platform = null;
    this.osversion = null;
    this.model = null;
    this.uuid = null;
    this.initialOrientation = null;
    this.appmobiversion = null;
    this.phonegapversion = null;
    this.orientation = null;
    this.connection = null;
    this.density = null;
    this.lastPlaying = null;
    this.hasAnalytics = false;
    this.hasCaching = false;
    this.hasStreaming = false;
    this.hasAdvertising = false;
    this.hasPush = false;
    this.hasPayments = false;
    this.hasInAppPay = false;
    this.hasUpdates = false;
    this.queryString = "";
    this.landwidth = "";
    this.landheight = "";
    this.portwidth = "";
    this.portheight = "";
    this.width = "";
    this.height = "";
    try {
        this.available          = true;
    /*    this.platform           = w0ndow.parent.arrDevices[w0ndow.parent.currentDevice].platform;   // commenting out call -- AppMobiDevice.getPlatform();
        this.osversion          = w0ndow.parent.arrDevices[w0ndow.parent.currentDevice].osversion; // commenting out call -- AppMobiDevice.getOSVersion();
        this.model              = w0ndow.parent.arrDevices[w0ndow.parent.currentDevice].model;         // commenting out call -- AppMobiDevice.getModel();
        this.uuid               = w0ndow.parent.arrDevices[w0ndow.parent.currentDevice].uuid;           // commenting out call -- AppMobiDevice.getUuid();
        this.initialOrientation = w0ndow.parent.rotation;                   // commenting out call -- AppMobiDevice.getInitialOrientation();
        this.appmobiversion     = w0ndow.parent.arrDevices[w0ndow.parent.currentDevice].appmobiversion; // commenting out call -- AppMobiDevice.getVersion();
    */

        if(deviceData != undefined)
        {
            this.platform           = deviceData.platform;   // commenting out call -- AppMobiDevice.getPlatform();
            this.osversion          = deviceData.osversion; // commenting out call -- AppMobiDevice.getOSVersion();
            this.model              = deviceData.model;         // commenting out call -- AppMobiDevice.getModel();
            this.uuid               = deviceData.uuid;           // commenting out call -- AppMobiDevice.getUuid();
            this.initialOrientation = deviceData.orientation;//w0ndow.parent.rotation;                   // commenting out call -- AppMobiDevice.getInitialOrientation();
            this.appmobiversion     = deviceData.appmobiversion; // commenting out call -- AppMobiDevice.getVersion();
            this.orientation        = deviceData.orientation;//w0ndow.parent.emulateGetCurrentOrientation(); // add dummy data // commenting out call -- AppMobiDevice.getOrientation();
            this.connection         = deviceData.connection;//w0ndow.parent.emulateGetCurrentNetworkingLevel();  // commenting out call -- AppMobiDevice.getConnection();
            AppMobi.isphone         = deviceData.isphone;
            AppMobi.istablet        = deviceData.istablet;
            AppMobi.isnook           = deviceData.isnook;
            this.portheight         = deviceData.height-deviceData.statusHeight;
            this.portwidth          = deviceData.width;
            this.landwidth          = deviceData.height;
            this.landheight         = deviceData.width - deviceData.statusHeight;
            this.width              = deviceData.width;
            this.height             = deviceData.height;
        }
        this.phonegapversion    = "1.0.0"; // add dummy data // commenting out call -- AppMobiDevice.getPGVersion();
        this.density = null; // add dummy data // commenting out call -- AppMobiDevice.getDisplayDensity();
        this.lastPlaying = ""; // add dummy data // commenting out call -- AppMobiDevice.getPlayingStation();
        this.hasAnalytics = AppMobi._hasAnalytics;
        this.hasCaching = AppMobi._hasCaching;
        this.hasStreaming = AppMobi._hasStreaming;
        this.hasAdvertising = AppMobi._hasAdvertising;
        this.hasPush = AppMobi._hasPush;
        this.hasInAppPay = AppMobi._hasInAppPay;
    } catch(e) {
        
        alert("AppMobi.Device Initilization: "+e.message);
        this.available = false;
    }
}

/**
 * This class specifies the attributes for getRemoteDataExt.
 * @constructor
 */
AppMobi.Device.RemoteDataParameters = function() {
	this.url = "";
	this.id = "";
	this.method = "GET";
	this.body = "";
	this.headers = "";
};

AppMobi.Device.RemoteDataParameters.prototype.addHeader = function(name, value) {
	if(typeof name != "string" || name.length==0) {
		throw(new Error("Error: the name parameter must be of type 'string' and must be of length > 0 for RemoteDataParameters"));
	}
	
	if(typeof value != "string") {

		if(typeof value == "undefined") {
			//convert undefined to zero-length string
			value = "";
		} else {
			//convert other non-strings (function, number, object, etc.) to string representation
			value = String(value);
		}
		
	}

	this.headers += name.length +"~" + name + value.length +"~" + value;
};

AppMobi.Device.prototype.managePower = function(shouldStayOn, onlyWhenPluggedIn) {
	// commenting out call -- AppMobiDevice.managePower(shouldStayOn, onlyWhenPluggedIn);
};

AppMobi.Device.prototype.setAutoRotate = function(shouldAutoRotate) {
	//w0ndow.parent.emulateSetAutoRotate(shouldAutoRotate);
    AppMobi.xdkBridge.exec('emulateSetAutoRotate',shouldAutoRotate);
};

AppMobi.Device.prototype.setRotateOrientation = function(orientation) {
	//orientation should be 'portrait' or 'landscape'
	// commenting out call -- AppMobiDevice.setRotateOrientation(orientation);
	//w0ndow.parent.emulateSetRotateOrientation(orientation);
    AppMobi.xdkBridge.exec('emulateSetRotateOrientation',orientation);
};

AppMobi.Device.prototype.updateConnection = function() {
    AppMobi.xdkBridge.exec('emulateUpdateConnection');
};

AppMobi.Device.prototype.setBasicAuthentication = function(host, username, password) {
	// commenting out call -- AppMobiDevice.setBasicAuthentication(host, username, password);
};

AppMobi.Device.prototype.addVirtualPage = function() {
	// commenting out call -- AppMobiDevice.addVirtualPage();
};

AppMobi.Device.prototype.removeVirtualPage = function() {
	// commenting out call -- AppMobiDevice.removeVirtualPage();
};

AppMobi.Device.prototype.registerLibrary = function(moduleName) {
	//w0ndow.parent.emulateRegisterLibrary(pluginName, moduleName);
    //AppMobi.xdkBridge.exec('emulateRegisterLibrary',moduleName);
    AppMobi.native.emulateRegisterLibrary(moduleName);
};

AppMobi.Device.prototype.pluginExec = function(classNamefunctionName) {
	var params = "";
	if(arguments.length>1) {
		for(var i=1;i<arguments.length;i++) {
			if(params != "") params += "|";
			params += arguments[i];
		}
	}
	//w0ndow.parent.emulatePluginExec(pluginName, className, functionName, params);
    //AppMobi.xdkBridge.exec('emulatePluginExec', classNamefunctionName, params);
    AppMobi.native.emulatePluginExec(classNamefunctionName, params);
};

AppMobi.Device.prototype.launchExternal = function(url) {
    //w0ndow.parent.emulateLaunchExternal(url);
    AppMobi.xdkBridge.exec('emulateLaunchExternal',url);
};


AppMobi.Device.prototype.showRemoteSite = function(strURL, closePortX, closePortY, closeWidth, closeHeight)
{
    AppMobi.device.showRemoteSiteExt(strURL, closePortX, closePortY, closePortX, closePortY, closeWidth, closeHeight);
};

AppMobi.Device.prototype.showRemoteSiteExt = function(strURL, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight, closeImage)
{
    //w0ndow.parent.emulateShowRemoteSiteExt(strURL, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight);  
    AppMobi.xdkBridge.exec('emulateShowRemoteSiteExt',strURL, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight, closeImage); 
};

AppMobi.Device.prototype.closeRemoteSite = function()
{
    //w0ndow.parent.closeRemote();
    AppMobi.xdkBridge.exec('closeRemote');
};

AppMobi.Device.prototype.mainViewExecute = function(data)
{
    AppMobi.xdkBridge.exec('emulateMainViewExecute',data);
    //AppMobi.xdkBridge.eval(data,'main');
}

AppMobi.Device.prototype.blockRemotePages = function(shouldblock, whitelist) {
	console.log("Error: AppMobi.device.blockRemotePages is not implemented in the XDK at this time.");
};

AppMobi.Device.prototype.scanBarcode = function() {
	//w0ndow.parent.emulateScanBarcode();
    //AppMobi.xdkBridge.exec('emulateScanBarcode');
    AppMobi.native.emulateScanBarcode();
};

AppMobi.Device.prototype.setOrientation = function(orientation) {
	AppMobi.device.orientation = orientation;

	var e = document.createEvent('Events');
	e.initEvent('appMobi.device.orientation.change', true, true);
	e.orientation = orientation;
	document.dispatchEvent(e);
};

AppMobi.Device.prototype.getRemoteDataWithId = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback, unique_id) {
	//validate parameters
	if(
		 (requestUrl == undefined || requestUrl=='') ||
		 (requestMethod == undefined || requestMethod=='' || (requestMethod.toUpperCase()!='GET' && requestMethod.toUpperCase()!='POST')) ||
		 (successCallback == undefined || successCallback=='') ||
		 (errorCallback == undefined || errorCallback=='')
		 ) {
		throw(new Error("Error: getRemoteData has the following required parameters: requestUrl, requestMethod, requestBody, successCallback, errorCallback.  requestMethod must be either GET or POST.  requestBody is ignored for GET requests."));
	}

	if(typeof(successCallback)!="string") throw(new Error("Error: getRemoteData successCallback parameter must be a string which is the name of a function"));
	if(typeof(errorCallback)!="string") throw(new Error("Error: getRemoteData errorCallback parameter must be a string which is the name of a function"));

	if(requestBody == undefined) requestBody="";

	//w0ndow.parent.emulateGetRemoteData(requestUrl, requestMethod, requestBody, successCallback, errorCallback, unique_id);
    //AppMobi.xdkBridge.exec('emulateGetRemoteData',requestUrl, requestMethod, requestBody, successCallback, errorCallback, unique_id);
    AppMobi.native.emulateGetRemoteData(requestUrl, requestMethod, requestBody, successCallback, errorCallback, unique_id);
};

AppMobi.Device.prototype.getRemoteDataWithID = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback, unique_id) {
    AppMobi.device.getRemoteDataWithId(requestUrl, requestMethod, requestBody, successCallback, errorCallback, unique_id);
};

AppMobi.Device.prototype.getRemoteDataExt = function(parameters) {
	if( parameters == undefined )
	{
		throw(new Error("Error: AppMobi.device.getRemoteDataExt: parameters is required."));
	}

	if( parameters.hasOwnProperty("url") == false || parameters.hasOwnProperty("id") == false || parameters.hasOwnProperty("method") == false 
	   || parameters.hasOwnProperty("body") == false || parameters.hasOwnProperty("headers") == false )
	{
		throw(new Error("Error: AppMobi.device.getRemoteDataExt: invalid parameters object. Initialize using 'new AppMobi.Device.RemoteDataParameters'."));
	}
	
	if( parameters.url == undefined || parameters.url=='' )
	{
		throw(new Error("Error: AppMobi.device.getRemoteDataExt requires a url property."));
	}

	if( parameters.method == undefined || (parameters.method.toUpperCase()!='GET' && parameters.method.toUpperCase()!='POST') )
	{
		throw(new Error("Error: AppMobi.device.getRemoteDataExt requires a method property of GET or POST. body is ignored for GET requests."));
	}
	
	//w0ndow.parent.emulateGetRemoteDataExt(parameters.url, parameters.id, parameters.method, parameters.body, parameters.headers);
    
    //AppMobi.xdkBridge.exec("emulateGetRemoteDataExt",parameters.url, parameters.id, parameters.method, parameters.body, parameters.headers);
   
    AppMobi.native.emulateGetRemoteDataExt(parameters.url, parameters.id, parameters.method, parameters.body, parameters.headers);
    //w0ndow.parent.emulateGetRemoteDataExt(parameters.url, parameters.id, parameters.method, parameters.body, parameters.headers);
};

AppMobi.Device.prototype.getRemoteData = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback) {
    AppMobi.device.getRemoteDataWithId(requestUrl, requestMethod, requestBody, successCallback, errorCallback);
};

AppMobi.Device.prototype.installUpdate = function() {
if(AppMobi.updateAvailable == true)
{
    AppMobi.updateAvailable = false;
    //w0ndow.parent.OTAU_installUpdate(1);
    AppMobi.xdkBridge.exec('OTAU_installUpdate',1);
}
};

AppMobi.Device.prototype.hideSplashScreen = function() {
       //w0ndow.parent.emulateHideSplashScreen();
       AppMobi.xdkBridge.exec('emulateHideSplashScreen');
};

AppMobi.Device.prototype.cachePackage = function(packageDir, packageURL)
{
       AppMobi.native.emulateCachePackage(packageDir, packageURL);
};

AppMobi.Device.prototype.runInstallNativeApp = function(packageDir, packageURL)
{
      //Stub
};


AppMobi.Device.prototype.sendEmail = function(body, to, subject, ishtml, cc, bcc) {
    if(typeof body != "string" || body.length==0) {
		throw(new Error("Error: AppMobi.device.sendEmail: body must be a non empty string."));
	}
    if(typeof to != "string" || to.length==0 ) to = "";
    if(typeof subject != "string" || subject.length==0 ) subject = "";
    if(typeof ishtml != "boolean" ) ishtml = false;
    if(typeof cc != "string" || cc.length==0 ) cc = "";
    if(typeof bcc != "string" || bcc.length==0 ) bcc = "";
    window.location = "mailto:"+to+"?subject="+subject+"&body="+body+"&cc="+cc+"&bcc="+bcc;
};


AppMobi.Device.prototype.sendSMS = function(body, to)
{
	throw(new Error("Error: AppMobi.device.sendSMS: Not available in the XDK"));
}

AppMobi.Device.prototype.hideStatusBar = function()
{
    AppMobi.xdkBridge.exec('emulateHideStatusBar');
}

AppMobi.addConstructor(function() {
    if (typeof AppMobi.device == "undefined") AppMobi.device = new AppMobi.Device();
});


//FACEBOOK API
//======================================================================================


AppMobi.Facebook = function() {
   this.isSessionValid = false;
    AppMobi.native.Facebook.initCommunicationFrame();
}

AppMobi.Facebook.prototype.login = function(permissions) {
       //permissions is a '|' separated list of permissions - no validation is performed
       AppMobi.native.Facebook.login(permissions);
}

AppMobi.Facebook.prototype.logout = function() {
      AppMobi.native.Facebook.logout();
}

AppMobi.Facebook.prototype.requestWithRestAPI = function(command, method, parameters) {
	//AppMobi.exec("AppMobiFacebook.requestWithRestAPI", command, method, parameters);
    if(typeof(parameters) != "object")
    {
        try
        {
            var tmpParam = JSON.parse(parameters);
            parameters = tmpParam;
        }
        catch(err)
        {}
    }
    
    
    AppMobi.native.Facebook.api(command, method, parameters);
}

AppMobi.Facebook.prototype.requestWithGraphAPI = function(path, method, parameters) {
       //AppMobi.exec("AppMobiFacebook.requestWithGraphAPI", path, parameters, httpMethod, AppMobi.facebook.nextRequestId);
       
    if(typeof(parameters)  != "object" )
    {
        try
        {
            var tmpParam = JSON.parse(parameters);
            parameters = tmpParam;
        }
        catch(err)
        {}
    }
       AppMobi.native.Facebook.api(path, method, parameters);
}

AppMobi.Facebook.prototype.showAppRequestDialog = function(parameters) {
       //AppMobi.exec("AppMobiFacebook.showAppRequestDialog", parameters);
    if(typeof(parameters) != "object" )
    {
        try
        {
            var tmpParam = JSON.parse(parameters);
            parameters = tmpParam;
        }
        catch(err)
        {}
    }
    AppMobi.native.Facebook.appRequest(parameters);
}

AppMobi.Facebook.prototype.showNewsFeedDialog = function(parameters)
{
    if( typeof(parameters) == "undefined" || typeof(parameters) != "object" )
        parameters = {};
    parameters.method = "feed";
    AppMobi.native.Facebook.ui(parameters, "dialog");
}

AppMobi.Facebook.prototype.enableFrictionlessRequests = function() {
       AppMobi.native.Facebook.frictionless = true;
}

AppMobi.addConstructor(function() {
    if (typeof AppMobi.facebook == "undefined") AppMobi.facebook = new AppMobi.Facebook();
});




AppMobi.Geolocation = function() {
}

AppMobi.Geolocation.prototype.getCurrentPosition = function(successCallback, errorCallback, options, calledFromWatch){
	//w0ndow.parent.AppMobiGeo.getCurrentPosition(successCallback, errorCallback, options, calledFromWatch);
    AppMobi['_xdk_support'].geolocation.getCurrentPosition(successCallback, errorCallback, options, calledFromWatch);
};
AppMobi.Geolocation.prototype.watchPosition = function(successCallback, errorCallback, options){
	//return w0ndow.parent.AppMobiGeo.watchPosition(successCallback, errorCallback, options);
   return  AppMobi['_xdk_support'].geolocation.watchPosition(successCallback, errorCallback, options);
};
AppMobi.Geolocation.prototype.clearWatch = function(watchId){
	//w0ndow.parent.AppMobiGeo.clearWatch(watchId);
     AppMobi['_xdk_support'].geolocation.clearWatch(watchId);
};

AppMobi.addConstructor(function() {

    if (typeof AppMobi.geolocation == "undefined") AppMobi.geolocation = new AppMobi.Geolocation();

});

/*
  This class provides compatibility with Android multi-touch support.
  @constructor
 */
AppMobi.Multitouch = function() {
}

AppMobi.Multitouch.prototype.enable = function(){}
/*
 * @param {element} target
 * @param {string} type ('touchstart', 'touchend', 'touchmove')
 * @param {function} listener
 * @param {boolean} useCapture
 */
AppMobi.Multitouch.prototype.add = function(target, type, listener, useCapture) {
    target.addEventListener(type, listener, useCapture);
}

/*
 * @param {element} target
 * @param {string} type ('touchstart', 'touchend', 'touchmove')
 * @param {function} listener
 * @param {boolean} useCapture
 */
AppMobi.Multitouch.prototype.remove = function(target, type, listener, useCapture) {
    target.removeEventListener(type, listener, useCapture);
}

AppMobi.addConstructor(function() {
    if (typeof AppMobi.multitouch == "undefined") AppMobi.multitouch = new AppMobi.Multitouch();
});

/**
 * This class provides access to notifications on the device.
 */
AppMobi.Notification = function() {
}
													 
/**
 * This class specifies the attributes for push users.
 * @constructor
 */
 AppMobi.Notification.PushUserAttributes = function() {
	this.s1 = null;
	this.s2 = null;
	this.s3 = null;
	this.s4 = null;
	this.s5 = null;
	this.s6 = null;
	this.n1 = null;
	this.n2 = null;
	this.n3 = null;
	this.n4 = null;
};

AppMobi.Notification.prototype.alert = function(message, title, button) {
    AppMobi.xdkBridge.exec("emulateAlert", message, title, button);
   // w0ndow.parent.emulateAlert(message, title, button);
};

AppMobi.Notification.prototype.vibrate = function() {
     AppMobi.xdkBridge.exec("emulateVibrate");
   // w0ndow.parent.emulateVibrate();
};

AppMobi.Notification.prototype.beep = function(count) {
    AppMobi.xdkBridge.exec("emulateBeep",count);
   // w0ndow.parent.emulateBeep(count);
};

AppMobi.Notification.prototype.showBusyIndicator = function() {
    //w0ndow.parent.emulateShowBusyIndicator();
    AppMobi.xdkBridge.exec('emulateShowBusyIndicator');
};

AppMobi.Notification.prototype.hideBusyIndicator = function() {
    //w0ndow.parent.emulateHideBusyIndicator();
    AppMobi.xdkBridge.exec('emulateHideBusyIndicator');
};

AppMobi.Notification.prototype.getNotificationList = function() {
	var notify = [];
	for(var note in AppMobi.notifications) {
		notify.push(AppMobi.notifications[note].id);
	}
	return notify;
};

AppMobi.Notification.prototype.getNotificationData = function(id) {
	var local = null;
	for(var note in AppMobi.notifications) {
		if(id==AppMobi.notifications[note].id) {
			local = {};
			local.id = AppMobi.notifications[note].id;
			local.msg = AppMobi.notifications[note].msg;
			local.data = AppMobi.notifications[note].data;
			local.userkey = AppMobi.notifications[note].userkey;
			local.richurl = AppMobi.notifications[note].richurl;
			local.richhtml = AppMobi.notifications[note].richhtml;
			local.isRich = AppMobi.notifications[note].isRich;
			break;
		}
	}
	return local;
};

AppMobi.Notification.prototype.checkPushUser = function(userID, password) {
	if( userID   == undefined || userID   == "" ||
		 password == undefined || password == "" )
	{
		throw(new Error("Error: AppMobi.notification.checkPushUser, No user or password specified."));
	}

	//w0ndow.parent.emulateCheckPushUser(userID, password);
     //AppMobi.xdkBridge.exec('emulateCheckPushUser',userID, password);
     AppMobi.native.emulateCheckPushUser(userID, password);
};

AppMobi.Notification.prototype.addPushUser = function(userID, password, email) {
    if(userID!= undefined && userID != null)
        userID = userID+""; //cast as string so we can use the indexOf method that strings have later
    if(userID!= undefined && userID != null)
        password  = password +""; //cast as string so we can use the indexOf method that strings have later    
	if( userID   == undefined || userID   == "" || userID.indexOf(' ')!=-1 || userID.indexOf('.')!=-1 || 
		password == undefined || password == "" || password.indexOf(' ')!=-1 || password.indexOf('.')!=-1 ||
		email    == undefined || email    == "" )
	{
		throw(new Error("Error: AppMobi.notification.addPushUser: User, email and password are required. The space (' ') and dot ('.') characters are not allowed in user and password."));
	}

	//w0ndow.parent.emulateAddPushUser(userID, password, email);
    //AppMobi.xdkBridge.exec('emulateAddPushUser',userID, password, email);
    AppMobi.native.emulateAddPushUser(userID, password, email);
};

AppMobi.Notification.prototype.editPushUser = function(newEmail, newPassword, newUser) {
    if(newUser == undefined)
        newUser = "";
	if( ( newEmail == undefined || newEmail == "" ) &&
		( newPassword == undefined || newPassword == "" || newPassword.indexOf(' ')!=-1 || newPassword.indexOf('.')!=-1) )
	{
		throw(new Error("Error: AppMobi.notification.editPushUser, No new value (email or password) specified. The space (' ') and dot ('.') characters are not allowed in password."));
	}

	//w0ndow.parent.emulateEditPushUser(newEmail, newPassword);
    //AppMobi.xdkBridge.exec('emulateEditPushUser',newEmail, newPassword);
    AppMobi.native.emulateEditPushUser(newEmail, newPassword, newUser);
};

AppMobi.Notification.prototype.deletePushUser = function() {
	//w0ndow.parent.emulateDeletePushUser();
    //AppMobi.xdkBridge.exec('emulateDeletePushUser');
    AppMobi.native.emulateDeletePushUser();
};

AppMobi.Notification.prototype.sendPushUserPass = function() {
	//w0ndow.parent.emulateSendPushUserPass();
    //AppMobi.xdkBridge.exec('emulateSendPushUserPass');
    AppMobi.native.emulateSendPushUserPass();
};

AppMobi.Notification.prototype.setPushUserAttributes = function(attributes) {
	if( attributes == undefined )
	{
		throw(new Error("Error: AppMobi.notification.setPushUserAttributes: attributes is required."));
	}

	if( attributes.hasOwnProperty("s1") == false || attributes.hasOwnProperty("s2") == false || attributes.hasOwnProperty("s3") == false || attributes.hasOwnProperty("s4") == false 
			|| attributes.hasOwnProperty("s5") == false || attributes.hasOwnProperty("s6") == false || attributes.hasOwnProperty("n1") == false
			 || attributes.hasOwnProperty("n2") == false || attributes.hasOwnProperty("n3") == false || attributes.hasOwnProperty("n4") == false )
	{
		throw(new Error("Error: AppMobi.notification.setPushUserAttributes: invalid attributes parameter specified. Initialize using 'new AppMobi.Notification.PushUserAttributes'."));
	}

	if( (Number(attributes.n1) == NaN) || (Number(attributes.n2) == NaN) || 
			(Number(attributes.n3) == NaN) || (Number(attributes.n4) == NaN) )
	{
		throw(new Error("Error: AppMobi.notification.setPushUserAttributes: attributes n1,n2,n3,n4 must be numbers."));
	}

	var parsedAttributes = "";
	for(var prop in attributes)
    {
		if( (prop=="s1"||prop=="s2"||prop=="s3"||prop=="s4"||prop=="s5"||prop=="s6"||prop=="n1"||prop=="n2"||prop=="n3"||prop=="n4") && attributes[prop] != null)
        {
            parsedAttributes += "[";
            parsedAttributes += prop;
            parsedAttributes += "=";
            parsedAttributes += escape(attributes[prop]);
            parsedAttributes += "]";
		}
	}
	//w0ndow.parent.emulateSetPushUserAttributes();
    //AppMobi.xdkBridge.exec('emulateSetPushUserAttributes');
    AppMobi.native.emulateSetPushUserAttributes(parsedAttributes);
};

AppMobi.Notification.prototype.findPushUser = function(userID, email) {
	//w0ndow.parent.emulateFindPushUser(userID, email);
    //AppMobi.xdkBridge.exec('emulateFindPushUser',userID, email);
    AppMobi.native.emulateFindPushUser(userID, email);
};

AppMobi.Notification.prototype.refreshPushNotifications = function() {
	//w0ndow.parent.emulateRefreshPushNotifications();
    //AppMobi.xdkBridge.exec('emulateRefreshPushNotifications');
    AppMobi.native.emulateRefreshPushNotifications();
};

//readPush is deprecated left in for compatability (use deletePush instead)
AppMobi.Notification.prototype.readPushNotifications = function(notificationIDs) {
	if( notificationIDs == "undefined" || notificationIDs == "")
	{
		throw(new Error("Error: AppMobi.notification.readPushNotifications, No notificationIDs specified."));
	}
	//w0ndow.parent.emulateDeletePushNotifications(notificationIDs, 'read');
    //AppMobi.xdkBridge.exec('emulateDeletePushNotifications',notificationIDs, 'read');
    AppMobi.native.emulateDeletePushNotifications(notificationIDs, 'read');
};


AppMobi.Notification.prototype.deletePushNotifications = function(notificationIDs) {
	if( notificationIDs == "undefined" || notificationIDs == "")
	{
		throw(new Error("Error: AppMobi.notification.deletePushNotifications, No notificationIDs specified."));
	}
	//w0ndow.parent.emulateDeletePushNotifications(notificationIDs);
    //AppMobi.xdkBridge.exec('emulateDeletePushNotifications',notificationIDs);
    AppMobi.native.emulateDeletePushNotifications(notificationIDs);
};

AppMobi.Notification.prototype.sendPushNotification = function(userID, message, data) {
	if( userID  == "undefined" || userID  == "" ||
		 message == "undefined" || message == "" ||
		 data    == "undefined" || data    == "" )
	{
		throw(new Error("Error: AppMobi.notification.sendPushNotification, No user, message or data specified."));
	}
	if(message.length>160) throw(new Error("Error: AppMobi.notification.sendPushNotification, message cannot exceed 160 characters in length."));
	if(data.length>160) throw(new Error("Error: AppMobi.notification.sendPushNotification, data cannot exceed 160 characters in length."));

	//w0ndow.parent.emulateSendPushNotification(userID, message, data);
    //AppMobi.xdkBridge.exec('emulateSendPushNotification',userID, message, data);
    AppMobi.native.emulateSendPushNotification(userID, message, data);
};

AppMobi.Notification.prototype.showRichPushViewer = function(notificationID, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight) {
	if( notificationID == undefined || notificationID  == "")
    {
        throw(new Error("Error: AppMobi.notification.showRichPushViewer, No notification ID specified."));
    }

    var notification = AppMobi.notification.getNotificationData( notificationID );
    if( notification == null || ( notification.richurl == "" && notification.richhtml == "" ) )
    {
        throw(new Error("Error: AppMobi.notification.showRichPushViewer, This notification ID is not a rich message."));
    }

    //w0ndow.parent.emulateShowRichPushViewer(notificationID, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight, AppMobi.notifications);
    AppMobi.xdkBridge.exec('emulateShowRichPushViewer',notificationID, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight, AppMobi.notifications);

};

AppMobi.Notification.prototype.closeRichPushViewer = function() {
	//w0ndow.parent.emulateCloseRichPushViewer();
    AppMobi.xdkBridge.exec('emulateCloseRichPushViewer');
};


AppMobi.Notification.prototype.refreshUserPushNotifications = function(user, pass, device, newerthan) {
   AppMobi.native.emulateRefreshUserPushNotifications(user, pass, device, newerthan);
};

AppMobi.Notification.prototype.broadcastPushNotification = function(message, data, attributes, skip) {
	if( message == undefined || message == "" )
	{
		throw(new Error("Error: AppMobi.notification.broadcastPushNotification, No message specified."));
	}
    
    if( typeof( data ) != "string" ) data = "";	
	if( message.length > 160 ) throw(new Error("Error: AppMobi.notification.broadcastPushNotification, message cannot exceed 160 characters in length."));
	if( data.length > 1024 ) throw(new Error("Error: AppMobi.notification.broadcastPushNotification, data cannot exceed 1024 characters in length."));
    
   // AppMobi.exec("AppMobiNotification.broadcastPushNotification", message, data, attirbutes);
     AppMobi.native.emulatebroadcastPushNotification(message, data, attributes, skip);
};


AppMobi.Notification.prototype.confirm = function(message, id, title, ok, cancel)
{
    AppMobi.xdkBridge.exec("confirm_dialog",message, id, title, ok, cancel);
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.notification == "undefined") AppMobi.notification = new AppMobi.Notification();
});

/**
 * This class provides access to the device display.
 * @constructor
 */
AppMobi.Display = function() {
    this.viewport = {};
    this.oldviewport = {};
    this.window = {};
    this.window.landwidth = 0;
    this.window.portwidth = 0;
    this.window.landheight = 0;
    this.window.portheight = 0;
}

/**
//turns on appmobi managed viewport
 * @param {int} portraitWidthInPx
 * @param {int} landscapeWidthInPx
 */

AppMobi.Display.prototype.switchViewport = function(portraitWidthInPx, landscapeWidthInPx) {

 	//w0ndow.parent._oldportraitWidthInPx = w0ndow.parent._portraitWidthInPx
 	//w0ndow.parent._oldlandscapeWidthInPx = w0ndow.parent._landscapeWidthInPx
 	AppMobi.xdkBridge.eval('_oldportraitWidthInPx = _portraitWidthInPx;');
    AppMobi.xdkBridge.eval('_oldlandscapeWidthInPx = _landscapeWidthInPx;');
    this.useViewport(portraitWidthInPx, landscapeWidthInPx);
}

AppMobi.Display.prototype.revertViewport = function()
{
 	//this.useViewport(w0ndow.parent._oldportraitWidthInPx, w0ndow.parent._oldlandscapeWidthInPx );
    AppMobi.exec('emulateRevertViewPort');
}

AppMobi.Display.prototype.useViewport = function(portraitWidthInPx, landscapeWidthInPx)
{

	//w0ndow.parent._portraitWidthInPx = portraitWidthInPx;
	//w0ndow.parent._landscapeWidthInPx = landscapeWidthInPx;
	//w0ndow.parent._useviewport = true;
    AppMobi.xdkBridge.assignVar('_portraitWidthInPx',portraitWidthInPx);
    AppMobi.xdkBridge.assignVar('_landscapeWidthInPx',landscapeWidthInPx);
    AppMobi.xdkBridge.assignVar('_useviewport',true);

	//get reference to head
	var head, heads = document.getElementsByTagName('head');
	if(heads.length>0) head = heads[0];
	else return;
	//remove any viewport meta tags
	var metas = document.getElementsByTagName('meta');
	for(var i=0;i<metas.length;i++) {
	    if(metas[i].name=='viewport') try {head.removeChild(metas[i]);} catch(e){}
	}

	//if (window.parent.emulateGetCurrentOrientation()==0)
    //FIXLATER
    if (AppMobi['_xdk_support'].rotation == 0)
	{
		//window.parent.currentViewportZoomLevel=window.parent.arrDevices[window.parent.currentDevice].emulator.width/portraitWidthInPx;
        //AppMobi.xdkBridge.eval('currentViewportZoomLevel=arrDevices[currentDevice].emulator.width/'+portraitWidthInPx+';');
        AppMobi.xdkBridge.exec('setViewportZoomLevel',portraitWidthInPx);
    }
	else
	{
		//window.parent.currentViewportZoomLevel=window.parent.arrDevices[window.parent.currentDevice].emulator.height/landscapeWidthInPx;
        //AppMobi.xdkBridge.eval('currentViewportZoomLevel=arrDevices[currentDevice].emulator.height/'+landscapeWidthInPx+';');
         AppMobi.xdkBridge.exec('setViewportZoomLevel',landscapeWidthInPx);
	}
    //w0ndow.parent.displayCurrentDevice();
	AppMobi.xdkBridge.exec('displayCurrentDevice');
                 
}

AppMobi.Display.prototype.lockViewportWindow = function (portwidth, portheight, landwidth, landheight)
{
    var vplandwidth = parseInt( ( parseFloat(landheight) / parseFloat(AppMobi.device.landheight) ) * parseFloat(AppMobi.device.landwidth) );
    var vpportwidth = parseInt( ( parseFloat(portheight) / parseFloat(AppMobi.device.portheight) ) * parseFloat(AppMobi.device.portwidth) );
    var vplandheight = parseInt( ( parseFloat(landwidth) / parseFloat(AppMobi.device.landwidth) ) * parseFloat(AppMobi.device.landheight) );
    var vpportheight = parseInt( ( parseFloat(portwidth) / parseFloat(AppMobi.device.portwidth) ) * parseFloat(AppMobi.device.portheight) );

    if( vpportwidth > portwidth )
    {
    	AppMobi.display.window.portwidth = vpportwidth;
    	AppMobi.display.window.portheight = portheight
    }
    else
    {
    	AppMobi.display.window.portwidth = portwidth;
    	AppMobi.display.window.portheight = vpportheight;
    }

    if( vplandwidth > landwidth )
    {
    	AppMobi.display.window.landwidth = vplandwidth;
    	AppMobi.display.window.landheight = landheight
    }
    else
    {
    	AppMobi.display.window.landwidth = landwidth;
    	AppMobi.display.window.landheight = vplandheight;
    }
    AppMobi.display.useViewport( AppMobi.display.window.portwidth,
    AppMobi.display.window.landwidth );
}
    
AppMobi.Display.prototype.updateViewportContent = function(content)
{
    //get reference to head
    var head, heads = document.getElementsByTagName('head');
    if(heads.length>0) head = heads[0];
    else return;
    //remove any viewport meta tags
    var metas = document.getElementsByTagName('meta');
    for(var i=0;i<metas.length;i++) {
        if(metas[i].name=='viewport') try {head.removeChild(metas[i]);} catch(e){}
    }
    //add the new viewport meta tag
    var viewport = document.createElement('meta');
    viewport.setAttribute('name', 'viewport');
    viewport.setAttribute('id', 'viewport');
    viewport.setAttribute('content', content);
    head.appendChild(viewport);
}

AppMobi.Display.prototype.updateViewportOrientation = function(orientation) {
    var width;
    if(orientation==0||orientation==180) {
        width=AppMobi.display.viewport.portraitWidth;
    } else {
        width=AppMobi.display.viewport.landscapeWidth;
    }
    //!!!fixed this scale piece
  var scale;
  try
  {
    scale = (screen.width)/(width*navigator.device.density);//needed for any-density = false, otherwise (screen.width)/width
  }
  catch(e)
  {
    scale = (screen.width)/width;//needed for any-density = false, otherwise (screen.width)/width
  }
  AppMobi.display.updateViewportContent('minimum-scale='+scale+',maximum-scale='+scale);//if any-density=true, prepend with target-densitydpi=device-dpi,
}

AppMobi.Display.prototype.viewportOrientationListener = function(e){
    AppMobi.display.updateViewportOrientation(AppMobi.device.orientation);
}

AppMobi.Display.prototype.startAR = function() {
    //w0ndow.parent.emulateStartAR();
    AppMobi.xdkBridge.exec('emulateStartAR');
};

AppMobi.Display.prototype.stopAR = function() {
    //w0ndow.parent.emulateStopAR();
    AppMobi.xdkBridge.exec('emulateStopAR');
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.display == "undefined") AppMobi.display = new AppMobi.Display();
});

/**
 * This class provides access to oauth.
 * @constructor
 */
AppMobi.OAuth = function() {
}

/**
 * This class specifies the attributes for getRemoteDataExt.
 * @constructor
 */
AppMobi.OAuth.ProtectedDataParameters = function() {
	this.service = "";
	this.url = "";
	this.id = "";
	this.method = "GET";
	this.body = "";
	this.headers = "";
};

AppMobi.OAuth.ProtectedDataParameters.prototype.addHeader = function(name, value) {
	if(typeof name != "string" || name.length==0) {
		throw(new Error("Error: the name parameter must be of type 'string' and must be of length > 0 for ProtectedDataParameters"));
	}
	
	if(typeof value != "string") {		
		if(typeof value == "undefined") {
			//convert undefined to zero-length string
			value = "";
		} else {
			//convert other non-strings (function, number, object, etc.) to string representation
			value = String(value);
		}		
	}
	
	this.headers += name.length +"~" + name + value.length +"~" + value;
};

AppMobi.OAuth.prototype.unauthorizeService = function(service) {
	
		//throw(new Error('Error: AppMobi.OAuth.unauthorizeService, OAuth is not implemented in the XDK at this time.'));
        //w0ndow.parent.oauth.unauthorizeService(service);
        AppMobi.xdkBridge.exec('oauth.unauthorizeService',service);
}

AppMobi.OAuth.prototype.getProtectedData = function(parameters) {
	if( parameters == undefined )
	{
		throw(new Error("Error: AppMobi.oauth.getProtectedData: parameters is required."));
	}
	
	if( parameters.hasOwnProperty("service") == false || parameters.hasOwnProperty("url") == false || parameters.hasOwnProperty("id") == false 
	    || parameters.hasOwnProperty("method") == false || parameters.hasOwnProperty("body") == false || parameters.hasOwnProperty("headers") == false )
	{
		throw(new Error("Error: AppMobi.oauth.getProtectedData: invalid parameters object. Initialize using 'new AppMobi.Device.RemoteDataParameters'."));
	}
	
	if( parameters.service == undefined || parameters.service=='' )
	{
		throw(new Error("Error: AppMobi.oauth.getProtectedData requires a service property."));
	}
	
	if( parameters.url == undefined || parameters.url=='' )
	{
		throw(new Error("Error: AppMobi.oauth.getProtectedData requires a url property."));
	}
	
	if( parameters.method == undefined || (parameters.method.toUpperCase()!='GET' && parameters.method.toUpperCase()!='POST') )
	{
		throw(new Error("Error: AppMobi.oauth.getProtectedData requires a method property of GET or POST. body is ignored for GET requests."));
	}
	
	//w0ndow.parent.emulateOAuthGetProtectedData()
    //w0ndow.parent.oauth.getProtectedData();
    //w0ndow.parent.oauth.getProtectedData(parameters.service, parameters.url, parameters.id, parameters.method, parameters.body, parameters.headers);
    AppMobi.xdkBridge.exec("oauth.getProtectedData",parameters.service, parameters.url, parameters.id, parameters.method, parameters.body, parameters.headers);
	//throw(new Error('Error: AppMobi.OAuth.getProtectedData, OAuth is not implemented in the XDK at this time.'));
};

AppMobi.addConstructor(function() {
    if (typeof AppMobi.oauth == "undefined") AppMobi.oauth = new AppMobi.OAuth();
});

function getAppMobiObject()
{
	if( typeof AppMobi == "undefined" )
		return null;

	return AppMobi;
}

function getAppMobiDocument()
{
	return document;
}

//-==========================================================================/
//EXPERIMENTAL

AppMobi.xdkBridge = new Object();


AppMobi['_xdk_support'] = new Object();

    //======================================================================
    //GEOLOCATION TEST
    //======================================================================
    		if (navigator.geolocation) {
			navigator.geolocation.getCurrentPositionCopy = navigator.geolocation.getCurrentPosition;
		}

		AppMobi['_xdk_support'].geolocation = {
			interval : 5 * 1000, // five seconds for a default
			callbackFunctions : []
		}

	
		AppMobi['_xdk_support'].geolocation.getPositionHandler = function(eventData)
		{
			var callbackType = (eventData.success?'successCallback':'errorCallback');
			var currentIndex = null;
			var isWatch = null;
			for(i in AppMobi['_xdk_support'].geolocation.callbackFunctions)
			{
				currentIndex = i;
				if(eventData.id = 'all' || AppMobi['_xdk_support'].geolocation.callbackFunctions[currentIndex].id == eventData.id)
				{				
					if(typeof AppMobi['_xdk_support'].geolocation.callbackFunctions[currentIndex][callbackType] == 'function')
					{
                        ff = AppMobi['_xdk_support'].geolocation.callbackFunctions[currentIndex][callbackType];
                        ff(eventData.position);
                        AppMobi['_xdk_support'].geolocation.callbackFunctions[currentIndex][callbackType](eventData.position);
                    }
                    isWatch = AppMobi['_xdk_support'].geolocation.callbackFunctions[currentIndex].isWatch;
					break;
				}
			}
			
			if(currentIndex != null && !isWatch)
				AppMobi['_xdk_support'].geolocation.callbackFunctions = AppMobi['_xdk_support'].geolocation.callbackFunctions.slice(currentIndex);

		}
		document.addEventListener('appMobi.xdk.geolocation.position',AppMobi['_xdk_support'].geolocation.getPositionHandler, false);
		
		AppMobi['_xdk_support'].geolocation.getPosition = function(id,isWatch)
		{	
			if(isWatch == undefined)
				isWatch = false;
			getPosEvt = AppMobi.xdkBridge.createEvent('Events');
			getPosEvt.initEvent('appMobi.xdk.geolocation.getPosition', true, true);
            getPosEvt.id = id;
            getPosEvt.isWatch = isWatch;
            AppMobi.xdkBridge.dispatchEvent(getPosEvt);	
		}
		
		AppMobi['_xdk_support'].geolocation.addCallbacks= function(successCallback, errorCallback, options, isWatch)
		{	
			var uid = new Date().getTime();
    		uid += '_'+Math.floor(Math.random()*9999);
    		
			if(isWatch == undefined)
				isWatch = false;
			newCallbackSet = {'id':uid,'successCallback':successCallback, 'errorCallback':errorCallback, 'options':options, 'isWatch':isWatch, 'watchId':null};
			this.callbackFunctions.push(newCallbackSet);
			
			return uid;
		}
	
		AppMobi['_xdk_support'].geolocation.getCurrentPosition = function(successCallback, errorCallback, options)
		{
			AppMobi['_xdk_support'].geolocation.getPosition(AppMobi['_xdk_support'].geolocation.addCallbacks(successCallback, errorCallback, options, false))
		}
        
        AppMobi['_xdk_support'].geolocation.setWatchId = function(callbackId, watchId)
        {
        	for(i in AppMobi['_xdk_support'].geolocation.callbackFunctions)
			{
				if(callbackId == AppMobi['_xdk_support'].geolocation.callbackFunctions[i].id)
				{
					AppMobi['_xdk_support'].geolocation.callbackFunctions[i].watchId = watchId;
					break;
				}
			}
        
        }
        
		AppMobi['_xdk_support'].geolocation.watchPosition = function(successCallback, errorCallback, options)
		{
			watchInterval = AppMobi['_xdk_support'].geolocation.interval;
			if( options != null && typeof options == "object" && options.maximumAge != undefined )
				watchInterval = options.maximumAge;
			
			var callbackId = AppMobi['_xdk_support'].geolocation.addCallbacks(successCallback, errorCallback, options,true);			
			//AppMobi['_xdk_support'].geolocation.getPosition(callbackId,true);
			AppMobi['_xdk_support'].geolocation.getPosition(callbackId,false);
			
			var watchId = setInterval(function(){AppMobi['_xdk_support'].geolocation.getPosition(callbackId,true)}, watchInterval);
			AppMobi['_xdk_support'].geolocation.setWatchId(callbackId,watchId);
			return watchId;
		}

		AppMobi['_xdk_support'].geolocation.clearWatch = function(watchId)
		{
			for(i in AppMobi['_xdk_support'].geolocation.callbackFunctions)
			{
				if(watchId == AppMobi['_xdk_support'].geolocation.callbackFunctions[i].watchId)
				{
					AppMobi['_xdk_support'].geolocation.callbackFunctions = AppMobi['_xdk_support'].geolocation.callbackFunctions.slice(i);
					break;
				}
			}
			clearInterval(watchId);
		}
        
        		navigator.geolocation.getCurrentPosition = function(successCallback, errorCallback, options, calledFromWatch){
					AppMobi['_xdk_support'].geolocation.getCurrentPosition(successCallback, errorCallback, options, calledFromWatch);
				};
				navigator.geolocation.watchPosition = function(successCallback, errorCallback, options){
					return AppMobi['_xdk_support'].geolocation.watchPosition(successCallback, errorCallback, options);
				};
				navigator.geolocation.clearWatch = function(watchId){
					AppMobi['_xdk_support'].geolocation.clearWatch(watchId);
				};

    //======================================================================
    //GEOLOCATION TEST END
    //======================================================================
    
    
    
// MULTITOUCH SUPPORT
//----------------------------------------------------------------
AppMobi['_xdk_support'].currentTouchTarget = {};
AppMobi['_xdk_support'].mouseButtonsDown = {};

    
    AppMobi['_xdk_support'].redirectMouseToMultiTouch = function (type, originalEvent)
	{
        if(originalEvent.target.tagName.toUpperCase().indexOf("SELECT")==-1 && originalEvent.target.tagName.toUpperCase().indexOf("TEXTAREA")==-1&& originalEvent.target.tagName.toUpperCase().indexOf("INPUT")==-1)//SELECT, TEXTAREA & INPUT
        {
            originalEvent.stopPropagation();
        }
        
        originalEvent._xdk_target = originalEvent.target;
        
        var StoredEvent = AppMobi['_xdk_support'].multitouchPoints[originalEvent.button];
        if(type == 'touchstart' || type == 'touchmove')
        {
            if(type == "touchstart")
                	originalEvent.identifier = originalEvent.timeStamp;
            else if(type == "touchmove")
            {
                originalEvent.identifier =  StoredEvent.identifier;
                originalEvent._xdk_target = StoredEvent._xdk_target;
            }
            AppMobi['_xdk_support'].multitouchPoints[originalEvent.button] = originalEvent;
        }
        else if(type == 'touchend')
        {
            if(originalEvent.button != 0)
                originalEvent = StoredEvent;
            else
            {
                originalEvent.identifier =  StoredEvent.identifier;
                originalEvent._xdk_target = StoredEvent._xdk_target;
                //debugger;
            }
            
            delete AppMobi['_xdk_support'].multitouchPoints[originalEvent.button];
        }   
        //define changedTouches    
        
         var touchevt = document.createEvent("Event");
         touchevt.initEvent(type, true, true);
         
        touchevt.touches=new Array();
        touchevt.targetTouches=new Array();
        touchevt.changedTouches=new Array();
         
         
         touchevt.changedTouches[0]=new Object();
         touchevt.changedTouches[0].pageX=originalEvent.clientX;
         touchevt.changedTouches[0].pageY=originalEvent.clientY;
         touchevt.changedTouches[0].target=originalEvent._xdk_target;
         touchevt.changedTouches[0].identifier=originalEvent.identifier;
         touchevt.changedTouches[0].clientX=touchevt.changedTouches[0].pageX; //compatibility code
         touchevt.changedTouches[0].clientY=touchevt.changedTouches[0].pageY; //compatibility code
         
        for(evt in AppMobi['_xdk_support'].multitouchPoints)
        {
            var curEvent = AppMobi['_xdk_support'].multitouchPoints[evt];
            var tmpTouch = new Object();
            tmpTouch.pageX=curEvent.clientX;
            tmpTouch.pageY=curEvent.clientY;
            tmpTouch.target=curEvent._xdk_target;
            tmpTouch.identifier=curEvent.identifier;
            tmpTouch.clientX=curEvent.clientX; //compatibility code
            tmpTouch.clientY=curEvent.clientY; //compatibility code
                  
            touchevt.touches.push(tmpTouch);

            if(originalEvent._xdk_target === tmpTouch.target)
            {
                touchevt.targetTouches.push(tmpTouch);
            }
        }

        touchevt.target=originalEvent._xdk_target;
        originalEvent._xdk_target.dispatchEvent(touchevt);
        
        try
        {
            if(document['on'+type])
               document['on'+type](touchevt);
        }
        catch(e){}
	}
    
    
AppMobi['_xdk_support'].emulateTouchEvents = function()
{
    document.mouseMoving=false;
    document.mainTouchDown=false;
    
    // MOUSEDOWN LISTENER
    //-------------------------------------------
    document.addEventListener("mousedown", function(e)
    {
        var TouchEventType = undefined;
        try
        {                    
            if(e.button == 0) //button 0 is special
            {
                TouchEventType = "touchstart";
                this.mainTouchDown = true;
                this.mouseMoving=true;
                if(window.parent.MultiTouchEnabled)
                {
                    document.body.style.cursor = "url(http://localhost:58888/_emulator/0.gif),auto";
                    AppMobi['_xdk_support'].addMouseMarker(e.button, e.clientX, e.clientY);
                }
            }
            else if(window.parent.MultiTouchEnabled)
            {
                if(AppMobi['_xdk_support'].multitouchPoints[e.button] == undefined)
                {
                    AppMobi['_xdk_support'].addMouseMarker(e.button, e.clientX, e.clientY); //add visual maker (does not change data)
                    TouchEventType = "touchstart";
                }
                else
                {
                    AppMobi['_xdk_support'].removeMouseMarker(e.button); //remove visual maker (does not change data)
                    TouchEventType = "touchend";
                }
                
                AppMobi['_xdk_support'].mouseButtonsDown[e.button] = e.button;
            }

                   

            //fire off a touch event if needed
           if(TouchEventType != undefined)
           {
                AppMobi['_xdk_support'].currentTouchTarget[e.button] = e.target;
                AppMobi['_xdk_support'].redirectMouseToMultiTouch(TouchEventType, e);
           }
           
        }catch(e){ }
    });
    
    // MOUSEUP LISTENER
    //-------------------------------------------
    document.addEventListener("mouseup",function(e)
    {
        try
        {
            delete AppMobi['_xdk_support'].mouseButtonsDown[e.button]; 
            if(e.button == 0)
            {
                this.mouseMoving=false;
                this.mainTouchDown = false;
                
                if(window.parent.MultiTouchEnabled)
                {
                    AppMobi._xdk_support.removeMouseMarker(e.button);
                    document.body.style.cursor  = "auto";
                }   
                //fire off a touchend event
                AppMobi['_xdk_support'].redirectMouseToMultiTouch("touchend", e);
            }
           
            
            
           
        }
        catch(e){ }
    });

    // MOUSEMOVE LISTENER
    //-------------------------------------------
    document.addEventListener("mousemove",function(e)
    {
       try
       {
            if(!this.mouseMoving)                      
                return;

            if(window.parent.MultiTouchEnabled && this.mainTouchDown)
            {
                AppMobi['_xdk_support'].addMouseMarker(e.button, e.clientX, e.clientY);
                document.body.style.cursor = "url(http://localhost:58888/_emulator/0.gif),auto";
            }
            else
            {
                 document.body.style.cursor = "auto";
            }
            //fire off a touchstart event
            AppMobi['_xdk_support'].redirectMouseToMultiTouch("touchmove", e);
       }
       catch(e){ }
    });
    
    // CONTEXT MENU LISTENER
    //-------------------------------------------
    document.addEventListener("contextmenu",function(e)
    {
       try
        {
            if(window.parent.MultiTouchEnabled)
            {
                e.preventDefault();
                e.stopPropagation();
                return false;
            }
        }
       catch(e){ }
       return true;
    });

}
   
AppMobi['_xdk_support'].removeMouseMarker = function(number)
{
     var idPrefix = "_xdk_support_touchmarker_";
     
     var mouseMarker = document.getElementById('idPrefix'+number)
    if(mouseMarker != undefined)
    {
            mouseMarker.parentNode.removeChild(mouseMarker);
    }
}


AppMobi['_xdk_support'].setMarkerType = function(dtype)
{
    AppMobi['_xdk_support'].markerType = dtype;
    AppMobi['_xdk_support'].clearMultiTouchMarkers();
    
    for(var evt in AppMobi['_xdk_support'].multitouchPoints)
    {
        var curEvt = AppMobi['_xdk_support'].multitouchPoints[evt];
        AppMobi['_xdk_support'].addMouseMarker(curEvt.button, curEvt.clientX, curEvt.clientY); //add visual maker (does not change data)
    }
    
}

AppMobi['_xdk_support'].markerType = "thumb";

AppMobi['_xdk_support'].addMouseMarker = function(number, Xcoord, Ycoord, size)
{
    var colorArray = ['red','blue','green','purple','orange','yellow','plum'];
    
    
     if(AppMobi['_xdk_support'].markerType == "dot")
        var markerSize = 40;
    else
        var markerSize = 70;
    
    if(size != undefined)
        markerSize = size;
    var idPrefix = "_xdk_support_touchmarker_";
    var maxZIndex = "99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999";

    try
    {

        if(document.getElementById('idPrefix'+number) != undefined)
        {
            var mouseMarker = document.getElementById('idPrefix'+number);
        }
        else
        {
            if(AppMobi['_xdk_support'].markerType == "dot")
            {
                var mouseMarker = document.createElement('div');
                mouseMarker.innerHTML = number;
                mouseMarker.id = 'idPrefix'+number;
                mouseMarker.style.setProperty("background-image", "-webkit-gradient(linear, left bottom, left top, color-stop(0, #FFFFFF), color-stop(1, "+colorArray[number]+"))");
                mouseMarker.style.setProperty("border", "2px solid #666666");
                mouseMarker.style.setProperty("font-family", "Helvetica, Sans-Serif");
                mouseMarker.style.setProperty("text-shadow", "2px 2px 0px #eeeeee");
                mouseMarker.style.setProperty("color", "#333333");
                mouseMarker.style.textAlign = "center";
                mouseMarker.style.position = "absolute";
                mouseMarker.style.margin = "0px";
                mouseMarker.style.setProperty("padding-top", "1px");
                mouseMarker.style.setProperty("padding-left", "1px");
                mouseMarker.style.setProperty("user-select", "none");
                mouseMarker.style.setProperty("-webkit-user-select", "none");
                mouseMarker.style.zIndex = maxZIndex-1;
            
                mouseMarker.style.setProperty("font-size", parseInt(markerSize*0.85)+"px");
                mouseMarker.style.setProperty("-webkit-box-shadow", parseInt(markerSize*0.1)+"px "+parseInt(markerSize*0.1)+"px "+(markerSize/2)+"px 0px rgba(0,0,0,0.5)");
                mouseMarker.style.width = markerSize+"px";
                mouseMarker.style.height = markerSize+"px";
                mouseMarker.style.webkitBorderRadius = markerSize+'px';
            }
            else
            {
                var mouseMarker = document.createElement('img');
                mouseMarker.id = 'idPrefix'+number;
                
                if(number == 0)
                    mouseMarker.src = "http://localhost:58888/_emulator/_ide/images/multitouch/multimarker-touchmove.png";
                else
                    mouseMarker.src = "http://localhost:58888/_emulator/_ide/images/multitouch/multimarker-anchor.png";
                
                mouseMarker.style.position = "absolute";
                mouseMarker.style.zIndex = maxZIndex-1;
                mouseMarker.style.width = parseInt(markerSize*.8)+"px";
                mouseMarker.style.height = markerSize+"px";
                mouseMarker.style.cursor = "url(http://localhost:58888/_emulator/0.gif),auto";
            }
            mouseMarker.ondragstart = function(evt){evt.preventDefault(); return false;};
            mouseMarker.onselectstart= function(evt){evt.preventDefault(); return false;};
            
            document.body.appendChild(mouseMarker);
        }


        if(AppMobi['_xdk_support'].markerType == "dot")
        {
           mouseMarker.style.top = Ycoord-(markerSize/2)+"px";
           mouseMarker.style.left = Xcoord-(markerSize/2)+"px"; 
        }
        else
        {
            mouseMarker.style.top = Ycoord-(59/2)+"px";
            mouseMarker.style.left = Xcoord-(48/2)+"px";    
        }

    }
    catch(e)
    {
        console.log(e);
    }
}


AppMobi['_xdk_support'].clearMultiTouchMarkers = function()
{
    for(i = 0; i<=10; i++)
        AppMobi['_xdk_support'].removeMouseMarker(i);
}


AppMobi['_xdk_support'].multitouchPoints = {};
//----------------------------------------------------------------

AppMobi['_xdk_support'].initBridge = function(type)
{
    	//run constructors
	while (AppMobi._constructors.length > 0) {
		var constructor = AppMobi._constructors.shift();
		try {
			constructor();
		} catch(e) {
			if (typeof(AppMobi.debug['log']) == 'function')
				AppMobi.debug.log("Failed to run constructor: " + AppMobi.debug.processMessage(e));
			else
				alert("Failed to run constructor: " + e.message);
		}
	}
    
    //  REMOTE BRIDGE
    //==================================
    if(type == 'remote')
    {
        var uid = new Date().getTime();
        uid += '_'+Math.floor(Math.random()*99999999);
        var nif = document.createElement('iframe');
        nif.style.display = 'none';
        nif.style.height = '1px';
        nif.style.width = '1px';
        nif.style.border = '0px';
        nif.setAttribute('src', 'http://localhost:58888/_emulator/uniqueIdHandler.html#'+uid)
        document.body.appendChild(nif);
        
        
        AppMobi.xdkBridge = new AppMobi['_xdk_support'].commandBridge('remote');
        AppMobi.xdkBridge.connection.key = uid;
        AppMobi.xdkBridge.connection.server = 'http://127.0.0.1:58888/?CMD=COMET';
        AppMobi.xdkBridge.connection.txChannel = 'XDK';
        AppMobi.xdkBridge.connection.rxChannel = 'device';
        AppMobi.xdkBridge.connection.subscribe();
        console.log('RemoteBridge');
        

    }
    else if(type == 'remote2')
    {
        window.addEventListener('message', function(e) {
            
            if(e.data.substring(0,AppMobi.xdkBridge.messagePrefix.length) == AppMobi.xdkBridge.messagePrefix)
                eval(e.data.substring(AppMobi.xdkBridge.messagePrefix.length));
        }, false);
        AppMobi.xdkBridge = new AppMobi['_xdk_support'].commandBridge('remote2',undefined,"xdk_communication_message:");
    
        AppMobi.xdkBridge.connection.key = "http://localhost:58888";
        AppMobi.xdkBridge.connection.subscribe();

        AppMobi.xdkBridge.exec('deviceBridge.updateConnectionKey',window.location.origin);
        AppMobi.xdkBridge.exec('setLoadedPath', location.href.substr(0,location.href.lastIndexOf("/")+1));
       // AppMobi.xdkBridge.exec('deviceBridge.connection.subscribe');
        AppMobi.xdkBridge.exec('deviceBridge.bridgeEstablished');
        console.log('RemoteBridge2');
    }
    //  LOCAL BRIDGE
    //==================================
    else if(type == 'local')
    {
        window.parent.AppMobiMissing = false;
        console.log('LocalBridge');
        AppMobi.xdkBridge = new AppMobi['_xdk_support'].commandBridge('local','window.parent');
        AppMobi.xdkBridge.exec('deviceBridge.bridgeEstablished');
    }
 
 //AppMobi.xdkBridge.exec('emulateRefreshPushNotifications',true);
 AppMobi.native.emulateRefreshPushNotifications(true);
 setTimeout("AppMobi.setReady();", 1000); //1.0 sec dealy to simulate loading on a real device  //AppMobi.setReady();
setTimeout("AppMobi.device.hideSplashScreen();",15000); //15 sec splash timeout   
}

if(typeof window.parent.document == 'undefined')
    window.addEventListener('load', function(){AppMobi['_xdk_support'].initBridge('remote2');}, false);
else
window.addEventListener('load', function(){AppMobi['_xdk_support'].initBridge('remote2');}, false);
//   window.addEventListener('load', function(){initBridge('local');}, false);
   

//-------------===============


//-----------------------------


//================================================================================/
//setTimeout("AppMobi.setReady();", 1000); //1.0 sec dealy to simulate loading on a real device  //AppMobi.setReady();
//setTimeout("AppMobi.device.hideSplashScreen();",15000); //15 sec splash timeout


//================================================================
//  auto injected contents from '/_emulator/emu_core.js' 
//================================================================
if(AppMobi.native == undefined)
     AppMobi.native = new Object()
AppMobi.native.SERVERS = {"FACEBOOKHOST":"html5tools-software.intel.com/facebook","CLOUDSERVICES":"https://cservices.appmobi.com","XDK":"http://xdk-software.intel.com","SERVICES":"https://services.html5tools-software.intel.com","MARKETING":"https://www.html5dev-software.intel.com","FACEBOOK":"https://html5tools-software.intel.com/facebook","HUB":"https://appcenter.html5tools-software.intel.com","WEBSERVICES":"https://webservices.appmobi.com"};

//================================================================
// New Code to EMULATE API features in same js context as appmobi js
//================================================================
if(AppMobi == undefined)
   AppMobi = new Object;
if(AppMobi.native == undefined)
   AppMobi.native = new Object();
AppMobi.native.randomizer =function() {
	return "&rnd=" + Math.floor(Math.random()*99999999);
}

AppMobi.native.injectLocalScriptTag = function(script_src)
{
   var script = document.createElement("script");
   script.setAttribute("src",script_src);
   script.setAttribute("type","text/javascript");
   document.body.appendChild(script);     
}

//==============================================================================================================
//Device
//==============================================================================================================
AppMobi.native.emulateGetRemoteData = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback, unique_id)
{
    if(unique_id == undefined)
	unique_id = '';
   
   if(requestUrl.indexOf("http") != 0)
      requestUrl = AppMobi.webRoot+requestUrl
      
	var command = "http://localhost:58888/?CMD=GETREMOTEDATA&URL=" + escape(requestUrl) + "&TYPE=" + requestMethod;
	command += "&BODY=" + escape(requestBody)+ "&SUC=" + successCallback + "&ERR=" + errorCallback + "&UID=" + unique_id+AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
}

AppMobi.native.emulateGetRemoteDataExt = function(requestUrl, unique_id, requestMethod, requestBody, headers)
{
    if(unique_id == undefined)
	unique_id = '';
   
   if(requestUrl.indexOf("http") != 0)
      requestUrl = AppMobi.webRoot+requestUrl
            
	var command = "http://localhost:58888/?CMD=GETREMOTEDATAEXT&URL=" + escape(requestUrl) + "&TYPE=" + requestMethod;
	command += "&BODY=" + escape(requestBody) + "&HEADERS=" + escape(headers) + "&UID=" + unique_id + AppMobi.native.randomizer();

    AppMobi.native.injectLocalScriptTag(command);
}

AppMobi.native.emulateRegisterLibrary = function(moduleName)
{
	var command = "http://localhost:58888/?CMD=REGISTER_LIBRARY&MODULE=" + moduleName + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
}

AppMobi.native.emulatePluginExec = function(classNamefunctionName, params)
{
	var command = "http://localhost:58888/?CMD=PLUGIN_EXEC&CLASS=" + classNamefunctionName + "&PARAM=" + params + AppMobi.native.randomizer();
     AppMobi.native.injectLocalScriptTag(command);
}

AppMobi.native.emulateScanBarcode = function()
{
    var taskEvt = document.createEvent('Event');
    taskEvt.initEvent('appMobi.device.barcode.scan', true, true);
    taskEvt.success = true;
    taskEvt.codetype = "QR code";
    taskEvt.codedata = "http://www.sampleurl.com/fake.html";
    taskEvt.message = "This is sample barcode data.";
    document.dispatchEvent(taskEvt);
}
//==============================================================================================================
/* AppMobi.notification object */
//==============================================================================================================
AppMobi.native.emulateCheckPushUser = function(userID, password) {
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_CHECKUSER&USER=" + userID + "&PASS=" + password + "&APP=" + AppMobi.app +"&DEVICE=" + AppMobi.device.uuid +  AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
};

AppMobi.native.emulateAddPushUser = function(userID, password, email) {
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_ADDUSER&USER=" + userID + "&PASS=" + password + "&EMAIL=" + email + "&APP=" + AppMobi.app +"&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
};

 AppMobi.native.emulateDeletePushUser = function()
 {
	var command = "http://localhost:58888/?CMD=SDK_DELETE_PUSH_USER"+ "&APP=" + AppMobi.app +"&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
 }
 
AppMobi.native.emulateEditPushUser = function(newEmail, newPassword, newUserName)
{
   if(newUserName == undefined)
      newUserName = "";
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_EDITUSER&PASS=" + newPassword + "&EMAIL=" + newEmail + "&NEWUSER=" + newUserName + "&APP=" + AppMobi.app + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
};

AppMobi.native.emulateSendPushUserPass = function() {
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_SENDPASS" + "&APP=" + AppMobi.app + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
};


AppMobi.native.emulateSetPushUserAttributes = function(attributes)
{
   attributes = encodeURIComponent(attributes);
   	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_SET_USER_ATTRIBUTES" + "&ATTRIBUTES=" + attributes + "&APP=" + AppMobi.app + "&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
    
   /* var e = document.createEvent('Events');
    e.initEvent('appMobi.notification.push.user.editattributes',true,true);
    e.success=true;
    document.dispatchEvent(e);*/
}

AppMobi.native.emulateFindPushUser = function(userID, email) {
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_FINDUSER&USER=" + userID + "&EMAIL=" + email + "&APP=" + AppMobi.app + "&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
};

AppMobi.native.emulateRefreshPushNotifications = function(silent) {
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_REFRESH" + "&APP=" + AppMobi.app + "&SILENT=" + (silent?"true":'') + "&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
};

AppMobi.native.emulateDeletePushNotifications = function(notificationIDs, callMode) { 
    if(callMode != undefined && callMode.toUpperCase() == 'READ')
        callMode = 'READ';
    else
        callMode = 'DELETE';
        
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_DELETEMSGS" + "&IDS=" + notificationIDs + "&APP=" + AppMobi.app + "&DEVICE=" + AppMobi.device.uuid +"&CALLMODE="+ callMode + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
};

//AppMobi.native.emulateSendPushNotification = function(userID, message, data, richurl, richhtml, userkey, push_to_all, suppress_events) {
AppMobi.native.emulateSendPushNotification = function(userID, message, data) {
 /*   	if(userkey == undefined) userkey = "";
        if(richurl == undefined) richurl = '';
        if(richhtml == undefined) richhtml = '';
	var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_SENDMSG&USER=" + userID + "&MSG=" + message + "&DATA=" + data  + "&USERKEY=" + userkey + "&URL=" + richurl + "&HTML=" + richhtml+ "&APP=" + AppMobi.app + AppMobi.native.randomizer();
	if(push_to_all != undefined && push_to_all == true)
	    command += "&PUSH_ALL=1";
    if(suppress_events != undefined && suppress_events == true)
	    command += "&SUPPRESS_EVENTS=1";*/
 //userID = encodeURIComponent(userID);
 //   message = encodeURIComponent(message);
  // data = encodeURIComponent(data);
 var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_SENDMSG_DEVICE&USER=" + userID + "&MSG=" + message + "&DATA=" + data  + "&APP=" + AppMobi.app + "&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
	
    AppMobi.native.injectLocalScriptTag(command);
};


AppMobi.native.emulateSendPushNotificationXDK = function(userID, message, data, richurl, richhtml, userkey, push_to_all, messageMode) {
   	if(userkey == undefined) userkey = "";
        if(richurl == undefined) richurl = '';
        if(richhtml == undefined) richhtml = '';
	/*var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_SENDMSG&USER=" + userID + "&MSG=" + message + "&DATA=" + data  + "&USERKEY=" + userkey + "&URL=" + richurl + "&HTML=" + richhtml+ "&APP=" + AppMobi.app + AppMobi.native.randomizer();
	if(push_to_all != undefined && push_to_all == true)
	    command += "&PUSH_ALL=1";
    if(suppress_events != undefined && suppress_events == true)
	    command += "&SUPPRESS_EVENTS=1";
    
    AppMobi.native.injectLocalScriptTag(command);
    */
    var command = "http://localhost:58888/?CMD=COMMAND_SDK_PUSH_SENDMSG_XDK&MESSAGE_MODE="+ messageMode +"&USER=" + userID + "&MSG=" + message + "&DATA=" + data  + "&USERKEY=" + userkey + "&URL=" + richurl + "&HTML=" + richhtml+ "&APP=" + AppMobi.app + "&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
	
    AppMobi.native.injectLocalScriptTag(command);
};

 AppMobi.native.emulateRefreshUserPushNotifications = function(userID, password, device, newerThan)
 {
   	var command = "http://localhost:58888/?CMD=SDK_PUSH_REFRESH_USER_NOTIFICATIONS&USER=" + userID + "&DEVICE_PARAM=" + device + "&NEWERTHAN=" + newerThan + "&PASS=" + password + "&APP=" + AppMobi.app +"&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
 }
 
  AppMobi.native.emulatebroadcastPushNotification = function(message, data, attributes, skip)
  {
   attributes = encodeURIComponent(attributes);
   message = encodeURIComponent(message);
   data = encodeURIComponent(data);
   
    var command = "http://localhost:58888/?CMD=SDK_PUSH_BROADCAST_NOTIFICATION&MESSAGE=" + message + "&DATA=" + data + "&ATTR=" + attributes + "&SKIP=" + skip + "&APP=" + AppMobi.app + "&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
   
  }
  
  //USED ONLY BY THE XDK 
  AppMobi.native.emulateAsyncPushReceive = function()
  {
    var command = "http://localhost:58888/?CMD=SDK_PUSH_ASYNC_RECEIVE"+ "&APP=" + AppMobi.app + "&DEVICE=" + AppMobi.device.uuid + AppMobi.native.randomizer();
    AppMobi.native.injectLocalScriptTag(command);
  }

//==================================================================================================
// FILE FUNCTIONS
//==================================================================================================
     AppMobi.native.emulateFileUpload = function(url, uploadurl, foldername, mime, callback)
    {
        var command = "http://localhost:58888/?CMD=SDK_FILE_UPLOAD"+"&URL="+escape(url)+"&UPLOADURL="+escape(uploadurl)+"&FOLDERNAME="+escape(foldername)+"&MIME="+escape(mime)+"&CALLBACK="+callback+AppMobi.native.randomizer();
        AppMobi.native.injectLocalScriptTag(command); 
    }
    
     AppMobi.native.emulateFileCancelUpload = function()
    {
        var command = "http://localhost:58888/?CMD=SDK_FILE_CANCEL_UPLOAD"+AppMobi.native.randomizer();
        AppMobi.native.injectLocalScriptTag(command);
    }
    
     AppMobi.native.getFileUploadStatus = function()
    {
        var command = "http://localhost:58888/?CMD=SDK_FILE_UPLOAD_STATUS"+AppMobi.native.randomizer();
         AppMobi.native.injectLocalScriptTag(command);
    }


//==================================================================================================
// PURCHASE FUNCTIONS
//=================================================================================================
AppMobi.native.emulatePurchaseProduct = function(productId, quan, user)
{
   device = AppMobi.device.uuid;
   tmpAppName = AppMobi.app;
  // tmpAppName = "sbbingo.app";
           var command = "http://localhost:58888/?CMD=PURCHASE_PRODUCT&APPNAME="+tmpAppName+"&PRODUCTID="+productId+"&USER="+user+"&QUANTITY="+quan+"&DEVICE="+device+AppMobi.native.randomizer();
         AppMobi.native.injectLocalScriptTag(command);
   
   
   console.log("ProductID: "+productId+"   QUAN: "+quan+"    User: "+user);
   
}

//==================================================================================================
// PACKAGE CACHE FUNCTIONS
//==================================================================================================
AppMobi.native.emulateCachePackage = function(packageDir, packageURL)
{
   var command = "http://localhost:58888/?CMD=CACHE_PACKAGE&DIR="+packageDir+"&URL="+packageURL+AppMobi.native.randomizer();
   AppMobi.native.injectLocalScriptTag(command);
}

AppMobi.native.getCachePackageStatus = function(url)
{
   var command = "http://localhost:58888/?CMD=CACHE_PACKAGE_STATUS&URL=" + escape(url) + AppMobi.native.randomizer();
   AppMobi.native.injectLocalScriptTag(command);
}


//===============================================================
//  AUDIO STUFF - (not to be confused with sound)
//===============================================================
AppMobi.native.audioPlr = null;
AppMobi.native.audioPlrCurrentTime = 0;
AppMobi.native.audioPlrLoop = false;
AppMobi.native.emulateStopAudio = function()
{
	if( AppMobi.native.audioPlr == null ) return;

	var evt = document.createEvent('Event');
	evt.initEvent('appMobi.player.audio.stop', true, true);
	document.dispatchEvent(evt);

	AppMobi.native.audioPlr.pause();
	AppMobi.native.audioPlr = null;
}


AppMobi.native.emulateStartAudio = function(strRelativeFileURL, shouldLoop)
{
 	if( strRelativeFileURL.length == 0 )
	{
		var evt = document.createEvent('Event');
		evt.initEvent('appMobi.player.audio.error', true, true);
		document.dispatchEvent(evt);
		return;
	}
    
   AppMobi.xdkBridge.exec('emulateCheckIfAudioBusy', strRelativeFileURL, shouldLoop);
}

document.addEventListener("appMobi.xdk.player.audio.busy", function(data){ AppMobi.native.emulateStartAudioContinue(data);}, false);


AppMobi.native.emulateStartAudioContinue = function(data)
{
   //retreve data needed to play file from the event data (eventually all the other audio/player code should move to AppMobi.native or similar)
   strRelativeFileURL = data.fileName;
   shouldLoop = data.shouldLoop;
   audioBusy = data.busy;
   loadedPath = data.loadedPath;
   
	if( AppMobi.native.audioPlr != null ) AppMobi.native.emulateStopAudio();

	if(audioBusy)
	{
		var evt = document.createEvent('Event');
		evt.initEvent('appMobi.player.audio.busy', true, true);
		document.dispatchEvent(evt);
		return;
	}

	var url = loadedPath + strRelativeFileURL;
	if( strRelativeFileURL.indexOf( "_mediacache") > -1 )
		url = "http://localhost:58888/" + strRelativeFileURL;

    AppMobi.native.audioPlr = new Audio(url);
    if(shouldLoop) AppMobi.native.audioPlr.loop =  true;
    AppMobi.native.audioPlr.addEventListener("ended", AppMobi.native.emulateStopAudio, false);
    AppMobi.native.audioPlr.load();
    
    //audioPlr.addEventListener('progress', startAudioAfterLoad ,false);
   //setTimeout("AppMobi.native.startAudioAfterLoad()", 10);
   AppMobi.native.audioPlr.addEventListener("loadeddata",AppMobi.native.startAudioAfterLoad, false);

}


AppMobi.native.startAudioAfterLoad = function()
{
    if(AppMobi.native.audioPlr.buffered.length == 0)
    {
        //console.log("BUFFER EMPTY");
        setTimeout("AppMobi.native.startAudioAfterLoad()", 10);
    }
    else
    {
    AppMobi.native.audioPlr.removeEventListener ('progress', AppMobi.native.startAudioAfterLoad ,false);
    AppMobi.native.audioPlr.currentTime = AppMobi.native.audioPlrCurrentTime;
    AppMobi.native.audioPlr.play();
    var evt = document.createEvent('Event');
	evt.initEvent('appMobi.player.audio.start', true, true);
	document.dispatchEvent(evt);
    }
}

AppMobi.native.emulateSetAudioCurrentTime = function(timeMark)
{
   // audioPlr.pause();
   AppMobi.native.audioPlrCurrentTime = timeMark;
   
   if(AppMobi.native.audioPlr != null)
    AppMobi.native.audioPlr.currentTime = AppMobi.native.audioPlrCurrentTime;
   
    var evt = document.createEvent('Event');
	evt.initEvent('appMobi.player.audio.currenttime.set', true, true);
	document.dispatchEvent(evt);
}


AppMobi.native.emulateToggleAudio = function()
{
	if( AppMobi.native.audioPlr == null ) return;

	if( AppMobi.native.audioPlr.paused )
		AppMobi.native.audioPlr.play();
	else
		AppMobi.native.audioPlr.pause();
}

AppMobi.native.populateAudioInfo = function()
{
   AppMobi.player.audioInfo.currentTime = (AppMobi.native.audioPlr != null)?AppMobi.native.audioPlr.currentTime:0;
    AppMobi.player.audioInfo.duration = (AppMobi.native.audioPlr != null)?AppMobi.native.audioPlr.duration:0;
   
}

//===============================================================
//  FACEBOOK
//===============================================================
   AppMobi.native.Facebook = {};
   AppMobi.native.Facebook.busy = false;
   AppMobi.native.Facebook.frictionless = false;
   AppMobi.native.Facebook.busyError = function()
   {
      console.log("XDK Message: FACEBOOK IS BUSY!");
      var e = document.createEvent('Events');
      e.initEvent('appMobi.facebook.busy',true,true);
      document.dispatchEvent(e);
   }
   
   AppMobi.native.Facebook.initCommunicationFrame = function()
   {  
    	console.log("Initialzing Facebook Communication Frame");
        var fbf = document.createElement('iframe');
        fbf.id = "appMobi_Facebook_Communication_Frame";
        fbf.style.display = "none";
        fbf.style.zIndex = "2147483647";  //2147483647 max z-index browsers
        fbf.style.width = "100%";
        fbf.style.height = "100%";
        fbf.style.top = '0px';
        fbf.style.left = '0px';
        fbf.style.position= 'absolute';
        document.body.appendChild(fbf);
    }
    
    AppMobi.native.Facebook.setCommunicationFrameUrl = function(url)
    {
       document.getElementById("appMobi_Facebook_Communication_Frame").src = url;
    }
    
    
    
   AppMobi.native.Facebook.callbackComplete = function()
   {
      //AppMobi.native.Facebook.windowType = undefined;
      AppMobi.native.Facebook.busy = false;
      document.getElementById('appMobi_Facebook_Communication_Frame').style.display = 'none';
   }
   
   
    AppMobi.native.Facebook.login = function(scope)
    {
    
      if(AppMobi.native.Facebook.busy)
         return AppMobi.native.Facebook.busyError();
      else
         AppMobi.native.Facebook.busy = true;
               
       var args =[]
   
   
      params = {};
      params.display = "dialog"; 
      params.scope = (typeof(scope) == "undefined" || scope.length == 0 )?"publish_stream,publish_actions,offline_access":scope;
      args.push(params);
      AppMobi.native.Facebook.apiCall('login',args, 'login');
    }
    
    AppMobi.native.Facebook.appRequest = function(params)
	{
      if( typeof(params) == "undefined" || typeof( params ) != "object")
         params = {};        
      params.method = 'apprequests';
      AppMobi.native.Facebook.ui(params, 'apprequest');
    }
    
    AppMobi.native.Facebook.api = function(path, httpMethod, parameters)
    {
      if(AppMobi.native.Facebook.busy)
         return AppMobi.native.Facebook.busyError();
      else
         AppMobi.native.Facebook.busy = true;
               
      //FBData = {'path':path, 'parameters':parameters, 'method': httpMethod};
      //dataToSend = encodeURIComponent(AppMobi.native.Base64.encode(JSON.stringify(FBData)));
      var args =[]
      if(path != undefined)args.push(path);
      if(httpMethod != undefined)args.push(httpMethod);
      if(parameters != undefined)args.push(parameters);
   
      AppMobi.native.Facebook.apiCall('api',args, 'request.response');
   }
   
   
     AppMobi.native.Facebook.ui = function(params, responseType)
    {
      if(AppMobi.native.Facebook.busy)
         return AppMobi.native.Facebook.busyError();
      else
         AppMobi.native.Facebook.busy = true;
      
      if( typeof(params) == "undefined" || typeof( params ) != "object" ) params = {};        
      params.display = "dialog"; //popup
      dataToSend = encodeURIComponent(AppMobi.native.Base64.encode(JSON.stringify(params)));
      AppMobi.native.Facebook.apiCall('ui',[params], responseType);
   }
   
   
     AppMobi.native.Facebook.logout = function(params)
    {
      if(AppMobi.native.Facebook.busy)
         return AppMobi.native.Facebook.busyError();
      else
         AppMobi.native.Facebook.busy = true;
         
      AppMobi.native.Facebook.apiCall('logout',[],'logout');
   }
   
   AppMobi.native.Facebook.handleResponse = function(eventName,success,responseData,extra,remainbusy)
   {
      if(remainbusy == undefined || remainbusy == false)
         AppMobi.native.Facebook.callbackComplete();
	  
      var e = document.createEvent('Events');
      e.initEvent('appMobi.facebook.'+eventName,true,true);
      e.success=success;
      if(responseData != undefined)
         e.data=responseData;
       
      if(extra == undefined)
         extra = {};
      
      for(i in extra)
      {
         if(e[i] == undefined)
            e[i] = extra[i];
      }
      document.dispatchEvent(e);
      
   }
   
   AppMobi.native.Facebook.apiCall = function(func,args,responseType)
   {
         var apiDat = {'func':func,'args':args,'responseType':responseType};
         var dataToSend = encodeURIComponent(AppMobi.native.Base64.encode(JSON.stringify(apiDat)));
         var callback= encodeURIComponent("http://localhost:58888/facebook.html");
          document.getElementById('appMobi_Facebook_Communication_Frame').style.display = 'block';
         AppMobi.native.Facebook.setCommunicationFrameUrl("//"+AppMobi.native.SERVERS.FACEBOOKHOST+"/facebook/default.aspx?cmd=fbxdk&apicall=true&appname="+AppMobi.app+"&data="+dataToSend+"&callback="+callback);
   }
   
    //=================================================================================
    // BASE 64
    //=================================================================================
    
    AppMobi.native.Base64 = {
 
	// private property
	_keyStr : "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=",
 
	// public method for encoding
	encode : function (input) {
		var output = "";
		var chr1, chr2, chr3, enc1, enc2, enc3, enc4;
		var i = 0;
 
		input = AppMobi.native.Base64._utf8_encode(input);
 
		while (i < input.length) {
 
			chr1 = input.charCodeAt(i++);
			chr2 = input.charCodeAt(i++);
			chr3 = input.charCodeAt(i++);
 
			enc1 = chr1 >> 2;
			enc2 = ((chr1 & 3) << 4) | (chr2 >> 4);
			enc3 = ((chr2 & 15) << 2) | (chr3 >> 6);
			enc4 = chr3 & 63;
 
			if (isNaN(chr2)) {
				enc3 = enc4 = 64;
			} else if (isNaN(chr3)) {
				enc4 = 64;
			}
 
			output = output +
			this._keyStr.charAt(enc1) + this._keyStr.charAt(enc2) +
			this._keyStr.charAt(enc3) + this._keyStr.charAt(enc4);
 
		}
 
		return output;
	},
 
	// public method for decoding
	decode : function (input) {
		var output = "";
		var chr1, chr2, chr3;
		var enc1, enc2, enc3, enc4;
		var i = 0;
 
		input = input.replace(/[^A-Za-z0-9\+\/\=]/g, "");
 
		while (i < input.length) {
 
			enc1 = this._keyStr.indexOf(input.charAt(i++));
			enc2 = this._keyStr.indexOf(input.charAt(i++));
			enc3 = this._keyStr.indexOf(input.charAt(i++));
			enc4 = this._keyStr.indexOf(input.charAt(i++));
 
			chr1 = (enc1 << 2) | (enc2 >> 4);
			chr2 = ((enc2 & 15) << 4) | (enc3 >> 2);
			chr3 = ((enc3 & 3) << 6) | enc4;
 
			output = output + String.fromCharCode(chr1);
 
			if (enc3 != 64) {
				output = output + String.fromCharCode(chr2);
			}
			if (enc4 != 64) {
				output = output + String.fromCharCode(chr3);
			}
 
		}
 
		output = AppMobi.native.Base64._utf8_decode(output);
 
		return output;
 
	},
 
	// private method for UTF-8 encoding
	_utf8_encode : function (string) {
		string = string.replace(/\r\n/g,"\n");
		var utftext = "";
 
		for (var n = 0; n < string.length; n++) {
 
			var c = string.charCodeAt(n);
 
			if (c < 128) {
				utftext += String.fromCharCode(c);
			}
			else if((c > 127) && (c < 2048)) {
				utftext += String.fromCharCode((c >> 6) | 192);
				utftext += String.fromCharCode((c & 63) | 128);
			}
			else {
				utftext += String.fromCharCode((c >> 12) | 224);
				utftext += String.fromCharCode(((c >> 6) & 63) | 128);
				utftext += String.fromCharCode((c & 63) | 128);
			}
 
		}
 
		return utftext;
	},
 
	// private method for UTF-8 decoding
	_utf8_decode : function (utftext) {
		var string = "";
		var i = 0;
		var c = c1 = c2 = 0;
 
		while ( i < utftext.length ) {
 
			c = utftext.charCodeAt(i);
 
			if (c < 128) {
				string += String.fromCharCode(c);
				i++;
			}
			else if((c > 191) && (c < 224)) {
				c2 = utftext.charCodeAt(i+1);
				string += String.fromCharCode(((c & 31) << 6) | (c2 & 63));
				i += 2;
			}
			else {
				c2 = utftext.charCodeAt(i+1);
				c3 = utftext.charCodeAt(i+2);
				string += String.fromCharCode(((c & 15) << 12) | ((c2 & 63) << 6) | (c3 & 63));
				i += 3;
			}
 
		}
 
		return string;
	}
 
}


//================================================================
//  auto injected contents from '/_emulator/bridge.js' 
//================================================================
AppMobi['_xdk_support'].commandBridge = function(bridgeType,localPrefix, messagePrefix)
{
   this.bridge_type = bridgeType;
   this.local_prefix = localPrefix; //ex: frm.contentWindow.document
   this.REMOTE = (this.bridge_type == 'remote');
   this.LOCAL = (this.bridge_type == 'local');
   this.REMOTE2 = (this.bridge_type == 'remote2');
   this.connection = null;
   this.messagePrefix = ((messagePrefix == undefined)?"xdkMessagePrefix:":messagePrefix);
   
   
   if(this.REMOTE)
   {
      if(this.connection == null)
      {
         this.connection = new AppMobi['_xdk_support'].comet();
         this.connection.txChannel = 'device';
         this.connection.rxChannel = 'XDK';
         this.connection.key = '';
         //this.connection.subscribe();
         // this.connection.send("AppMobi.available = true;");
         
      }
     /* else
      {
         this.connection.keyChange(newKey)
      }*/
     
     var self = this;
      document.addEventListener("co"+"met.subscribed",function(){self.bridgeEstablished()},false);
   }
   else if(this.REMOTE2)
   {
      if(this.connection == null)
      {
         var self = this;
         document.addEventListener("xdk"+"Messenger.subscribed",function(){self.bridgeEstablished()},false);
         this.connection = new xdkMessenger(this.local_prefix);
      }
      this.REMOTE = true;
   }
   else
   {
      var self = this;
     // setTimeout(function(){self.bridgeEstablished();},750);
   }
   
}

AppMobi['_xdk_support'].commandBridge.prototype.updateConnectionKey = function(newKey)
{
   //console.log("NEW KEY: "+newKey);
   if(!this.connection.subscribed)
   {
      this.connection.key = newKey;
      this.connection.subscribe();
   }
   else
      this.connection.keyChange(newKey);
}

AppMobi['_xdk_support'].commandBridge.prototype.sanitize = function(obj)
{
    if(typeof obj == undefined)
         return undefined;
    else if(typeof obj == 'string')
    {
      obj= obj.replace(new RegExp( "\\\\", "g" ), "\\\\");   
      obj= obj.replace(new RegExp( "\\r", "g" ), "\\r"); 
      obj= obj.replace(new RegExp( "\\n", "g" ), "\\n"); 
      obj= obj.replace(new RegExp( "'", "g" ), "\\'");   
        return ("'"+obj+"'");
    }
    else if(typeof obj == 'object')
        return JSON.stringify(obj);
    else
        return obj.toString();
}

AppMobi['_xdk_support'].commandBridge.prototype.createEvent = function(type)
{
   //-----==== LOCAL ====-----//
   if(this.LOCAL)
   {
      localObj = eval(this.local_prefix+".document");
     return localObj.createEvent(type);
   }
   //-----==== REMOTE ====-----//
   else if(this.REMOTE)
   {
     newEvt = new Object();
     newEvt['__event_obj_data__'] = {'type':type};
     newEvt.initEvent = function(name, bubbles, cancelable)
     {
         this['__event_obj_data__'].name = name;
         this['__event_obj_data__'].bubbles = bubbles;
         this['__event_obj_data__'].cancelable = cancelable;
     }
     return newEvt;
   }

}


AppMobi['_xdk_support'].commandBridge.prototype.dispatchEvent = function(eventObj)
{
   //-----==== LOCAL ====-----//
   if(this.LOCAL)
   {
      localObj = eval(this.local_prefix+".document");
      localObj.dispatchEvent(eventObj);
   }
   //-----==== REMOTE ====-----//
   else if(this.REMOTE)
   {
      type = eventObj['__event_obj_data__'].type;
      name = eventObj['__event_obj_data__'].name;
      bubbles = eventObj['__event_obj_data__'].bubbles;
      cancelable = eventObj['__event_obj_data__'].cancelable;
      
      var command = "var newEvent = document.createEvent('"+type+"');\r\n";
      command += "newEvent.initEvent('"+name+"',"+bubbles+","+cancelable+");\r\n";
      
      for(i in eventObj)
      {
          if(i != "initEvent" && i != "__event_obj_data__")
          {
              evntxtra = "newEvent['"+i+"']="+this.sanitize(eventObj[i]);
              command += evntxtra+";\r\n";  
          }
      }
      
      command += "document.dispatchEvent(newEvent);";
      // alert(command);
      if(this.test)
         window.parent.postMessage(command,'http://localhost:58888');
      else
         this.connection.send(this.messagePrefix+command);
      //newEvent.success=false;newEvent.cancelled=true;
   }
}

AppMobi['_xdk_support'].commandBridge.prototype.injectScriptTag = function(script_src)
{
     //-----==== LOCAL ====-----//
   if(this.LOCAL)
   {
      
      localObj = eval(this.local_prefix+".document");
      var script = localObj.createElement("script");
      script.setAttribute("src",script_src);
      script.setAttribute("type","text/javascript");
      localObj.body.appendChild(script);
   }
   //-----==== REMOTE ====-----//
   else if(this.REMOTE)
   {
      command = "var script = document.createElement('script');"+
      "script.setAttribute('src',"+this.sanitize(script_src)+");"+
      "script.setAttribute('type','text/javascript');"+
      "document.body.appendChild(script);";
       this.connection.send(this.messagePrefix+command);
   }
}

AppMobi['_xdk_support'].commandBridge.prototype.assignVar = function (varName, varValue)
{
   //-----==== LOCAL ====-----//
   if(this.LOCAL)
   {
      //alert(this.local_prefix+"."+varName+"="+this.sanitize(varValue)+";");
      eval(this.local_prefix+"."+varName+"="+this.sanitize(varValue)+";");
   }
   //-----==== REMOTE ====-----//
   else if(this.REMOTE)
   {
      var command = varName+"="+this.sanitize(varValue)+";\r\n";
      this.connection.send(this.messagePrefix+command);
   }
}

AppMobi['_xdk_support'].commandBridge.prototype.eval = function(code,targetView)
{
   if(targetView == undefined || targetView != 'main')
      targetView = '';
   
  if(this.LOCAL)
  {
   
   //alert(this.local_prefix+"."+code);
   
   //eval(this.local_prefix+"."+code); // OLD WAY NOW WORKING RIGHT
     localObj = eval(this.local_prefix);
     localObj.eval(code);
  }
  else if(this.REMOTE)
  {
     this.connection.send(this.messagePrefix+code,targetView); 
  }
}

AppMobi['_xdk_support'].commandBridge.prototype.exec = function()
{
    var args = arguments;
    
     var remcomand = args[0]+"(";
     for (var i = 1; i < args.length; i++)
     {
        var arg = args[i];
        
        if (arg == undefined || arg == null)
            arg = '';

         remcomand += this.sanitize(arg);
         remcomand += (i == args.length -1)?"":",";
    }
    remcomand += ");";

   //console.log(remcomand);
   //-----==== LOCAL ====-----//
   if(this.LOCAL)
   {
      eval(this.local_prefix+"."+remcomand);
   }
   //-----==== REMOTE ====-----//
   else if(this.REMOTE)
   {
      this.connection.send(this.messagePrefix+remcomand);
   }

};
    
AppMobi['_xdk_support'].commandBridge.prototype.bridgeEstablished = function()
{
      var newEvent = document.createEvent('Events');
      newEvent.initEvent('command'+'Bridge.connected',true,true);
      document.dispatchEvent(newEvent);
}
                
            
            
//================================================================
//  auto injected contents from '/_emulator/xdkMessenger.js' 
//================================================================
xdkMessenger = function(windowObj,server){
this.key =  (server != undefined)?server:'';
this.subscribed = true;
this.windowObj = windowObj;
this.dataQueue = [];
this.sendBusy = false;
}


//SEND
xdkMessenger.prototype.send = function(data,targetView)
{
      if(targetView == undefined)
         targetView = '';
   
   this.dataQueue[this.dataQueue.length] = {'target':targetView,'data':data};
   if(this.sendBusy || this.key == "")
    {       
       return;		
    }
    this.sendBusy = true;
    self = this;
    
    while(self.dataQueue.length > 0)
    {
            
    data2 = self.dataQueue.shift();
    dataTarget = data2.target;
    data2 = data2.data;
   try{
   //console.log("XDK Message: "+data+"\r\n KEY:"+this.key+"\r\n");
   //var obj = eval(this.windowObj);
   

   
   if(this.windowObj == undefined)
       window.parent.postMessage(data2,this.key);
   else
   {
      
      ccc =  document.getElementById("em-frm");
      ccc.contentWindow.postMessage(data2,this.key);
      
      if(dataTarget != 'main')
      {
         ccc =  document.getElementById("em-srs"); //HACK TO SEND MESSAGES TO SHOW REMOTE SITE AS WELL
         ccc.contentWindow.postMessage(data2,this.key);
      }

   }
   }catch(e){}
    }
    
      this.sendBusy = false;
}

//Event "Launcher"
xdkMessenger.prototype.fireEvent = function(eventName)
{ 
      var newEvent = document.createEvent('Events');
      newEvent.initEvent("xdk"+"Messenger."+eventName,true,true);
      document.dispatchEvent(newEvent);
}

//SUBSCRIBE TO A SPECIFIC "CHANNEL"
xdkMessenger.prototype.subscribe = function(channel)
{
      this.subscribed = true;
      this.fireEvent('subscribed');
}

//SEND
xdkMessenger.prototype.keyChange = function(newKey)
{
  this.key = newKey;
}


AppMobi.app = 'demo.HelloWorld';AppMobi.release = '3.4.0';AppMobi.webRoot = 'http://localhost:58888/demo.HelloWorld/3.4.0/';AppMobi._hasAnalytics = true;AppMobi._hasCaching = true;AppMobi._hasStreaming = true;AppMobi._hasAdvertising = true;AppMobi._hasOAuth = false;AppMobi.oauthAvailable = false;
AppMobi.picturelist=[];