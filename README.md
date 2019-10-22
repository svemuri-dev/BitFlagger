# BitFlagger
Use this library when ther is a  collection of  binary flags that need to be set or unset and records needs to be filtered based on those flags. A simple usecase is where , certain product can be taxed in certain state or not . There are 50 states in USA and one flag is needed for each state. 

This solution uses a Long (int64). Each state is assinged to postion of the bit . eg: first bit is assigned to AL, second bit is assigned to AK ... and california would be assigned to 6 th bit. 

If certain product is  taxed in AL and CA, then first and sixt flag are set to 1 for that product and rest are 0. 

If the customer is ordering from state of california , doing and bitwise "&" would result in value greater than 0 . If the product has 6 th bitt set to 0 , doing an & would result in 0 . 
