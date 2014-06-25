if (typeof(AppMobiInit) != 'object')
    AppMobiInit = {};

if(!window.createGUID){
	function createGUID() {
		return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
			var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
			return v.toString(16);
		});
	}
}

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
	jsVersion: '3.4.0',
	revision: 9
};

/**
 * Boolean flag indicating if the AppMobi API is available and initialized.
 */
AppMobi.isnative = false;
AppMobi.isxdk = false;
AppMobi.istest = false;
AppMobi.ischrome = false;
AppMobi.isfacebook = false;
AppMobi.isphone = false;
AppMobi.istablet = false;
AppMobi.isweb = false;
AppMobi.isamazon = false;
AppMobi.isgoogle = false;
AppMobi.isintel = false;
AppMobi.ismozilla = false;
AppMobi.available = false;
AppMobi.oauthAvailable = false;
AppMobi.paymentsAvailable = false;
AppMobi.updateAvailable = false;
AppMobi.updateMessage = "";
AppMobi.app = "";
AppMobi.release = "";
AppMobi.package = "";
AppMobi.webRoot = "";

AppMobi.cookies = {};
AppMobi.mediacache = [];
AppMobi.notifications = [];
AppMobi.people = [];
AppMobi.picturelist = [];
AppMobi.recordinglist = [];
AppMobi.playingtrack = {};

// Local Storage
function supports_local_storage() {
    try {
        return 'localStorage' in window && window['localStorage'] !== null;
    } catch (e) {
        return false;
    }
}

AppMobi.hasLocalStorage = supports_local_storage();

/**
 * Add an initialization function to a queue that ensures it will run and initialize
 * application constructors only once AppMobi has been initialized.
 * @param {Function} func The function callback you want run once AppMobi is initialized
 */
AppMobi.addConstructor = function(func) {
};

/**
 * Execute a AppMobi command in a queued fashion, to ensure commands do not
 * execute with any race conditions, and only run when AppMobi is ready to
 * recieve them.
 * @param {String} command Command to be run in AppMobi, e.g. "ClassName.method"
 * @param {String[]} [args] Zero or more arguments to pass to the method
 */
AppMobi.exec = function() {
};

/**
 * Internal function used to dispatch the request to AppMobi.  This needs to be implemented per-platform to
 * ensure that methods are called on the phone in a way appropriate for that device.
 * @private
 */
AppMobi.run_command = function() {
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
}

/**
 * Asynchronously acquires the acceleration repeatedly at a given interval.
 * @param {Function} successCallback The function to call each time the acceleration
 * data is available
 * @param {AccelerationOptions} options The options for getting the accelerometer data
 * such as timeout.
 */
AppMobi.Accelerometer.prototype.watchAcceleration = function(successCallback, options) {
}

/**
 * Clears the specified accelerometer watch.
 * @param {String} watchId The ID of the watch returned from #watchAcceleration.
 */
AppMobi.Accelerometer.prototype.clearWatch = function(watchId) {
};

if (typeof AppMobi.accelerometer == "undefined") AppMobi.accelerometer = new AppMobi.Accelerometer();

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

AppMobi.Contacts.prototype.getContacts = function()
{
	AppMobi.stubEvent('contacts.get');
}

AppMobi.Contacts.prototype.addContact = function()
{
	AppMobi.stubEvent('contacts.add');
}

AppMobi.Contacts.prototype.chooseContact = function()
{
	AppMobi.stubEvent('contacts.choose');
}

AppMobi.Contacts.prototype.editContact = function(contactID)
{
	AppMobi.stubEvent('contacts.edit', {'error':'contacts not available on web','contactid':contactID});
}

AppMobi.Contacts.prototype.removeContact = function(contactID)
{
	AppMobi.stubEvent('contacts.remove', {'error':'contacts not available on web','contactid':contactID});
}

if (typeof AppMobi.contacts == "undefined") AppMobi.contacts = new AppMobi.Contacts();

AppMobi.Advertising = function() {
};

AppMobi.Advertising.prototype.getAd = function(name, path, callbackId) {
};

AppMobi.Advertising.prototype.runPromotion = function(appname, storeurl, promotion, protocol, package, query) {
    if( typeof( appname ) != "string" || appname.length == 0 ||
        typeof( storeurl ) != "string" || storeurl.length == 0 ||
        typeof( promotion ) != "string" || promotion.length == 0 ||
        typeof( protocol ) != "string" || protocol.length == 0 ||
        typeof( package ) != "string" || package.length == 0 )
		throw(new Error("Error: AppMobi.advertising.runPromotion, appname, storeurl, promotion, protocol and package are required."));

	if( query == undefined || query.length == 0 ) query = "";

	var runPromoData  = "XPROMO_CLICK";
	runPromoData += "~"+AppMobi.app;//appName
	runPromoData += "~"+AppMobi.release;//relName
	runPromoData += "~"+AppMobi.device.uuid;//DeviceId
	runPromoData += "~"+AppMobi.helper.getTime();//TimeStamp
	runPromoData += "~"+AppMobi.helper.getOsType();//OS
	runPromoData += "~"+AppMobi.helper.identifyBrowser(undefined,0).browser;//Model
	runPromoData += "~"+AppMobi.helper.identifyBrowser(undefined,0).version;//System Version
	runPromoData += "~"+AppMobi.analytics.ipAddress;//Local IP
	runPromoData += "~"+appname;//appname passed into function
	runPromoData += "~"+'_'+AppMobi.device.uuid;//'Encrypted' DeviceID
	runPromoData += "~"+promotion;//Promotion data passed into function

	var XclickUrl = "https://queue.amazonaws.com/668107645782/appmobi_xpromo_clickthrough?Action=SendMessage&MessageBody=" + runPromoData + "&Version=2009-02-01";
	AppMobi.helper.loadURL(XclickUrl);
};

if (typeof AppMobi.advertising == "undefined") AppMobi.advertising = new AppMobi.Advertising();

AppMobi.AudioInfo = function(currentTime, duration) {
	this.currentTime = currentTime;
	this.duration = duration;
};

/**
 * This class provides access to the appMobiPlayer
 * @constructor
 */
AppMobi.Player = function() {
	this.currentTime = 0;
	this.audioInfo = new AppMobi.AudioInfo(0, 0);
	this.sounds = {};
	this.audio = { "player":null, "playing":false };
};

AppMobi.Player.prototype.show = function()
{
    AppMobi.stubEvent('player.show', {'error':'player.show not available on web'});
};

AppMobi.Player.prototype.hide = function()
{
	AppMobi.stubEvent('player.hide', {'error':'player.show not available on web'});
};

AppMobi.Player.prototype.playPodcast = function(strPodcastURL)
{
	AppMobi.stubEvent('player.podcast.error', {'error':'player.playPodcast not available on web'});
};

AppMobi.Player.prototype.startStation = function(strNetStationID, boolResumeMode, boolShowPlayer) {

	AppMobi.stubEvent('player.station.error', {'error':'player.startStation not available on web'});
};

AppMobi.Player.prototype.playSound = function(strRelativeFileURL) {
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

	//hack for intel, because of problem with replaying sounds
	if(AppMobi.isintel) {
		soundarray[0].player = new Audio(strRelativeFileURL);
		soundarray[0].player.load();
		soundarray[0].playing = false;
		soundarray[0].lasttime = 0;
	}
		
	soundarray[index].player.pause();
	if( soundarray[index].player.currentTime != 0 ) {
		soundarray[index].player.currentTime = 0;
	}
	soundarray[index].player.play();
	soundarray[index].lasttime = new Date();
};

AppMobi.Player.prototype.loadSound = function(strRelativeFileURL, count) {
	if(!count)count=1;
	AppMobi.player.sounds[strRelativeFileURL] = [];
	var soundarray = AppMobi.player.sounds[strRelativeFileURL];
	for( var a = 0; a < count; a++ )
	{
		soundarray[a] = {};
		soundarray[a].player = new Audio(strRelativeFileURL);
		soundarray[a].player.load();
		soundarray[a].playing = false;
		soundarray[a].player.id=a;
		soundarray[a].player.addEventListener("timeupdate", function(e){
			console.log(strRelativeFileURL+'['+this.id+'] currentTime:'+this.currentTime);
		}, false);
		soundarray[a].lasttime = 0;
	}
};

AppMobi.Player.prototype.unloadSound = function(strRelativeFileURL) {
	delete AppMobi.player.sounds[strRelativeFileURL];
};

AppMobi.Player.prototype.unloadAllSounds = function() {
	AppMobi.player.sounds = {};
};

AppMobi.Player.prototype.startAudio = function(strRelativeFileURL, boolLoop) {
	if( AppMobi.player.audio.player != null )
	{
		AppMobi.player.audio.player.pause();
		AppMobi.player.audio.player = null;
	}

	AppMobi.player.audio.player = new Audio(strRelativeFileURL);
	AppMobi.player.audio.player.load();
	if( AppMobi.player.currentTime != 0 ) AppMobi.player.audio.player.currentTime = AppMobi.player.currentTime;
	AppMobi.player.audio.player.loop = boolLoop;
	AppMobi.player.audio.player.play();
	AppMobi.player.audio.player.playing = true;
	AppMobi.player.audio.playing = true;
};

AppMobi.Player.prototype.toggleAudio = function() {
	if( AppMobi.player.audio.player == null ) return;

	if( AppMobi.player.audio.player.playing == true )
	{
		AppMobi.player.audio.player.pause();
		AppMobi.player.audio.player.playing = false;
	}
	else
	{
		AppMobi.player.audio.player.play();
		AppMobi.player.audio.player.playing = true;
	}
};

AppMobi.Player.prototype.stopAudio = function() {
	if( AppMobi.player.audio.player == null ) return;

	AppMobi.player.audio.player.pause();
	AppMobi.player.audio.player = null;
	AppMobi.player.audio.playing = false;
};

AppMobi.Player.prototype.setAudioCurrentTime = function(time) {
	AppMobi.player.currentTime = time;
	if( AppMobi.player.audio.player != null )
	{
		AppMobi.player.audio.player.currentTime = time;
	}
};

AppMobi.Player.prototype.getAudioCurrentTime = function(successCallback) {
	var time = 0;
	if( AppMobi.player.audio.player != null )
	{
		time = AppMobi.player.audio.player.currentTime;
	}

	return time;
};

AppMobi.Player.prototype.watchAudioCurrentTime = function(successCallback, frequency) {
};

AppMobi.Player.prototype.clearAudioCurrentTimeWatch = function(watchId) {
};

AppMobi.Player.prototype.play = function() {
AppMobi.stubEvent('player.station.error');
};

AppMobi.Player.prototype.pause = function() {

};

AppMobi.Player.prototype.stop = function() {
};

AppMobi.Player.prototype.volume = function(iPercentage) {
};

AppMobi.Player.prototype.rewind = function() {
};

AppMobi.Player.prototype.ffwd = function() {
};

AppMobi.Player.prototype.setColors = function(strBackColor, strFillColor, strDoneColor, strPlayColor) {
};

AppMobi.Player.prototype.setPosition = function(portraitX, portraitY, landscapeX, landscapeY) {
};

AppMobi.Player.prototype.startShoutcast = function(strStationURL, boolShowPlayer) {
AppMobi.stubEvent('player.shoutcast.error');
};

if (typeof AppMobi.player == "undefined") AppMobi.player = new AppMobi.Player();

/**
 * This class provides access to the appMobiStats
 * @constructor
 */
AppMobi.Stats = function() {
};

AppMobi.Stats.prototype.logEvent = function(message) {
};

if (typeof AppMobi.stats == "undefined") AppMobi.stats = new AppMobi.Stats();

/**
 * This class provides access to the appMobiAnalytics
 * @constructor
 */
AppMobi.Analytics = function() {
	this.queueLink = "";
	this.analyticsQueue = {};
	this.uniqueId = "";
	this.hasConnection = true;
	this.ipAddress = "127.0.0.1";
};

AppMobi.Analytics.prototype.initialize = function() {
	AppMobi.analytics.uniqueId = AppMobi.device.uuid;
	//this.queueLink = AppMobi.internal.analyticsServer;
	var tmpQueue = AppMobi.cache.getCookie('statMobiQueue');
	if( typeof( tmpQueue ) != "undefined" )
		AppMobi.analytics.analyticsQueue = JSON.parse(tmpQueue);
}

AppMobi.Analytics.prototype.eventObj = function() {
	return {
	   date:'',
	   time:'',
	   ip:'',
	   uniqueId:AppMobi.analytics.uniqueId,
	   method:'GET',
	   uri:'-',
	   query:'-',
	   status:'200',
	   bytes:'0',
	   userAgent:navigator.userAgent,
	   referer:window.location
	}
};

AppMobi.Analytics.prototype.processQueue = function() {
	  var that=this;
	  var running=true;
	  if(!AppMobi.analytics.hasConnection||!AppMobi.analytics.queueLink)
		 return;
	  else{
			try{
		   //todo...make sure events don't get lost with an offline connection
		   var tmpQueue=AppMobi.analytics.analyticsQueue;
		   for(var key in tmpQueue)
		   {
			  if(!running)
				return;
			  var obj=tmpQueue[key];
			  var string=obj.date.replace(/ /g,'+')+' '+obj.time.replace(/ /g,'+')+' '+obj.ip.replace(/ /g,'+')+' '+obj.uniqueId.replace(/ /g,'+')+' '+obj.method.replace(/ /g,'+')+' '+obj.uri.replace(/ /g,'+')+' '+obj.query.replace(/ /g,'+')+' '+obj.status.replace(/ /g,'+')+' '+obj.bytes+' '+obj.userAgent.replace(/ /g,'+')+' '+obj.referer.replace(/ /g,'+');
			  var script=document.createElement('script');
			  script.src=AppMobi.analytics.queueLink+'?Action=SendMessage&MessageBody='+encodeURIComponent(string)+'&Version=2009-02-01';
			  script.tmpId=key;
              script.type="text/xml";
			  script.onload=function(){
				delete that.analyticsQueue[this.tmpId];
				this.parentNode.removeChild(this);
				if(window.JSON)
					AppMobi.cache.setCookie('statMobiQueue',JSON.stringify(that.analyticsQueue),-1);
			  }
			  script.onerror=function(){
					that.setOffline();
					running=false;
			  }
			  var head= document.getElementsByTagName('head')[0];
			  head.appendChild(script);
		   }
	   }
	   catch(e){}
   }
};

AppMobi.Analytics.prototype.processQueue = function() {
	  var that=this;
	  var running=true;
	  if(!AppMobi.analytics.hasConnection||!AppMobi.analytics.queueLink)
		 return;
	  else{
			try{
		   //todo...make sure events don't get lost with an offline connection
		   var tmpQueue=AppMobi.analytics.analyticsQueue;
		   for(var key in tmpQueue)
		   {
			  if(!running)
				return;
			  var obj=tmpQueue[key];
			  var string=obj.date.replace(/ /g,'+')+' '+obj.time.replace(/ /g,'+')+' '+obj.ip.replace(/ /g,'+')+' '+obj.uniqueId.replace(/ /g,'+')+' '+obj.method.replace(/ /g,'+')+' '+obj.uri.replace(/ /g,'+')+' '+obj.query.replace(/ /g,'+')+' '+obj.status.replace(/ /g,'+')+' '+obj.bytes+' '+obj.userAgent.replace(/ /g,'+')+' '+obj.referer.replace(/ /g,'+');
			  var script=document.createElement('script');
			  script.src=AppMobi.analytics.queueLink+'?Action=SendMessage&MessageBody='+encodeURIComponent(string)+'&Version=2009-02-01';
			  script.tmpId=key;
			  script.onload=function(){
				delete that.analyticsQueue[this.tmpId];
				this.parentNode.removeChild(this);
				if(window.JSON)
					AppMobi.cache.setCookie('statMobiQueue',JSON.stringify(that.analyticsQueue),-1);
			  }
			  script.onerror=function(){
					that.setOffline();
					running=false;
			  }
			  var head= document.getElementsByTagName('head')[0];
			  script.type= 'text/html';
			  head.appendChild(script);
		   }
	   }
	   catch(e){}
   }
};

AppMobi.Analytics.prototype.setOffline = function() {
	this.hasConnection=false;
	var that=this;
	window.setTimeout(function(){that.processQueue();},1000*60*3);
};

AppMobi.Analytics.prototype.logEvent = function(eventID,queryString)
{
	try
	{
	   if (queryString==null) { queryString = ''; }
			AppMobi.analytics.logPageEvent('/application/'+eventID+'.event', queryString);
	}
	catch(e){}
}

AppMobi.Analytics.prototype.logPageEvent = function(page, query, status, method, bytes, referrer) {
   if(!status)
	  status='200';
   if(!method)
	  method='GET';
   if(!bytes)
	  bytes='0';
   if(!referrer)
	  referrer=window.location.href;
   if(!query)
	  query='-'
   var d = new Date();
   var eventObj = AppMobi.analytics.eventObj();
   var month=(d.getMonth()+1);
   if(month<10)
	 month='0'+month;
   var day=(d.getDate());
   if(day<10)
	 day='0'+day;
   var hours=(d.getHours());
   if(hours<10)
	 day='0'+hours;
   var minutes=(d.getMinutes());
   if(minutes<10)
	 minutes='0'+minutes;
   var seconds=(d.getSeconds());
   if(seconds<10)
	 seconds='0'+seconds;
   eventObj.date=d.getFullYear()+'-'+(month)+'-'+day;
   eventObj.time=hours+':'+minutes+':'+seconds;
   eventObj.ip=AppMobi.analytics.ipAddress;
   eventObj.status=status;
   eventObj.uri=page;
   eventObj.query=query;
   eventObj.method=method;
   eventObj.bytes=bytes;
   eventObj.referer=referrer;
   AppMobi.analytics.analyticsQueue['trans_'+createGUID()]=eventObj;
   if(window.JSON){
   try{
	AppMobi.cache.setCookie('statMobiQueue',JSON.stringify(AppMobi.analytics.analyticsQueue),365,null,null,null,true);
	}
	catch(e){}
	}
   if(AppMobi.analytics.hasConnection)
	  AppMobi.analytics.processQueue();
};AppMobi.analytics

if (typeof AppMobi.analytics == "undefined") AppMobi.analytics = new AppMobi.Analytics();

/**
 * This class provides access to the appMobiCalendar
 * @constructor
 */
AppMobi.Calendar = function() {
};

AppMobi.Calendar.prototype.addEvent = function(title, start, end) {
};

if (typeof AppMobi.calendar == "undefined") AppMobi.calendar = new AppMobi.Calendar();

/**
 * This class provides access to the appMobiFile
 * @constructor
 */
AppMobi.File = function() {
};

AppMobi.File.prototype.uploadToServer = function(localURL, uploadURL, foldername, mimetype, updateCallback) {
};


AppMobi.File.prototype.cancelUpload = function() {
};

if (typeof AppMobi.file == "undefined") AppMobi.file = new AppMobi.File();

/**
 * This class provides access to the appMobiSpeech
 * @constructor
 */
AppMobi.Speech = function() {
};

AppMobi.Speech.prototype.recognize = function(longPause, language) {
};

AppMobi.Speech.prototype.stopRecording = function() {
};

AppMobi.Speech.prototype.vocalize = function(text, voiceName, language) {
};

AppMobi.Speech.prototype.cancel = function() {
};

if (typeof AppMobi.speech == "undefined") AppMobi.speech = new AppMobi.Speech();

/**
 * This class provides access to the appMobiCamera
 * @constructor
 */
AppMobi.Camera = function() {
};

AppMobi.Camera.prototype.takePicture = function(quality, saveToLib, picType)
{
	AppMobi.stubEvent('camera.picture.add');
};

AppMobi.Camera.prototype.importPicture = function() {
	AppMobi.stubEvent('camera.picture.add');
};

AppMobi.Camera.prototype.deletePicture = function(picURL) {
	AppMobi.stubEvent('camera.picture.remove');
};

AppMobi.Camera.prototype.clearPictures = function() {
	AppMobi.stubEvent('camera.picture.clear');
};

AppMobi.Camera.prototype.getPictureList = function() {
	return [];
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
		localURL = AppMobi.webRoot+'_pictures/'+filename;
	return localURL;
}

if (typeof AppMobi.camera == "undefined") AppMobi.camera = new AppMobi.Camera();

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
 * This class provides access to the appMobiCache
 * @constructor
 */
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
			localURL = AppMobi.webRoot+'_mediacache/'+localURL[localURL.length-1];
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
};

AppMobi.Cache.prototype.addToMediaCacheImpl = function(url, ID) {
};

AppMobi.Cache.prototype.addToMediaCache = function(url) {
};

AppMobi.Cache.prototype.addToMediaCacheExt = function(url, ID) {
};

AppMobi.Cache.prototype.removeFromMediaCache = function(url) {
};

if (typeof AppMobi.cache == "undefined") AppMobi.cache = new AppMobi.Cache();

/**
 * This class provides access to the appMobi native GL canvas
 * @constructor
 */
AppMobi.Canvas = function() {
	this.isHidden = true;
};

AppMobi.Canvas.prototype.load = function(strRelativeFileURL) {
};

AppMobi.Canvas.prototype.show = function() {
	AppMobi.canvas.isHidden = false;
};

AppMobi.Canvas.prototype.hide = function() {
	AppMobi.canvas.isHidden = true;
};

AppMobi.Canvas.prototype.execute = function(strJavascript) {
};

AppMobi.Canvas.prototype.eval = function(strJavascript) {
};

AppMobi.Canvas.prototype.reset = function() {
};

AppMobi.Canvas.prototype.setFramesPerSecond = function(fps) {
};

AppMobi.Canvas.prototype.setFPS = function(fps) {
};

AppMobi.Canvas.prototype.forwardTouchEvent = function(event)
{
}

if (typeof AppMobi.canvas == "undefined") AppMobi.canvas = new AppMobi.Canvas();

/**
 * This class provides access to the appMobi in-app purchasing system
 * @constructor
 */
AppMobi.Purchasing = function() {
};

AppMobi.Purchasing.prototype.purchaseProduct = function(productId, quantity, user) {
};

if (typeof AppMobi.purchasing == "undefined") AppMobi.purchasing = new AppMobi.Purchasing();

/**
 * This class provides access to the debugging console.
 * @constructor
 */
AppMobi.Debug = function() {
}

/**
 * Utility function for rendering and indenting strings, or serializing
 * objects to a string capable of being printed to the console.
 * @param {Object|String} message The string or object to convert to an indented string
 * @private
 */
AppMobi.Debug.prototype.processMessage = function(message) {
    if (typeof(message) != 'object') {
        return message;
    } else {
        /**
         * @function
         * @ignore
         */
        function indent(str) {
            return str.replace(/^/mg, "    ");
        }
        /**
         * @function
         * @ignore
         */
        function makeStructured(obj) {
            var str = "";
            for (var i in obj) {
                try {
                    if (typeof(obj[i]) == 'object') {
                        str += i + ":\n" + indent(makeStructured(obj[i])) + "\n";
                    } else {
                        str += i + " = " + indent(String(obj[i])).replace(/^    /, "") + "\n";
                    }
                } catch(e) {
                    str += i + " = EXCEPTION: " + e.message + "\n";
                }
            }
            return str;
        }
        return "Object:\n" + makeStructured(message);
    }
};

/**
 * Print a normal log message to the console
 * @param {Object|String} message Message or object to print to the console
 */
AppMobi.Debug.prototype.log = function(message) {
	console.log(message);
};

/**
 * Print a warning message to the console
 * @param {Object|String} message Message or object to print to the console
 */
AppMobi.Debug.prototype.warn = function(message) {
	console.error(message);
};

/**
 * Print an error message to the console
 * @param {Object|String} message Message or object to print to the console
 */
AppMobi.Debug.prototype.error = function(message) {
	console.error(message);
};

if (typeof AppMobi.debug == "undefined") AppMobi.debug = new AppMobi.Debug();

/**
 * this represents the mobile device, and provides properties for inspecting the model, version, UUID of the
 * phone, etc.
 * @constructor
 */
AppMobi.Device = function() {
    this.available = AppMobi.available;
    this.platform = "Web";
    this.osversion = "";
    this.model = "Desktop";
    this.uuid = createGUID();
    this.initialOrientation = "";
    this.appmobiversion = AppMobi.jsVersion;
    this.phonegapversion = "";
    this.orientation = 90;
    this.connection = "NET";
    this.density = "";
    this.lastPlaying = "";
    this.hasAnalytics = true;
    this.hasCaching = true;
    this.hasStreaming = true;
    this.hasAdvertising = true;
    this.hasPush = true;
    this.hasPayments = true;
    this.hasUpdates = true;
    this.landwidth = "";
    this.landheight = "";
    this.portwidth = "";
    this.portheight = "";
    this.width = 0;
    this.height = 0;
    this.queryString = "";
    
    try
    {
        this.landwidth = window.innerWidth;
    	this.landheight = window.innerHeight;
   	 	this.portwidth = window.innerHeight;
    	this.portheight = window.innerWidth;
    	this.width = window.innerWidth;
    	this.height = window.innerHeight;
    }
    catch(exp)
    {
    }
}

AppMobi.Device.prototype.initialize = function() {
	var srsf = document.createElement('iframe');
	srsf.id = "em-srs";
	srsf.style.position = "absolute";
	srsf.style.display = "none";
	srsf.style.width = window.innerWidth + "px";
	srsf.style.height = window.innerHeight + "px";
	srsf.style.left = "0px";
	srsf.style.top = "0px";
	srsf.style.scrolling = 'no';
	srsf.style.overflow = "hidden";
	srsf.style.border = "0px";
	srsf.style.zIndex = 15000;
	srsf.style.background = "#FFF";
	document.body.appendChild(srsf);

	var crsi = document.createElement('image');
	crsi.id = "em-crs";
		crsi.imgdata = 'data:image/png;base64, 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';
	crsi.onclick = AppMobi.device.closeRemoteSite;
	crsi.style.position = "absolute";
	crsi.style.display = "none";
	crsi.style.zIndex = 15001;
	document.body.appendChild(crsi);
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
};

AppMobi.Device.prototype.setAutoRotate = function(shouldAutoRotate) {
};

AppMobi.Device.prototype.setRotateOrientation = function(orientation) {
};

AppMobi.Device.prototype.updateConnection = function() {
};

AppMobi.Device.prototype.setBasicAuthentication = function(host, username, password) {
};

AppMobi.Device.prototype.addVirtualPage = function() {
};

AppMobi.Device.prototype.removeVirtualPage = function() {
};

AppMobi.Device.prototype.addMenuItem = function(text, callback) {
};

AppMobi.Device.prototype.registerLibrary = function(strDelegateName) {
};

AppMobi.Device.prototype.launchExternal = function(strURL) {
};

AppMobi.Device.prototype.showRemoteSite = function(strURL, closePortX, closePortY, closeWidth, closeHeight) {
		AppMobi.device.showRemoteSiteExt(strURL, closePortX, closePortY, closePortX, closePortY, closeWidth, closeHeight, "");
};

AppMobi.Device.prototype.showRemoteSiteExt = function(strURL, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight, closeImage) {

		if( typeof( closeImage ) != "string" || closeImage.length == 0 ) closeImage = document.getElementById('em-crs').imgdata;
	document.getElementById('em-crs').style.left = closePortX + "px";
	document.getElementById('em-crs').style.top = closePortY + "px";
	document.getElementById('em-crs').src = closeImage;
	document.getElementById('em-crs').style.display = "block";

	document.getElementById('em-srs').style.display = "block";
	document.getElementById('em-srs').src = strURL;
};

AppMobi.Device.prototype.closeRemoteSite = function() {
	document.getElementById('em-srs').style.display = "none";
	document.getElementById('em-crs').style.display = "none";
};

AppMobi.Device.prototype.mainViewExecute = function(strMsg) {
};

AppMobi.Device.prototype.blockRemotePages = function(shouldblock, whitelist) {
};

AppMobi.Device.prototype.scanBarcode = function() {
};

AppMobi.Device.prototype.runInstallNativeApp = function(appname, runcommand, installurl, bundleid) {
};

AppMobi.Device.prototype.sendEmail = function(body, to, subject, ishtml, cc, bcc) {
};

AppMobi.Device.prototype.sendSMS = function(body, to) {
};

AppMobi.Device.prototype.setOrientation = function(orientation) {
};

AppMobi.Device.prototype.getRemoteDataImpl = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback, id, hasId) {
};

AppMobi.Device.prototype.getRemoteDataWithId = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback, id) {
};

AppMobi.Device.prototype.getRemoteDataWithID = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback, id) {
};

AppMobi.Device.prototype.getRemoteData = function(requestUrl, requestMethod, requestBody, successCallback, errorCallback) {
};

AppMobi.Device.prototype.getRemoteDataExt = function(parameters) {
};

AppMobi.Device.prototype.installUpdate = function() {
};

AppMobi.Device.prototype.hideSplashScreen = function() {
};

AppMobi.Device.prototype.hideStatusBar = function() {
};

AppMobi.Device.prototype.cachePackage = function(subdir, url) {
};

if (typeof AppMobi.device == "undefined") AppMobi.device = new AppMobi.Device();


if (typeof AppMobi.geolocation == "undefined") AppMobi.geolocation = navigator.geolocation;

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

/**
 * Open a native alert dialog, with a customizable title and button text.
 * @param {String} message Message to print in the body of the alert
 * @param {String} [title="Alert"] Title of the alert dialog (default: Alert)
 * @param {String} [buttonLabel="OK"] Label of the close button (default: OK)
 */
AppMobi.Notification.prototype.alert = function(message, title, button) {
	alert(message);
};

AppMobi.Notification.prototype.confirm = function(message, id, title, ok, cancel) {
};

/**
 * Causes the device to vibrate.
 */
AppMobi.Notification.prototype.vibrate = function() {
};

/**
 * Causes the device to beep.
 * @param {Integer} count The number of beeps.
 */
AppMobi.Notification.prototype.beep = function(count) {
};

AppMobi.Notification.prototype.showBusyIndicator = function() {
};

AppMobi.Notification.prototype.hideBusyIndicator = function() {
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
	AppMobi.stubEvent('notification.push.enable',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.addPushUser = function(userID, password, email) {
	AppMobi.stubEvent('notification.push.enable',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.editPushUser = function(newEmail, newPassword, newUser) {
	AppMobi.stubEvent('notification.push.user.edit',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.deletePushUser = function() {

	AppMobi.stubEvent('notification.push.disable',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.sendPushUserPass = function() {
	AppMobi.stubEvent('notification.push.sendpassword',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.setPushUserAttributes = function(attributes) {
	AppMobi.stubEvent('notification.push.user.editattributes',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.findPushUser = function(userID, email) {
	AppMobi.stubEvent('notification.push.user.find',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.refreshPushNotifications = function() {
	AppMobi.stubEvent('notification.push.refresh',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.refreshUserPushNotifications = function(user, pass, device, newerthan) {
	AppMobi.stubEvent('notification.push.userrefresh',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.readPushNotifications = function(notificationIDs) {
	AppMobi.stubEvent('notification.push.read',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.deletePushNotifications = function(notificationIDs) {
	AppMobi.stubEvent('notification.push.delete',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.sendPushNotification = function(userID, message, data) {
	AppMobi.stubEvent('notification.push.send',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.broadcastPushNotification = function(message, data, attributes, skip) {
	AppMobi.stubEvent('notification.push.broadcast',{'message':'Push Messaging not available on web'});
};

AppMobi.Notification.prototype.showRichPushViewer = function(notificationID, closePortX, closePortY, closeLandX, closeLandY, closeWidth, closeHeight) {
};

AppMobi.Notification.prototype.closeRichPushViewer = function() {
};

if (typeof AppMobi.notification == "undefined") AppMobi.notification = new AppMobi.Notification();


AppMobi.Display = function () {
    this.viewport = {};
    this.oldviewport = {};
    this.doc = document;
    this.window = {};
    this.window.landwidth = 0;
    this.window.portwidth = 0;
    this.window.landheight = 0;
    this.window.portheight = 0;
};

AppMobi.Display.prototype.startAR = function () {
};

AppMobi.Display.prototype.stopAR = function () {
};

AppMobi.Display.prototype.updateViewportContent = function (content) {
    //get reference to head
    var head, heads = AppMobi.display.doc.getElementsByTagName('head');
    if (heads.length > 0) head = heads[0];
    else return;
    //remove any viewport meta tags
    var metas = AppMobi.display.doc.getElementsByTagName('meta');
    for (var i = 0; i < metas.length; i++) {
        if (metas[i].name == 'viewport') try { head.removeChild(metas[i]); } catch (e) { }
    }
    //add the new viewport meta tag
    var viewport = AppMobi.display.doc.createElement('meta');
    viewport.setAttribute('name', 'viewport');
    viewport.setAttribute('id', 'viewport');
    viewport.setAttribute('content', content);
    head.appendChild(viewport);
}

AppMobi.Display.prototype.updateViewportOrientation = function (orientation) {
    var width;
    if (orientation == 0 || orientation == 180) {
        width = AppMobi.display.viewport.portraitWidth;
    } else {
        width = AppMobi.display.viewport.landscapeWidth;
    }
    var content = "width=" + width + ",maximum-scale=10.0,user-scalable=no";
    //AppMobi.debug.log("****"+content);
    AppMobi.display.updateViewportContent(content);
}

AppMobi.Display.prototype.viewportOrientationListener = function (e) {
    AppMobi.display.updateViewportOrientation(AppMobi.device.orientation);
}

/*
* @param portraitWidthInPx
* @param landscapeWidthInPx
*/
AppMobi.Display.prototype.useViewport = function (portraitWidthInPx, landscapeWidthInPx) {
    /// <param name='widthPortrait'></param>

    /// <param name='widthLandscape'></param>
    AppMobi.display.viewport.portraitWidth = parseInt(portraitWidthInPx);
    AppMobi.display.viewport.landscapeWidth = parseInt(landscapeWidthInPx);
    if (isNaN(AppMobi.display.viewport.portraitWidth) || isNaN(AppMobi.display.viewport.landscapeWidth)) return;
    document.addEventListener('appMobi.device.orientation.change', AppMobi.display.viewportOrientationListener, false);
    AppMobi.display.updateViewportOrientation(AppMobi.device.orientation);
};

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

AppMobi.Display.prototype.updateViewportContent = function (content) {
    //get reference to head
    var head, heads = AppMobi.display.doc.getElementsByTagName('head');
    if (heads.length > 0) head = heads[0];
    else return;
    //remove any viewport meta tags
    var metas = AppMobi.display.doc.getElementsByTagName('meta');
    for (var i = 0; i < metas.length; i++) {
        if (metas[i].name == 'viewport') try { head.removeChild(metas[i]); } catch (e) { }
    }
    //add the new viewport meta tag
    var viewport = AppMobi.display.doc.createElement('meta');
    viewport.setAttribute('name', 'viewport');
    viewport.setAttribute('id', 'viewport');
    viewport.setAttribute('content', content);
    head.appendChild(viewport);
}

AppMobi.Display.prototype.updateViewportOrientation = function (orientation) {
    var width;
    if (orientation == 0 || orientation == 180) {
        width = AppMobi.display.viewport.portraitWidth;
    } else {
        width = AppMobi.display.viewport.landscapeWidth;
    }
    var content = "width=" + width + ",maximum-scale=10.0,user-scalable=no";
    //AppMobi.debug.log("****"+content);
    AppMobi.display.updateViewportContent(content);
}

if( typeof AppMobi.display == "undefined" ) AppMobi.display = new AppMobi.Display();

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

	this.headers[name]=value;
};

AppMobi.OAuth.prototype.unauthorizeService = function(service) {
	AppMobi.cache.removeCookie("ServiceToken_"+service);
	AppMobi.cache.removeCookie("ServiceSecret_"+service);
}

AppMobi.OAuth.prototype.getProtectedData = function(parameters) {
	if(!parameters.service||parameters.service.length==0)
		throw(new Error("Service name is required for getProtectedData"));
	if(!parameters.url||parameters.url.length==0)
		throw(new Error("URL is required for getProtectedData"));
	if(!parameters.id||parameters.id.length==0)
		throw(new Error("ID is required for getProtectedData"));

	if(AppMobi.oauth.internal.processing){
		var e=document.createEvent("Event");
		e.success=false;
		e.initEvent('appMobi.oauth.busy',true,true);
		document.dispatchEvent(e);
		return;
	}

	var secretToken=AppMobi.cache.getCookie("ServiceSecret_"+parameters.service);
	var token=AppMobi.cache.getCookie("ServiceToken_"+parameters.service);
	parameters.app=AppMobi.app;
	parameters.host=document.location.origin;
	var makeRequest=function(params){
		var cbName=AppMobi.oauth.internal.oAuthCB+(++AppMobi.oauth.internal.oAuthCBCounter);
		window[cbName]=function(data){

			var e=document.createEvent("Event");
			e.id=params.id;
			e.success=data.success;
			e.message=data.message||"";
			e.response=data.data||null;
			e.initEvent('appMobi.oauth.protected.data',true,true);
			document.dispatchEvent(e);
			script.parentNode.removeChild(script);
			AppMobi.oauth.internal.processing=false;
		}
		var script = document.createElement("script");
		params.callback=cbName;
		parameters.token=token;
		parameters.secret=secretToken;
		parameters.init='true';
		script.src=AppMobi.oauth.internal.oAuthServer+AppMobi.oauth.internal.encodeParams(params);

		script.type="text/javascript";
		script.id=params.scriptid;
		var head= document.getElementsByTagName('head')[0];
		head.appendChild(script);
	}
	//Block oAuth requests
	processing=true;
	if((!token||token=="undefined")||(!secretToken||secretToken=="undefined"))
	{
		AppMobi.oauth.internal.oAuthRegisterCB[parameters.service]=function(){
			secretToken=AppMobi.cache.getCookie("ServiceSecret_"+parameters.service);
			token=AppMobi.cache.getCookie("ServiceToken_"+parameters.service);
			parameters.token=token;
			parameters.secret=secretToken;
			makeRequest(parameters);
			delete AppMobi.oauth.internal.oAuthRegisterCB[parameters.service];
		}

		authWindow=window.open(AppMobi.oauth.internal.oAuthServer + "cmd=auth&"+AppMobi.oauth.internal.encodeParams(parameters),'OAUTH WINDOW');
	}
	else
		makeRequest(parameters);
};

if (typeof AppMobi.oauth == "undefined") AppMobi.oauth = new AppMobi.OAuth();


AppMobi.OAuthInternal = function() {
	this.processing = false;
	this.oAuthServerOrigin = "https://services.appmobi.com";
	this.oAuthServer = this.oAuthServerOrigin + "/html5/oauth.aspx?";
	this.oAuthCB = "oAauthCB";
    this.oAuthCBCounter=0;
    this.oAuthRegisterCB={};
}

AppMobi.OAuthInternal.prototype.initialize = function(e) {
	window.addEventListener('message', AppMobi.oauth.internal.onmessage, false);
}

AppMobi.OAuthInternal.prototype.onmessage = function(e) {
	var data = e.data;
	var origin = e.origin;
	if(e.origin==AppMobi.oauth.internal.oAuthServerOrigin)
	{
		data=JSON.parse(data);
		AppMobi.cache.setCookie("ServiceSecret_"+data.service,data.secret,-1);
		AppMobi.cache.setCookie("ServiceToken_"+data.service,data.token,-1);
		if(AppMobi.oauth.internal.oAuthRegisterCB[data.service])
		{
			AppMobi.oauth.internal.oAuthRegisterCB[data.service]();
		}
	}
}

AppMobi.OAuthInternal.prototype.encodeParams = function(obj) {
   var str="";
   for(var j in obj)
   {
	 if(obj.__proto__[j])
		continue;
	 if (str != "")
			str += "&";
	  str+=j+"="+encodeURIComponent(obj[j]);
   }
   startday = new Date();
   str+="&randBlocker="+ startday.getTime();
   return str;
}

if (typeof AppMobi.oauth.internal == "undefined") AppMobi.oauth.internal = new AppMobi.OAuthInternal();

/**
 * This class provides access to facebook.
 * @constructor
 */
AppMobi.Facebook = function() {
	this.willHandleUserTouchingLink =  false;
}

AppMobi.Facebook.prototype.login = function(permissions) {
	AppMobi.facebook.internal.login(permissions);
}

AppMobi.Facebook.prototype.logout = function() {
	AppMobi.facebook.internal.logout();
}

AppMobi.Facebook.prototype.requestWithRestAPI = function(command, method, parameters) {
	AppMobi.facebook.internal.api(command, method, parameters);
}

AppMobi.Facebook.prototype.requestWithGraphAPI = function(path, method, parameters) {
	AppMobi.facebook.internal.api(path, method, parameters);
}

AppMobi.Facebook.prototype.showAppRequestDialog = function(parameters) {
	AppMobi.facebook.internal.appRequest(parameters);
}

AppMobi.Facebook.prototype.showNewsFeedDialog = function(parameters) {
    if( typeof(parameters) == "undefined" || typeof(parameters) != "object" )
        parameters = {};
    parameters.method = "feed";
    AppMobi.facebook.internal.ui(parameters, "dialog");
}

AppMobi.Facebook.prototype.enableFrictionlessRequests = function() {
	AppMobi.facebook.internal.frictionless = true;
}
if (typeof AppMobi.facebook == "undefined") AppMobi.facebook = new AppMobi.Facebook();

AppMobi.FacebookInternal = function() {
	this._keyStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";
	this.busy = false;
	this.frictionless = false;
}

AppMobi.FacebookInternal.prototype.busyError = function()
{
  if(debug) console.log("appMobi.facebook.busy = true;");
  var e = document.createEvent('Events');
  e.initEvent('appMobi.facebook.busy',true,true);
  document.dispatchEvent(e);
}

AppMobi.FacebookInternal.prototype.initialize = function()
{
	var fbf = document.createElement('iframe');
	fbf.id = "appMobi_Facebook_Communication_Frame";
	fbf.style.display = "none";
	fbf.style.width = "100%";
	fbf.style.height = "100%";
	fbf.style.top = '0px';
	fbf.style.left = '0px';
	fbf.style.position= 'absolute';
	fbf.style.zIndex = "2147483647"; // browser max
	document.body.appendChild(fbf);
}

AppMobi.FacebookInternal.prototype.setCommunicationFrameUrl = function(url)
{
	document.getElementById("appMobi_Facebook_Communication_Frame").src = url;
}

AppMobi.FacebookInternal.prototype.callbackComplete = function()
{
	AppMobi.facebook.internal.busy = false;
	document.getElementById('appMobi_Facebook_Communication_Frame').style.display = 'none';
}

AppMobi.FacebookInternal.prototype.login = function(scope)
{
	if(AppMobi.facebook.internal.busy)
		return AppMobi.facebook.internal.busyError();
	else
		AppMobi.facebook.internal.busy = true;

    var args = [];

    args.push({'scope':(typeof(scope) == "undefined" || scope.length == 0 )?"publish_stream,publish_actions,offline_access":scope});
    AppMobi.facebook.internal.apiCall('login',args, 'login');
}

AppMobi.FacebookInternal.prototype.appRequest = function(params)
{
	if( typeof(params) == "undefined" || typeof( params ) != "object")
		params = {};
	params.method = 'apprequests';
	AppMobi.facebook.internal.ui(params, 'request');
}

AppMobi.FacebookInternal.prototype.api = function(path, httpMethod, parameters)
{
	if(AppMobi.facebook.internal.busy)
		return AppMobi.facebook.internal.busyError();
	else
		AppMobi.facebook.internal.busy = true;

	//FBData = {'path':path, 'parameters':parameters, 'method': httpMethod};
	//dataToSend = encodeURIComponent(emu_core.Base64.encode(JSON.stringify(FBData)));
	//this.setCommunicationFrameUrl("http://fb.appmobi.com/facebook/default.aspx?cmd=fbxdk&appname="+AppMobi.app+"&data="+dataToSend+"&type=api");
	var args =[]
	if(path != undefined)args.push(path);
	if(httpMethod != undefined)args.push(httpMethod);
	if(parameters != undefined)args.push(parameters);

	AppMobi.facebook.internal.apiCall('api',args, 'request.response');
}

AppMobi.FacebookInternal.prototype.ui = function(params, responseType)
{
	if(AppMobi.facebook.internal.busy)
		return AppMobi.facebook.internal.busyError();
	else
		AppMobi.facebook.internal.busy = true;

	if( typeof(params) == "undefined" || typeof( params ) != "object" ) params = {};
	params.display = "dialog"; //popup
	dataToSend = encodeURIComponent(AppMobi.facebook.internal.base64Encode(JSON.stringify(params)));
	//this.setCommunicationFrameUrl("http://fb.appmobi.com/facebook/default.aspx?cmd=fbxdk&appname="+AppMobi.app+"&data="+dataToSend+"&type=ui");
	AppMobi.facebook.internal.apiCall('ui',[params], responseType);
}

AppMobi.FacebookInternal.prototype.logout = function(params)
{
	if(AppMobi.facebook.internal.busy)
		return AppMobi.facebook.internal.busyError();
	else
		AppMobi.facebook.internal.busy = true;

	AppMobi.facebook.internal.apiCall('logout',[],'logout');
	//this.setCommunicationFrameUrl("http://fb.appmobi.com/facebook/default.aspx?cmd=fbxdk&appname="+AppMobi.app+"&type=logout");
}

AppMobi.FacebookInternal.prototype.handleResponse = function(eventName,success,responseData,extra,remainbusy)
{
	if(remainbusy == undefined || remainbusy == false)
		AppMobi.facebook.internal.callbackComplete();
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

AppMobi.FacebookInternal.prototype.apiCall = function(func,args,responseType)
{
	var apiDat = {'func':func,'args':args,'responseType':responseType};
	var dataToSend = encodeURIComponent(AppMobi.facebook.internal.base64Encode(JSON.stringify(apiDat)));
	var callback= encodeURIComponent(AppMobi.webRoot + "amfacebook.html");
	document.getElementById('appMobi_Facebook_Communication_Frame').style.display = 'block';
	AppMobi.facebook.internal.setCommunicationFrameUrl((window.location.href.substr(0,4)!="http"?"http://":"//")+"fb.appmobi.com/facebook/default.aspx?cmd=fbxdk&apicall=true&appname="+AppMobi.app+"&data="+dataToSend+"&callback="+callback);
}

AppMobi.FacebookInternal.prototype.base64Encode = function(input) {
	var output = "";
	var chr1, chr2, chr3, enc1, enc2, enc3, enc4;
	var i = 0;

	input = AppMobi.facebook.internal._utf8_encode(input);
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
		AppMobi.facebook.internal._keyStr.charAt(enc1) + AppMobi.facebook.internal._keyStr.charAt(enc2) +
		AppMobi.facebook.internal._keyStr.charAt(enc3) + AppMobi.facebook.internal._keyStr.charAt(enc4);
	}

	return output;
}

AppMobi.FacebookInternal.prototype.base64Decode = function(input) {
	var output = "";
	var chr1, chr2, chr3;
	var enc1, enc2, enc3, enc4;
	var i = 0;

	input = input.replace(/[^A-Za-z0-9\+\/\=]/g, "");
	while (i < input.length) {

		enc1 = AppMobi.facebook.internal._keyStr.indexOf(input.charAt(i++));
		enc2 = AppMobi.facebook.internal._keyStr.indexOf(input.charAt(i++));
		enc3 = AppMobi.facebook.internal._keyStr.indexOf(input.charAt(i++));
		enc4 = AppMobi.facebook.internal._keyStr.indexOf(input.charAt(i++));

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

	output = AppMobi.facebook.internal._utf8_decode(output);
	return output;
}

AppMobi.FacebookInternal.prototype._utf8_encode = function(string) {
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
}

AppMobi.FacebookInternal.prototype._utf8_decode = function(utftext) {
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
if (typeof AppMobi.facebook.internal == "undefined") AppMobi.facebook.internal = new AppMobi.FacebookInternal();

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

/**
 * This class provides compatibility with Android multi-touch support.
 * @constructor
 */
AppMobi.Multitouch = function() {
}

/**
 * @param {element} target
 * @param {string} type ('touchstart', 'touchend', 'touchmove')
 * @param {function} listener
 * @param {boolean} useCapture
 */
AppMobi.Multitouch.prototype.add = function(target, type, listener, useCapture) {
	target.addEventListener(type, listener, useCapture);
}

/**
 * @param {element} target
 * @param {string} type ('touchstart', 'touchend', 'touchmove')
 * @param {function} listener
 * @param {boolean} useCapture
 */
AppMobi.Multitouch.prototype.remove = function(target, type, listener, useCapture) {
	target.removeEventListener(type, listener, useCapture);
}

if (typeof AppMobi.multitouch == "undefined") AppMobi.multitouch = new AppMobi.Multitouch();

//redirect mouse to touch
AppMobi.redirectMouseToTouch = function (type, originalEvent) {
    //stop propagation, and remove default behavior for everything but INPUT, TEXTAREA & SELECT fields
    // originalEvent.stopPropagation();
    if (originalEvent.target.tagName.toUpperCase().indexOf("SELECT") == -1 &&
			originalEvent.target.tagName.toUpperCase().indexOf("TEXTAREA") == -1 &&
			originalEvent.target.tagName.toUpperCase().indexOf("INPUT") == -1)//SELECT, TEXTAREA & INPUT
    {
        originalEvent.stopPropagation();
    }

    var touchevt = document.createEvent("Event");
    touchevt.initEvent(type, true, true);
    touchevt.touches = new Array();
    touchevt.touches[0] = new Object();
    touchevt.touches[0].pageX = originalEvent.clientX;
    touchevt.touches[0].pageY = originalEvent.clientY;
    touchevt.touches[0].target = originalEvent.target;
    touchevt.changedTouches = touchevt.touches; //for jqtouch
    touchevt.targetTouches = touchevt.touches; //for jqtouch
    touchevt.touches[0].clientX = touchevt.touches[0].pageX; //compatibility code
    touchevt.touches[0].clientY = touchevt.touches[0].pageY; //compatibility code
    touchevt.target = originalEvent.target;

	//by default, we just dispatch but there are special cases that need to be handled
	//these include inline event handlers, event handler properties and bubbling
	originalEvent.target.dispatchEvent(touchevt);

	//handle inline event handlers and bubbling for IE and Firefox
	if( /Firefox|MSIE/.test(AppMobi.helper.identifyBrowser().browser) ) {
		//handle inline event handlers for target and parents (for bubbling)
		var elem = originalEvent.target;
		while(elem!=null) {
			if(elem.hasAttribute("on"+type)) {
				eval(elem.getAttribute("on"+type));
			}
			elem = elem.parentElement;
		}
	}
		
		return touchevt;
	}
	
	AppMobi.emulateTouchEvents = function () {
		var ee = document;
		document.mouseMoving = false;
		document.onmousedown = function (e) {
			try {
				this.mouseMoving = true;
				var touchevt = AppMobi.redirectMouseToTouch("touchstart", e);
				if (document.ontouchstart) {
					document.ontouchstart(touchevt);
				}
			} catch (e) { }
		}
		document.onmouseup = function (e) {
			try {
				this.mouseMoving = false;
				var touchevt = AppMobi.redirectMouseToTouch("touchend", e);
				if (document.ontouchend) {
					document.ontouchend(touchevt);
				}
			}
			catch (e) { }
		}
		document.onmousemove = function (e) {
			try {
				if (!this.mouseMoving) return;
				var touchevt = AppMobi.redirectMouseToTouch("touchmove", e);
				if (document.ontouchmove) {
					document.ontouchmove(touchevt);
				}
			}
			catch (e) { }
		}
	}
	//only emulate if browser does not handle touch events
	if(!('ontouchstart' in document.documentElement)) {
		AppMobi.emulateTouchEvents();
	}
	
	//Event Stub Support function
	AppMobi.stubEvent = function(event_suffix,extra)
	{
		if(event_suffix == undefined)
			return;
	
		var e = document.createEvent('Events');
		e.initEvent('appMobi.'+event_suffix,true,true);
		e.success=false;
		e.cancelled=false;
	
		if(extra != undefined && typeof(extra) == 'object')
		{
			for(i in extra)
				e[i] = extra[i];
		}
	
		document.dispatchEvent(e);
	}
	
	// -------------------------------------------------------------------------------------------------------------------
	//set up DirectCanvas shim
	AppMobi.injectQueue = [];
	AppMobi.readyToInject = true;
	AppMobi.doInject = function () {
		//if not ready or queue is empty return
		if (!AppMobi.readyToInject || !AppMobi.injectQueue.length) return;
		//set ready state
		AppMobi.readyToInject = false;
		//get next src from queue and make path absolute
		var src = AppMobi.injectQueue.shift();
		//create script tag with load listener
		var script = document.createElement("script");
		script.type = "text/javascript";
		script.onload = AppMobi.makeReadyToInject;
		script.src = src;
		document.body.appendChild(script);
	}
	
	AppMobi.makeReadyToInject = function () {
		AppMobi.readyToInject = true;
		AppMobi.doInject();
	}

AppMobi.inject = function (src) {
    //add src to queue, call doInject
    AppMobi.injectQueue.push(src);
    AppMobi.doInject();
}

AppMobi.webview = {};

AppMobi.webview.execute = function (strJavascript) {
    eval(strJavascript);
}

AppMobi.webview.eval = function (strJavascript) {
    eval(strJavascript);
}

//DirectCanvas compatibility
AppMobi.context = {};
AppMobi.context.include = AppMobi.inject;
AppMobi.context.startBackgroundSound = function (sound, looping) {
	AppMobi.player.startAudio(sound, looping);
}
AppMobi.context.toggleBackgroundSound = function () {
	AppMobi.player.toggleAudio();
}
AppMobi.context.stopBackgroundSound = function () {
	AppMobi.player.stopAudio();
}
AppMobi.context.playSound = function (sound) {
	AppMobi.player.playSound(sound);
}
AppMobi.context.loadSound = function (sound, count) {
	AppMobi.player.loadSound(sound, count);
}
AppMobi.context.loadPolySound = function (sound, count) {
	AppMobi.player.loadSound(sound, count);
}
AppMobi.context.hideLoadingScreen = function () { };
try{	
	var dCsetup = function (e) {
		window.addEventListener("message", function(e) { try { eval(e.data); } catch(ex) { } }, false);
			
	    //DirectCanvas compatibility: should use iframe instead?
	    Canvas = document.getElementById('_cvs');

	    if (!Canvas) {
	        var _cvs = document.createElement('canvas');
	        _cvs.id = '_cvs';
	        document.body.appendChild(_cvs);
	        Canvas = _cvs;
		
			//need to align with screen so that touch forwarding will work
			Canvas.style.position = 'absolute';
			Canvas.style.top = '0px';
			Canvas.style.left = '0px';
			Canvas.style.zIndex=-2;
	    }

	    Canvas.context = {};

	    Canvas.origGetContext = Canvas.getContext;
	    Canvas.getContext = function (ctx) {
	        var context = Canvas.origGetContext(ctx);
	        context.setFPS = function () { };
	        context.clear = function () { };
	        context.present = function () { };

			// Object.defineProperty(context, "height", {
			// 	set: function (h) {
			// 		Canvas.setAttribute("height", h + "px");
			// 	}
			// });
			// Object.defineProperty(context, "width", {
			// 	set: function (w) {
			// 		Canvas.setAttribute("width", w + "px");
			// 	}
			// });
			// Object.defineProperty(context, "globalScale", {
			// 	set: function () {
			// 	}
			// });

	        return context;
	    }

	    Canvas.isHidden = true;

	    Canvas.load = function (strRelativeURL) {
	        AppMobi.inject(strRelativeURL);
	    };

	    Canvas.show = function () {
	        this.isHidden = false;
	        Canvas.style.display = "block";
	    };

	    Canvas.hide = function () {
	        this.isHidden = true;
	        Canvas.style.display = "none";
	    };

	    Canvas.execute = function (strJavascript) {
	        //alert(strJavascript);
	        eval(strJavascript);
	    };

	    Canvas.eval = function (strJavascript) {
	        eval(strJavascript);
	    };

	    Canvas.reset = function () {
	        //compatibility stub

	        //should reload page?
	    };

	    Canvas.setFramesPerSecond = function (fps) {
	        //compatibility stub
	    };

	    Canvas.setFPS = function (fps) {
	        //compatibility stub
	    };

	    AppMobi.canvas = Canvas;

	    //fire deviceReady -- this will happen automatically on android - how to make sure DirectCanvas shim is ready first?

		try {
			if( AppMobi.hasLocalStorage )
			{
				AppMobi.device.uuid  = localStorage.getItem("appMobi.uuid");
			}
			if( !AppMobi.device.uuid || AppMobi.device.uuid  == "" )
			{
			   AppMobi.device.uuid = createGUID();
			   localStorage.setItem('appMobi.uuid',AppMobi.device.uuid ,365);
			}
		} catch(e) { }

	    AppMobi.available = true;
	    AppMobi.cache.initialize();
	    AppMobi.device.initialize();
	    AppMobi.facebook.internal.initialize();
	    AppMobi.oauth.internal.initialize();
	    AppMobi.analytics.initialize();
	    AppMobi.analytics.logPageEvent("/device/start.event", "-");
	    setTimeout("fireDeviceReady();", 2000);

	    this.removeEventListener('load', arguments.callee, false);
	};
	//addEventListener
	window.addEventListener("load", dCsetup, false);
	//execute immediately in case window load already happened
	dCsetup();
} catch(e){}

function fireDeviceReady() {
	AppMobi.helper.sendAppStart();
	AppMobi.helper.sendXPromoRunHome();

	var evt = document.createEvent('Events');
	evt.initEvent("appMobi.device.ready",true,true);
	document.dispatchEvent(evt);
}

function cfInstallCheck() {
    var ss1 = document.createElement('style');
    var def = '.chromeFrameInstallDefaultStyle { width: 800px; border: 1px solid #ccc; z-index: 99999; }';

    var hh1 = document.getElementsByTagName('head')[0];
    hh1.appendChild(ss1);
    ss1.setAttribute("type", "text/css");
	if(ss1.styleSheet) {
		ss1.styleSheet.cssText =def;
	} else {
		ss1.style.cssText =def;
	}
    var scr=document.createElement("script");
    scr.src="http://ajax.googleapis.com/ajax/libs/chrome-frame/1/CFInstall.min.js";
    scr.type="text/javascript";
    var done=false;
    scr.onreadystatechange = function() {
        if ( !done && (!this.readyState || this.readyState === "loaded" || this.readyState === "complete") ) {
            done = true;
            // Handle memory leak in IE
            scr.onreadystatechange = null;
            CFInstall.check({mode: "inline",node: "ie-cf-prompt",destination: document.location.href});
        }
    };

    document.getElementsByTagName("head")[0].appendChild(scr);
    document.getElementById("body");
    var div=document.createElement("div");
    div.id="ie-cf-prompt";
    document.body.appendChild(div);
}
//only use chrome frame in IE9 and below
if(!window.addEventListener&&('attachEvent' in window||window.attachEvent))
    window.attachEvent("onload", cfInstallCheck);

// try to get ip
// http://services.appmobi.com/external/echoip.aspx
function setAnalyticsIP(ip)
{
	AppMobi.analytics.ipAddress = ip;
}

var head = document.getElementsByTagName('head')[0];
var script = document.createElement('script');
script.setAttribute('type', 'text/javascript');
script.setAttribute('src', 'https://services.appmobi.com/external/echoip.aspx?callback=setAnalyticsIP');
head.appendChild(script);

AppMobi.helper ={};

AppMobi.helper.getOsType = function()
{
	if(AppMobi.ischrome)
		return "chrome";
	else if(AppMobi.isfacebook)
		return "facebook";
	else if(AppMobi.isweb)
		return "web";
	else if(AppMobi.isintel)
		return "intel";
	else if(AppMobi.ismozilla)
		return "mozilla";
	else
		return "unknown";
}

AppMobi.helper.getTime = function()
{
	//yyyy-MM-dd HH:mm:ss   //Date Format
	var today=new Date();
	var yyyy = today.getFullYear();
	var MM = AppMobi.helper.checkTime(today.getMonth()+1);
	var dd = AppMobi.helper.checkTime(today.getDate());
	var hh= AppMobi.helper.checkTime(today.getHours());
	var mm= AppMobi.helper.checkTime(today.getMinutes());
	var ss= AppMobi.helper.checkTime(today.getSeconds());

	return yyyy+'-'+MM+'-'+dd+' '+hh+":"+mm+":"+ss;
}

AppMobi.helper.checkTime = function(i){return i<10?("0"+i):i;}

AppMobi.helper.identifyBrowser = function (userAgent, elements) {
    var regexps = {
            'Chrome': [ /Chrome\/(\S+)/ ],
            'Firefox': [ /Firefox\/(\S+)/ ],
            'MSIE': [ /MSIE (\S+);/ ],
            'Opera': [
                /Opera\/.*?Version\/(\S+)/,     /* Opera 10 */
                /Opera\/(\S+)/                  /* Opera 9 and older */
            ],
            'Safari': [ /Version\/(\S+).*?Safari\// ]
        },
        re, m, browser, version;

    if (userAgent === undefined)
        userAgent = navigator.userAgent;

    if (elements === undefined)
        elements = 2;
    else if (elements === 0)
        elements = 1337;

    for (browser in regexps)
        while (re = regexps[browser].shift())
            if (m = userAgent.match(re)) {
                version = (m[1].match(new RegExp('[^.]+(?:\.[^.]+){0,' + --elements + '}')))[0];
                //return browser + ' ' + version;
                return {'browser':browser,'version':version};
            }

    return {'browser':'unknown','version':'unknown'};
}

AppMobi.helper.loadURL = function(url)
{
	var remoteIframe = document.createElement('iframe');
	remoteIframe.style.display = "none";
	remoteIframe.style.zIndex = "-1";
	remoteIframe.style.width = "0px";
	remoteIframe.style.height = "0px";
	remoteIframe.src = url;
	remoteIframe.onload = function(){document.body.removeChild(this)};
	document.body.appendChild(remoteIframe);
}

AppMobi.helper.sendAppStart = function()
{
	var appStartData  = "APP_START";
	appStartData += "~"+AppMobi.app;//appName
	appStartData += "~"+AppMobi.release;//relName
	appStartData += "~"+AppMobi.device.uuid;//DeviceId
	appStartData += "~"+AppMobi.helper.getTime();//TimeStamp
	appStartData += "~"+AppMobi.helper.getOsType();//OS
	appStartData += "~"+AppMobi.helper.identifyBrowser(undefined,0).browser;//Model
	appStartData += "~"+AppMobi.helper.identifyBrowser(undefined,0).version;//System Version
	appStartData += "~"+AppMobi.analytics.ipAddress;//Local IP

	var appStartURL =  "https://queue.amazonaws.com/668107645782/appmobi_user_queue?Action=SendMessage&MessageBody="+appStartData+"&Version=2009-02-01"
	AppMobi.helper.loadURL(appStartURL);
}

AppMobi.helper.sendXPromoRunHome = function()
{
	var promoData = "XPROMO_RUN_HOME";
	promoData += "~"+AppMobi.app;//appName
	promoData += "~"+AppMobi.release;//relName
	promoData += "~"+AppMobi.device.uuid;//DeviceId
	promoData += "~"+AppMobi.helper.getTime();//TimeStamp
	promoData += "~"+AppMobi.helper.getOsType();//OS
	promoData += "~"+AppMobi.helper.identifyBrowser(undefined,0).browser;//Model
	promoData += "~"+AppMobi.helper.identifyBrowser(undefined,0).version;//System Version
	promoData += "~"+AppMobi.analytics.ipAddress;//Local IP
	promoData += "~"+AppMobi.app;//appName
	promoData += "~"+'_'+AppMobi.device.uuid;//"Encrypted" deviceId
	promoData += "~"+'';//code

	var promoUrl = "https://queue.amazonaws.com/668107645782/appmobi_xpromo_appstart?Action=SendMessage&MessageBody="+promoData+"&Version=2009-02-01";
	AppMobi.helper.loadURL(promoUrl);
}
