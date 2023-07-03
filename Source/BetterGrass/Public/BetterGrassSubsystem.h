#pragma once

#include "CoreMinimal.h"
#include "Subsystem/ModSubsystem.h"
#include "BetterGrass.h"
#include "BetterGrassSubsystem.generated.h"

UCLASS()
class BETTERGRASS_API ABetterGrassSubsystem: public AModSubsystem
{
	GENERATED_BODY()

private:
	
	FString DensityCommand;
	float CustomScale;
	FString CustomDistanceCommand;
	float CustomDistance;
	static UModConfiguration* ModConfigReference;
	
protected:
	
	virtual void BeginPlay() override;
};
