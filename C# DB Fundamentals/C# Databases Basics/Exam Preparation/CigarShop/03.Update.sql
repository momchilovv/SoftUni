UPDATE Cigars
SET PriceForSingleCigar += PriceForSingleCigar * 0.2
WHERE TastId = 1;

UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL;