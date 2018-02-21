


function factorialRecursivo (n) {
	var factorialTotal = 0; 
	if (n == 0){ 
		return 1; 
	}
	return n * factorialRecursivo (n-1);

}