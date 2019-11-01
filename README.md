# BitFlagger
## About
Bitflagger is a C# library that implements efficient filtering of data records using binary flags. It uses a collection of binary flags that can be set or unset so that filtering of records can be done based on those flags. 

## Simple Use Case
A simple use-case is where certain products can be taxed in a certain state or not. There are 50 states in the USA and one flag is needed for each state. 

This solution uses a Long (int64). Each state is assigned to the position of the bit. e.g.: first bit is assigned to AL, the second bit is assigned to AK ... and California would be assigned to 6th bit. 

If a certain product is taxed in AL and CA, then the first and sixth flags are set to 1 for that product and the rest are 0. 

If the customer is ordering from the state of California, doing and bitwise "&" would result in value greater than 0. If the product has 6th bitt set to 0, doing an & would result in 0. 
