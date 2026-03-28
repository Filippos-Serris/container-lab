import { useEffect, useState } from "react";
import { getParking } from "./api/parkingApi";
import type { Parking } from "./models/Parking";

function App() {
  const [parking, setParking] = useState<Parking | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    async function fetchData() {
      try {
        const data = await getParking(1);
        setParking(data);
      } catch (err) {
        setError("Error fetching parking");
      } finally {
        setLoading(false);
      }
    }

    fetchData();
  }, []);

  if (loading) return <p>Loading...</p>;
  if (error) return <p>{error}</p>;

  return (
    <div>
      <h1>Parking Info</h1>
      {parking && (
        <div>
          <p>ID: {parking.id}</p>
          <p>Name: {parking.name}</p>
          <p>Spots: {parking.spots}</p>
        </div>
      )}
    </div>
  );
}

export default App;
