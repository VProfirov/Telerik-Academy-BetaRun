// let number = 5;
this.number = 505;
let invoice = {
	self:this,	
	number: 123,
	process: function () {
		return () =>console.log(this.number);
	},
	pro(){
		console.log(this.number);		
	},
	ifee(){
		return (function(){console.log(this.number);}());
	},
	arrow:()=>console.log(this.number),	
	arrowSelf:(self=this)=>console.log(self.number),
	// func: function(self){return (self)=>console.log(self.number);},
};
invoice.process()(); //the 2nd () ... calls the ()=> empty param function
console.log('process: ' + invoice.process());
console.log('__________');
console.log(invoice.process());
console.log(invoice.process);

console.log('_________________');
invoice.pro();
console.log('pro: ' + invoice.pro());



console.log(invoice.pro());
console.log(invoice.pro);

console.log('ifee: _____________');
invoice.ifee();

console.log('arrow: ___________');
invoice.arrow();

console.log('arrowSelf: ___________');
invoice.arrowSelf();

console.log('func:___________');
invoice.func();
console.log('objectss^2');