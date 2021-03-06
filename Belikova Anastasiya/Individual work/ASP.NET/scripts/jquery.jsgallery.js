$(function() {
    FastClick.attach(document.body);
});
(function ( $ ) {
	
	var globalSelf;
	var methods = {
		
		show : function(self){
			globalSelf = self;
			setTimeout(function(){animateUI("in")}, 10);
			//globalSelf.css("display","block");
			
		},
		
		hide : function(self){
			$("*").removeClass("selected_slider_div");
			globalSelf = self;
			animateUI("out");
			//$(globalSelf).css("display","none");
			
		}
		
	}
	
	function createGallery(self){
		var html = '<div id="jsgall_prevButton" class="gallery-arrow arrow-left start_pos">'+config.leftNavHTML+'</i></div>';
			html += '<div id="jsgall_imageContainer" ><img id="jsgallery_displayed_image" class="start_size">';
			html += '<div id="jsgall_htmloverlay"><span id="customHTMLFooter"></span></div></div>';
			html += '<div id="jsgall_nextButton" class="gallery-arrow arrow-right start_pos">'+config.rightNavHTML+'</i></div>';
			html += '<div id="jsgall_close">'+config.closeHTML+'</div>';
			
			
			
			$(self).html(html);
		
			
			
			
	}
	
	function loadNextImage(){
		    	if(config.currentImage == images.length - 1) {
			    		config.currentImage = 0;
			    	} else {
				    	config.currentImage ++;
				    }
					showSelectedImage();
	    	}
	    	
	function loadPrevImage(){
    	if(config.currentImage == 0) { 
	    		config.currentImage = images.length - 1;
	    	} else {
				config.currentImage --;
    		}
			showSelectedImage();
	}
	
	function showSelectedImage(){
		if(images[config.currentImage]){
			$('#jsgall_imageContainer img').attr("src", images[config.currentImage].src);
			
			var strHTML = config.customHTMLFooter;
			strHTML = strHTML.replace("%FB%", images[config.currentImage].fb);
			strHTML = strHTML.replace("%TW%", images[config.currentImage].tw);
			strHTML = strHTML.replace("%PIN%", images[config.currentImage].pin);
			
			$('#pageBlockContent').html(strHTML);
		} 
	}
	
	
	function animateUI(dir){
		
		//Animate arrows
		if(dir == "in"){
			//globalSelf.css("background","rgba(0,0,0,0)");
			//$(globalSelf).css("display","block");
			$(globalSelf).css("visibility","visible");
			//$(globalSelf).css("background","rgba(0,0,0,0.7)");

			
			setTimeout(function(){
					$( "img#jsgallery_displayed_image" ).width("auto");
					var imgWidth = $('img#jsgallery_displayed_image').width();
					$( "img#jsgallery_displayed_image" ).width("0");
					$( "img#jsgallery_displayed_image" ).animate({
						width: imgWidth +"px",
						opacity : 1
					  }, 200,  function() {
						   $( "img#jsgallery_displayed_image" ).width("auto");
						   $('img#jsgallery_displayed_image').removeClass("start_size");
					  });
									
					$('.gallery-arrow').removeClass("start_pos");
				
				}, 100); 
				
				$( "#jsgall_close" ).animate({
						opacity : 1
					  }, 100, function() {
					  
			});
			
		}
		if(dir == "out"){
			$('.gallery-arrow').addClass("start_pos");
			$( "img#jsgallery_displayed_image" ).animate({
						width: "0",
						opacity : 0
					  }, 200, function() {
					  $('img#jsgallery_displayed_image').addClass("start_size");
			});
			
			$( "#jsgall_close" ).animate({
						opacity : 0
					  }, 200, function() {
					  
			});
					
			setTimeout(function(){
				$(globalSelf).css("visibility","hidden");
				}, 300); 
		}
		
		
	}
	
	function createImagesArray(){
		$.each($(config.imgSelector), function(index, element){
		             if(element.src) {
			          var image = {};
			          image.src = element.src;
			          if(element.alt && element.alt != "") image.alt = element.alt;
			          if(element.width != 0) image.width = element.width;
					  if(element.height != 0) image.height = element.height;
					  if($(element).data('fb')) image.fb = $(element).data('fb');
					  if($(element).data('tw')) image.tw = $(element).data('tw');
					  if($(element).data('pin')) image.pin = $(element).data('pin');
			          images.push(image);
			          }
	            });
	}
	
	var images = [];
	var config = {};
	var originalSelector;
    
	
$.fn.jsgallery = function(optionsOrMethod) {
			
			
			
			var newDiv = $('<div></div>').addClass("jsgallery-container");
			$("body").append(newDiv);

			var self = newDiv;
			config = {
				imgSelector : "img",
				currentImage : 0,
				customHTMLFooter : "",
				bgClickClose : true,
				leftNavHTML : '<i class="fa fa-chevron-left">',
				rightNavHTML : '<i class="fa fa-chevron-right">', 
				closeHTML : '<i class="fa fa-times"></i>'
			};
					
			if(typeof optionsOrMethod === "object"){
				config = $.extend(config,optionsOrMethod);
					
			} else {
				if(methods[optionsOrMethod]) methods[optionsOrMethod](this);	
				
			}
			
			originalSelector = optionsOrMethod.imgSelector;
			
			createGallery(self);
			
			$('#jsgall_nextButton').click(function() {
	        	loadNextImage();
	    	});
	    	
	    	$('#jsgall_prevButton').click(function() {
	        	loadPrevImage();
	    	});
	    	
	    	$('#jsgall_close').click(function() {
	        	methods.hide(self);
	    	});
	    
	    	
	    	$('#jsgall_imageContainer').click(function(e){
		    	if(e.target.id == "jsgall_imageContainer" && config.bgClickClose) methods.hide(self);
	    	})
	    	
	    	
	    	$(config.imgSelector).click(function(){
		    	config.imgSelector = originalSelector;
		    	
		    	var parents = $(this).parents();
		    	
		    	for(var i = 0; i < parents.length; i++){
			    	if($(parents[i]).attr("media") == "slider"){
				    	$(parents[i]).addClass("selected_slider_div");
				    	config.imgSelector = ".selected_slider_div " + originalSelector;
				    	
			    	}
		    	}
		    	
		    	images = [];
	            createImagesArray();
		    	
		    	console.log(config.imgSelector);
		    	
		    	var src = this.src;
		    	
		    	var selectedIndex;	
		    	
		    	    	
/*
		    	var result = images.filter(function( obj , index) {
				  if( obj.src == src) selectedIndex = index;
				  return result;
				});
*/
				
				
				for(var i = 0; i < images.length; i++){
					if(images[i].src == src){
						selectedIndex = i;
						break;
					}
				}
				
				
				
				config.currentImage = selectedIndex;
				showSelectedImage();
				methods.show(self);
				
	    	})
	    	
	    	
	    	$(config.imgSelector).css("cursor","pointer");
	    	
	    	

	    	$("#jsgall_imageContainer").touchwipe({
			     wipeLeft: function() { loadNextImage(); },
			     wipeRight: function() { loadPrevImage(); },
			     min_move_x: 100,
			     min_move_y: 100
			});

	    		    	
	        return this.each( function() {
	            
	            images = [];
	            createImagesArray();
	            
	            $('.gallery-arrow').css('display',"block");
	            if(images.length < 2) $('.gallery-arrow').css('display',"none");
	            showSelectedImage();
	            
	        });

    
}
    

   
    
}( jQuery ));


(function($){$.fn.touchwipe=function(settings){var config={min_move_x:20,min_move_y:20,wipeLeft:function(){},wipeRight:function(){},wipeUp:function(){},wipeDown:function(){},preventDefaultEvents:true};if(settings)$.extend(config,settings);this.each(function(){var startX;var startY;var isMoving=false;function cancelTouch(){this.removeEventListener('touchmove',onTouchMove);startX=null;isMoving=false}function onTouchMove(e){if(config.preventDefaultEvents){e.preventDefault()}if(isMoving){var x=e.touches[0].pageX;var y=e.touches[0].pageY;var dx=startX-x;var dy=startY-y;if(Math.abs(dx)>=config.min_move_x){cancelTouch();if(dx>0){config.wipeLeft()}else{config.wipeRight()}}else if(Math.abs(dy)>=config.min_move_y){cancelTouch();if(dy>0){config.wipeDown()}else{config.wipeUp()}}}}function onTouchStart(e){if(e.touches.length==1){startX=e.touches[0].pageX;startY=e.touches[0].pageY;isMoving=true;this.addEventListener('touchmove',onTouchMove,false)}}if('ontouchstart'in document.documentElement){this.addEventListener('touchstart',onTouchStart,false)}});return this}})(jQuery);

!function(){"use strict";function t(e,o){function i(t,e){return function(){return t.apply(e,arguments)}}var r;if(o=o||{},this.trackingClick=!1,this.trackingClickStart=0,this.targetElement=null,this.touchStartX=0,this.touchStartY=0,this.lastTouchIdentifier=0,this.touchBoundary=o.touchBoundary||10,this.layer=e,this.tapDelay=o.tapDelay||200,this.tapTimeout=o.tapTimeout||700,!t.notNeeded(e)){for(var a=["onMouse","onClick","onTouchStart","onTouchMove","onTouchEnd","onTouchCancel"],c=this,s=0,u=a.length;u>s;s++)c[a[s]]=i(c[a[s]],c);n&&(e.addEventListener("mouseover",this.onMouse,!0),e.addEventListener("mousedown",this.onMouse,!0),e.addEventListener("mouseup",this.onMouse,!0)),e.addEventListener("click",this.onClick,!0),e.addEventListener("touchstart",this.onTouchStart,!1),e.addEventListener("touchmove",this.onTouchMove,!1),e.addEventListener("touchend",this.onTouchEnd,!1),e.addEventListener("touchcancel",this.onTouchCancel,!1),Event.prototype.stopImmediatePropagation||(e.removeEventListener=function(t,n,o){var i=Node.prototype.removeEventListener;"click"===t?i.call(e,t,n.hijacked||n,o):i.call(e,t,n,o)},e.addEventListener=function(t,n,o){var i=Node.prototype.addEventListener;"click"===t?i.call(e,t,n.hijacked||(n.hijacked=function(t){t.propagationStopped||n(t)}),o):i.call(e,t,n,o)}),"function"==typeof e.onclick&&(r=e.onclick,e.addEventListener("click",function(t){r(t)},!1),e.onclick=null)}}var e=navigator.userAgent.indexOf("Windows Phone")>=0,n=navigator.userAgent.indexOf("Android")>0&&!e,o=/iP(ad|hone|od)/.test(navigator.userAgent)&&!e,i=o&&/OS 4_\d(_\d)?/.test(navigator.userAgent),r=o&&/OS [6-7]_\d/.test(navigator.userAgent),a=navigator.userAgent.indexOf("BB10")>0;t.prototype.needsClick=function(t){switch(t.nodeName.toLowerCase()){case"button":case"select":case"textarea":if(t.disabled)return!0;break;case"input":if(o&&"file"===t.type||t.disabled)return!0;break;case"label":case"iframe":case"video":return!0}return/\bneedsclick\b/.test(t.className)},t.prototype.needsFocus=function(t){switch(t.nodeName.toLowerCase()){case"textarea":return!0;case"select":return!n;case"input":switch(t.type){case"button":case"checkbox":case"file":case"image":case"radio":case"submit":return!1}return!t.disabled&&!t.readOnly;default:return/\bneedsfocus\b/.test(t.className)}},t.prototype.sendClick=function(t,e){var n,o;document.activeElement&&document.activeElement!==t&&document.activeElement.blur(),o=e.changedTouches[0],n=document.createEvent("MouseEvents"),n.initMouseEvent(this.determineEventType(t),!0,!0,window,1,o.screenX,o.screenY,o.clientX,o.clientY,!1,!1,!1,!1,0,null),n.forwardedTouchEvent=!0,t.dispatchEvent(n)},t.prototype.determineEventType=function(t){return n&&"select"===t.tagName.toLowerCase()?"mousedown":"click"},t.prototype.focus=function(t){var e;o&&t.setSelectionRange&&0!==t.type.indexOf("date")&&"time"!==t.type&&"month"!==t.type?(e=t.value.length,t.setSelectionRange(e,e)):t.focus()},t.prototype.updateScrollParent=function(t){var e,n;if(e=t.fastClickScrollParent,!e||!e.contains(t)){n=t;do{if(n.scrollHeight>n.offsetHeight){e=n,t.fastClickScrollParent=n;break}n=n.parentElement}while(n)}e&&(e.fastClickLastScrollTop=e.scrollTop)},t.prototype.getTargetElementFromEventTarget=function(t){return t.nodeType===Node.TEXT_NODE?t.parentNode:t},t.prototype.onTouchStart=function(t){var e,n,r;if(t.targetTouches.length>1)return!0;if(e=this.getTargetElementFromEventTarget(t.target),n=t.targetTouches[0],o){if(r=window.getSelection(),r.rangeCount&&!r.isCollapsed)return!0;if(!i){if(n.identifier&&n.identifier===this.lastTouchIdentifier)return t.preventDefault(),!1;this.lastTouchIdentifier=n.identifier,this.updateScrollParent(e)}}return this.trackingClick=!0,this.trackingClickStart=t.timeStamp,this.targetElement=e,this.touchStartX=n.pageX,this.touchStartY=n.pageY,t.timeStamp-this.lastClickTime<this.tapDelay&&t.preventDefault(),!0},t.prototype.touchHasMoved=function(t){var e=t.changedTouches[0],n=this.touchBoundary;return Math.abs(e.pageX-this.touchStartX)>n||Math.abs(e.pageY-this.touchStartY)>n?!0:!1},t.prototype.onTouchMove=function(t){return this.trackingClick?((this.targetElement!==this.getTargetElementFromEventTarget(t.target)||this.touchHasMoved(t))&&(this.trackingClick=!1,this.targetElement=null),!0):!0},t.prototype.findControl=function(t){return void 0!==t.control?t.control:t.htmlFor?document.getElementById(t.htmlFor):t.querySelector("button, input:not([type=hidden]), keygen, meter, output, progress, select, textarea")},t.prototype.onTouchEnd=function(t){var e,a,c,s,u,l=this.targetElement;if(!this.trackingClick)return!0;if(t.timeStamp-this.lastClickTime<this.tapDelay)return this.cancelNextClick=!0,!0;if(t.timeStamp-this.trackingClickStart>this.tapTimeout)return!0;if(this.cancelNextClick=!1,this.lastClickTime=t.timeStamp,a=this.trackingClickStart,this.trackingClick=!1,this.trackingClickStart=0,r&&(u=t.changedTouches[0],l=document.elementFromPoint(u.pageX-window.pageXOffset,u.pageY-window.pageYOffset)||l,l.fastClickScrollParent=this.targetElement.fastClickScrollParent),c=l.tagName.toLowerCase(),"label"===c){if(e=this.findControl(l)){if(this.focus(l),n)return!1;l=e}}else if(this.needsFocus(l))return t.timeStamp-a>100||o&&window.top!==window&&"input"===c?(this.targetElement=null,!1):(this.focus(l),this.sendClick(l,t),o&&"select"===c||(this.targetElement=null,t.preventDefault()),!1);return o&&!i&&(s=l.fastClickScrollParent,s&&s.fastClickLastScrollTop!==s.scrollTop)?!0:(this.needsClick(l)||(t.preventDefault(),this.sendClick(l,t)),!1)},t.prototype.onTouchCancel=function(){this.trackingClick=!1,this.targetElement=null},t.prototype.onMouse=function(t){return this.targetElement?t.forwardedTouchEvent?!0:t.cancelable&&(!this.needsClick(this.targetElement)||this.cancelNextClick)?(t.stopImmediatePropagation?t.stopImmediatePropagation():t.propagationStopped=!0,t.stopPropagation(),t.preventDefault(),!1):!0:!0},t.prototype.onClick=function(t){var e;return this.trackingClick?(this.targetElement=null,this.trackingClick=!1,!0):"submit"===t.target.type&&0===t.detail?!0:(e=this.onMouse(t),e||(this.targetElement=null),e)},t.prototype.destroy=function(){var t=this.layer;n&&(t.removeEventListener("mouseover",this.onMouse,!0),t.removeEventListener("mousedown",this.onMouse,!0),t.removeEventListener("mouseup",this.onMouse,!0)),t.removeEventListener("click",this.onClick,!0),t.removeEventListener("touchstart",this.onTouchStart,!1),t.removeEventListener("touchmove",this.onTouchMove,!1),t.removeEventListener("touchend",this.onTouchEnd,!1),t.removeEventListener("touchcancel",this.onTouchCancel,!1)},t.notNeeded=function(t){var e,o,i,r;if("undefined"==typeof window.ontouchstart)return!0;if(o=+(/Chrome\/([0-9]+)/.exec(navigator.userAgent)||[,0])[1]){if(!n)return!0;if(e=document.querySelector("meta[name=viewport]")){if(-1!==e.content.indexOf("user-scalable=no"))return!0;if(o>31&&document.documentElement.scrollWidth<=window.outerWidth)return!0}}if(a&&(i=navigator.userAgent.match(/Version\/([0-9]*)\.([0-9]*)/),i[1]>=10&&i[2]>=3&&(e=document.querySelector("meta[name=viewport]")))){if(-1!==e.content.indexOf("user-scalable=no"))return!0;if(document.documentElement.scrollWidth<=window.outerWidth)return!0}return"none"===t.style.msTouchAction||"manipulation"===t.style.touchAction?!0:(r=+(/Firefox\/([0-9]+)/.exec(navigator.userAgent)||[,0])[1],r>=27&&(e=document.querySelector("meta[name=viewport]"),e&&(-1!==e.content.indexOf("user-scalable=no")||document.documentElement.scrollWidth<=window.outerWidth))?!0:"none"===t.style.touchAction||"manipulation"===t.style.touchAction?!0:!1)},t.attach=function(e,n){return new t(e,n)},"function"==typeof define&&"object"==typeof define.amd&&define.amd?define(function(){return t}):"undefined"!=typeof module&&module.exports?(module.exports=t.attach,module.exports.FastClick=t):window.FastClick=t}();
