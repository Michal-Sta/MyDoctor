import React from "react";
import { createLazyFileRoute } from "@tanstack/react-router";
import { AppointmentList } from "../components/appointment/appointment-list";

const Index = () => {
  return <AppointmentList />;
};

export const Route = createLazyFileRoute("/appointment-list")({
  component: Index,
});
