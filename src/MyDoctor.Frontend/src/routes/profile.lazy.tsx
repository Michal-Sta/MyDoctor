import { createLazyFileRoute } from "@tanstack/react-router";
import React from "react";
import { Profile } from "../components/profile/profile";

function Index() {
  return <Profile />;
}

export const Route = createLazyFileRoute("/profile")({
  component: Index,
});
