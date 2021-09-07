CREATE PROCEDURE GetPetName
	@droneID int,
	@petName char(10) output
AS
	SELECT @petName = PetName from Inventory where DroneId = @droneID
