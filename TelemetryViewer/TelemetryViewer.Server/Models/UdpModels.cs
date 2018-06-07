using System.IO;
namespace TelemetryViewer.Server.Models
{
    public class UdpPacket
    {
        /// <summary>
        /// Time spent in the session.
        /// </summary>
        public float SessionTime { get; }

        /// <summary>
        /// Time spent on the current lap.
        /// </summary>
        public float LapTime { get; }

        /// <summary>
        /// Distance covered on the current lap.
        /// </summary>
        public float LapDistance { get; }

        /// <summary>
        /// Distance completed in the session.
        /// </summary>
        public float TotalDistance { get; }

        /// <summary>
        /// X Position in world space.
        /// </summary>
        public float X { get; }

        /// <summary>
        /// Y Position in world space.
        /// </summary>
        public float Y { get; }

        /// <summary>
        /// Z position in world space.
        /// </summary>
        public float Z { get; }

        /// <summary>
        /// Speed of car in MPH.
        /// </summary>
        public float Speed { get; }

        /// <summary>
        /// Velocity in the X direction in world space.
        /// </summary>
        public float XVelocity { get; }

        /// <summary>
        /// Velocity in the Y direction in world space.
        /// </summary>
        public float YVelocity { get; }

        /// <summary>
        /// Velocity in the Z direction in world space.
        /// </summary>
        public float ZVelocity { get; }

        /// <summary>
        /// World space right direction TODO: Summary this
        /// </summary>
        public float XRightDirection { get; }

        /// <summary>
        /// World space right direction TODO: Summary this
        /// </summary>
        public float YRightDirection { get; }

        /// <summary>
        /// World space right direction TODO: Summary this
        /// </summary>
        public float ZRightDirection { get; }

        /// <summary>
        /// World space forward direction TODO: Summary this
        /// </summary>
        public float XForwardDirection { get; }

        /// <summary>
        /// World space forward direction TODO: Summary this
        /// </summary>
        public float YForwardDirection { get; }

        /// <summary>
        /// World space forward direction TODO: Summary this
        /// </summary>
        public float ZForwardDiretion { get; }

        /// <summary>
        /// The position of the suspension (ordered: RL, RR, FL, FR).
        /// </summary>
        public float[] SuspensionPosition { get; }

        /// <summary>
        /// The velocity of the suspension (ordered: RL, RR, FL, FR).
        /// </summary>
        public float[] SuspensionVelocity { get; }

        /// <summary>
        /// The speed of the wheels (ordered: RL, RR, FL, FR).
        /// </summary>
        public float[] WheelSpeed { get; }
        
        public float Throttle { get; }

        /// <summary>
        /// The percentage of max steering applied.
        /// </summary>
        public float Steering { get; }

        public float Brake { get; }

        public float Clutch { get; }

        public float Gear { get; }

        /// <summary>
        /// Latitudinal G-Force (forward/backwards).
        /// </summary>
        public float GForceLat { get; }

        /// <summary>
        /// Longitudinal G-Force (left/right).
        /// </summary>
        public float GForceLon { get; }

        /// <summary>
        /// The current lap number TODO: Summary this
        /// </summary>
        public float Lap { get; }

        /// <summary>
        ///  TODO: Summary this
        /// </summary>
        public float EngineRate { get; }

        /// <summary>
        /// SLI Pro support.
        /// </summary>
        public float SliProNativeSupport { get; }

        /// <summary>
        /// Race position of the car.
        /// </summary>
        public float CarPosition { get; }

        /// <summary>
        /// KERS energy left.
        /// </summary>
        public float KersLevel { get; }

        /// <summary>
        /// Maximum KERS energy.
        /// </summary>
        public float MaxKersLevel { get; }

        /// <summary>
        /// Whether DRS is enabled or not, 0 = off, 1 = on.
        /// </summary>
        public float Drs { get; }

        /// <summary>
        /// Whether traction control is enabled or not, 0 (off) - 2 (high).
        /// </summary>
        public float TractionControl { get; }

        /// <summary>
        /// Whether anti lock braking is enabled or not, 0 (off) - 1 (on).
        /// </summary>
        public float AntiLockBrakes { get; }
        
        public float FuelRemaining { get; }
        
        public float FuelCapacity { get; }

        /// <summary>
        /// Whether the car is in the pits or not, 0 = none, 1 = pitting, 2 = in pit area.
        /// </summary>
        public float InPits { get; }

        /// <summary>
        /// The current sector of the car, 0 = sector1, 1 = sector2, 2 = sector3.
        /// </summary>
        public float Sector { get; }

        /// <summary>
        /// Time of sector1 (or 0).
        /// </summary>
        public float Sector1Time { get; }

        /// <summary>
        /// Time of sector2 (or 0).
        /// </summary>
        public float Sector2Time { get; }

        /// <summary>
        /// Brake Temperatures (ordered: RL, RR, FL, FR).
        /// </summary>
        public float[] BrakeTemps { get; }

        /// <summary>
        /// Tyre pressures in PSI (ordered: RL, RR, FL, FR).
        /// </summary>
        public float[] TyrePressures { get; }

        /// <summary>
        /// The ID of the Team.
        /// </summary>
        public float TeamId { get; }

        /// <summary>
        /// Total number of laps in the race.
        /// </summary>
        public float TotalLaps { get; }

        /// <summary>
        /// The length of the track in metres.
        /// </summary>
        public float TrackSize { get; }
        
        public float LastLapTime { get; }

        /// <summary>
        /// The RPM at which the rev limiter will kick in.
        /// </summary>
        public float MaxRpm { get; }
        
        public float IdleRpm { get; }
        
        public float MaxGears { get; }

        /// <summary>
        /// The current session type (0 = unknown, 1 = practice, 2 = qualifying, 3 = race).
        /// </summary>
        public float SessionType { get; }

        /// <summary>
        /// Whether or not DRS is allowed (0 = not allowed, 1 = allowed, -1 = invalid / unknown).
        /// </summary>
        public float DrsAllowed { get; }

        /// <summary>
        /// The ID of the current track (-1 for unknown, 0-21 for tracks).
        /// </summary>
        public float TrackNumber { get; }

        /// <summary>
        /// The track flag being waved at the car (-1 = invalid/unknown, 0 = none, 1 = green, 2 = blue, 3 = yellow, 4 = red).
        /// </summary>
        public float VehicleFiaFlag { get; }

        /// <summary>
        /// The era of the cars (2017 = current, 1980 = classic).
        /// </summary>
        public float Era { get; }

        /// <summary>
        /// The engine temperature in centigrade.
        /// </summary>
        public float EngineTemperature { get; }

        /// <summary>
        /// Vertical G-Force.
        /// </summary>
        public float GForceVertical { get; }

        /// <summary>
        /// Angular velocity X-component.
        /// </summary>
        public float XAngularVelocity { get; }

        /// <summary>
        /// Angular velocity Y-component.
        /// </summary>
        public float YAngularVelocity { get; }

        /// <summary>
        /// Angular velocity Z-component.
        /// </summary>
        public float ZAngularVelocity { get; }

        /// <summary>
        /// Tyre temperatures in centigrade (ordered: RL, RR, FL, FR).
        /// </summary>
        public byte[] TyreTemperatures { get; }

        /// <summary>
        /// Tyre wear percentages (ordered: RL, RR, FL, FR).
        /// </summary>
        public byte[] TyreWear { get; }

        /// <summary>
        /// Compund of tyre on the car (0 = ultra soft, 1 = super soft, 2 = soft, 3 = medium, 4 = hard, 5 = inter, 6 = wet).
        /// </summary>
        public byte TyreCompound { get; }

        /// <summary>
        /// Front brake bias percentage.
        /// </summary>
        public byte FrontBrakeBias { get; }

        /// <summary>
        /// Active fuel mix (0 = lean, 1 = standard, 2 = rich, 3 = max).
        /// </summary>
        public byte FuelMix { get; }

        /// <summary>
        /// Whether the current lap is valid or not (0 = valid, 1 = invalid).
        /// </summary>
        public byte CurrentLapInvalid { get; }

        /// <summary>
        /// Tyre damage percentage (ordered: RL, RR, FL, FR).
        /// </summary>
        public byte[] TyreDamage { get; }

        /// <summary>
        /// Front left wing damage percentage.
        /// </summary>
        public byte FrontLeftWingDamage { get; }

        /// <summary>
        /// Front right wing damage percentage.
        /// </summary>
        public byte FrontRightWingDamage { get; }

        /// <summary>
        /// Rear wing damage percentage.
        /// </summary>
        public byte RearWingDamage { get; }

        /// <summary>
        /// Engine Damage percentage.
        /// </summary>
        public byte EngineDamage { get; }

        /// <summary>
        /// Gear box damage percentage.
        /// </summary>
        public byte GearBoxDamage { get; }

        /// <summary>
        /// Exhaust damage percentage.
        /// </summary>
        public byte ExhaustDamage { get; }

        /// <summary>
        /// Whether the pit limiter is on or not (0 = off, 1 = on).
        /// </summary>
        public byte PitLimiterEnabled { get; }

        /// <summary>
        /// Pit speed limit in MPH.
        /// </summary>
        public byte PitSpeedLimit { get; }

        /// <summary>
        /// Time left in the session.
        /// </summary>
        public float SessionTimeLeft { get; }

        /// <summary>
        /// Rev lights indicator percentage.
        /// </summary>
        public byte RevLightsPercent { get; }

        /// <summary>
        /// Whether the player is spectating or not (0 = not spectating, 1 = spectating).
        /// </summary>
        public byte Spectating { get; }

        /// <summary>
        /// Index of the car being spectated.
        /// </summary>
        public byte SpectatorCarIndex { get; }


        // Car data
        /// <summary>
        /// The number of cars in data.
        /// </summary>
        public byte NumberOfCars { get; }

        /// <summary>
        /// Index of the player's car in the TyrePressures.
        /// </summary>
        public byte PlayerCarIndex { get; }

        /// <summary>
        /// Data for all cars on track.
        /// </summary>
        public CarUdpData[] CarData { get; }


        public float Yaw { get; }

        public float Pitch { get; }

        public float Roll { get; }

        /// <summary>
        /// X velocity in local space.
        /// </summary>
        public float XLocalVelocity { get; }

        /// <summary>
        /// Y velocity in local space.
        /// </summary>
        public float YLocalVelocity { get; }

        /// <summary>
        /// Z velocity in local space.
        /// </summary>
        public float ZLocalVelocity { get; }

        /// <summary>
        /// Acceleration on the suspension (ordered: RL, RR, FL, FR).
        /// </summary>
        public float[] SuspensionAcceleration { get; }

        /// <summary>
        /// Angular acceleration X-component
        /// </summary>
        public float AngularAccelerationX { get; }

        /// <summary>
        /// Angular acceleration Y-component
        /// </summary>
        public float AngularAccelerationY { get; }

        /// <summary>
        /// Angular acceleration Z-component
        /// </summary>
        public float AngularAccelerationZ { get; }

        public UdpPacket(byte[] packetData)
        {
            using (var stream = new MemoryStream(packetData))
            using (var reader = new BinaryReader(stream))
            {
                SessionTime = reader.ReadSingle();
                LapTime = reader.ReadSingle();
                LapDistance = reader.ReadSingle();
                TotalDistance = reader.ReadSingle();
                X = reader.ReadSingle();
                Y = reader.ReadSingle();
                Z = reader.ReadSingle();
                Speed = reader.ReadSingle();
                XVelocity = reader.ReadSingle();
                YVelocity = reader.ReadSingle();
                ZVelocity = reader.ReadSingle();
                XRightDirection = reader.ReadSingle();
                YRightDirection = reader.ReadSingle();
                ZRightDirection = reader.ReadSingle();
                XForwardDirection = reader.ReadSingle();
                YForwardDirection = reader.ReadSingle();
                ZForwardDiretion = reader.ReadSingle();
                SuspensionPosition = new float[4];
                SuspensionPosition[0] = reader.ReadSingle();
                SuspensionPosition[1] = reader.ReadSingle();
                SuspensionPosition[2] = reader.ReadSingle();
                SuspensionPosition[3] = reader.ReadSingle();
                SuspensionVelocity = new float[4];
                SuspensionVelocity[0] = reader.ReadSingle();
                SuspensionVelocity[1] = reader.ReadSingle();
                SuspensionVelocity[2] = reader.ReadSingle();
                SuspensionVelocity[3] = reader.ReadSingle();
                WheelSpeed = new float[4];
                WheelSpeed[0] = reader.ReadSingle();
                WheelSpeed[1] = reader.ReadSingle();
                WheelSpeed[2] = reader.ReadSingle();
                WheelSpeed[3] = reader.ReadSingle();
                Throttle = reader.ReadSingle();
                Steering = reader.ReadSingle();
                Brake = reader.ReadSingle();
                Clutch = reader.ReadSingle();
                Gear = reader.ReadSingle();
                GForceLat = reader.ReadSingle();
                GForceLon = reader.ReadSingle();
                Lap = reader.ReadSingle();
                EngineRate = reader.ReadSingle();
                SliProNativeSupport = reader.ReadSingle();
                CarPosition = reader.ReadSingle();
                KersLevel = reader.ReadSingle();
                MaxKersLevel = reader.ReadSingle();
                Drs = reader.ReadSingle();
                TractionControl = reader.ReadSingle();
                AntiLockBrakes = reader.ReadSingle();
                FuelRemaining = reader.ReadSingle();
                FuelCapacity = reader.ReadSingle();
                InPits = reader.ReadSingle();
                Sector = reader.ReadSingle();
                Sector1Time = reader.ReadSingle();
                Sector2Time = reader.ReadSingle();
                BrakeTemps = new float[4];
                BrakeTemps[0] = reader.ReadSingle();
                BrakeTemps[1] = reader.ReadSingle();
                BrakeTemps[2] = reader.ReadSingle();
                BrakeTemps[3] = reader.ReadSingle();
                TyrePressures = new float[4];
                TyrePressures[0] = reader.ReadSingle();
                TyrePressures[1] = reader.ReadSingle();
                TyrePressures[2] = reader.ReadSingle();
                TyrePressures[3] = reader.ReadSingle();
                TeamId = reader.ReadSingle();
                TotalLaps = reader.ReadSingle();
                TrackSize = reader.ReadSingle();
                LastLapTime = reader.ReadSingle();
                MaxRpm = reader.ReadSingle();
                IdleRpm = reader.ReadSingle();
                MaxGears = reader.ReadSingle();
                SessionType = reader.ReadSingle();
                DrsAllowed = reader.ReadSingle();
                TrackNumber = reader.ReadSingle();
                VehicleFiaFlag = reader.ReadSingle();
                Era = reader.ReadSingle();
                EngineTemperature = reader.ReadSingle();
                GForceVertical = reader.ReadSingle();
                XAngularVelocity = reader.ReadSingle();
                YAngularVelocity = reader.ReadSingle();
                ZAngularVelocity = reader.ReadSingle();
                TyreTemperatures = new byte[4];
                TyreTemperatures[0] = reader.ReadByte();
                TyreTemperatures[1] = reader.ReadByte();
                TyreTemperatures[2] = reader.ReadByte();
                TyreTemperatures[3] = reader.ReadByte();
                TyreWear = new byte[4];
                TyreWear[0] = reader.ReadByte();
                TyreWear[1] = reader.ReadByte();
                TyreWear[2] = reader.ReadByte();
                TyreWear[3] = reader.ReadByte();
                TyreCompound = reader.ReadByte();
                FrontBrakeBias = reader.ReadByte();
                FuelMix = reader.ReadByte();
                CurrentLapInvalid = reader.ReadByte();
                TyreDamage = new byte[4];
                TyreDamage[0] = reader.ReadByte();
                TyreDamage[1] = reader.ReadByte();
                TyreDamage[2] = reader.ReadByte();
                TyreDamage[3] = reader.ReadByte();
                FrontLeftWingDamage = reader.ReadByte();
                FrontRightWingDamage = reader.ReadByte();
                RearWingDamage = reader.ReadByte();
                EngineDamage = reader.ReadByte();
                GearBoxDamage = reader.ReadByte();
                ExhaustDamage = reader.ReadByte();
                PitLimiterEnabled = reader.ReadByte();
                PitSpeedLimit = reader.ReadByte();
                SessionTimeLeft = reader.ReadSingle();
                RevLightsPercent = reader.ReadByte();
                Spectating = reader.ReadByte();
                SpectatorCarIndex = reader.ReadByte();
                NumberOfCars = reader.ReadByte();
                PlayerCarIndex = reader.ReadByte();
                CarData = new CarUdpData[20];
                for (var i = 0; i < 20; i++)
                    CarData[i] = new CarUdpData(reader);
                Yaw = reader.ReadByte();
                Pitch = reader.ReadSingle();
                Roll = reader.ReadSingle();
                XLocalVelocity = reader.ReadSingle();
                YLocalVelocity = reader.ReadSingle();
                ZLocalVelocity = reader.ReadSingle();
                SuspensionAcceleration = new float[4];
                SuspensionAcceleration[0] = reader.ReadSingle();
                SuspensionAcceleration[1] = reader.ReadSingle();
                SuspensionAcceleration[2] = reader.ReadSingle();
                SuspensionAcceleration[3] = reader.ReadSingle();
                AngularAccelerationX = reader.ReadSingle();
                AngularAccelerationY = reader.ReadSingle();
                AngularAccelerationZ = reader.ReadSingle();
            }
        }
    }

    public class CarUdpData
    {
        /// <summary>
        /// World co-ordinates of vehicle.
        /// </summary>
        public float[] WorldPosition { get; }

        public float LastLapTime { get; }

        public float CurrentLapTime { get; }

        public float BestLapTime { get; }

        public float Sector1Time { get; }

        public float Sector2Time { get; }

        public float LapDistance { get; }

        public byte DriverId { get; }

        public byte TeamId { get; }

        /// <summary>
        /// Track position of vehicle.
        /// </summary>
        public byte Position { get; }

        public byte CurrentLapNumber { get; }

        /// <summary>
        /// Compound of tyre (0 = ultra soft, 1 = super soft, 2 = soft, 3 = medium, 4 = hard, 5 = inter, 6 = wet).
        /// </summary>
        public byte TyreCompound { get; }

        /// <summary>
        /// Whether the car is in the pits or not (0 = none, 1 = pitting, 2 = in pit area).
        /// </summary>
        public byte InPits { get; }

        /// <summary>
        /// The sector the car is in (0 = sector1, 1 = sector2, 2 = sector3).
        /// </summary>
        public byte Sector { get; }

        /// <summary>
        /// Whether the current lap is invalid or not (0 = valid, 1 = invalid).
        /// </summary>
        public byte CurrentLapInvalid { get; }

        /// <summary>
        /// Accumalated time penalties.
        /// </summary>
        public byte Penalties { get; }

        public CarUdpData(BinaryReader reader)
        {
            WorldPosition = new float[3];
            WorldPosition[0] = reader.ReadSingle();
            WorldPosition[1] = reader.ReadSingle();
            WorldPosition[2] = reader.ReadSingle();
            LastLapTime = reader.ReadSingle();
            CurrentLapTime = reader.ReadSingle();
            BestLapTime = reader.ReadSingle();
            Sector1Time = reader.ReadSingle();
            Sector2Time = reader.ReadSingle();
            LapDistance = reader.ReadSingle();
            DriverId = reader.ReadByte();
            TeamId = reader.ReadByte();
            Position = reader.ReadByte();
            CurrentLapNumber = reader.ReadByte();
            TyreCompound = reader.ReadByte();
            InPits = reader.ReadByte();
            Sector = reader.ReadByte();
            CurrentLapInvalid = reader.ReadByte();
            Penalties = reader.ReadByte();
        }
    }
}