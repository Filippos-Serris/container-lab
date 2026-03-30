import type { Parking } from "../models/Parking";

const BASE_URL = "http://localhost:5000/api";

export async function getParking(id: number): Promise<Parking> {
  const response = await fetch(`${BASE_URL}/parkings/${id}`);

  if (!response.ok) {
    throw new Error("Failed to fetch parking");
  }

  return response.json();
}