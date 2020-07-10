// Default script for custom communication protocol
function CommHandler()
{
	var beat_timer = 5.0; // beat timer in sec
	var peer_name;
	return {
		onConnect: function (peerName)
		{
			peer_name = peerName;
			this.resetHeartBeat(); // initial timer
			this.expectFramed("\0", "\0", 128); // some pattern unlikely to happen			
			comm_handler.push(this); // register the handler for results	
			// Disable the handler for this connection:
			return true;
		},
		onDisconnect: function ()
		{		
			comm_handler = new Array(0);
		},
		onError: function (errorMsg)
		{
		},
		onExpectedData: function (inputString) {
			return false;
		},
		onUnexpectedData: function (inputString) {
			return false;
		},
		onTimer: function () {
			today = new Date();
			var msg = today.getSeconds() * 1000 + today.getMilliseconds();
			num_send = this.send(peer_name + ': time is: ' + msg + '\r\n');
			this.resetHeartBeat(); // schedule next timer event [sec]
		},
		resetHeartBeat: function () {
			this.setTimer(beat_timer); // schedule next timer event [sec]
		}
	};
}
