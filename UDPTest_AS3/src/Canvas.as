package  
{
	
	import flash.display.Sprite;
	import flash.events.Event;
	/**
	 * ...
	 * @author umhr
	 */
	public class Canvas extends Sprite 
	{
		
		private var _ui:UI = UI.getInstance();
		private var udpAccessor:UDPAccessor;
		public function Canvas():void
		{
			if (stage) onInit();
			else addEventListener(Event.ADDED_TO_STAGE, onInit);
		}

		private function onInit(event:Event = null):void 
		{
			removeEventListener(Event.ADDED_TO_STAGE, onInit);
			// entry point
			
			addChild(_ui);
			
			udpAccessor = UDPAccessor.getInstance();
			udpAccessor.addEventListener(Event.COMPLETE, udpAccessor_complete);
			udpAccessor.addEventListener("bind", udpAccessor_bind);
			//udpAccessor
		}
		
		private function udpAccessor_bind(e:Event):void 
		{
			var message:String = "";
			message = "Bound to: " + udpAccessor.localAddress + ":" + udpAccessor.localPort;
			_ui.log.textField.appendText(message + "\n");
			_ui.ipAddressLabel.text = "IPAddress:" + udpAccessor.localAddress;
			_ui.recivePort.enabled = false;
			_ui.reciveButton.enabled = false;
		}
		
		private function udpAccessor_complete(e:Event):void 
		{
			var message:String = "";
			message = udpAccessor.srcAddress + ":" + udpAccessor.srcPort + " " + udpAccessor.message;
			_ui.log.textField.appendText(message + "\n");
		}
		
		
	}
	
}
class Block { };