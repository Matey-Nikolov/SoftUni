SELECT Id, Name, Quantity, BoxCapacity, PalletCapacity,
	CEILING(
		CEILING(
			CAST(Quantity AS float) / BoxCapacity / PalletCapacity))
		AS [Number of pallets]
	FROM Products 