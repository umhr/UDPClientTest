package  
{
	
	import com.bit101.components.InputText;
	import com.bit101.components.Label;
	import com.bit101.components.PushButton;
	import com.bit101.components.TextArea;
	import flash.display.Sprite;
	import flash.events.Event;
	/**
	 * ...
	 * @author umhr
	 */
	public class UI extends Sprite 
	{
		private static var _instance:UI;
		public function UI(block:Block){init();};
		public static function getInstance():UI{
			if ( _instance == null ) {_instance = new UI(new Block());};
			return _instance;
		}
		
		public var ipAddressLabel:Label;
		public var recivePort:InputText;
		public var reciveButton:PushButton;
		public var targetIP:InputText;
		public var targetPort:InputText;
		public var message:InputText;
		public var sendButton:PushButton;
		public var log:TextArea;
		private function init():void
		{
			if (stage) onInit();
			else addEventListener(Event.ADDED_TO_STAGE, onInit);
		}

		private function onInit(event:Event = null):void 
		{
			removeEventListener(Event.ADDED_TO_STAGE, onInit);
			// entry point
			
			// recive
			ipAddressLabel = new Label(this, 8, 8, "IPAddress");
			recivePort = new InputText(this, 141, 8, "8989");
			recivePort.width = 50;
			reciveButton = new PushButton(this, 197, 8, "Bind", onBind);
			reciveButton.width = 75;
			
			// send
			new Label(this, 8, 38, "SendTo");
			targetIP = new InputText(this, 69, 38, "192.168.0.255");
			targetIP.width = 85;
			targetPort = new InputText(this, 160, 38, "7777");
			targetPort.width = 50;
			message = new InputText(this, 8, 60, "Message");
			message.width = 174;
			sendButton = new PushButton(this, 197, 60, "Send", onSend);
			sendButton.width = 75;
			
			log = new TextArea(this, 8, 89);
			log.width = 260;
			log.height = 161;
		}
		
		private function onSend(event:Event):void 
		{
			UDPAccessor.getInstance().send(message.text, targetIP.text, int(targetPort.text));
			var text:String = "";
			text = "Send "+targetIP.text + ":" + targetPort.text + " " + message.text;
			
		log.textField.appendText(text + "\n");
		}
		
		private function onBind(event:Event):void 
		{
			UDPAccessor.getInstance().bind(int(recivePort.text));
		}
		
		
	}
	
}
class Block { };