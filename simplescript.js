function greet(){

	alert("Hi welcome to chennai");

}

function printmsg(){

	document.write("This is another msg ");
}

function square(){
	var a,c;
	a=prompt("enter number");
	c=a*a;
	alert(c);
}

function add(){

	var x,y,z;
	
	x=prompt("enter first number");
	y=prompt("enter second number");
	z=parseInt(x) + parseInt(y);	
	alert(z);
}
function showdate(){

	document.getElementById("display").innerHTML=date();
	
}