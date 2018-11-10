<b>Post on Publish–subscribe pattern</b>.

Apps heavily use request and response pattern.Button is clicked, requested some info from database and got the response from server and info is displayed on UI.This pattern is good but some apps have different requirements and this post is about that.

Our life is driven by events and so is publish–subscribe pattern.When an event occurs, it will result into an action.This is exact philosophy of event driven applications.

<b>Some Definitions:</b>
Publisher: the one which publishes the message to queue.
Subscriber: the one which subscribes to the queue and processes the message from it.

<b>Real life example</b><br>
Food outlet.<br>
You give order at outlet.Order-taker will give you receipt,paste another receipt on kitchen queue and tell his/her peers about your order listed on kitchen queue which is to be served.<br>
<b>Let us break  this example</b><br>
-You giving order and order-taker associate informing about your order to his/her peers translates to publisher publishing the message to the queue.<br>
-Kitchen staff making your order and you getting food translates to subscribers processing queue's message and giving end result.<br>

<b>Demo App:</b><br>
I have build a mvc webapp(Publisher) which pushes which youtube video to play on the queue and console application(Subsciber) reads the message from queue, processes and displays the video search of youtube based on that message<br>
<b>Code Link:</b></br>
https://github.com/Sumeetgaara/Publisher-Subscriber-Pattern.<br>
Messaging queue used in demo: RabbitMQ.<br>
<b>Video Link:</b></br>
https://vimeo.com/300047760<br>

<b>Notes:</b><br>
-Messaging patterns like pub/sub are used in microservice architecture.<br>



