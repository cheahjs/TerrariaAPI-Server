
using System;
using Hooks;

namespace Terraria
{
	public class NPC
	{
		public const int maxBuffs = 5;
		public static int immuneTime = 20;
		public static int maxAI = 4;
		public int netSpam;
		public static int spawnSpaceX = 3;
		public static int spawnSpaceY = 3;
		public static int maxAttack = 20;
		public static int[] attackNPC = new int[NPC.maxAttack];
		public Vector2[] oldPos = new Vector2[10];
		public int netSkip;
		public bool netAlways;
		public int realLife = -1;
		public static int sWidth = 1920;
		public static int sHeight = 1080;
		public static int spawnRangeX = (int)((double)(NPC.sWidth / 16) * 0.7);
		public static int spawnRangeY = (int)((double)(NPC.sHeight / 16) * 0.7);
		public static int safeRangeX = (int)((double)(NPC.sWidth / 16) * 0.52);
		public static int safeRangeY = (int)((double)(NPC.sHeight / 16) * 0.52);
		public static int activeRangeX = (int)((double)NPC.sWidth * 1.7);
		public static int activeRangeY = (int)((double)NPC.sHeight * 1.7);
		public static int townRangeX = NPC.sWidth;
		public static int townRangeY = NPC.sHeight;
		public float npcSlots = 1f;
		public static bool noSpawnCycle = false;
		public static int activeTime = 750;
		public static int defaultSpawnRate = 600;
		public static int defaultMaxSpawns = 5;
		public bool wet;
		public byte wetCount;
		public bool lavaWet;
		public int[] buffType = new int[5];
		public int[] buffTime = new int[5];
		public bool[] buffImmune = new bool[40];
		public bool onFire;
		public bool onFire2;
		public bool poisoned;
		public int lifeRegen;
		public int lifeRegenCount;
		public bool confused;
		public static bool downedBoss1 = false;
		public static bool downedBoss2 = false;
		public static bool downedBoss3 = false;
		public static bool savedGoblin = false;
		public static bool savedWizard = false;
		public static bool savedMech = false;
		public static bool downedGoblins = false;
		public static bool downedFrost = false;
		public static bool downedClown = false;
		public static int spawnRate = NPC.defaultSpawnRate;
		public static int maxSpawns = NPC.defaultMaxSpawns;
		public int soundDelay;
		public Vector2 position;
		public Vector2 velocity;
		public Vector2 oldPosition;
		public Vector2 oldVelocity;
		public int width;
		public int height;
		public bool active;
		public int[] immune = new int[256];
		public int direction = 1;
		public int directionY = 1;
		public int type;
		public float[] ai = new float[NPC.maxAI];
		public float[] localAI = new float[NPC.maxAI];
		public int aiAction;
		public int aiStyle;
		public bool justHit;
		public int timeLeft;
		public int target = -1;
		public int damage;
		public int defense;
		public int defDamage;
		public int defDefense;
		public int soundHit;
		public int soundKilled;
		public int life;
		public int lifeMax;
		public Rectangle targetRect;
		public double frameCounter;
		public Rectangle frame;
		public string name;
		public string displayName;
		public Color color;
		public int alpha;
		public float scale = 1f;
		public float knockBackResist = 1f;
		public int oldDirection;
		public int oldDirectionY;
		public int oldTarget;
		public int whoAmI;
		public float rotation;
		public bool noGravity;
		public bool noTileCollide;
		public bool netUpdate;
		public bool netUpdate2;
		public bool collideX;
		public bool collideY;
		public bool boss;
		public int spriteDirection = -1;
		public bool behindTiles;
		public bool lavaImmune;
		public float value;
		public bool dontTakeDamage;
		public int netID;
		public bool townNPC;
		public bool homeless;
		public int homeTileX = -1;
		public int homeTileY = -1;
		public bool oldHomeless;
		public int oldHomeTileX = -1;
		public int oldHomeTileY = -1;
		public bool friendly;
		public bool closeDoor;
		public int doorX;
		public int doorY;
		public int friendlyRegen;
		public static void clrNames()
		{
			for (int i = 0; i < 147; i++)
			{
				Main.chrName[i] = "";
			}
		}
		public static void setNames()
		{
			if (WorldGen.genRand == null)
			{
				WorldGen.genRand = new Random();
			}
			int num = WorldGen.genRand.Next(23);
			string text = "";
			switch (num)
			{
				case 0:
					text = "Molly";
					break;
				case 1:
					text = "Amy";
					break;
				case 2:
					text = "Claire";
					break;
				case 3:
					text = "Emily";
					break;
				case 4:
					text = "Katie";
					break;
				case 5:
					text = "Madeline";
					break;
				case 6:
					text = "Katelyn";
					break;
				case 7:
					text = "Emma";
					break;
				case 8:
					text = "Abigail";
					break;
				case 9:
					text = "Carly";
					break;
				case 10:
					text = "Jenna";
					break;
				case 11:
					text = "Heather";
					break;
				case 12:
					text = "Katherine";
					break;
				case 13:
					text = "Caitlin";
					break;
				case 14:
					text = "Kaitlin";
					break;
				case 15:
					text = "Holly";
					break;
				case 16:
					text = "Kaitlyn";
					break;
				case 17:
					text = "Hannah";
					break;
				case 18:
					text = "Kathryn";
					break;
				case 19:
					text = "Lorraine";
					break;
				case 20:
					text = "Helen";
					break;
				case 21:
					text = "Kayla";
					break;
				default:
					text = "Allison";
					break;
			}
			if (Main.chrName[18] == "")
			{
				Main.chrName[18] = text;
			}
			num = WorldGen.genRand.Next(24);
			text = "";
			if (num == 0)
			{
				text = "Shayna";
			}
			else
			{
				if (num == 1)
				{
					text = "Korrie";
				}
				else
				{
					if (num == 2)
					{
						text = "Ginger";
					}
					else
					{
						if (num == 3)
						{
							text = "Brooke";
						}
						else
						{
							if (num == 4)
							{
								text = "Jenny";
							}
							else
							{
								if (num == 5)
								{
									text = "Autumn";
								}
								else
								{
									if (num == 6)
									{
										text = "Nancy";
									}
									else
									{
										if (num == 7)
										{
											text = "Ella";
										}
										else
										{
											if (num == 8)
											{
												text = "Kayla";
											}
											else
											{
												if (num == 9)
												{
													text = "Beth";
												}
												else
												{
													if (num == 10)
													{
														text = "Sophia";
													}
													else
													{
														if (num == 11)
														{
															text = "Marshanna";
														}
														else
														{
															if (num == 12)
															{
																text = "Lauren";
															}
															else
															{
																if (num == 13)
																{
																	text = "Trisha";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Shirlena";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Sheena";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Ellen";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Amy";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Dawn";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Susana";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Meredith";
																							}
																							else
																							{
																								if (num == 21)
																								{
																									text = "Selene";
																								}
																								else
																								{
																									if (num == 22)
																									{
																										text = "Terra";
																									}
																									else
																									{
																										text = "Sally";
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[124] == "")
			{
				Main.chrName[124] = text;
			}
			num = WorldGen.genRand.Next(23);
			text = "";
			if (num == 0)
			{
				text = "DeShawn";
			}
			else
			{
				if (num == 1)
				{
					text = "DeAndre";
				}
				else
				{
					if (num == 2)
					{
						text = "Marquis";
					}
					else
					{
						if (num == 3)
						{
							text = "Darnell";
						}
						else
						{
							if (num == 4)
							{
								text = "Terrell";
							}
							else
							{
								if (num == 5)
								{
									text = "Malik";
								}
								else
								{
									if (num == 6)
									{
										text = "Trevon";
									}
									else
									{
										if (num == 7)
										{
											text = "Tyrone";
										}
										else
										{
											if (num == 8)
											{
												text = "Willie";
											}
											else
											{
												if (num == 9)
												{
													text = "Dominique";
												}
												else
												{
													if (num == 10)
													{
														text = "Demetrius";
													}
													else
													{
														if (num == 11)
														{
															text = "Reginald";
														}
														else
														{
															if (num == 12)
															{
																text = "Jamal";
															}
															else
															{
																if (num == 13)
																{
																	text = "Maurice";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Jalen";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Darius";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Xavier";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Terrance";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Andre";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Dante";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Brimst";
																							}
																							else
																							{
																								if (num == 21)
																								{
																									text = "Bronson";
																								}
																								else
																								{
																									text = "Darryl";
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[19] == "")
			{
				Main.chrName[19] = text;
			}
			num = WorldGen.genRand.Next(35);
			text = "";
			if (num == 0)
			{
				text = "Jake";
			}
			else
			{
				if (num == 1)
				{
					text = "Connor";
				}
				else
				{
					if (num == 2)
					{
						text = "Tanner";
					}
					else
					{
						if (num == 3)
						{
							text = "Wyatt";
						}
						else
						{
							if (num == 4)
							{
								text = "Cody";
							}
							else
							{
								if (num == 5)
								{
									text = "Dustin";
								}
								else
								{
									if (num == 6)
									{
										text = "Luke";
									}
									else
									{
										if (num == 7)
										{
											text = "Jack";
										}
										else
										{
											if (num == 8)
											{
												text = "Scott";
											}
											else
											{
												if (num == 9)
												{
													text = "Logan";
												}
												else
												{
													if (num == 10)
													{
														text = "Cole";
													}
													else
													{
														if (num == 11)
														{
															text = "Lucas";
														}
														else
														{
															if (num == 12)
															{
																text = "Bradley";
															}
															else
															{
																if (num == 13)
																{
																	text = "Jacob";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Garrett";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Dylan";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Maxwell";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Steve";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Brett";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Andrew";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Harley";
																							}
																							else
																							{
																								if (num == 21)
																								{
																									text = "Kyle";
																								}
																								else
																								{
																									if (num == 22)
																									{
																										text = "Jake";
																									}
																									else
																									{
																										if (num == 23)
																										{
																											text = "Ryan";
																										}
																										else
																										{
																											if (num == 24)
																											{
																												text = "Jeffrey";
																											}
																											else
																											{
																												if (num == 25)
																												{
																													text = "Seth";
																												}
																												else
																												{
																													if (num == 26)
																													{
																														text = "Marty";
																													}
																													else
																													{
																														if (num == 27)
																														{
																															text = "Brandon";
																														}
																														else
																														{
																															if (num == 28)
																															{
																																text = "Zach";
																															}
																															else
																															{
																																if (num == 29)
																																{
																																	text = "Jeff";
																																}
																																else
																																{
																																	if (num == 30)
																																	{
																																		text = "Daniel";
																																	}
																																	else
																																	{
																																		if (num == 31)
																																		{
																																			text = "Trent";
																																		}
																																		else
																																		{
																																			if (num == 32)
																																			{
																																				text = "Kevin";
																																			}
																																			else
																																			{
																																				if (num == 33)
																																				{
																																					text = "Brian";
																																				}
																																				else
																																				{
																																					text = "Colin";
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[22] == "")
			{
				Main.chrName[22] = text;
			}
			num = WorldGen.genRand.Next(22);
			text = "";
			if (num == 0)
			{
				text = "Alalia";
			}
			else
			{
				if (num == 1)
				{
					text = "Alalia";
				}
				else
				{
					if (num == 2)
					{
						text = "Alura";
					}
					else
					{
						if (num == 3)
						{
							text = "Ariella";
						}
						else
						{
							if (num == 4)
							{
								text = "Caelia";
							}
							else
							{
								if (num == 5)
								{
									text = "Calista";
								}
								else
								{
									if (num == 6)
									{
										text = "Chryseis";
									}
									else
									{
										if (num == 7)
										{
											text = "Emerenta";
										}
										else
										{
											if (num == 8)
											{
												text = "Elysia";
											}
											else
											{
												if (num == 9)
												{
													text = "Evvie";
												}
												else
												{
													if (num == 10)
													{
														text = "Faye";
													}
													else
													{
														if (num == 11)
														{
															text = "Felicitae";
														}
														else
														{
															if (num == 12)
															{
																text = "Lunette";
															}
															else
															{
																if (num == 13)
																{
																	text = "Nata";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Nissa";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Tatiana";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Rosalva";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Shea";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Tania";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Isis";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Celestia";
																							}
																							else
																							{
																								text = "Xylia";
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[20] == "")
			{
				Main.chrName[20] = text;
			}
			num = WorldGen.genRand.Next(22);
			text = "";
			if (num == 0)
			{
				text = "Dolbere";
			}
			else
			{
				if (num == 1)
				{
					text = "Bazdin";
				}
				else
				{
					if (num == 2)
					{
						text = "Durim";
					}
					else
					{
						if (num == 3)
						{
							text = "Tordak";
						}
						else
						{
							if (num == 4)
							{
								text = "Garval";
							}
							else
							{
								if (num == 5)
								{
									text = "Morthal";
								}
								else
								{
									if (num == 6)
									{
										text = "Oten";
									}
									else
									{
										if (num == 7)
										{
											text = "Dolgen";
										}
										else
										{
											if (num == 8)
											{
												text = "Gimli";
											}
											else
											{
												if (num == 9)
												{
													text = "Gimut";
												}
												else
												{
													if (num == 10)
													{
														text = "Duerthen";
													}
													else
													{
														if (num == 11)
														{
															text = "Beldin";
														}
														else
														{
															if (num == 12)
															{
																text = "Jarut";
															}
															else
															{
																if (num == 13)
																{
																	text = "Ovbere";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Norkas";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Dolgrim";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Boften";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Norsun";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Dias";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Fikod";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Urist";
																							}
																							else
																							{
																								text = "Darur";
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[38] == "")
			{
				Main.chrName[38] = text;
			}
			num = WorldGen.genRand.Next(21);
			text = "";
			if (num == 0)
			{
				text = "Dalamar";
			}
			else
			{
				if (num == 1)
				{
					text = "Dulais";
				}
				else
				{
					if (num == 2)
					{
						text = "Elric";
					}
					else
					{
						if (num == 3)
						{
							text = "Arddun";
						}
						else
						{
							if (num == 4)
							{
								text = "Maelor";
							}
							else
							{
								if (num == 5)
								{
									text = "Leomund";
								}
								else
								{
									if (num == 6)
									{
										text = "Hirael";
									}
									else
									{
										if (num == 7)
										{
											text = "Gwentor";
										}
										else
										{
											if (num == 8)
											{
												text = "Greum";
											}
											else
											{
												if (num == 9)
												{
													text = "Gearroid";
												}
												else
												{
													if (num == 10)
													{
														text = "Fizban";
													}
													else
													{
														if (num == 11)
														{
															text = "Ningauble";
														}
														else
														{
															if (num == 12)
															{
																text = "Seonag";
															}
															else
															{
																if (num == 13)
																{
																	text = "Sargon";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Merlyn";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Magius";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Berwyn";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Arwyn";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Alasdair";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Tagar";
																						}
																						else
																						{
																							text = "Xanadu";
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[108] == "")
			{
				Main.chrName[108] = text;
			}
			num = WorldGen.genRand.Next(23);
			text = "";
			if (num == 0)
			{
				text = "Alfred";
			}
			else
			{
				if (num == 1)
				{
					text = "Barney";
				}
				else
				{
					if (num == 2)
					{
						text = "Calvin";
					}
					else
					{
						if (num == 3)
						{
							text = "Edmund";
						}
						else
						{
							if (num == 4)
							{
								text = "Edwin";
							}
							else
							{
								if (num == 5)
								{
									text = "Eugene";
								}
								else
								{
									if (num == 6)
									{
										text = "Frank";
									}
									else
									{
										if (num == 7)
										{
											text = "Frederick";
										}
										else
										{
											if (num == 8)
											{
												text = "Gilbert";
											}
											else
											{
												if (num == 9)
												{
													text = "Gus";
												}
												else
												{
													if (num == 10)
													{
														text = "Wilbur";
													}
													else
													{
														if (num == 11)
														{
															text = "Seymour";
														}
														else
														{
															if (num == 12)
															{
																text = "Louis";
															}
															else
															{
																if (num == 13)
																{
																	text = "Humphrey";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Harold";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Milton";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Mortimer";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Howard";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Walter";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Finn";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Isacc";
																							}
																							else
																							{
																								if (num == 21)
																								{
																									text = "Joseph";
																								}
																								else
																								{
																									text = "Ralph";
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[17] == "")
			{
				Main.chrName[17] = text;
			}
			num = WorldGen.genRand.Next(24);
			text = "";
			if (num == 0)
			{
				text = "Sebastian";
			}
			else
			{
				if (num == 1)
				{
					text = "Rupert";
				}
				else
				{
					if (num == 2)
					{
						text = "Clive";
					}
					else
					{
						if (num == 3)
						{
							text = "Nigel";
						}
						else
						{
							if (num == 4)
							{
								text = "Mervyn";
							}
							else
							{
								if (num == 5)
								{
									text = "Cedric";
								}
								else
								{
									if (num == 6)
									{
										text = "Pip";
									}
									else
									{
										if (num == 7)
										{
											text = "Cyril";
										}
										else
										{
											if (num == 8)
											{
												text = "Fitz";
											}
											else
											{
												if (num == 9)
												{
													text = "Lloyd";
												}
												else
												{
													if (num == 10)
													{
														text = "Arthur";
													}
													else
													{
														if (num == 11)
														{
															text = "Rodney";
														}
														else
														{
															if (num == 12)
															{
																text = "Graham";
															}
															else
															{
																if (num == 13)
																{
																	text = "Edward";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Alfred";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Edmund";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Henry";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Herald";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Roland";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Lincoln";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Lloyd";
																							}
																							else
																							{
																								if (num == 21)
																								{
																									text = "Edgar";
																								}
																								else
																								{
																									if (num == 22)
																									{
																										text = "Eustace";
																									}
																									else
																									{
																										text = "Rodrick";
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[54] == "")
			{
				Main.chrName[54] = text;
			}
			num = WorldGen.genRand.Next(25);
			text = "";
			if (num == 0)
			{
				text = "Grodax";
			}
			else
			{
				if (num == 1)
				{
					text = "Sarx";
				}
				else
				{
					if (num == 2)
					{
						text = "Xon";
					}
					else
					{
						if (num == 3)
						{
							text = "Mrunok";
						}
						else
						{
							if (num == 4)
							{
								text = "Nuxatk";
							}
							else
							{
								if (num == 5)
								{
									text = "Tgerd";
								}
								else
								{
									if (num == 6)
									{
										text = "Darz";
									}
									else
									{
										if (num == 7)
										{
											text = "Smador";
										}
										else
										{
											if (num == 8)
											{
												text = "Stazen";
											}
											else
											{
												if (num == 9)
												{
													text = "Mobart";
												}
												else
												{
													if (num == 10)
													{
														text = "Knogs";
													}
													else
													{
														if (num == 11)
														{
															text = "Tkanus";
														}
														else
														{
															if (num == 12)
															{
																text = "Negurk";
															}
															else
															{
																if (num == 13)
																{
																	text = "Nort";
																}
																else
																{
																	if (num == 14)
																	{
																		text = "Durnok";
																	}
																	else
																	{
																		if (num == 15)
																		{
																			text = "Trogem";
																		}
																		else
																		{
																			if (num == 16)
																			{
																				text = "Stezom";
																			}
																			else
																			{
																				if (num == 17)
																				{
																					text = "Gnudar";
																				}
																				else
																				{
																					if (num == 18)
																					{
																						text = "Ragz";
																					}
																					else
																					{
																						if (num == 19)
																						{
																							text = "Fahd";
																						}
																						else
																						{
																							if (num == 20)
																							{
																								text = "Xanos";
																							}
																							else
																							{
																								if (num == 21)
																								{
																									text = "Arback";
																								}
																								else
																								{
																									if (num == 22)
																									{
																										text = "Fjell";
																									}
																									else
																									{
																										if (num == 23)
																										{
																											text = "Dalek";
																										}
																										else
																										{
																											text = "Knub";
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Main.chrName[107] == "")
			{
				Main.chrName[107] = text;
			}
		}
		public void netDefaults(int type)
		{
			if (type < 0)
			{
				switch (type)
				{
					case -1:
						this.SetDefaults("Slimeling");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -2:
						this.SetDefaults("Slimer2");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -3:
						this.SetDefaults("Green Slime");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -4:
						this.SetDefaults("Pinky");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -5:
						this.SetDefaults("Baby Slime");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -6:
						this.SetDefaults("Black Slime");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -7:
						this.SetDefaults("Purple Slime");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -8:
						this.SetDefaults("Red Slime");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -9:
						this.SetDefaults("Yellow Slime");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -10:
						this.SetDefaults("Jungle Slime");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -11:
						this.SetDefaults("Little Eater");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -12:
						this.SetDefaults("Big Eater");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -13:
						this.SetDefaults("Short Bones");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -14:
						this.SetDefaults("Big Boned");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -15:
						this.SetDefaults("Heavy Skeleton");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -16:
						this.SetDefaults("Little Stinger");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
					case -17:
						this.SetDefaults("Big Stinger");
						NpcHooks.OnNetDefaults(ref type, this);
						return;
				}
			}
			else
			{
				this.SetDefaults(type, -1f);
			}
		}
		public void SetDefaults(string Name)
		{
			this.SetDefaults(0, -1f);
			switch (Name)
			{
				case "Slimeling":
					this.SetDefaults(81, 0.6f);
					this.name = Name;
					this.damage = 45;
					this.defense = 10;
					this.life = 90;
					this.knockBackResist = 1.2f;
					this.value = 100f;
					this.netID = -1;
					break;
				case "Slimer2":
					this.SetDefaults(81, 0.9f);
					this.displayName = "Slimer";
					this.name = Name;
					this.damage = 45;
					this.defense = 20;
					this.life = 90;
					this.knockBackResist = 1.2f;
					this.value = 100f;
					this.netID = -2;
					break;
				case "Green Slime":
					this.SetDefaults(1, 0.9f);
					this.name = Name;
					this.damage = 6;
					this.defense = 0;
					this.life = 14;
					this.knockBackResist = 1.2f;
					this.color = new Color(0, 220, 40, 100);
					this.value = 3f;
					this.netID = -3;
					break;
				case "Pinky":
					this.SetDefaults(1, 0.6f);
					this.name = Name;
					this.damage = 5;
					this.defense = 5;
					this.life = 150;
					this.knockBackResist = 1.4f;
					this.color = new Color(250, 30, 90, 90);
					this.value = 10000f;
					this.netID = -4;
					break;
				case "Baby Slime":
					this.SetDefaults(1, 0.9f);
					this.name = Name;
					this.damage = 13;
					this.defense = 4;
					this.life = 30;
					this.knockBackResist = 0.95f;
					this.alpha = 120;
					this.color = new Color(0, 0, 0, 50);
					this.value = 10f;
					this.netID = -5;
					break;
				case "Black Slime":
					this.SetDefaults(1, -1f);
					this.name = Name;
					this.damage = 15;
					this.defense = 4;
					this.life = 45;
					this.color = new Color(0, 0, 0, 50);
					this.value = 20f;
					this.netID = -6;
					break;
				case "Purple Slime":
					this.SetDefaults(1, 1.2f);
					this.name = Name;
					this.damage = 12;
					this.defense = 6;
					this.life = 40;
					this.knockBackResist = 0.9f;
					this.color = new Color(200, 0, 255, 150);
					this.value = 10f;
					this.netID = -7;
					break;
				case "Red Slime":
					this.SetDefaults(1, -1f);
					this.name = Name;
					this.damage = 12;
					this.defense = 4;
					this.life = 35;
					this.color = new Color(255, 30, 0, 100);
					this.value = 8f;
					this.netID = -8;
					break;
				case "Yellow Slime":
					this.SetDefaults(1, 1.2f);
					this.name = Name;
					this.damage = 15;
					this.defense = 7;
					this.life = 45;
					this.color = new Color(255, 255, 0, 100);
					this.value = 10f;
					this.netID = -9;
					break;
				case "Jungle Slime":
					this.SetDefaults(1, 1.1f);
					this.name = Name;
					this.damage = 18;
					this.defense = 6;
					this.life = 60;
					this.color = new Color(143, 215, 93, 100);
					this.value = 500f;
					this.netID = -10;
					break;
				case "Little Eater":
					this.SetDefaults(6, 0.85f);
					this.name = Name;
					this.defense = (int)((float)this.defense * this.scale);
					this.damage = (int)((float)this.damage * this.scale);
					this.life = (int)((float)this.life * this.scale);
					this.value = (float)((int)(this.value * this.scale));
					this.npcSlots *= this.scale;
					this.knockBackResist *= 2f - this.scale;
					this.netID = -11;
					break;
				case "Big Eater":
					this.SetDefaults(6, 1.15f);
					this.name = Name;
					this.defense = (int)((float)this.defense * this.scale);
					this.damage = (int)((float)this.damage * this.scale);
					this.life = (int)((float)this.life * this.scale);
					this.value = (float)((int)(this.value * this.scale));
					this.npcSlots *= this.scale;
					this.knockBackResist *= 2f - this.scale;
					this.netID = -12;
					break;
				case "Short Bones":
					this.SetDefaults(31, 0.9f);
					this.name = Name;
					this.defense = (int)((float)this.defense * this.scale);
					this.damage = (int)((float)this.damage * this.scale);
					this.life = (int)((float)this.life * this.scale);
					this.value = (float)((int)(this.value * this.scale));
					this.netID = -13;
					break;
				case "Big Boned":
					this.SetDefaults(31, 1.15f);
					this.name = Name;
					this.defense = (int)((float)this.defense * this.scale);
					this.damage = (int)((double)((float)this.damage * this.scale) * 1.1);
					this.life = (int)((double)((float)this.life * this.scale) * 1.1);
					this.value = (float)((int)(this.value * this.scale));
					this.npcSlots = 2f;
					this.knockBackResist *= 2f - this.scale;
					this.netID = -14;
					break;
				case "Heavy Skeleton":
					this.SetDefaults(77, 1.15f);
					this.name = Name;
					this.defense = (int)((float)this.defense * this.scale);
					this.damage = (int)((double)((float)this.damage * this.scale) * 1.1);
					this.life = 400;
					this.value = (float)((int)(this.value * this.scale));
					this.npcSlots = 2f;
					this.knockBackResist *= 2f - this.scale;
					this.height = 44;
					this.netID = -15;
					break;
				case "Little Stinger":
					this.SetDefaults(42, 0.85f);
					this.name = Name;
					this.defense = (int)((float)this.defense * this.scale);
					this.damage = (int)((float)this.damage * this.scale);
					this.life = (int)((float)this.life * this.scale);
					this.value = (float)((int)(this.value * this.scale));
					this.npcSlots *= this.scale;
					this.knockBackResist *= 2f - this.scale;
					this.netID = -16;
					break;
				case "Big Stinger":
					this.SetDefaults(42, 1.2f);
					this.name = Name;
					this.defense = (int)((float)this.defense * this.scale);
					this.damage = (int)((float)this.damage * this.scale);
					this.life = (int)((float)this.life * this.scale);
					this.value = (float)((int)(this.value * this.scale));
					this.npcSlots *= this.scale;
					this.knockBackResist *= 2f - this.scale;
					this.netID = -17;
					break;
				default:
					if (Name != "")
					{
						for (int i = 1; i < 147; i++)
						{
							if (Main.npcName[i] == Name)
							{
								this.SetDefaults(i, -1f);
								return;
							}
						}
						this.SetDefaults(0, -1f);
						this.active = false;
					}
					else
					{
						this.active = false;
					}
					break;
			}
            this.displayName = Lang.npcName(this.netID);
			this.lifeMax = this.life;
			this.defDamage = this.damage;
			this.defDefense = this.defense;
			NpcHooks.OnSetDefaultsString(ref Name, this);
		}
		public static bool MechSpawn(float x, float y, int type)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < 200; i++)
			{
				if (Main.npc[i].active && Main.npc[i].type == type)
				{
					num++;
					Vector2 vector = new Vector2(x, y);
					float num4 = Main.npc[i].position.X - vector.X;
					float num5 = Main.npc[i].position.Y - vector.Y;
					float num6 = (float)Math.Sqrt((double)(num4 * num4 + num5 * num5));
					if (num6 < 200f)
					{
						num2++;
					}
					if (num6 < 600f)
					{
						num3++;
					}
				}
			}
			return num2 < 3 && num3 < 6 && num < 10;
		}
		public static int TypeToNum(int type)
		{
			if (type == 17)
			{
				return 2;
			}
			if (type == 18)
			{
				return 3;
			}
			if (type == 19)
			{
				return 6;
			}
			if (type == 20)
			{
				return 5;
			}
			if (type == 22)
			{
				return 1;
			}
			if (type == 38)
			{
				return 4;
			}
			if (type == 54)
			{
				return 7;
			}
			if (type == 107)
			{
				return 9;
			}
			if (type == 108)
			{
				return 10;
			}
			if (type == 124)
			{
				return 8;
			}
			if (type == 142)
			{
				return 11;
			}
			return -1;
		}
		public static int NumToType(int type)
		{
			if (type == 2)
			{
				return 17;
			}
			if (type == 3)
			{
				return 18;
			}
			if (type == 6)
			{
				return 19;
			}
			if (type == 5)
			{
				return 20;
			}
			if (type == 1)
			{
				return 22;
			}
			if (type == 4)
			{
				return 38;
			}
			if (type == 7)
			{
				return 54;
			}
			if (type == 9)
			{
				return 107;
			}
			if (type == 10)
			{
				return 108;
			}
			if (type == 8)
			{
				return 124;
			}
			if (type == 11)
			{
				return 142;
			}
			return -1;
		}
		public void SetDefaults(int Type, float scaleOverride = -1f)
		{
			this.netID = 0;
			this.netAlways = false;
			this.netSpam = 0;
			for (int i = 0; i < this.oldPos.Length; i++)
			{
				this.oldPos[i].X = 0f;
				this.oldPos[i].Y = 0f;
			}
			for (int j = 0; j < 5; j++)
			{
				this.buffTime[j] = 0;
				this.buffType[j] = 0;
			}
			for (int k = 0; k < 40; k++)
			{
				this.buffImmune[k] = false;
			}
			this.buffImmune[31] = true;
			this.netSkip = -2;
			this.realLife = -1;
			this.lifeRegen = 0;
			this.lifeRegenCount = 0;
			this.poisoned = false;
			this.onFire = false;
			this.confused = false;
			this.onFire2 = false;
			this.justHit = false;
			this.dontTakeDamage = false;
			this.npcSlots = 1f;
			this.lavaImmune = false;
			this.lavaWet = false;
			this.wetCount = 0;
			this.wet = false;
			this.townNPC = false;
			this.homeless = false;
			this.homeTileX = -1;
			this.homeTileY = -1;
			this.friendly = false;
			this.behindTiles = false;
			this.boss = false;
			this.noTileCollide = false;
			this.rotation = 0f;
			this.active = true;
			this.alpha = 0;
			this.color = default(Color);
			this.collideX = false;
			this.collideY = false;
			this.direction = 0;
			this.oldDirection = this.direction;
			this.frameCounter = 0.0;
			this.netUpdate = true;
			this.netUpdate2 = false;
			this.knockBackResist = 1f;
			this.name = "";
			this.displayName = "";
			this.noGravity = false;
			this.scale = 1f;
			this.soundHit = 0;
			this.soundKilled = 0;
			this.spriteDirection = -1;
			this.target = 255;
			this.oldTarget = this.target;
			this.targetRect = default(Rectangle);
			this.timeLeft = NPC.activeTime;
			this.type = Type;
			this.value = 0f;
			for (int l = 0; l < NPC.maxAI; l++)
			{
				this.ai[l] = 0f;
			}
			for (int m = 0; m < NPC.maxAI; m++)
			{
				this.localAI[m] = 0f;
			}
			switch (this.type)
			{
				case 1:
					this.name = "Blue Slime";
					this.width = 24;
					this.height = 18;
					this.aiStyle = 1;
					this.damage = 7;
					this.defense = 2;
					this.lifeMax = 25;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.alpha = 175;
					this.color = new Color(0, 80, 255, 100);
					this.value = 25f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 2:
					this.name = "Demon Eye";
					this.width = 30;
					this.height = 32;
					this.aiStyle = 2;
					this.damage = 18;
					this.defense = 2;
					this.lifeMax = 60;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 1;
					this.value = 75f;
					this.buffImmune[31] = false;
					break;
				case 3:
					this.name = "Zombie";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 14;
					this.defense = 6;
					this.lifeMax = 45;
					this.soundHit = 1;
					this.soundKilled = 2;
					this.knockBackResist = 0.5f;
					this.value = 60f;
					this.buffImmune[31] = false;
					break;
				case 4:
					this.name = "Eye of Cthulhu";
					this.width = 100;
					this.height = 110;
					this.aiStyle = 4;
					this.damage = 15;
					this.defense = 12;
					this.lifeMax = 2800;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0f;
					this.noGravity = true;
					this.noTileCollide = true;
					this.timeLeft = NPC.activeTime * 30;
					this.boss = true;
					this.value = 30000f;
					this.npcSlots = 5f;
					break;
				case 5:
					this.name = "Servant of Cthulhu";
					this.width = 20;
					this.height = 20;
					this.aiStyle = 5;
					this.damage = 12;
					this.defense = 0;
					this.lifeMax = 8;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					break;
				case 6:
					this.npcSlots = 1f;
					this.name = "Eater of Souls";
					this.width = 30;
					this.height = 30;
					this.aiStyle = 5;
					this.damage = 22;
					this.defense = 8;
					this.lifeMax = 40;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.knockBackResist = 0.5f;
					this.value = 90f;
					break;
				case 7:
					this.displayName = "Devourer";
					this.npcSlots = 3.5f;
					this.name = "Devourer Head";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.damage = 31;
					this.defense = 2;
					this.lifeMax = 100;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 140f;
					this.netAlways = true;
					break;
				case 8:
					this.displayName = "Devourer";
					this.name = "Devourer Body";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 16;
					this.defense = 6;
					this.lifeMax = 100;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 140f;
					break;
				case 9:
					this.displayName = "Devourer";
					this.name = "Devourer Tail";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 13;
					this.defense = 10;
					this.lifeMax = 100;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 140f;
					break;
				case 10:
					this.displayName = "Giant Worm";
					this.name = "Giant Worm Head";
					this.width = 14;
					this.height = 14;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 8;
					this.defense = 0;
					this.lifeMax = 30;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 40f;
					break;
				case 11:
					this.displayName = "Giant Worm";
					this.name = "Giant Worm Body";
					this.width = 14;
					this.height = 14;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 4;
					this.defense = 4;
					this.lifeMax = 30;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 40f;
					break;
				case 12:
					this.displayName = "Giant Worm";
					this.name = "Giant Worm Tail";
					this.width = 14;
					this.height = 14;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 4;
					this.defense = 6;
					this.lifeMax = 30;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 40f;
					break;
				case 13:
					this.displayName = "Eater of Worlds";
					this.npcSlots = 5f;
					this.name = "Eater of Worlds Head";
					this.width = 38;
					this.height = 38;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 22;
					this.defense = 2;
					this.lifeMax = 65;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 300f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 14:
					this.displayName = "Eater of Worlds";
					this.name = "Eater of Worlds Body";
					this.width = 38;
					this.height = 38;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 13;
					this.defense = 4;
					this.lifeMax = 150;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 300f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 15:
					this.displayName = "Eater of Worlds";
					this.name = "Eater of Worlds Tail";
					this.width = 38;
					this.height = 38;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 11;
					this.defense = 8;
					this.lifeMax = 220;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 300f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 16:
					this.npcSlots = 2f;
					this.name = "Mother Slime";
					this.width = 36;
					this.height = 24;
					this.aiStyle = 1;
					this.damage = 20;
					this.defense = 7;
					this.lifeMax = 90;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.alpha = 120;
					this.color = new Color(0, 0, 0, 50);
					this.value = 75f;
					this.scale = 1.25f;
					this.knockBackResist = 0.6f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 17:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Merchant";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 18:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Nurse";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 19:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Arms Dealer";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 20:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Dryad";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 21:
					this.name = "Skeleton";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 20;
					this.defense = 8;
					this.lifeMax = 60;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.knockBackResist = 0.5f;
					this.value = 100f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 22:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Guide";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 23:
					this.name = "Meteor Head";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 5;
					this.damage = 40;
					this.defense = 6;
					this.lifeMax = 26;
					this.soundHit = 3;
					this.soundKilled = 3;
					this.noGravity = true;
					this.noTileCollide = true;
					this.value = 80f;
					this.knockBackResist = 0.4f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 24:
					this.npcSlots = 3f;
					this.name = "Fire Imp";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 8;
					this.damage = 30;
					this.defense = 16;
					this.lifeMax = 70;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					this.lavaImmune = true;
					this.value = 350f;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 25:
					this.name = "Burning Sphere";
					this.width = 16;
					this.height = 16;
					this.aiStyle = 9;
					this.damage = 30;
					this.defense = 0;
					this.lifeMax = 1;
					this.soundHit = 3;
					this.soundKilled = 3;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.alpha = 100;
					break;
				case 26:
					this.name = "Goblin Peon";
					this.scale = 0.9f;
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 12;
					this.defense = 4;
					this.lifeMax = 60;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.8f;
					this.value = 100f;
					this.buffImmune[31] = false;
					break;
				case 27:
					this.name = "Goblin Thief";
					this.scale = 0.95f;
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 20;
					this.defense = 6;
					this.lifeMax = 80;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.7f;
					this.value = 200f;
					this.buffImmune[31] = false;
					break;
				case 28:
					this.name = "Goblin Warrior";
					this.scale = 1.1f;
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 25;
					this.defense = 8;
					this.lifeMax = 110;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					this.value = 150f;
					this.buffImmune[31] = false;
					break;
				case 29:
					this.name = "Goblin Sorcerer";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 8;
					this.damage = 20;
					this.defense = 2;
					this.lifeMax = 40;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.6f;
					this.value = 200f;
					break;
				case 30:
					this.name = "Chaos Ball";
					this.width = 16;
					this.height = 16;
					this.aiStyle = 9;
					this.damage = 20;
					this.defense = 0;
					this.lifeMax = 1;
					this.soundHit = 3;
					this.soundKilled = 3;
					this.noGravity = true;
					this.noTileCollide = true;
					this.alpha = 100;
					this.knockBackResist = 0f;
					break;
				case 31:
					this.name = "Angry Bones";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 26;
					this.defense = 8;
					this.lifeMax = 80;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.knockBackResist = 0.8f;
					this.value = 130f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 32:
					this.name = "Dark Caster";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 8;
					this.damage = 20;
					this.defense = 2;
					this.lifeMax = 50;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.knockBackResist = 0.6f;
					this.value = 140f;
					this.npcSlots = 2f;
					this.buffImmune[20] = true;
					break;
				case 33:
					this.name = "Water Sphere";
					this.width = 16;
					this.height = 16;
					this.aiStyle = 9;
					this.damage = 20;
					this.defense = 0;
					this.lifeMax = 1;
					this.soundHit = 3;
					this.soundKilled = 3;
					this.noGravity = true;
					this.noTileCollide = true;
					this.alpha = 100;
					this.knockBackResist = 0f;
					break;
				case 34:
					this.name = "Cursed Skull";
					this.width = 26;
					this.height = 28;
					this.aiStyle = 10;
					this.damage = 35;
					this.defense = 6;
					this.lifeMax = 40;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.noGravity = true;
					this.noTileCollide = true;
					this.value = 150f;
					this.knockBackResist = 0.2f;
					this.npcSlots = 0.75f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 35:
					this.displayName = "Skeletron";
					this.name = "Skeletron Head";
					this.width = 80;
					this.height = 102;
					this.aiStyle = 11;
					this.damage = 32;
					this.defense = 10;
					this.lifeMax = 4400;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.noGravity = true;
					this.noTileCollide = true;
					this.value = 50000f;
					this.knockBackResist = 0f;
					this.boss = true;
					this.npcSlots = 6f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 36:
					this.displayName = "Skeletron";
					this.name = "Skeletron Hand";
					this.width = 52;
					this.height = 52;
					this.aiStyle = 12;
					this.damage = 20;
					this.defense = 14;
					this.lifeMax = 600;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 37:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Old Man";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 38:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Demolitionist";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 39:
					this.npcSlots = 6f;
					this.name = "Bone Serpent Head";
					this.displayName = "Bone Serpent";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 30;
					this.defense = 10;
					this.lifeMax = 250;
					this.soundHit = 2;
					this.soundKilled = 5;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 1200f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 40:
					this.name = "Bone Serpent Body";
					this.displayName = "Bone Serpent";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 15;
					this.defense = 12;
					this.lifeMax = 250;
					this.soundHit = 2;
					this.soundKilled = 5;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 1200f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 41:
					this.name = "Bone Serpent Tail";
					this.displayName = "Bone Serpent";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 10;
					this.defense = 18;
					this.lifeMax = 250;
					this.soundHit = 2;
					this.soundKilled = 5;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 1200f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 42:
					this.name = "Hornet";
					this.width = 34;
					this.height = 32;
					this.aiStyle = 5;
					this.damage = 34;
					this.defense = 12;
					this.lifeMax = 50;
					this.soundHit = 1;
					this.knockBackResist = 0.5f;
					this.soundKilled = 1;
					this.value = 200f;
					this.noGravity = true;
					this.buffImmune[20] = true;
					break;
				case 43:
					this.noGravity = true;
					this.noTileCollide = true;
					this.name = "Man Eater";
					this.width = 30;
					this.height = 30;
					this.aiStyle = 13;
					this.damage = 42;
					this.defense = 14;
					this.lifeMax = 130;
					this.soundHit = 1;
					this.knockBackResist = 0f;
					this.soundKilled = 1;
					this.value = 350f;
					this.buffImmune[20] = true;
					break;
				case 44:
					this.name = "Undead Miner";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 22;
					this.defense = 9;
					this.lifeMax = 70;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.knockBackResist = 0.5f;
					this.value = 250f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 45:
					this.name = "Tim";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 8;
					this.damage = 20;
					this.defense = 4;
					this.lifeMax = 200;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.knockBackResist = 0.6f;
					this.value = 5000f;
					this.buffImmune[20] = true;
					break;
				case 46:
					this.name = "Bunny";
					this.width = 18;
					this.height = 20;
					this.aiStyle = 7;
					this.damage = 0;
					this.defense = 0;
					this.lifeMax = 5;
					this.soundHit = 1;
					this.soundKilled = 1;
					break;
				case 47:
					this.name = "Corrupt Bunny";
					this.width = 18;
					this.height = 20;
					this.aiStyle = 3;
					this.damage = 20;
					this.defense = 4;
					this.lifeMax = 70;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 500f;
					this.buffImmune[31] = false;
					break;
				case 48:
					this.name = "Harpy";
					this.width = 24;
					this.height = 34;
					this.aiStyle = 14;
					this.damage = 25;
					this.defense = 8;
					this.lifeMax = 100;
					this.soundHit = 1;
					this.knockBackResist = 0.6f;
					this.soundKilled = 1;
					this.value = 300f;
					break;
				case 49:
					this.npcSlots = 0.5f;
					this.name = "Cave Bat";
					this.width = 22;
					this.height = 18;
					this.aiStyle = 14;
					this.damage = 13;
					this.defense = 2;
					this.lifeMax = 16;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 4;
					this.value = 90f;
					this.buffImmune[31] = false;
					break;
				case 50:
					this.boss = true;
					this.name = "King Slime";
					this.width = 98;
					this.height = 92;
					this.aiStyle = 15;
					this.damage = 40;
					this.defense = 10;
					this.lifeMax = 2000;
					this.knockBackResist = 0f;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.alpha = 30;
					this.value = 10000f;
					this.scale = 1.25f;
					this.buffImmune[20] = true;
					break;
				case 51:
					this.npcSlots = 0.5f;
					this.name = "Jungle Bat";
					this.width = 22;
					this.height = 18;
					this.aiStyle = 14;
					this.damage = 20;
					this.defense = 4;
					this.lifeMax = 34;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 4;
					this.value = 80f;
					this.buffImmune[31] = false;
					break;
				case 52:
					this.name = "Doctor Bones";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 20;
					this.defense = 10;
					this.lifeMax = 500;
					this.soundHit = 1;
					this.soundKilled = 2;
					this.knockBackResist = 0.5f;
					this.value = 1000f;
					this.buffImmune[31] = false;
					break;
				case 53:
					this.name = "The Groom";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 14;
					this.defense = 8;
					this.lifeMax = 200;
					this.soundHit = 1;
					this.soundKilled = 2;
					this.knockBackResist = 0.5f;
					this.value = 1000f;
					this.buffImmune[31] = false;
					break;
				case 54:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Clothier";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 55:
					this.noGravity = true;
					this.name = "Goldfish";
					this.width = 20;
					this.height = 18;
					this.aiStyle = 16;
					this.damage = 0;
					this.defense = 0;
					this.lifeMax = 5;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 56:
					this.noTileCollide = true;
					this.noGravity = true;
					this.name = "Snatcher";
					this.width = 30;
					this.height = 30;
					this.aiStyle = 13;
					this.damage = 25;
					this.defense = 10;
					this.lifeMax = 60;
					this.soundHit = 1;
					this.knockBackResist = 0f;
					this.soundKilled = 1;
					this.value = 90f;
					this.buffImmune[20] = true;
					break;
				case 57:
					this.noGravity = true;
					this.name = "Corrupt Goldfish";
					this.width = 18;
					this.height = 20;
					this.aiStyle = 16;
					this.damage = 30;
					this.defense = 6;
					this.lifeMax = 100;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 500f;
					break;
				case 58:
					this.npcSlots = 0.5f;
					this.noGravity = true;
					this.name = "Piranha";
					this.width = 18;
					this.height = 20;
					this.aiStyle = 16;
					this.damage = 25;
					this.defense = 2;
					this.lifeMax = 30;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 50f;
					break;
				case 59:
					this.name = "Lava Slime";
					this.width = 24;
					this.height = 18;
					this.aiStyle = 1;
					this.damage = 15;
					this.defense = 10;
					this.lifeMax = 50;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.scale = 1.1f;
					this.alpha = 50;
					this.lavaImmune = true;
					this.value = 120f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.buffImmune[31] = false;
					break;
				case 60:
					this.npcSlots = 0.5f;
					this.name = "Hellbat";
					this.width = 22;
					this.height = 18;
					this.aiStyle = 14;
					this.damage = 35;
					this.defense = 8;
					this.lifeMax = 46;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 4;
					this.value = 120f;
					this.scale = 1.1f;
					this.lavaImmune = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.buffImmune[31] = false;
					break;
				case 61:
					this.name = "Vulture";
					this.width = 36;
					this.height = 36;
					this.aiStyle = 17;
					this.damage = 15;
					this.defense = 4;
					this.lifeMax = 40;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 1;
					this.value = 60f;
					break;
				case 62:
					this.npcSlots = 2f;
					this.name = "Demon";
					this.width = 28;
					this.height = 48;
					this.aiStyle = 14;
					this.damage = 32;
					this.defense = 8;
					this.lifeMax = 120;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 1;
					this.value = 300f;
					this.lavaImmune = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 63:
					this.noGravity = true;
					this.name = "Blue Jellyfish";
					this.width = 26;
					this.height = 26;
					this.aiStyle = 18;
					this.damage = 20;
					this.defense = 2;
					this.lifeMax = 30;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 100f;
					this.alpha = 20;
					break;
				case 64:
					this.noGravity = true;
					this.name = "Pink Jellyfish";
					this.width = 26;
					this.height = 26;
					this.aiStyle = 18;
					this.damage = 30;
					this.defense = 6;
					this.lifeMax = 70;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 100f;
					this.alpha = 20;
					break;
				case 65:
					this.noGravity = true;
					this.name = "Shark";
					this.width = 100;
					this.height = 24;
					this.aiStyle = 16;
					this.damage = 40;
					this.defense = 2;
					this.lifeMax = 300;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 400f;
					this.knockBackResist = 0.7f;
					break;
				case 66:
					this.npcSlots = 2f;
					this.name = "Voodoo Demon";
					this.width = 28;
					this.height = 48;
					this.aiStyle = 14;
					this.damage = 32;
					this.defense = 8;
					this.lifeMax = 140;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 1;
					this.value = 1000f;
					this.lavaImmune = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 67:
					this.name = "Crab";
					this.width = 28;
					this.height = 20;
					this.aiStyle = 3;
					this.damage = 20;
					this.defense = 10;
					this.lifeMax = 40;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 60f;
					break;
				case 68:
					this.name = "Dungeon Guardian";
					this.width = 80;
					this.height = 102;
					this.aiStyle = 11;
					this.damage = 9000;
					this.defense = 9000;
					this.lifeMax = 9999;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 69:
					this.name = "Antlion";
					this.width = 24;
					this.height = 24;
					this.aiStyle = 19;
					this.damage = 10;
					this.defense = 6;
					this.lifeMax = 45;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0f;
					this.value = 60f;
					this.behindTiles = true;
					break;
				case 70:
					this.npcSlots = 0.3f;
					this.name = "Spike Ball";
					this.width = 34;
					this.height = 34;
					this.aiStyle = 20;
					this.damage = 32;
					this.defense = 100;
					this.lifeMax = 100;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0f;
					this.noGravity = true;
					this.noTileCollide = true;
					this.dontTakeDamage = true;
					this.scale = 1.5f;
					break;
				case 71:
					this.npcSlots = 2f;
					this.name = "Dungeon Slime";
					this.width = 36;
					this.height = 24;
					this.aiStyle = 1;
					this.damage = 30;
					this.defense = 7;
					this.lifeMax = 150;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.alpha = 60;
					this.value = 150f;
					this.scale = 1.25f;
					this.knockBackResist = 0.6f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 72:
					this.npcSlots = 0.3f;
					this.name = "Blazing Wheel";
					this.width = 34;
					this.height = 34;
					this.aiStyle = 21;
					this.damage = 24;
					this.defense = 100;
					this.lifeMax = 100;
					this.alpha = 100;
					this.behindTiles = true;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0f;
					this.noGravity = true;
					this.dontTakeDamage = true;
					this.scale = 1.2f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 73:
					this.name = "Goblin Scout";
					this.scale = 0.95f;
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 20;
					this.defense = 6;
					this.lifeMax = 80;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.7f;
					this.value = 200f;
					this.buffImmune[31] = false;
					break;
				case 74:
					this.name = "Bird";
					this.width = 14;
					this.height = 14;
					this.aiStyle = 24;
					this.damage = 0;
					this.defense = 0;
					this.lifeMax = 5;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 1;
					break;
				case 75:
					this.noGravity = true;
					this.name = "Pixie";
					this.width = 20;
					this.height = 20;
					this.aiStyle = 22;
					this.damage = 55;
					this.defense = 20;
					this.lifeMax = 150;
					this.soundHit = 5;
					this.knockBackResist = 0.6f;
					this.soundKilled = 7;
					this.value = 350f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.buffImmune[31] = false;
					break;
				case 77:
					this.name = "Armored Skeleton";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 60;
					this.defense = 36;
					this.lifeMax = 340;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.knockBackResist = 0.4f;
					this.value = 400f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 78:
					this.name = "Mummy";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 50;
					this.defense = 16;
					this.lifeMax = 130;
					this.soundHit = 1;
					this.soundKilled = 6;
					this.knockBackResist = 0.6f;
					this.value = 600f;
					this.buffImmune[31] = false;
					break;
				case 79:
					this.name = "Dark Mummy";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 60;
					this.defense = 18;
					this.lifeMax = 180;
					this.soundHit = 1;
					this.soundKilled = 6;
					this.knockBackResist = 0.5f;
					this.value = 700f;
					this.buffImmune[31] = false;
					break;
				case 80:
					this.name = "Light Mummy";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 55;
					this.defense = 18;
					this.lifeMax = 200;
					this.soundHit = 1;
					this.soundKilled = 6;
					this.knockBackResist = 0.55f;
					this.value = 700f;
					this.buffImmune[31] = false;
					break;
				case 81:
					this.name = "Corrupt Slime";
					this.width = 40;
					this.height = 30;
					this.aiStyle = 1;
					this.damage = 55;
					this.defense = 20;
					this.lifeMax = 170;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.alpha = 55;
					this.value = 400f;
					this.scale = 1.1f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 82:
					this.noGravity = true;
					this.noTileCollide = true;
					this.name = "Wraith";
					this.width = 24;
					this.height = 44;
					this.aiStyle = 22;
					this.damage = 75;
					this.defense = 18;
					this.lifeMax = 200;
					this.soundHit = 1;
					this.soundKilled = 6;
					this.alpha = 100;
					this.value = 500f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.knockBackResist = 0.7f;
					break;
				case 83:
					this.name = "Cursed Hammer";
					this.width = 40;
					this.height = 40;
					this.aiStyle = 23;
					this.damage = 80;
					this.defense = 18;
					this.lifeMax = 200;
					this.soundHit = 4;
					this.soundKilled = 6;
					this.value = 1000f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.knockBackResist = 0.4f;
					break;
				case 84:
					this.name = "Enchanted Sword";
					this.width = 40;
					this.height = 40;
					this.aiStyle = 23;
					this.damage = 80;
					this.defense = 18;
					this.lifeMax = 200;
					this.soundHit = 4;
					this.soundKilled = 6;
					this.value = 1000f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.knockBackResist = 0.4f;
					break;
				case 85:
					this.name = "Mimic";
					this.width = 24;
					this.height = 24;
					this.aiStyle = 25;
					this.damage = 80;
					this.defense = 30;
					this.lifeMax = 500;
					this.soundHit = 4;
					this.soundKilled = 6;
					this.value = 100000f;
					this.knockBackResist = 0.3f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 86:
					this.name = "Unicorn";
					this.width = 46;
					this.height = 42;
					this.aiStyle = 26;
					this.damage = 65;
					this.defense = 30;
					this.lifeMax = 400;
					this.soundHit = 10;
					this.soundKilled = 1;
					this.knockBackResist = 0.3f;
					this.value = 1000f;
					this.buffImmune[31] = false;
					break;
				case 87:
					this.displayName = "Wyvern";
					this.noTileCollide = true;
					this.npcSlots = 5f;
					this.name = "Wyvern Head";
					this.width = 32;
					this.height = 32;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 80;
					this.defense = 10;
					this.lifeMax = 4000;
					this.soundHit = 7;
					this.soundKilled = 8;
					this.noGravity = true;
					this.knockBackResist = 0f;
					this.value = 10000f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 88:
					this.displayName = "Wyvern";
					this.noTileCollide = true;
					this.name = "Wyvern Legs";
					this.width = 32;
					this.height = 32;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 40;
					this.defense = 20;
					this.lifeMax = 4000;
					this.soundHit = 7;
					this.soundKilled = 8;
					this.noGravity = true;
					this.knockBackResist = 0f;
					this.value = 10000f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 89:
					this.displayName = "Wyvern";
					this.noTileCollide = true;
					this.name = "Wyvern Body";
					this.width = 32;
					this.height = 32;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 40;
					this.defense = 20;
					this.lifeMax = 4000;
					this.soundHit = 7;
					this.soundKilled = 8;
					this.noGravity = true;
					this.knockBackResist = 0f;
					this.value = 2000f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 90:
					this.displayName = "Wyvern";
					this.noTileCollide = true;
					this.name = "Wyvern Body 2";
					this.width = 32;
					this.height = 32;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 40;
					this.defense = 20;
					this.lifeMax = 4000;
					this.soundHit = 7;
					this.soundKilled = 8;
					this.noGravity = true;
					this.knockBackResist = 0f;
					this.value = 10000f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 91:
					this.displayName = "Wyvern";
					this.noTileCollide = true;
					this.name = "Wyvern Body 3";
					this.width = 32;
					this.height = 32;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 40;
					this.defense = 20;
					this.lifeMax = 4000;
					this.soundHit = 7;
					this.soundKilled = 8;
					this.noGravity = true;
					this.knockBackResist = 0f;
					this.value = 10000f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 92:
					this.displayName = "Wyvern";
					this.noTileCollide = true;
					this.name = "Wyvern Tail";
					this.width = 32;
					this.height = 32;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 40;
					this.defense = 20;
					this.lifeMax = 4000;
					this.soundHit = 7;
					this.soundKilled = 8;
					this.noGravity = true;
					this.knockBackResist = 0f;
					this.value = 10000f;
					this.scale = 1f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 93:
					this.npcSlots = 0.5f;
					this.name = "Giant Bat";
					this.width = 26;
					this.height = 20;
					this.aiStyle = 14;
					this.damage = 70;
					this.defense = 20;
					this.lifeMax = 160;
					this.soundHit = 1;
					this.knockBackResist = 0.75f;
					this.soundKilled = 4;
					this.value = 400f;
					this.buffImmune[31] = false;
					break;
				case 94:
					this.npcSlots = 1f;
					this.name = "Corruptor";
					this.width = 44;
					this.height = 44;
					this.aiStyle = 5;
					this.damage = 60;
					this.defense = 32;
					this.lifeMax = 230;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.knockBackResist = 0.55f;
					this.value = 500f;
					break;
				case 95:
					this.displayName = "Digger";
					this.name = "Digger Head";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 45;
					this.defense = 10;
					this.lifeMax = 200;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.scale = 0.9f;
					this.value = 300f;
					break;
				case 96:
					this.displayName = "Digger";
					this.name = "Digger Body";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 28;
					this.defense = 20;
					this.lifeMax = 200;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.scale = 0.9f;
					this.value = 300f;
					break;
				case 97:
					this.displayName = "Digger";
					this.name = "Digger Tail";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 26;
					this.defense = 30;
					this.lifeMax = 200;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.scale = 0.9f;
					this.value = 300f;
					break;
				case 98:
					this.displayName = "World Feeder";
					this.npcSlots = 3.5f;
					this.name = "Seeker Head";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 70;
					this.defense = 36;
					this.lifeMax = 500;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 700f;
					break;
				case 99:
					this.displayName = "World Feeder";
					this.name = "Seeker Body";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 55;
					this.defense = 40;
					this.lifeMax = 500;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 700f;
					break;
				case 100:
					this.displayName = "World Feeder";
					this.name = "Seeker Tail";
					this.width = 22;
					this.height = 22;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 40;
					this.defense = 44;
					this.lifeMax = 500;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 700f;
					break;
				case 101:
					this.noGravity = true;
					this.noTileCollide = true;
					this.behindTiles = true;
					this.name = "Clinger";
					this.width = 30;
					this.height = 30;
					this.aiStyle = 13;
					this.damage = 70;
					this.defense = 30;
					this.lifeMax = 320;
					this.soundHit = 1;
					this.knockBackResist = 0.2f;
					this.soundKilled = 1;
					this.value = 600f;
					break;
				case 102:
					this.npcSlots = 0.5f;
					this.noGravity = true;
					this.name = "Angler Fish";
					this.width = 18;
					this.height = 20;
					this.aiStyle = 16;
					this.damage = 80;
					this.defense = 22;
					this.lifeMax = 90;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 500f;
					break;
				case 103:
					this.noGravity = true;
					this.name = "Green Jellyfish";
					this.width = 26;
					this.height = 26;
					this.aiStyle = 18;
					this.damage = 80;
					this.defense = 30;
					this.lifeMax = 120;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.value = 800f;
					this.alpha = 20;
					break;
				case 104:
					this.name = "Werewolf";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 70;
					this.defense = 40;
					this.lifeMax = 400;
					this.soundHit = 6;
					this.soundKilled = 1;
					this.knockBackResist = 0.4f;
					this.value = 1000f;
					this.buffImmune[31] = false;
					break;
				case 105:
					this.friendly = true;
					this.name = "Bound Goblin";
					this.width = 18;
					this.height = 34;
					this.aiStyle = 0;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					this.scale = 0.9f;
					break;
				case 106:
					this.friendly = true;
					this.name = "Bound Wizard";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 0;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 107:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Goblin Tinkerer";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					this.scale = 0.9f;
					break;
				case 108:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Wizard";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 109:
					this.name = "Clown";
					this.width = 34;
					this.height = 78;
					this.aiStyle = 3;
					this.damage = 50;
					this.defense = 20;
					this.lifeMax = 400;
					this.soundHit = 1;
					this.soundKilled = 2;
					this.knockBackResist = 0.4f;
					this.value = 8000f;
					break;
				case 110:
					this.name = "Skeleton Archer";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 55;
					this.defense = 28;
					this.lifeMax = 260;
					this.soundHit = 2;
					this.soundKilled = 2;
					this.knockBackResist = 0.55f;
					this.value = 400f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 111:
					this.name = "Goblin Archer";
					this.scale = 0.95f;
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 20;
					this.defense = 6;
					this.lifeMax = 80;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.7f;
					this.value = 200f;
					this.buffImmune[31] = false;
					break;
				case 112:
					this.name = "Vile Spit";
					this.width = 16;
					this.height = 16;
					this.aiStyle = 9;
					this.damage = 65;
					this.defense = 0;
					this.lifeMax = 1;
					this.soundHit = 0;
					this.soundKilled = 9;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.scale = 0.9f;
					this.alpha = 80;
					break;
				case 113:
					this.npcSlots = 10f;
					this.name = "Wall of Flesh";
					this.width = 100;
					this.height = 100;
					this.aiStyle = 27;
					this.damage = 50;
					this.defense = 12;
					this.lifeMax = 8000;
					this.soundHit = 8;
					this.soundKilled = 10;
					this.noGravity = true;
					this.noTileCollide = true;
					this.behindTiles = true;
					this.knockBackResist = 0f;
					this.scale = 1.2f;
					this.boss = true;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.value = 80000f;
					break;
				case 114:
					this.name = "Wall of Flesh Eye";
					this.displayName = "Wall of Flesh";
					this.width = 100;
					this.height = 100;
					this.aiStyle = 28;
					this.damage = 50;
					this.defense = 0;
					this.lifeMax = 8000;
					this.soundHit = 8;
					this.soundKilled = 10;
					this.noGravity = true;
					this.noTileCollide = true;
					this.behindTiles = true;
					this.knockBackResist = 0f;
					this.scale = 1.2f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.value = 80000f;
					break;
				case 115:
					this.name = "The Hungry";
					this.width = 30;
					this.height = 30;
					this.aiStyle = 29;
					this.damage = 30;
					this.defense = 10;
					this.lifeMax = 240;
					this.soundHit = 9;
					this.soundKilled = 11;
					this.noGravity = true;
					this.behindTiles = true;
					this.noTileCollide = true;
					this.knockBackResist = 1.1f;
					break;
				case 116:
					this.name = "The Hungry II";
					this.displayName = "The Hungry";
					this.width = 30;
					this.height = 32;
					this.aiStyle = 2;
					this.damage = 30;
					this.defense = 6;
					this.lifeMax = 80;
					this.soundHit = 9;
					this.knockBackResist = 0.8f;
					this.soundKilled = 12;
					break;
				case 117:
					this.displayName = "Leech";
					this.name = "Leech Head";
					this.width = 14;
					this.height = 14;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 26;
					this.defense = 2;
					this.lifeMax = 60;
					this.soundHit = 9;
					this.soundKilled = 12;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					break;
				case 118:
					this.displayName = "Leech";
					this.name = "Leech Body";
					this.width = 14;
					this.height = 14;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 22;
					this.defense = 6;
					this.lifeMax = 60;
					this.soundHit = 9;
					this.soundKilled = 12;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					break;
				case 119:
					this.displayName = "Leech";
					this.name = "Leech Tail";
					this.width = 14;
					this.height = 14;
					this.aiStyle = 6;
					this.netAlways = true;
					this.damage = 18;
					this.defense = 10;
					this.lifeMax = 60;
					this.soundHit = 9;
					this.soundKilled = 12;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					break;
				case 120:
					this.name = "Chaos Elemental";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 40;
					this.defense = 30;
					this.lifeMax = 370;
					this.soundHit = 1;
					this.soundKilled = 6;
					this.knockBackResist = 0.4f;
					this.value = 600f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.buffImmune[31] = false;
					break;
				case 121:
					this.name = "Slimer";
					this.width = 40;
					this.height = 30;
					this.aiStyle = 14;
					this.damage = 45;
					this.defense = 20;
					this.lifeMax = 60;
					this.soundHit = 1;
					this.alpha = 55;
					this.knockBackResist = 0.8f;
					this.scale = 1.1f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					break;
				case 122:
					this.noGravity = true;
					this.name = "Gastropod";
					this.width = 20;
					this.height = 20;
					this.aiStyle = 22;
					this.damage = 60;
					this.defense = 22;
					this.lifeMax = 220;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 1;
					this.value = 600f;
					this.buffImmune[20] = true;
					break;
				case 123:
					this.friendly = true;
					this.name = "Bound Mechanic";
					this.width = 18;
					this.height = 34;
					this.aiStyle = 0;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					this.scale = 0.9f;
					break;
				case 124:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Mechanic";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 125:
					this.name = "Retinazer";
					this.width = 100;
					this.height = 110;
					this.aiStyle = 30;
					this.damage = 50;
					this.defense = 10;
					this.lifeMax = 24000;
					this.soundHit = 1;
					this.soundKilled = 14;
					this.knockBackResist = 0f;
					this.noGravity = true;
					this.noTileCollide = true;
					this.timeLeft = NPC.activeTime * 30;
					this.boss = true;
					this.value = 120000f;
					this.npcSlots = 5f;
					this.boss = true;
					break;
				case 126:
					this.name = "Spazmatism";
					this.width = 100;
					this.height = 110;
					this.aiStyle = 31;
					this.damage = 50;
					this.defense = 10;
					this.lifeMax = 24000;
					this.soundHit = 1;
					this.soundKilled = 14;
					this.knockBackResist = 0f;
					this.noGravity = true;
					this.noTileCollide = true;
					this.timeLeft = NPC.activeTime * 30;
					this.boss = true;
					this.value = 120000f;
					this.npcSlots = 5f;
					this.boss = true;
					break;
				case 127:
					this.name = "Skeletron Prime";
					this.width = 80;
					this.height = 102;
					this.aiStyle = 32;
					this.damage = 50;
					this.defense = 25;
					this.lifeMax = 30000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.value = 120000f;
					this.knockBackResist = 0f;
					this.boss = true;
					this.npcSlots = 6f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.boss = true;
					break;
				case 128:
					this.name = "Prime Cannon";
					this.width = 52;
					this.height = 52;
					this.aiStyle = 35;
					this.damage = 30;
					this.defense = 25;
					this.lifeMax = 7000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.netAlways = true;
					break;
				case 129:
					this.name = "Prime Saw";
					this.width = 52;
					this.height = 52;
					this.aiStyle = 33;
					this.damage = 52;
					this.defense = 40;
					this.lifeMax = 10000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.netAlways = true;
					break;
				case 130:
					this.name = "Prime Vice";
					this.width = 52;
					this.height = 52;
					this.aiStyle = 34;
					this.damage = 45;
					this.defense = 35;
					this.lifeMax = 10000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.netAlways = true;
					break;
				case 131:
					this.name = "Prime Laser";
					this.width = 52;
					this.height = 52;
					this.aiStyle = 36;
					this.damage = 29;
					this.defense = 20;
					this.lifeMax = 6000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.netAlways = true;
					break;
				case 132:
					this.displayName = "Zombie";
					this.name = "Bald Zombie";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 14;
					this.defense = 6;
					this.lifeMax = 45;
					this.soundHit = 1;
					this.soundKilled = 2;
					this.knockBackResist = 0.5f;
					this.value = 60f;
					this.buffImmune[31] = false;
					break;
				case 133:
					this.name = "Wandering Eye";
					this.width = 30;
					this.height = 32;
					this.aiStyle = 2;
					this.damage = 40;
					this.defense = 20;
					this.lifeMax = 300;
					this.soundHit = 1;
					this.knockBackResist = 0.8f;
					this.soundKilled = 1;
					this.value = 500f;
					this.buffImmune[31] = false;
					break;
				case 134:
					this.displayName = "The Destroyer";
					this.npcSlots = 5f;
					this.name = "The Destroyer";
					this.width = 38;
					this.height = 38;
					this.aiStyle = 37;
					this.damage = 60;
					this.defense = 0;
					this.lifeMax = 80000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.value = 120000f;
					this.scale = 1.25f;
					this.boss = true;
					this.netAlways = true;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 135:
					this.displayName = "The Destroyer";
					this.npcSlots = 5f;
					this.name = "The Destroyer Body";
					this.width = 38;
					this.height = 38;
					this.aiStyle = 37;
					this.damage = 40;
					this.defense = 30;
					this.lifeMax = 80000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.netAlways = true;
					this.scale = 1.25f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 136:
					this.displayName = "The Destroyer";
					this.npcSlots = 5f;
					this.name = "The Destroyer Tail";
					this.width = 38;
					this.height = 38;
					this.aiStyle = 37;
					this.damage = 20;
					this.defense = 35;
					this.lifeMax = 80000;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.noTileCollide = true;
					this.knockBackResist = 0f;
					this.behindTiles = true;
					this.scale = 1.25f;
					this.netAlways = true;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 137:
					this.name = "Illuminant Bat";
					this.width = 26;
					this.height = 20;
					this.aiStyle = 14;
					this.damage = 75;
					this.defense = 30;
					this.lifeMax = 200;
					this.soundHit = 1;
					this.knockBackResist = 0.75f;
					this.soundKilled = 6;
					this.value = 500f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.buffImmune[31] = false;
					break;
				case 138:
					this.name = "Illuminant Slime";
					this.width = 24;
					this.height = 18;
					this.aiStyle = 1;
					this.damage = 70;
					this.defense = 30;
					this.lifeMax = 180;
					this.soundHit = 1;
					this.soundKilled = 6;
					this.alpha = 100;
					this.value = 400f;
					this.buffImmune[20] = true;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					this.knockBackResist = 0.85f;
					this.scale = 1.05f;
					this.buffImmune[31] = false;
					break;
				case 139:
					this.npcSlots = 1f;
					this.name = "Probe";
					this.width = 30;
					this.height = 30;
					this.aiStyle = 5;
					this.damage = 50;
					this.defense = 20;
					this.lifeMax = 200;
					this.soundHit = 4;
					this.soundKilled = 14;
					this.noGravity = true;
					this.knockBackResist = 0.8f;
					this.noTileCollide = true;
					break;
				case 140:
					this.name = "Possessed Armor";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 3;
					this.damage = 55;
					this.defense = 28;
					this.lifeMax = 260;
					this.soundHit = 4;
					this.soundKilled = 6;
					this.knockBackResist = 0.4f;
					this.value = 400f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					this.buffImmune[24] = true;
					break;
				case 141:
					this.name = "Toxic Sludge";
					this.width = 34;
					this.height = 28;
					this.aiStyle = 1;
					this.damage = 50;
					this.defense = 18;
					this.lifeMax = 150;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.alpha = 55;
					this.value = 400f;
					this.scale = 1.1f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					this.knockBackResist = 0.8f;
					break;
				case 142:
					this.townNPC = true;
					this.friendly = true;
					this.name = "Santa Claus";
					this.width = 18;
					this.height = 40;
					this.aiStyle = 7;
					this.damage = 10;
					this.defense = 15;
					this.lifeMax = 250;
					this.soundHit = 1;
					this.soundKilled = 1;
					this.knockBackResist = 0.5f;
					break;
				case 143:
					this.name = "Snowman Gangsta";
					this.width = 26;
					this.height = 40;
					this.aiStyle = 38;
					this.damage = 50;
					this.defense = 20;
					this.lifeMax = 200;
					this.soundHit = 11;
					this.soundKilled = 15;
					this.knockBackResist = 0.6f;
					this.value = 400f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 144:
					this.name = "Mister Stabby";
					this.width = 26;
					this.height = 40;
					this.aiStyle = 38;
					this.damage = 65;
					this.defense = 26;
					this.lifeMax = 240;
					this.soundHit = 11;
					this.soundKilled = 15;
					this.knockBackResist = 0.6f;
					this.value = 400f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
				case 145:
					this.name = "Snow Balla";
					this.width = 26;
					this.height = 40;
					this.aiStyle = 38;
					this.damage = 55;
					this.defense = 22;
					this.lifeMax = 220;
					this.soundHit = 11;
					this.soundKilled = 15;
					this.knockBackResist = 0.6f;
					this.value = 400f;
					this.buffImmune[20] = true;
					this.buffImmune[31] = false;
					this.buffImmune[24] = true;
					this.buffImmune[39] = true;
					break;
			}
			if (Main.dedServ)
			{
				this.frame = default(Rectangle);
			}
			else
			{

			}
			if (scaleOverride > 0f)
			{
				int num = (int)((float)this.width * this.scale);
				int num2 = (int)((float)this.height * this.scale);
				this.position.X = this.position.X + (float)(num / 2);
				this.position.Y = this.position.Y + (float)num2;
				this.scale = scaleOverride;
				this.width = (int)((float)this.width * this.scale);
				this.height = (int)((float)this.height * this.scale);
				if (this.height == 16 || this.height == 32)
				{
					this.height++;
				}
				this.position.X = this.position.X - (float)(this.width / 2);
				this.position.Y = this.position.Y - (float)this.height;
			}
			else
			{
				this.width = (int)((float)this.width * this.scale);
				this.height = (int)((float)this.height * this.scale);
			}
			this.life = this.lifeMax;
			this.defDamage = this.damage;
			this.defDefense = this.defense;
			this.netID = this.type;
            this.displayName = Lang.npcName(this.netID);
			NpcHooks.OnSetDefaultsInt(ref Type, this);
		}
		public void AI()
		{
			if (this.aiStyle == 0)
			{
				for (int i = 0; i < 255; i++)
				{
					if (Main.player[i].active && Main.player[i].talkNPC == this.whoAmI)
					{
						if (this.type == 105)
						{
							this.Transform(107);
							return;
						}
						if (this.type == 106)
						{
							this.Transform(108);
							return;
						}
						if (this.type == 123)
						{
							this.Transform(124);
							return;
						}
					}
				}
				this.velocity.X = this.velocity.X * 0.93f;
				if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
				{
					this.velocity.X = 0f;
				}
				this.TargetClosest(true);
				this.spriteDirection = this.direction;
				return;
			}
			switch (this.aiStyle)
			{
				case 1:
					{
						bool flag = false;
						if (!Main.dayTime || this.life != this.lifeMax || (double)this.position.Y > Main.worldSurface * 16.0)
						{
							flag = true;
						}
						if (this.type == 81)
						{
							flag = true;
							if (Main.rand.Next(30) == 0)
							{
								int num = Dust.NewDust(this.position, this.width, this.height, 14, 0f, 0f, this.alpha, this.color, 1f);
								Dust expr_177 = Main.dust[num];
								expr_177.velocity *= 0.3f;
							}
						}
						if (this.type == 59)
						{
							Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 1f, 0.3f, 0.1f);
							Vector2 arg_244_0 = new Vector2(this.position.X, this.position.Y);
							int arg_244_1 = this.width;
							int arg_244_2 = this.height;
							int arg_244_3 = 6;
							float arg_244_4 = this.velocity.X * 0.2f;
							float arg_244_5 = this.velocity.Y * 0.2f;
							int arg_244_6 = 100;
							Color newColor = default(Color);
							int num2 = Dust.NewDust(arg_244_0, arg_244_1, arg_244_2, arg_244_3, arg_244_4, arg_244_5, arg_244_6, newColor, 1.7f);
							Main.dust[num2].noGravity = true;
						}
						if (this.ai[2] > 1f)
						{
							this.ai[2] -= 1f;
						}
						if (this.wet)
						{
							if (this.collideY)
							{
								this.velocity.Y = -2f;
							}
							if (this.velocity.Y < 0f && this.ai[3] == this.position.X)
							{
								this.direction *= -1;
								this.ai[2] = 200f;
							}
							if (this.velocity.Y > 0f)
							{
								this.ai[3] = this.position.X;
							}
							if (this.type == 59)
							{
								if (this.velocity.Y > 2f)
								{
									this.velocity.Y = this.velocity.Y * 0.9f;
								}
								else
								{
									if (this.directionY < 0)
									{
										this.velocity.Y = this.velocity.Y - 0.8f;
									}
								}
								this.velocity.Y = this.velocity.Y - 0.5f;
								if (this.velocity.Y < -10f)
								{
									this.velocity.Y = -10f;
								}
							}
							else
							{
								if (this.velocity.Y > 2f)
								{
									this.velocity.Y = this.velocity.Y * 0.9f;
								}
								this.velocity.Y = this.velocity.Y - 0.5f;
								if (this.velocity.Y < -4f)
								{
									this.velocity.Y = -4f;
								}
							}
							if (this.ai[2] == 1f && flag)
							{
								this.TargetClosest(true);
							}
						}
						this.aiAction = 0;
						if (this.ai[2] == 0f)
						{
							this.ai[0] = -100f;
							this.ai[2] = 1f;
							this.TargetClosest(true);
						}
						if (this.velocity.Y == 0f)
						{
							if (this.ai[3] == this.position.X)
							{
								this.direction *= -1;
								this.ai[2] = 200f;
							}
							this.ai[3] = 0f;
							this.velocity.X = this.velocity.X * 0.8f;
							if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
							{
								this.velocity.X = 0f;
							}
							if (flag)
							{
								this.ai[0] += 1f;
							}
							this.ai[0] += 1f;
							if (this.type == 59)
							{
								this.ai[0] += 2f;
							}
							if (this.type == 71)
							{
								this.ai[0] += 3f;
							}
							if (this.type == 138)
							{
								this.ai[0] += 2f;
							}
							if (this.type == 81)
							{
								if (this.scale >= 0f)
								{
									this.ai[0] += 4f;
								}
								else
								{
									this.ai[0] += 1f;
								}
							}
							if (this.ai[0] >= 0f)
							{
								this.netUpdate = true;
								if (flag && this.ai[2] == 1f)
								{
									this.TargetClosest(true);
								}
								if (this.ai[1] == 2f)
								{
									this.velocity.Y = -8f;
									if (this.type == 59)
									{
										this.velocity.Y = this.velocity.Y - 2f;
									}
									this.velocity.X = this.velocity.X + (float)(3 * this.direction);
									if (this.type == 59)
									{
										this.velocity.X = this.velocity.X + 0.5f * (float)this.direction;
									}
									this.ai[0] = -200f;
									this.ai[1] = 0f;
									this.ai[3] = this.position.X;
								}
								else
								{
									this.velocity.Y = -6f;
									this.velocity.X = this.velocity.X + (float)(2 * this.direction);
									if (this.type == 59)
									{
										this.velocity.X = this.velocity.X + (float)(2 * this.direction);
									}
									this.ai[0] = -120f;
									this.ai[1] += 1f;
								}
								if (this.type == 141)
								{
									this.velocity.Y = this.velocity.Y * 1.3f;
									this.velocity.X = this.velocity.X * 1.2f;
									return;
								}
							}
							else
							{
								if (this.ai[0] >= -30f)
								{
									this.aiAction = 1;
									return;
								}
							}
						}
						else
						{
							if (this.target < 255 && ((this.direction == 1 && this.velocity.X < 3f) || (this.direction == -1 && this.velocity.X > -3f)))
							{
								if ((this.direction == -1 && (double)this.velocity.X < 0.1) || (this.direction == 1 && (double)this.velocity.X > -0.1))
								{
									this.velocity.X = this.velocity.X + 0.2f * (float)this.direction;
									return;
								}
								this.velocity.X = this.velocity.X * 0.93f;
								return;
							}
						}
					}
					break;
				case 2:
					this.noGravity = true;
					if (this.collideX)
					{
						this.velocity.X = this.oldVelocity.X * -0.5f;
						if (this.direction == -1 && this.velocity.X > 0f && this.velocity.X < 2f)
						{
							this.velocity.X = 2f;
						}
						if (this.direction == 1 && this.velocity.X < 0f && this.velocity.X > -2f)
						{
							this.velocity.X = -2f;
						}
					}
					if (this.collideY)
					{
						this.velocity.Y = this.oldVelocity.Y * -0.5f;
						if (this.velocity.Y > 0f && this.velocity.Y < 1f)
						{
							this.velocity.Y = 1f;
						}
						if (this.velocity.Y < 0f && this.velocity.Y > -1f)
						{
							this.velocity.Y = -1f;
						}
					}
					if (Main.dayTime && (double)this.position.Y <= Main.worldSurface * 16.0 && (this.type == 2 || this.type == 133))
					{
						if (this.timeLeft > 10)
						{
							this.timeLeft = 10;
						}
						this.directionY = -1;
						if (this.velocity.Y > 0f)
						{
							this.direction = 1;
						}
						this.direction = -1;
						if (this.velocity.X > 0f)
						{
							this.direction = 1;
						}
					}
					else
					{
						this.TargetClosest(true);
					}
					switch (this.type)
					{
						case 116:
							this.TargetClosest(true);
							Lighting.addLight((int)(this.position.X + (float)(this.width / 2)) / 16, (int)(this.position.Y + (float)(this.height / 2)) / 16, 0.3f, 0.2f, 0.1f);
							if (this.direction == -1 && this.velocity.X > -6f)
							{
								this.velocity.X = this.velocity.X - 0.1f;
								if (this.velocity.X > 6f)
								{
									this.velocity.X = this.velocity.X - 0.1f;
								}
								else
								{
									if (this.velocity.X > 0f)
									{
										this.velocity.X = this.velocity.X - 0.2f;
									}
								}
								if (this.velocity.X < -6f)
								{
									this.velocity.X = -6f;
								}
							}
							else
							{
								if (this.direction == 1 && this.velocity.X < 6f)
								{
									this.velocity.X = this.velocity.X + 0.1f;
									if (this.velocity.X < -6f)
									{
										this.velocity.X = this.velocity.X + 0.1f;
									}
									else
									{
										if (this.velocity.X < 0f)
										{
											this.velocity.X = this.velocity.X + 0.2f;
										}
									}
									if (this.velocity.X > 6f)
									{
										this.velocity.X = 6f;
									}
								}
							}
							if (this.directionY == -1 && (double)this.velocity.Y > -2.5)
							{
								this.velocity.Y = this.velocity.Y - 0.04f;
								if ((double)this.velocity.Y > 2.5)
								{
									this.velocity.Y = this.velocity.Y - 0.05f;
								}
								else
								{
									if (this.velocity.Y > 0f)
									{
										this.velocity.Y = this.velocity.Y - 0.15f;
									}
								}
								if ((double)this.velocity.Y < -2.5)
								{
									this.velocity.Y = -2.5f;
								}
							}
							else
							{
								if (this.directionY == 1 && (double)this.velocity.Y < 1.5)
								{
									this.velocity.Y = this.velocity.Y + 0.04f;
									if ((double)this.velocity.Y < -2.5)
									{
										this.velocity.Y = this.velocity.Y + 0.05f;
									}
									else
									{
										if (this.velocity.Y < 0f)
										{
											this.velocity.Y = this.velocity.Y + 0.15f;
										}
									}
									if ((double)this.velocity.Y > 2.5)
									{
										this.velocity.Y = 2.5f;
									}
								}
							}
							if (Main.rand.Next(40) == 0)
							{
								Vector2 arg_E0E_0 = new Vector2(this.position.X, this.position.Y + (float)this.height * 0.25f);
								int arg_E0E_1 = this.width;
								int arg_E0E_2 = (int)((float)this.height * 0.5f);
								int arg_E0E_3 = 5;
								float arg_E0E_4 = this.velocity.X;
								float arg_E0E_5 = 2f;
								int arg_E0E_6 = 0;
								Color newColor = default(Color);
								int num3 = Dust.NewDust(arg_E0E_0, arg_E0E_1, arg_E0E_2, arg_E0E_3, arg_E0E_4, arg_E0E_5, arg_E0E_6, newColor, 1f);
								Dust expr_E22_cp_0 = Main.dust[num3];
								expr_E22_cp_0.velocity.X = expr_E22_cp_0.velocity.X * 0.5f;
								Dust expr_E40_cp_0 = Main.dust[num3];
								expr_E40_cp_0.velocity.Y = expr_E40_cp_0.velocity.Y * 0.1f;
							}
							break;
						case 133:
							if ((double)this.life < (double)this.lifeMax * 0.5)
							{
								if (this.direction == -1 && this.velocity.X > -6f)
								{
									this.velocity.X = this.velocity.X - 0.1f;
									if (this.velocity.X > 6f)
									{
										this.velocity.X = this.velocity.X - 0.1f;
									}
									else
									{
										if (this.velocity.X > 0f)
										{
											this.velocity.X = this.velocity.X + 0.05f;
										}
									}
									if (this.velocity.X < -6f)
									{
										this.velocity.X = -6f;
									}
								}
								else
								{
									if (this.direction == 1 && this.velocity.X < 6f)
									{
										this.velocity.X = this.velocity.X + 0.1f;
										if (this.velocity.X < -6f)
										{
											this.velocity.X = this.velocity.X + 0.1f;
										}
										else
										{
											if (this.velocity.X < 0f)
											{
												this.velocity.X = this.velocity.X - 0.05f;
											}
										}
										if (this.velocity.X > 6f)
										{
											this.velocity.X = 6f;
										}
									}
								}
								if (this.directionY == -1 && this.velocity.Y > -4f)
								{
									this.velocity.Y = this.velocity.Y - 0.1f;
									if (this.velocity.Y > 4f)
									{
										this.velocity.Y = this.velocity.Y - 0.1f;
									}
									else
									{
										if (this.velocity.Y > 0f)
										{
											this.velocity.Y = this.velocity.Y + 0.05f;
										}
									}
									if (this.velocity.Y < -4f)
									{
										this.velocity.Y = -4f;
									}
								}
								else
								{
									if (this.directionY == 1 && this.velocity.Y < 4f)
									{
										this.velocity.Y = this.velocity.Y + 0.1f;
										if (this.velocity.Y < -4f)
										{
											this.velocity.Y = this.velocity.Y + 0.1f;
										}
										else
										{
											if (this.velocity.Y < 0f)
											{
												this.velocity.Y = this.velocity.Y - 0.05f;
											}
										}
										if (this.velocity.Y > 4f)
										{
											this.velocity.Y = 4f;
										}
									}
								}
							}
							else
							{
								if (this.direction == -1 && this.velocity.X > -4f)
								{
									this.velocity.X = this.velocity.X - 0.1f;
									if (this.velocity.X > 4f)
									{
										this.velocity.X = this.velocity.X - 0.1f;
									}
									else
									{
										if (this.velocity.X > 0f)
										{
											this.velocity.X = this.velocity.X + 0.05f;
										}
									}
									if (this.velocity.X < -4f)
									{
										this.velocity.X = -4f;
									}
								}
								else
								{
									if (this.direction == 1 && this.velocity.X < 4f)
									{
										this.velocity.X = this.velocity.X + 0.1f;
										if (this.velocity.X < -4f)
										{
											this.velocity.X = this.velocity.X + 0.1f;
										}
										else
										{
											if (this.velocity.X < 0f)
											{
												this.velocity.X = this.velocity.X - 0.05f;
											}
										}
										if (this.velocity.X > 4f)
										{
											this.velocity.X = 4f;
										}
									}
								}
								if (this.directionY == -1 && (double)this.velocity.Y > -1.5)
								{
									this.velocity.Y = this.velocity.Y - 0.04f;
									if ((double)this.velocity.Y > 1.5)
									{
										this.velocity.Y = this.velocity.Y - 0.05f;
									}
									else
									{
										if (this.velocity.Y > 0f)
										{
											this.velocity.Y = this.velocity.Y + 0.03f;
										}
									}
									if ((double)this.velocity.Y < -1.5)
									{
										this.velocity.Y = -1.5f;
									}
								}
								else
								{
									if (this.directionY == 1 && (double)this.velocity.Y < 1.5)
									{
										this.velocity.Y = this.velocity.Y + 0.04f;
										if ((double)this.velocity.Y < -1.5)
										{
											this.velocity.Y = this.velocity.Y + 0.05f;
										}
										else
										{
											if (this.velocity.Y < 0f)
											{
												this.velocity.Y = this.velocity.Y - 0.03f;
											}
										}
										if ((double)this.velocity.Y > 1.5)
										{
											this.velocity.Y = 1.5f;
										}
									}
								}
							}
							break;
						default:
							if (this.direction == -1 && this.velocity.X > -4f)
							{
								this.velocity.X = this.velocity.X - 0.1f;
								if (this.velocity.X > 4f)
								{
									this.velocity.X = this.velocity.X - 0.1f;
								}
								else
								{
									if (this.velocity.X > 0f)
									{
										this.velocity.X = this.velocity.X + 0.05f;
									}
								}
								if (this.velocity.X < -4f)
								{
									this.velocity.X = -4f;
								}
							}
							else
							{
								if (this.direction == 1 && this.velocity.X < 4f)
								{
									this.velocity.X = this.velocity.X + 0.1f;
									if (this.velocity.X < -4f)
									{
										this.velocity.X = this.velocity.X + 0.1f;
									}
									else
									{
										if (this.velocity.X < 0f)
										{
											this.velocity.X = this.velocity.X - 0.05f;
										}
									}
									if (this.velocity.X > 4f)
									{
										this.velocity.X = 4f;
									}
								}
							}
							if (this.directionY == -1 && (double)this.velocity.Y > -1.5)
							{
								this.velocity.Y = this.velocity.Y - 0.04f;
								if ((double)this.velocity.Y > 1.5)
								{
									this.velocity.Y = this.velocity.Y - 0.05f;
								}
								else
								{
									if (this.velocity.Y > 0f)
									{
										this.velocity.Y = this.velocity.Y + 0.03f;
									}
								}
								if ((double)this.velocity.Y < -1.5)
								{
									this.velocity.Y = -1.5f;
								}
							}
							else
							{
								if (this.directionY == 1 && (double)this.velocity.Y < 1.5)
								{
									this.velocity.Y = this.velocity.Y + 0.04f;
									if ((double)this.velocity.Y < -1.5)
									{
										this.velocity.Y = this.velocity.Y + 0.05f;
									}
									else
									{
										if (this.velocity.Y < 0f)
										{
											this.velocity.Y = this.velocity.Y - 0.03f;
										}
									}
									if ((double)this.velocity.Y > 1.5)
									{
										this.velocity.Y = 1.5f;
									}
								}
							}
							break;
					}
					if ((this.type == 2 || this.type == 133) && Main.rand.Next(40) == 0)
					{
						Vector2 arg_17B3_0 = new Vector2(this.position.X, this.position.Y + (float)this.height * 0.25f);
						int arg_17B3_1 = this.width;
						int arg_17B3_2 = (int)((float)this.height * 0.5f);
						int arg_17B3_3 = 5;
						float arg_17B3_4 = this.velocity.X;
						float arg_17B3_5 = 2f;
						int arg_17B3_6 = 0;
						Color newColor = default(Color);
						int num4 = Dust.NewDust(arg_17B3_0, arg_17B3_1, arg_17B3_2, arg_17B3_3, arg_17B3_4, arg_17B3_5, arg_17B3_6, newColor, 1f);
						Dust expr_17C7_cp_0 = Main.dust[num4];
						expr_17C7_cp_0.velocity.X = expr_17C7_cp_0.velocity.X * 0.5f;
						Dust expr_17E5_cp_0 = Main.dust[num4];
						expr_17E5_cp_0.velocity.Y = expr_17E5_cp_0.velocity.Y * 0.1f;
					}
					if (this.wet)
					{
						if (this.velocity.Y > 0f)
						{
							this.velocity.Y = this.velocity.Y * 0.95f;
						}
						this.velocity.Y = this.velocity.Y - 0.5f;
						if (this.velocity.Y < -4f)
						{
							this.velocity.Y = -4f;
						}
						this.TargetClosest(true);
						return;
					}
					break;
				case 3:
					{
						int num5 = 60;
						if (this.type == 120)
						{
							num5 = 20;
							if (this.ai[3] == -120f)
							{
								this.velocity *= 0f;
								this.ai[3] = 0f;
								Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 8);
								Vector2 vector = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
								float num6 = this.oldPos[2].X + (float)this.width * 0.5f - vector.X;
								float num7 = this.oldPos[2].Y + (float)this.height * 0.5f - vector.Y;
								float num8 = (float)Math.Sqrt((double)(num6 * num6 + num7 * num7));
								num8 = 2f / num8;
								num6 *= num8;
								num7 *= num8;
								for (int j = 0; j < 20; j++)
								{
									Vector2 arg_19CC_0 = this.position;
									int arg_19CC_1 = this.width;
									int arg_19CC_2 = this.height;
									int arg_19CC_3 = 71;
									float arg_19CC_4 = num6;
									float arg_19CC_5 = num7;
									int arg_19CC_6 = 200;
									Color newColor = default(Color);
									int num9 = Dust.NewDust(arg_19CC_0, arg_19CC_1, arg_19CC_2, arg_19CC_3, arg_19CC_4, arg_19CC_5, arg_19CC_6, newColor, 2f);
									Main.dust[num9].noGravity = true;
									Dust expr_19EE_cp_0 = Main.dust[num9];
									expr_19EE_cp_0.velocity.X = expr_19EE_cp_0.velocity.X * 2f;
								}
								for (int k = 0; k < 20; k++)
								{
									Vector2 arg_1A4D_0 = this.oldPos[2];
									int arg_1A4D_1 = this.width;
									int arg_1A4D_2 = this.height;
									int arg_1A4D_3 = 71;
									float arg_1A4D_4 = -num6;
									float arg_1A4D_5 = -num7;
									int arg_1A4D_6 = 200;
									Color newColor = default(Color);
									int num10 = Dust.NewDust(arg_1A4D_0, arg_1A4D_1, arg_1A4D_2, arg_1A4D_3, arg_1A4D_4, arg_1A4D_5, arg_1A4D_6, newColor, 2f);
									Main.dust[num10].noGravity = true;
									Dust expr_1A6F_cp_0 = Main.dust[num10];
									expr_1A6F_cp_0.velocity.X = expr_1A6F_cp_0.velocity.X * 2f;
								}
							}
						}
						bool flag2 = false;
						bool flag3 = true;
						if (this.type == 47 || this.type == 67 || this.type == 109 || this.type == 110 || this.type == 111 || this.type == 120)
						{
							flag3 = false;
						}
						if ((this.type != 110 && this.type != 111) || this.ai[2] <= 0f)
						{
							if (this.velocity.Y == 0f && ((this.velocity.X > 0f && this.direction < 0) || (this.velocity.X < 0f && this.direction > 0)))
							{
								flag2 = true;
							}
							if (this.position.X == this.oldPosition.X || this.ai[3] >= (float)num5 || flag2)
							{
								this.ai[3] += 1f;
							}
							else
							{
								if ((double)Math.Abs(this.velocity.X) > 0.9 && this.ai[3] > 0f)
								{
									this.ai[3] -= 1f;
								}
							}
							if (this.ai[3] > (float)(num5 * 10))
							{
								this.ai[3] = 0f;
							}
							if (this.justHit)
							{
								this.ai[3] = 0f;
							}
							if (this.ai[3] == (float)num5)
							{
								this.netUpdate = true;
							}
						}
						if ((!Main.dayTime || (double)this.position.Y > Main.worldSurface * 16.0 || this.type == 26 || this.type == 27 || this.type == 28 || this.type == 31 || this.type == 47 || this.type == 67 || this.type == 73 || this.type == 77 || this.type == 78 || this.type == 79 || this.type == 80 || this.type == 110 || this.type == 111 || this.type == 120) && this.ai[3] < (float)num5)
						{
							if ((this.type == 3 || this.type == 21 || this.type == 31 || this.type == 77 || this.type == 110 || this.type == 132) && Main.rand.Next(1000) == 0)
							{
								Main.PlaySound(14, (int)this.position.X, (int)this.position.Y, 1);
							}
							if ((this.type == 78 || this.type == 79 || this.type == 80) && Main.rand.Next(500) == 0)
							{
								Main.PlaySound(26, (int)this.position.X, (int)this.position.Y, 1);
							}
							this.TargetClosest(true);
						}
						else
						{
							if ((this.type != 110 && this.type != 111) || this.ai[2] <= 0f)
							{
								if (Main.dayTime && (double)(this.position.Y / 16f) < Main.worldSurface && this.timeLeft > 10)
								{
									this.timeLeft = 10;
								}
								if (this.velocity.X == 0f)
								{
									if (this.velocity.Y == 0f)
									{
										this.ai[0] += 1f;
										if (this.ai[0] >= 2f)
										{
											this.direction *= -1;
											this.spriteDirection = this.direction;
											this.ai[0] = 0f;
										}
									}
								}
								else
								{
									this.ai[0] = 0f;
								}
								if (this.direction == 0)
								{
									this.direction = 1;
								}
							}
						}
						switch (this.type)
						{
							case 120:
								if (this.velocity.X < -3f || this.velocity.X > 3f)
								{
									if (this.velocity.Y == 0f)
									{
										this.velocity *= 0.8f;
									}
								}
								else
								{
									if (this.velocity.X < 3f && this.direction == 1)
									{
										if (this.velocity.Y == 0f && this.velocity.X < 0f)
										{
											this.velocity.X = this.velocity.X * 0.99f;
										}
										this.velocity.X = this.velocity.X + 0.07f;
										if (this.velocity.X > 3f)
										{
											this.velocity.X = 3f;
										}
									}
									else
									{
										if (this.velocity.X > -3f && this.direction == -1)
										{
											if (this.velocity.Y == 0f && this.velocity.X > 0f)
											{
												this.velocity.X = this.velocity.X * 0.99f;
											}
											this.velocity.X = this.velocity.X - 0.07f;
											if (this.velocity.X < -3f)
											{
												this.velocity.X = -3f;
											}
										}
									}
								}
								break;
							case 104:
							case 77:
							case 27:
								if (this.velocity.X < -2f || this.velocity.X > 2f)
								{
									if (this.velocity.Y == 0f)
									{
										this.velocity *= 0.8f;
									}
								}
								else
								{
									if (this.velocity.X < 2f && this.direction == 1)
									{
										this.velocity.X = this.velocity.X + 0.07f;
										if (this.velocity.X > 2f)
										{
											this.velocity.X = 2f;
										}
									}
									else
									{
										if (this.velocity.X > -2f && this.direction == -1)
										{
											this.velocity.X = this.velocity.X - 0.07f;
											if (this.velocity.X < -2f)
											{
												this.velocity.X = -2f;
											}
										}
									}
								}
								break;
							case 109:
								if (this.velocity.X < -2f || this.velocity.X > 2f)
								{
									if (this.velocity.Y == 0f)
									{
										this.velocity *= 0.8f;
									}
								}
								else
								{
									if (this.velocity.X < 2f && this.direction == 1)
									{
										this.velocity.X = this.velocity.X + 0.04f;
										if (this.velocity.X > 2f)
										{
											this.velocity.X = 2f;
										}
									}
									else
									{
										if (this.velocity.X > -2f && this.direction == -1)
										{
											this.velocity.X = this.velocity.X - 0.04f;
											if (this.velocity.X < -2f)
											{
												this.velocity.X = -2f;
											}
										}
									}
								}
								break;
							case 140:
							case 73:
							case 47:
							case 31:
							case 26:
							case 21:
								if (this.velocity.X < -1.5f || this.velocity.X > 1.5f)
								{
									if (this.velocity.Y == 0f)
									{
										this.velocity *= 0.8f;
									}
								}
								else
								{
									if (this.velocity.X < 1.5f && this.direction == 1)
									{
										this.velocity.X = this.velocity.X + 0.07f;
										if (this.velocity.X > 1.5f)
										{
											this.velocity.X = 1.5f;
										}
									}
									else
									{
										if (this.velocity.X > -1.5f && this.direction == -1)
										{
											this.velocity.X = this.velocity.X - 0.07f;
											if (this.velocity.X < -1.5f)
											{
												this.velocity.X = -1.5f;
											}
										}
									}
								}
								break;
							case 67:
								if (this.velocity.X < -0.5f || this.velocity.X > 0.5f)
								{
									if (this.velocity.Y == 0f)
									{
										this.velocity *= 0.7f;
									}
								}
								else
								{
									if (this.velocity.X < 0.5f && this.direction == 1)
									{
										this.velocity.X = this.velocity.X + 0.03f;
										if (this.velocity.X > 0.5f)
										{
											this.velocity.X = 0.5f;
										}
									}
									else
									{
										if (this.velocity.X > -0.5f && this.direction == -1)
										{
											this.velocity.X = this.velocity.X - 0.03f;
											if (this.velocity.X < -0.5f)
											{
												this.velocity.X = -0.5f;
											}
										}
									}
								}
								break;
							case 80:
							case 79:
							case 78:
								{
									float num11 = 1f;
									float num12 = 0.05f;
									if (this.life < this.lifeMax / 2)
									{
										num11 = 2f;
										num12 = 0.1f;
									}
									if (this.type == 79)
									{
										num11 *= 1.5f;
									}
									if (this.velocity.X < -num11 || this.velocity.X > num11)
									{
										if (this.velocity.Y == 0f)
										{
											this.velocity *= 0.7f;
										}
									}
									else
									{
										if (this.velocity.X < num11 && this.direction == 1)
										{
											this.velocity.X = this.velocity.X + num12;
											if (this.velocity.X > num11)
											{
												this.velocity.X = num11;
											}
										}
										else
										{
											if (this.velocity.X > -num11 && this.direction == -1)
											{
												this.velocity.X = this.velocity.X - num12;
												if (this.velocity.X < -num11)
												{
													this.velocity.X = -num11;
												}
											}
										}
									}
								}
								break;
							default:
								if (this.type != 110 && this.type != 111)
								{
									if (this.velocity.X < -1f || this.velocity.X > 1f)
									{
										if (this.velocity.Y == 0f)
										{
											this.velocity *= 0.8f;
										}
									}
									else
									{
										if (this.velocity.X < 1f && this.direction == 1)
										{
											this.velocity.X = this.velocity.X + 0.07f;
											if (this.velocity.X > 1f)
											{
												this.velocity.X = 1f;
											}
										}
										else
										{
											if (this.velocity.X > -1f && this.direction == -1)
											{
												this.velocity.X = this.velocity.X - 0.07f;
												if (this.velocity.X < -1f)
												{
													this.velocity.X = -1f;
												}
											}
										}
									}
								}
								break;
						}
						if (this.type == 110 || this.type == 111)
						{
							if (this.confused)
							{
								this.ai[2] = 0f;
							}
							else
							{
								if (this.ai[1] > 0f)
								{
									this.ai[1] -= 1f;
								}
								if (this.justHit)
								{
									this.ai[1] = 30f;
									this.ai[2] = 0f;
								}
								int num13 = 70;
								if (this.type == 111)
								{
									num13 = 180;
								}
								if (this.ai[2] > 0f)
								{
									this.TargetClosest(true);
									if (this.ai[1] == (float)(num13 / 2))
									{
										float num14 = 11f;
										if (this.type == 111)
										{
											num14 = 9f;
										}
										Vector2 vector2 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
										float num15 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector2.X;
										float num16 = Math.Abs(num15) * 0.1f;
										float num17 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector2.Y - num16;
										num15 += (float)Main.rand.Next(-40, 41);
										num17 += (float)Main.rand.Next(-40, 41);
										float num18 = (float)Math.Sqrt((double)(num15 * num15 + num17 * num17));
										this.netUpdate = true;
										num18 = num14 / num18;
										num15 *= num18;
										num17 *= num18;
										int num19 = 35;
										if (this.type == 111)
										{
											num19 = 11;
										}
										int num20 = 82;
										if (this.type == 111)
										{
											num20 = 81;
										}
										vector2.X += num15;
										vector2.Y += num17;
										if (Main.netMode != 1)
										{
											Projectile.NewProjectile(vector2.X, vector2.Y, num15, num17, num20, num19, 0f, Main.myPlayer);
										}
										if (Math.Abs(num17) > Math.Abs(num15) * 2f)
										{
											if (num17 > 0f)
											{
												this.ai[2] = 1f;
											}
											else
											{
												this.ai[2] = 5f;
											}
										}
										else
										{
											if (Math.Abs(num15) > Math.Abs(num17) * 2f)
											{
												this.ai[2] = 3f;
											}
											else
											{
												if (num17 > 0f)
												{
													this.ai[2] = 2f;
												}
												else
												{
													this.ai[2] = 4f;
												}
											}
										}
									}
									if (this.velocity.Y != 0f || this.ai[1] <= 0f)
									{
										this.ai[2] = 0f;
										this.ai[1] = 0f;
									}
									else
									{
										this.velocity.X = this.velocity.X * 0.9f;
										this.spriteDirection = this.direction;
									}
								}
								if (this.ai[2] <= 0f && this.velocity.Y == 0f && this.ai[1] <= 0f && !Main.player[this.target].dead && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
								{
									float num21 = 10f;
									Vector2 vector3 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
									float num22 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector3.X;
									float num23 = Math.Abs(num22) * 0.1f;
									float num24 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector3.Y - num23;
									num22 += (float)Main.rand.Next(-40, 41);
									num24 += (float)Main.rand.Next(-40, 41);
									float num25 = (float)Math.Sqrt((double)(num22 * num22 + num24 * num24));
									if (num25 < 700f)
									{
										this.netUpdate = true;
										this.velocity.X = this.velocity.X * 0.5f;
										num25 = num21 / num25;
										num22 *= num25;
										num24 *= num25;
										this.ai[2] = 3f;
										this.ai[1] = (float)num13;
										if (Math.Abs(num24) > Math.Abs(num22) * 2f)
										{
											if (num24 > 0f)
											{
												this.ai[2] = 1f;
											}
											else
											{
												this.ai[2] = 5f;
											}
										}
										else
										{
											if (Math.Abs(num22) > Math.Abs(num24) * 2f)
											{
												this.ai[2] = 3f;
											}
											else
											{
												if (num24 > 0f)
												{
													this.ai[2] = 2f;
												}
												else
												{
													this.ai[2] = 4f;
												}
											}
										}
									}
								}
								if (this.ai[2] <= 0f)
								{
									if (this.velocity.X < -1f || this.velocity.X > 1f)
									{
										if (this.velocity.Y == 0f)
										{
											this.velocity *= 0.8f;
										}
									}
									else
									{
										if (this.velocity.X < 1f && this.direction == 1)
										{
											this.velocity.X = this.velocity.X + 0.07f;
											if (this.velocity.X > 1f)
											{
												this.velocity.X = 1f;
											}
										}
										else
										{
											if (this.velocity.X > -1f && this.direction == -1)
											{
												this.velocity.X = this.velocity.X - 0.07f;
												if (this.velocity.X < -1f)
												{
													this.velocity.X = -1f;
												}
											}
										}
									}
								}
							}
						}
						if (this.type == 109 && Main.netMode != 1 && !Main.player[this.target].dead)
						{
							if (this.justHit)
							{
								this.ai[2] = 0f;
							}
							this.ai[2] += 1f;
							if (this.ai[2] > 450f)
							{
								Vector2 vector4 = new Vector2(this.position.X + (float)this.width * 0.5f - (float)(this.direction * 24), this.position.Y + 4f);
								int num26 = 3 * this.direction;
								int num27 = -5;
								int num28 = Projectile.NewProjectile(vector4.X, vector4.Y, (float)num26, (float)num27, 75, 0, 0f, Main.myPlayer);
								Main.projectile[num28].timeLeft = 300;
								this.ai[2] = 0f;
							}
						}
						bool flag4 = false;
						if (this.velocity.Y == 0f)
						{
							int num29 = (int)(this.position.Y + (float)this.height + 8f) / 16;
							int num30 = (int)this.position.X / 16;
							int num31 = (int)(this.position.X + (float)this.width) / 16;
							for (int l = num30; l <= num31; l++)
							{
								if (Main.tile[l, num29] == null)
								{
									return;
								}
								if (Main.tile[l, num29].active && Main.tileSolid[(int)Main.tile[l, num29].type])
								{
									flag4 = true;
									break;
								}
							}
						}
						if (flag4)
						{
							int num32 = (int)((this.position.X + (float)(this.width / 2) + (float)(15 * this.direction)) / 16f);
							int num33 = (int)((this.position.Y + (float)this.height - 15f) / 16f);
							if (this.type == 109)
							{
								num32 = (int)((this.position.X + (float)(this.width / 2) + (float)((this.width / 2 + 16) * this.direction)) / 16f);
							}
							if (Main.tile[num32, num33 - 1].active && Main.tile[num32, num33 - 1].type == 10 && flag3)
							{
								this.ai[2] += 1f;
								this.ai[3] = 0f;
								if (this.ai[2] >= 60f)
								{
									if (!Main.bloodMoon && (this.type == 3 || this.type == 132))
									{
										this.ai[1] = 0f;
									}
									this.velocity.X = 0.5f * (float)(-(float)this.direction);
									this.ai[1] += 1f;
									if (this.type == 27)
									{
										this.ai[1] += 1f;
									}
									if (this.type == 31)
									{
										this.ai[1] += 6f;
									}
									this.ai[2] = 0f;
									bool flag5 = false;
									if (this.ai[1] >= 10f)
									{
										flag5 = true;
										this.ai[1] = 10f;
									}
									WorldGen.KillTile(num32, num33 - 1, true, false, false);
									if ((Main.netMode != 1 || !flag5) && flag5 && Main.netMode != 1)
									{
										if (this.type == 26)
										{
											WorldGen.KillTile(num32, num33 - 1, false, false, false);
											if (Main.netMode == 2)
											{
												NetMessage.SendData(17, -1, -1, "", 0, (float)num32, (float)(num33 - 1), 0f, 0);
											}
										}
										else
										{
											bool flag6 = WorldGen.OpenDoor(num32, num33, this.direction);
											if (!flag6)
											{
												this.ai[3] = (float)num5;
												this.netUpdate = true;
											}
											if (Main.netMode == 2 && flag6)
											{
												NetMessage.SendData(19, -1, -1, "", 0, (float)num32, (float)num33, (float)this.direction, 0);
											}
										}
									}
								}
							}
							else
							{
								if ((this.velocity.X < 0f && this.spriteDirection == -1) || (this.velocity.X > 0f && this.spriteDirection == 1))
								{
									if (Main.tile[num32, num33 - 2].active && Main.tileSolid[(int)Main.tile[num32, num33 - 2].type])
									{
										if (Main.tile[num32, num33 - 3].active && Main.tileSolid[(int)Main.tile[num32, num33 - 3].type])
										{
											this.velocity.Y = -8f;
											this.netUpdate = true;
										}
										else
										{
											this.velocity.Y = -7f;
											this.netUpdate = true;
										}
									}
									else
									{
										if (Main.tile[num32, num33 - 1].active && Main.tileSolid[(int)Main.tile[num32, num33 - 1].type])
										{
											this.velocity.Y = -6f;
											this.netUpdate = true;
										}
										else
										{
											if (Main.tile[num32, num33].active && Main.tileSolid[(int)Main.tile[num32, num33].type])
											{
												this.velocity.Y = -5f;
												this.netUpdate = true;
											}
											else
											{
												if (this.directionY < 0 && this.type != 67 && (!Main.tile[num32, num33 + 1].active || !Main.tileSolid[(int)Main.tile[num32, num33 + 1].type]) && (!Main.tile[num32 + this.direction, num33 + 1].active || !Main.tileSolid[(int)Main.tile[num32 + this.direction, num33 + 1].type]))
												{
													this.velocity.Y = -8f;
													this.velocity.X = this.velocity.X * 1.5f;
													this.netUpdate = true;
												}
												else
												{
													if (flag3)
													{
														this.ai[1] = 0f;
														this.ai[2] = 0f;
													}
												}
											}
										}
									}
								}
								if ((this.type == 31 || this.type == 47 || this.type == 77 || this.type == 104) && this.velocity.Y == 0f && Math.Abs(this.position.X + (float)(this.width / 2) - (Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2))) < 100f && Math.Abs(this.position.Y + (float)(this.height / 2) - (Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2))) < 50f && ((this.direction > 0 && this.velocity.X >= 1f) || (this.direction < 0 && this.velocity.X <= -1f)))
								{
									this.velocity.X = this.velocity.X * 2f;
									if (this.velocity.X > 3f)
									{
										this.velocity.X = 3f;
									}
									if (this.velocity.X < -3f)
									{
										this.velocity.X = -3f;
									}
									this.velocity.Y = -4f;
									this.netUpdate = true;
								}
								if (this.type == 120 && this.velocity.Y < 0f)
								{
									this.velocity.Y = this.velocity.Y * 1.1f;
								}
							}
						}
						else
						{
							if (flag3)
							{
								this.ai[1] = 0f;
								this.ai[2] = 0f;
							}
						}
						if (Main.netMode != 1 && this.type == 120 && this.ai[3] >= (float)num5)
						{
							int num34 = (int)Main.player[this.target].position.X / 16;
							int num35 = (int)Main.player[this.target].position.Y / 16;
							int num36 = (int)this.position.X / 16;
							int num37 = (int)this.position.Y / 16;
							int num38 = 20;
							int num39 = 0;
							bool flag7 = false;
							if (Math.Abs(this.position.X - Main.player[this.target].position.X) + Math.Abs(this.position.Y - Main.player[this.target].position.Y) > 2000f)
							{
								num39 = 100;
								flag7 = true;
							}
							while (!flag7)
							{
								if (num39 >= 100)
								{
									return;
								}
								num39++;
								int num40 = Main.rand.Next(num34 - num38, num34 + num38);
								int num41 = Main.rand.Next(num35 - num38, num35 + num38);
								for (int m = num41; m < num35 + num38; m++)
								{
									if ((m < num35 - 4 || m > num35 + 4 || num40 < num34 - 4 || num40 > num34 + 4) && (m < num37 - 1 || m > num37 + 1 || num40 < num36 - 1 || num40 > num36 + 1) && Main.tile[num40, m].active)
									{
										bool flag8 = true;
										if (this.type == 32 && Main.tile[num40, m - 1].wall == 0)
										{
											flag8 = false;
										}
										else
										{
											if (Main.tile[num40, m - 1].lava)
											{
												flag8 = false;
											}
										}
										if (flag8 && Main.tileSolid[(int)Main.tile[num40, m].type] && !Collision.SolidTiles(num40 - 1, num40 + 1, m - 4, m - 1))
										{
											this.position.X = (float)(num40 * 16 - this.width / 2);
											this.position.Y = (float)(m * 16 - this.height);
											this.netUpdate = true;
											this.ai[3] = -120f;
										}
									}
								}
							}
						}
					}
					break;
				case 4:
					{
						if (this.target < 0 || this.target == 255 || Main.player[this.target].dead || !Main.player[this.target].active)
						{
							this.TargetClosest(true);
						}
						bool dead = Main.player[this.target].dead;
						float num42 = this.position.X + (float)(this.width / 2) - Main.player[this.target].position.X - (float)(Main.player[this.target].width / 2);
						float num43 = this.position.Y + (float)this.height - 59f - Main.player[this.target].position.Y - (float)(Main.player[this.target].height / 2);
						float num44 = (float)Math.Atan2((double)num43, (double)num42) + 1.57f;
						if (num44 < 0f)
						{
							num44 += 6.283f;
						}
						else
						{
							if ((double)num44 > 6.283)
							{
								num44 -= 6.283f;
							}
						}
						float num45 = 0f;
						if (this.ai[0] == 0f && this.ai[1] == 0f)
						{
							num45 = 0.02f;
						}
						if (this.ai[0] == 0f && this.ai[1] == 2f && this.ai[2] > 40f)
						{
							num45 = 0.05f;
						}
						if (this.ai[0] == 3f && this.ai[1] == 0f)
						{
							num45 = 0.05f;
						}
						if (this.ai[0] == 3f && this.ai[1] == 2f && this.ai[2] > 40f)
						{
							num45 = 0.08f;
						}
						if (this.rotation < num44)
						{
							if ((double)(num44 - this.rotation) > 3.1415)
							{
								this.rotation -= num45;
							}
							else
							{
								this.rotation += num45;
							}
						}
						else
						{
							if (this.rotation > num44)
							{
								if ((double)(this.rotation - num44) > 3.1415)
								{
									this.rotation += num45;
								}
								else
								{
									this.rotation -= num45;
								}
							}
						}
						if (this.rotation > num44 - num45 && this.rotation < num44 + num45)
						{
							this.rotation = num44;
						}
						if (this.rotation < 0f)
						{
							this.rotation += 6.283f;
						}
						else
						{
							if ((double)this.rotation > 6.283)
							{
								this.rotation -= 6.283f;
							}
						}
						if (this.rotation > num44 - num45 && this.rotation < num44 + num45)
						{
							this.rotation = num44;
						}
						if (Main.rand.Next(5) == 0)
						{
							Vector2 arg_3DD5_0 = new Vector2(this.position.X, this.position.Y + (float)this.height * 0.25f);
							int arg_3DD5_1 = this.width;
							int arg_3DD5_2 = (int)((float)this.height * 0.5f);
							int arg_3DD5_3 = 5;
							float arg_3DD5_4 = this.velocity.X;
							float arg_3DD5_5 = 2f;
							int arg_3DD5_6 = 0;
							Color newColor = default(Color);
							int num46 = Dust.NewDust(arg_3DD5_0, arg_3DD5_1, arg_3DD5_2, arg_3DD5_3, arg_3DD5_4, arg_3DD5_5, arg_3DD5_6, newColor, 1f);
							Dust expr_3DE9_cp_0 = Main.dust[num46];
							expr_3DE9_cp_0.velocity.X = expr_3DE9_cp_0.velocity.X * 0.5f;
							Dust expr_3E07_cp_0 = Main.dust[num46];
							expr_3E07_cp_0.velocity.Y = expr_3E07_cp_0.velocity.Y * 0.1f;
						}
						if (Main.dayTime || dead)
						{
							this.velocity.Y = this.velocity.Y - 0.04f;
							if (this.timeLeft > 10)
							{
								this.timeLeft = 10;
								return;
							}
						}
						else
						{
							if (this.ai[0] == 0f)
							{
								if (this.ai[1] == 0f)
								{
									float num47 = 5f;
									float num48 = 0.04f;
									Vector2 vector5 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
									float num49 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector5.X;
									float num50 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - 200f - vector5.Y;
									float num51 = (float)Math.Sqrt((double)(num49 * num49 + num50 * num50));
									float num52 = num51;
									num51 = num47 / num51;
									num49 *= num51;
									num50 *= num51;
									if (this.velocity.X < num49)
									{
										this.velocity.X = this.velocity.X + num48;
										if (this.velocity.X < 0f && num49 > 0f)
										{
											this.velocity.X = this.velocity.X + num48;
										}
									}
									else
									{
										if (this.velocity.X > num49)
										{
											this.velocity.X = this.velocity.X - num48;
											if (this.velocity.X > 0f && num49 < 0f)
											{
												this.velocity.X = this.velocity.X - num48;
											}
										}
									}
									if (this.velocity.Y < num50)
									{
										this.velocity.Y = this.velocity.Y + num48;
										if (this.velocity.Y < 0f && num50 > 0f)
										{
											this.velocity.Y = this.velocity.Y + num48;
										}
									}
									else
									{
										if (this.velocity.Y > num50)
										{
											this.velocity.Y = this.velocity.Y - num48;
											if (this.velocity.Y > 0f && num50 < 0f)
											{
												this.velocity.Y = this.velocity.Y - num48;
											}
										}
									}
									this.ai[2] += 1f;
									if (this.ai[2] >= 600f)
									{
										this.ai[1] = 1f;
										this.ai[2] = 0f;
										this.ai[3] = 0f;
										this.target = 255;
										this.netUpdate = true;
									}
									else
									{
										if (this.position.Y + (float)this.height < Main.player[this.target].position.Y && num52 < 500f)
										{
											if (!Main.player[this.target].dead)
											{
												this.ai[3] += 1f;
											}
											if (this.ai[3] >= 110f)
											{
												this.ai[3] = 0f;
												this.rotation = num44;
												float num53 = 5f;
												float num54 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector5.X;
												float num55 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector5.Y;
												float num56 = (float)Math.Sqrt((double)(num54 * num54 + num55 * num55));
												num56 = num53 / num56;
												Vector2 vector6 = vector5;
												Vector2 vector7;
												vector7.X = num54 * num56;
												vector7.Y = num55 * num56;
												vector6.X += vector7.X * 10f;
												vector6.Y += vector7.Y * 10f;
												if (Main.netMode != 1)
												{
													int num57 = NPC.NewNPC((int)vector6.X, (int)vector6.Y, 5, 0);
													Main.npc[num57].velocity.X = vector7.X;
													Main.npc[num57].velocity.Y = vector7.Y;
													if (Main.netMode == 2 && num57 < 200)
													{
														NetMessage.SendData(23, -1, -1, "", num57, 0f, 0f, 0f, 0);
													}
												}
												Main.PlaySound(3, (int)vector6.X, (int)vector6.Y, 1);
												for (int n = 0; n < 10; n++)
												{
													Vector2 arg_4352_0 = vector6;
													int arg_4352_1 = 20;
													int arg_4352_2 = 20;
													int arg_4352_3 = 5;
													float arg_4352_4 = vector7.X * 0.4f;
													float arg_4352_5 = vector7.Y * 0.4f;
													int arg_4352_6 = 0;
													Color newColor = default(Color);
													Dust.NewDust(arg_4352_0, arg_4352_1, arg_4352_2, arg_4352_3, arg_4352_4, arg_4352_5, arg_4352_6, newColor, 1f);
												}
											}
										}
									}
								}
								else
								{
									if (this.ai[1] == 1f)
									{
										this.rotation = num44;
										float num58 = 6f;
										Vector2 vector8 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
										float num59 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector8.X;
										float num60 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector8.Y;
										float num61 = (float)Math.Sqrt((double)(num59 * num59 + num60 * num60));
										num61 = num58 / num61;
										this.velocity.X = num59 * num61;
										this.velocity.Y = num60 * num61;
										this.ai[1] = 2f;
									}
									else
									{
										if (this.ai[1] == 2f)
										{
											this.ai[2] += 1f;
											if (this.ai[2] >= 40f)
											{
												this.velocity.X = this.velocity.X * 0.98f;
												this.velocity.Y = this.velocity.Y * 0.98f;
												if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
												{
													this.velocity.X = 0f;
												}
												if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
												{
													this.velocity.Y = 0f;
												}
											}
											else
											{
												this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) - 1.57f;
											}
											if (this.ai[2] >= 150f)
											{
												this.ai[3] += 1f;
												this.ai[2] = 0f;
												this.target = 255;
												this.rotation = num44;
												if (this.ai[3] >= 3f)
												{
													this.ai[1] = 0f;
													this.ai[3] = 0f;
												}
												else
												{
													this.ai[1] = 1f;
												}
											}
										}
									}
								}
								if ((double)this.life < (double)this.lifeMax * 0.5)
								{
									this.ai[0] = 1f;
									this.ai[1] = 0f;
									this.ai[2] = 0f;
									this.ai[3] = 0f;
									this.netUpdate = true;
									return;
								}
							}
							else
							{
								if (this.ai[0] == 1f || this.ai[0] == 2f)
								{
									if (this.ai[0] == 1f)
									{
										this.ai[2] += 0.005f;
										if ((double)this.ai[2] > 0.5)
										{
											this.ai[2] = 0.5f;
										}
									}
									else
									{
										this.ai[2] -= 0.005f;
										if (this.ai[2] < 0f)
										{
											this.ai[2] = 0f;
										}
									}
									this.rotation += this.ai[2];
									this.ai[1] += 1f;
									Color newColor;
									if (this.ai[1] == 100f)
									{
										this.ai[0] += 1f;
										this.ai[1] = 0f;
										if (this.ai[0] == 3f)
										{
											this.ai[2] = 0f;
										}
										else
										{
											Main.PlaySound(3, (int)this.position.X, (int)this.position.Y, 1);
											for (int num62 = 0; num62 < 2; num62++)
											{
												Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 8, 1f);
												Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 7, 1f);
												Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 6, 1f);
											}
											for (int num63 = 0; num63 < 20; num63++)
											{
												Vector2 arg_48F4_0 = this.position;
												int arg_48F4_1 = this.width;
												int arg_48F4_2 = this.height;
												int arg_48F4_3 = 5;
												float arg_48F4_4 = (float)Main.rand.Next(-30, 31) * 0.2f;
												float arg_48F4_5 = (float)Main.rand.Next(-30, 31) * 0.2f;
												int arg_48F4_6 = 0;
												newColor = default(Color);
												Dust.NewDust(arg_48F4_0, arg_48F4_1, arg_48F4_2, arg_48F4_3, arg_48F4_4, arg_48F4_5, arg_48F4_6, newColor, 1f);
											}
											Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
										}
									}
									Vector2 arg_4977_0 = this.position;
									int arg_4977_1 = this.width;
									int arg_4977_2 = this.height;
									int arg_4977_3 = 5;
									float arg_4977_4 = (float)Main.rand.Next(-30, 31) * 0.2f;
									float arg_4977_5 = (float)Main.rand.Next(-30, 31) * 0.2f;
									int arg_4977_6 = 0;
									newColor = default(Color);
									Dust.NewDust(arg_4977_0, arg_4977_1, arg_4977_2, arg_4977_3, arg_4977_4, arg_4977_5, arg_4977_6, newColor, 1f);
									this.velocity.X = this.velocity.X * 0.98f;
									this.velocity.Y = this.velocity.Y * 0.98f;
									if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
									{
										this.velocity.X = 0f;
									}
									if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
									{
										this.velocity.Y = 0f;
										return;
									}
								}
								else
								{
									this.damage = 23;
									this.defense = 0;
									if (this.ai[1] == 0f)
									{
										float num64 = 6f;
										float num65 = 0.07f;
										Vector2 vector9 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
										float num66 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector9.X;
										float num67 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - 120f - vector9.Y;
										float num68 = (float)Math.Sqrt((double)(num66 * num66 + num67 * num67));
										num68 = num64 / num68;
										num66 *= num68;
										num67 *= num68;
										if (this.velocity.X < num66)
										{
											this.velocity.X = this.velocity.X + num65;
											if (this.velocity.X < 0f && num66 > 0f)
											{
												this.velocity.X = this.velocity.X + num65;
											}
										}
										else
										{
											if (this.velocity.X > num66)
											{
												this.velocity.X = this.velocity.X - num65;
												if (this.velocity.X > 0f && num66 < 0f)
												{
													this.velocity.X = this.velocity.X - num65;
												}
											}
										}
										if (this.velocity.Y < num67)
										{
											this.velocity.Y = this.velocity.Y + num65;
											if (this.velocity.Y < 0f && num67 > 0f)
											{
												this.velocity.Y = this.velocity.Y + num65;
											}
										}
										else
										{
											if (this.velocity.Y > num67)
											{
												this.velocity.Y = this.velocity.Y - num65;
												if (this.velocity.Y > 0f && num67 < 0f)
												{
													this.velocity.Y = this.velocity.Y - num65;
												}
											}
										}
										this.ai[2] += 1f;
										if (this.ai[2] >= 200f)
										{
											this.ai[1] = 1f;
											this.ai[2] = 0f;
											this.ai[3] = 0f;
											this.target = 255;
											this.netUpdate = true;
											return;
										}
									}
									else
									{
										if (this.ai[1] == 1f)
										{
											Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
											this.rotation = num44;
											float num69 = 6.8f;
											Vector2 vector10 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
											float num70 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector10.X;
											float num71 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector10.Y;
											float num72 = (float)Math.Sqrt((double)(num70 * num70 + num71 * num71));
											num72 = num69 / num72;
											this.velocity.X = num70 * num72;
											this.velocity.Y = num71 * num72;
											this.ai[1] = 2f;
											return;
										}
										if (this.ai[1] == 2f)
										{
											this.ai[2] += 1f;
											if (this.ai[2] >= 40f)
											{
												this.velocity.X = this.velocity.X * 0.97f;
												this.velocity.Y = this.velocity.Y * 0.97f;
												if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
												{
													this.velocity.X = 0f;
												}
												if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
												{
													this.velocity.Y = 0f;
												}
											}
											else
											{
												this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) - 1.57f;
											}
											if (this.ai[2] >= 130f)
											{
												this.ai[3] += 1f;
												this.ai[2] = 0f;
												this.target = 255;
												this.rotation = num44;
												if (this.ai[3] >= 3f)
												{
													this.ai[1] = 0f;
													this.ai[3] = 0f;
													return;
												}
												this.ai[1] = 1f;
												return;
											}
										}
									}
								}
							}
						}
					}
					break;
				case 5:
					{
						if (this.target < 0 || this.target == 255 || Main.player[this.target].dead)
						{
							this.TargetClosest(true);
						}
						float num73 = 6f;
						float num74 = 0.05f;
						switch (this.type)
						{
							case 6:
								num73 = 4f;
								num74 = 0.02f;
								break;
							case 94:
								num73 = 4.2f;
								num74 = 0.022f;
								break;
							case 42:
								num73 = 3.5f;
								num74 = 0.021f;
								break;
							case 23:
								num73 = 1f;
								num74 = 0.03f;
								break;
							case 5:
								num73 = 5f;
								num74 = 0.03f;
								break;
						}
						Vector2 vector11 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
						float num75 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2);
						float num76 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2);
						num75 = (float)((int)(num75 / 8f) * 8);
						num76 = (float)((int)(num76 / 8f) * 8);
						vector11.X = (float)((int)(vector11.X / 8f) * 8);
						vector11.Y = (float)((int)(vector11.Y / 8f) * 8);
						num75 -= vector11.X;
						num76 -= vector11.Y;
						float num77 = (float)Math.Sqrt((double)(num75 * num75 + num76 * num76));
						float num78 = num77;
						bool flag9 = false;
						if (num77 > 600f)
						{
							flag9 = true;
						}
						if (num77 == 0f)
						{
							num75 = this.velocity.X;
							num76 = this.velocity.Y;
						}
						else
						{
							num77 = num73 / num77;
							num75 *= num77;
							num76 *= num77;
						}
						if (this.type == 6 || this.type == 42 || this.type == 94 || this.type == 139)
						{
							if (num78 > 100f || this.type == 42 || this.type == 94)
							{
								this.ai[0] += 1f;
								if (this.ai[0] > 0f)
								{
									this.velocity.Y = this.velocity.Y + 0.023f;
								}
								else
								{
									this.velocity.Y = this.velocity.Y - 0.023f;
								}
								if (this.ai[0] < -100f || this.ai[0] > 100f)
								{
									this.velocity.X = this.velocity.X + 0.023f;
								}
								else
								{
									this.velocity.X = this.velocity.X - 0.023f;
								}
								if (this.ai[0] > 200f)
								{
									this.ai[0] = -200f;
								}
							}
							if (num78 < 150f && (this.type == 6 || this.type == 94))
							{
								this.velocity.X = this.velocity.X + num75 * 0.007f;
								this.velocity.Y = this.velocity.Y + num76 * 0.007f;
							}
						}
						if (Main.player[this.target].dead)
						{
							num75 = (float)this.direction * num73 / 2f;
							num76 = -num73 / 2f;
						}
						if (this.velocity.X < num75)
						{
							this.velocity.X = this.velocity.X + num74;
							if (this.type != 6 && this.type != 42 && this.type != 94 && this.type != 139 && this.velocity.X < 0f && num75 > 0f)
							{
								this.velocity.X = this.velocity.X + num74;
							}
						}
						else
						{
							if (this.velocity.X > num75)
							{
								this.velocity.X = this.velocity.X - num74;
								if (this.type != 6 && this.type != 42 && this.type != 94 && this.type != 139 && this.velocity.X > 0f && num75 < 0f)
								{
									this.velocity.X = this.velocity.X - num74;
								}
							}
						}
						if (this.velocity.Y < num76)
						{
							this.velocity.Y = this.velocity.Y + num74;
							if (this.type != 6 && this.type != 42 && this.type != 94 && this.type != 139 && this.velocity.Y < 0f && num76 > 0f)
							{
								this.velocity.Y = this.velocity.Y + num74;
							}
						}
						else
						{
							if (this.velocity.Y > num76)
							{
								this.velocity.Y = this.velocity.Y - num74;
								if (this.type != 6 && this.type != 42 && this.type != 94 && this.type != 139 && this.velocity.Y > 0f && num76 < 0f)
								{
									this.velocity.Y = this.velocity.Y - num74;
								}
							}
						}
						if (this.type == 23)
						{
							if (num75 > 0f)
							{
								this.spriteDirection = 1;
								this.rotation = (float)Math.Atan2((double)num76, (double)num75);
							}
							else
							{
								if (num75 < 0f)
								{
									this.spriteDirection = -1;
									this.rotation = (float)Math.Atan2((double)num76, (double)num75) + 3.14f;
								}
							}
						}
						else
						{
							if (this.type == 139)
							{
								this.localAI[0] += 1f;
								if (this.justHit)
								{
									this.localAI[0] = 0f;
								}
								if (Main.netMode != 1 && this.localAI[0] >= 120f)
								{
									this.localAI[0] = 0f;
									if (Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
									{
										int num79 = 25;
										int num80 = 84;
										Projectile.NewProjectile(vector11.X, vector11.Y, num75, num76, num80, num79, 0f, Main.myPlayer);
									}
								}
								int num81 = (int)this.position.X + this.width / 2;
								int num82 = (int)this.position.Y + this.height / 2;
								num81 /= 16;
								num82 /= 16;
								if (!WorldGen.SolidTile(num81, num82))
								{
									Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.3f, 0.1f, 0.05f);
								}
								if (num75 > 0f)
								{
									this.spriteDirection = 1;
									this.rotation = (float)Math.Atan2((double)num76, (double)num75);
								}
								if (num75 < 0f)
								{
									this.spriteDirection = -1;
									this.rotation = (float)Math.Atan2((double)num76, (double)num75) + 3.14f;
								}
							}
							else
							{
								switch (this.type)
								{
									case 94:
									case 6:
										this.rotation = (float)Math.Atan2((double)num76, (double)num75) - 1.57f;
										break;
									case 42:
										if (num75 > 0f)
										{
											this.spriteDirection = 1;
										}
										if (num75 < 0f)
										{
											this.spriteDirection = -1;
										}
										this.rotation = this.velocity.X * 0.1f;
										break;
									default:
										this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) - 1.57f;
										break;
								}
							}
						}
						if (this.type == 6 || this.type == 23 || this.type == 42 || this.type == 94 || this.type == 139)
						{
							float num83 = 0.7f;
							if (this.type == 6)
							{
								num83 = 0.4f;
							}
							if (this.collideX)
							{
								this.netUpdate = true;
								this.velocity.X = this.oldVelocity.X * -num83;
								if (this.direction == -1 && this.velocity.X > 0f && this.velocity.X < 2f)
								{
									this.velocity.X = 2f;
								}
								if (this.direction == 1 && this.velocity.X < 0f && this.velocity.X > -2f)
								{
									this.velocity.X = -2f;
								}
							}
							if (this.collideY)
							{
								this.netUpdate = true;
								this.velocity.Y = this.oldVelocity.Y * -num83;
								if (this.velocity.Y > 0f && (double)this.velocity.Y < 1.5)
								{
									this.velocity.Y = 2f;
								}
								if (this.velocity.Y < 0f && (double)this.velocity.Y > -1.5)
								{
									this.velocity.Y = -2f;
								}
							}
							if (this.type == 23)
							{
								Vector2 arg_5A5C_0 = new Vector2(this.position.X - this.velocity.X, this.position.Y - this.velocity.Y);
								int arg_5A5C_1 = this.width;
								int arg_5A5C_2 = this.height;
								int arg_5A5C_3 = 6;
								float arg_5A5C_4 = this.velocity.X * 0.2f;
								float arg_5A5C_5 = this.velocity.Y * 0.2f;
								int arg_5A5C_6 = 100;
								Color newColor = default(Color);
								int num84 = Dust.NewDust(arg_5A5C_0, arg_5A5C_1, arg_5A5C_2, arg_5A5C_3, arg_5A5C_4, arg_5A5C_5, arg_5A5C_6, newColor, 2f);
								Main.dust[num84].noGravity = true;
								Dust expr_5A7E_cp_0 = Main.dust[num84];
								expr_5A7E_cp_0.velocity.X = expr_5A7E_cp_0.velocity.X * 0.3f;
								Dust expr_5A9C_cp_0 = Main.dust[num84];
								expr_5A9C_cp_0.velocity.Y = expr_5A9C_cp_0.velocity.Y * 0.3f;
							}
							else
							{
								if (this.type != 42 && this.type != 139 && Main.rand.Next(20) == 0)
								{
									int num85 = Dust.NewDust(new Vector2(this.position.X, this.position.Y + (float)this.height * 0.25f), this.width, (int)((float)this.height * 0.5f), 18, this.velocity.X, 2f, 75, this.color, this.scale);
									Dust expr_5B51_cp_0 = Main.dust[num85];
									expr_5B51_cp_0.velocity.X = expr_5B51_cp_0.velocity.X * 0.5f;
									Dust expr_5B6F_cp_0 = Main.dust[num85];
									expr_5B6F_cp_0.velocity.Y = expr_5B6F_cp_0.velocity.Y * 0.1f;
								}
							}
						}
						else
						{
							if (Main.rand.Next(40) == 0)
							{
								Vector2 arg_5BF8_0 = new Vector2(this.position.X, this.position.Y + (float)this.height * 0.25f);
								int arg_5BF8_1 = this.width;
								int arg_5BF8_2 = (int)((float)this.height * 0.5f);
								int arg_5BF8_3 = 5;
								float arg_5BF8_4 = this.velocity.X;
								float arg_5BF8_5 = 2f;
								int arg_5BF8_6 = 0;
								Color newColor = default(Color);
								int num86 = Dust.NewDust(arg_5BF8_0, arg_5BF8_1, arg_5BF8_2, arg_5BF8_3, arg_5BF8_4, arg_5BF8_5, arg_5BF8_6, newColor, 1f);
								Dust expr_5C0C_cp_0 = Main.dust[num86];
								expr_5C0C_cp_0.velocity.X = expr_5C0C_cp_0.velocity.X * 0.5f;
								Dust expr_5C2A_cp_0 = Main.dust[num86];
								expr_5C2A_cp_0.velocity.Y = expr_5C2A_cp_0.velocity.Y * 0.1f;
							}
						}
						if ((this.type == 6 || this.type == 94) && this.wet)
						{
							if (this.velocity.Y > 0f)
							{
								this.velocity.Y = this.velocity.Y * 0.95f;
							}
							this.velocity.Y = this.velocity.Y - 0.3f;
							if (this.velocity.Y < -2f)
							{
								this.velocity.Y = -2f;
							}
						}
						if (this.type == 42)
						{
							if (this.wet)
							{
								if (this.velocity.Y > 0f)
								{
									this.velocity.Y = this.velocity.Y * 0.95f;
								}
								this.velocity.Y = this.velocity.Y - 0.5f;
								if (this.velocity.Y < -4f)
								{
									this.velocity.Y = -4f;
								}
								this.TargetClosest(true);
							}
							if (this.ai[1] == 101f)
							{
								Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 17);
								this.ai[1] = 0f;
							}
							if (Main.netMode != 1)
							{
								this.ai[1] += (float)Main.rand.Next(5, 20) * 0.1f * this.scale;
								if (this.ai[1] >= 130f)
								{
									if (Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
									{
										float num87 = 8f;
										Vector2 vector12 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)(this.height / 2));
										float num88 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector12.X + (float)Main.rand.Next(-20, 21);
										float num89 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector12.Y + (float)Main.rand.Next(-20, 21);
										if ((num88 < 0f && this.velocity.X < 0f) || (num88 > 0f && this.velocity.X > 0f))
										{
											float num90 = (float)Math.Sqrt((double)(num88 * num88 + num89 * num89));
											num90 = num87 / num90;
											num88 *= num90;
											num89 *= num90;
											int num91 = (int)(13f * this.scale);
											int num92 = 55;
											int num93 = Projectile.NewProjectile(vector12.X, vector12.Y, num88, num89, num92, num91, 0f, Main.myPlayer);
											Main.projectile[num93].timeLeft = 300;
											this.ai[1] = 101f;
											this.netUpdate = true;
										}
										else
										{
											this.ai[1] = 0f;
										}
									}
									else
									{
										this.ai[1] = 0f;
									}
								}
							}
						}
						if (this.type == 139 && flag9)
						{
							if ((this.velocity.X > 0f && num75 > 0f) || (this.velocity.X < 0f && num75 < 0f))
							{
								if (Math.Abs(this.velocity.X) < 12f)
								{
									this.velocity.X = this.velocity.X * 1.05f;
								}
							}
							else
							{
								this.velocity.X = this.velocity.X * 0.9f;
							}
						}
						if (Main.netMode != 1 && this.type == 94 && !Main.player[this.target].dead)
						{
							if (this.justHit)
							{
								this.localAI[0] = 0f;
							}
							this.localAI[0] += 1f;
							if (this.localAI[0] == 180f)
							{
								if (Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
								{
									NPC.NewNPC((int)(this.position.X + (float)(this.width / 2) + this.velocity.X), (int)(this.position.Y + (float)(this.height / 2) + this.velocity.Y), 112, 0);
								}
								this.localAI[0] = 0f;
							}
						}
						if ((Main.dayTime && this.type != 6 && this.type != 23 && this.type != 42 && this.type != 94) || Main.player[this.target].dead)
						{
							this.velocity.Y = this.velocity.Y - num74 * 2f;
							if (this.timeLeft > 10)
							{
								this.timeLeft = 10;
							}
						}
						if (((this.velocity.X > 0f && this.oldVelocity.X < 0f) || (this.velocity.X < 0f && this.oldVelocity.X > 0f) || (this.velocity.Y > 0f && this.oldVelocity.Y < 0f) || (this.velocity.Y < 0f && this.oldVelocity.Y > 0f)) && !this.justHit)
						{
							this.netUpdate = true;
							return;
						}
					}
					break;
				case 6:
					{
						if (this.type == 117 && this.localAI[1] == 0f)
						{
							this.localAI[1] = 1f;
							Main.PlaySound(4, (int)this.position.X, (int)this.position.Y, 13);
							int num94 = 1;
							if (this.velocity.X < 0f)
							{
								num94 = -1;
							}
							for (int num95 = 0; num95 < 20; num95++)
							{
								Vector2 arg_634E_0 = new Vector2(this.position.X - 20f, this.position.Y - 20f);
								int arg_634E_1 = this.width + 40;
								int arg_634E_2 = this.height + 40;
								int arg_634E_3 = 5;
								float arg_634E_4 = (float)(num94 * 8);
								float arg_634E_5 = -1f;
								int arg_634E_6 = 0;
								Color newColor = default(Color);
								Dust.NewDust(arg_634E_0, arg_634E_1, arg_634E_2, arg_634E_3, arg_634E_4, arg_634E_5, arg_634E_6, newColor, 1f);
							}
						}
						if (this.type >= 13 && this.type <= 15)
						{
							this.realLife = -1;
						}
						else
						{
							if (this.ai[3] > 0f)
							{
								this.realLife = (int)this.ai[3];
							}
						}
						if (this.target < 0 || this.target == 255 || Main.player[this.target].dead)
						{
							this.TargetClosest(true);
						}
						if (Main.player[this.target].dead && this.timeLeft > 300)
						{
							this.timeLeft = 300;
						}
						if (Main.netMode != 1)
						{
							if (this.type == 87 && this.ai[0] == 0f)
							{
								this.ai[3] = (float)this.whoAmI;
								this.realLife = this.whoAmI;
								int num96 = this.whoAmI;
								for (int num97 = 0; num97 < 14; num97++)
								{
									int num98 = 89;
									switch (num97)
									{
										case 8:
										case 1:
											num98 = 88;
											break;
										case 11:
											num98 = 90;
											break;
										case 12:
											num98 = 91;
											break;
										case 13:
											num98 = 92;
											break;
									}
									int num99 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), num98, this.whoAmI);
									Main.npc[num99].ai[3] = (float)this.whoAmI;
									Main.npc[num99].realLife = this.whoAmI;
									Main.npc[num99].ai[1] = (float)num96;
									Main.npc[num96].ai[0] = (float)num99;
									NetMessage.SendData(23, -1, -1, "", num99, 0f, 0f, 0f, 0);
									num96 = num99;
								}
							}
							if ((this.type == 7 || this.type == 8 || this.type == 10 || this.type == 11 || this.type == 13 || this.type == 14 || this.type == 39 || this.type == 40 || this.type == 95 || this.type == 96 || this.type == 98 || this.type == 99 || this.type == 117 || this.type == 118) && this.ai[0] == 0f)
							{
								switch (this.type)
								{
									case 117:
									case 98:
									case 95:
									case 39:
									case 13:
									case 10:
									case 7:
										if (this.type < 13 || this.type > 15)
										{
											this.ai[3] = (float)this.whoAmI;
											this.realLife = this.whoAmI;
										}
										this.ai[2] = (float)Main.rand.Next(8, 13);
										if (this.type == 10)
										{
											this.ai[2] = (float)Main.rand.Next(4, 7);
										}
										if (this.type == 13)
										{
											this.ai[2] = (float)Main.rand.Next(45, 56);
										}
										if (this.type == 39)
										{
											this.ai[2] = (float)Main.rand.Next(12, 19);
										}
										if (this.type == 95)
										{
											this.ai[2] = (float)Main.rand.Next(6, 12);
										}
										if (this.type == 98)
										{
											this.ai[2] = (float)Main.rand.Next(20, 26);
										}
										if (this.type == 117)
										{
											this.ai[2] = (float)Main.rand.Next(3, 6);
										}
										this.ai[0] = (float)NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), this.type + 1, this.whoAmI);
										break;
									default:
										if ((this.type == 8 || this.type == 11 || this.type == 14 || this.type == 40 || this.type == 96 || this.type == 99 || this.type == 118) && this.ai[2] > 0f)
										{
											this.ai[0] = (float)NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), this.type, this.whoAmI);
										}
										else
										{
											this.ai[0] = (float)NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), this.type + 1, this.whoAmI);
										}
										break;
								}
								if (this.type < 13 || this.type > 15)
								{
									Main.npc[(int)this.ai[0]].ai[3] = this.ai[3];
									Main.npc[(int)this.ai[0]].realLife = this.realLife;
								}
								Main.npc[(int)this.ai[0]].ai[1] = (float)this.whoAmI;
								Main.npc[(int)this.ai[0]].ai[2] = this.ai[2] - 1f;
								this.netUpdate = true;
							}
							if ((this.type == 8 || this.type == 9 || this.type == 11 || this.type == 12 || this.type == 40 || this.type == 41 || this.type == 96 || this.type == 97 || this.type == 99 || this.type == 100 || (this.type > 87 && this.type <= 92) || this.type == 118 || this.type == 119) && (!Main.npc[(int)this.ai[1]].active || Main.npc[(int)this.ai[1]].aiStyle != this.aiStyle))
							{
								this.life = 0;
								this.HitEffect(0, 10.0);
								this.active = false;
							}
							if ((this.type == 7 || this.type == 8 || this.type == 10 || this.type == 11 || this.type == 39 || this.type == 40 || this.type == 95 || this.type == 96 || this.type == 98 || this.type == 99 || (this.type >= 87 && this.type < 92) || this.type == 117 || this.type == 118) && (!Main.npc[(int)this.ai[0]].active || Main.npc[(int)this.ai[0]].aiStyle != this.aiStyle))
							{
								this.life = 0;
								this.HitEffect(0, 10.0);
								this.active = false;
							}
							if (this.type == 13 || this.type == 14 || this.type == 15)
							{
								if (!Main.npc[(int)this.ai[1]].active && !Main.npc[(int)this.ai[0]].active)
								{
									this.life = 0;
									this.HitEffect(0, 10.0);
									this.active = false;
								}
								if (this.type == 13 && !Main.npc[(int)this.ai[0]].active)
								{
									this.life = 0;
									this.HitEffect(0, 10.0);
									this.active = false;
								}
								if (this.type == 15 && !Main.npc[(int)this.ai[1]].active)
								{
									this.life = 0;
									this.HitEffect(0, 10.0);
									this.active = false;
								}
								if (this.type == 14 && (!Main.npc[(int)this.ai[1]].active || Main.npc[(int)this.ai[1]].aiStyle != this.aiStyle))
								{
									this.type = 13;
									int num100 = this.whoAmI;
									float num101 = (float)this.life / (float)this.lifeMax;
									float num102 = this.ai[0];
									this.SetDefaults(this.type, -1f);
									this.life = (int)((float)this.lifeMax * num101);
									this.ai[0] = num102;
									this.TargetClosest(true);
									this.netUpdate = true;
									this.whoAmI = num100;
								}
								if (this.type == 14 && (!Main.npc[(int)this.ai[0]].active || Main.npc[(int)this.ai[0]].aiStyle != this.aiStyle))
								{
									int num103 = this.whoAmI;
									float num104 = (float)this.life / (float)this.lifeMax;
									float num105 = this.ai[1];
									this.SetDefaults(this.type, -1f);
									this.life = (int)((float)this.lifeMax * num104);
									this.ai[1] = num105;
									this.TargetClosest(true);
									this.netUpdate = true;
									this.whoAmI = num103;
								}
								if (this.life == 0)
								{
									bool flag10 = true;
									for (int num106 = 0; num106 < 200; num106++)
									{
										if (Main.npc[num106].active && (Main.npc[num106].type == 13 || Main.npc[num106].type == 14 || Main.npc[num106].type == 15))
										{
											flag10 = false;
											break;
										}
									}
									if (flag10)
									{
										this.boss = true;
										this.NPCLoot();
									}
								}
							}
							if (!this.active && Main.netMode == 2)
							{
								NetMessage.SendData(28, -1, -1, "", this.whoAmI, -1f, 0f, 0f, 0);
							}
						}
						int num107 = (int)(this.position.X / 16f) - 1;
						int num108 = (int)((this.position.X + (float)this.width) / 16f) + 2;
						int num109 = (int)(this.position.Y / 16f) - 1;
						int num110 = (int)((this.position.Y + (float)this.height) / 16f) + 2;
						if (num107 < 0)
						{
							num107 = 0;
						}
						if (num108 > Main.maxTilesX)
						{
							num108 = Main.maxTilesX;
						}
						if (num109 < 0)
						{
							num109 = 0;
						}
						if (num110 > Main.maxTilesY)
						{
							num110 = Main.maxTilesY;
						}
						bool flag11 = false;
						if (this.type >= 87 && this.type <= 92)
						{
							flag11 = true;
						}
						if (!flag11)
						{
							for (int num111 = num107; num111 < num108; num111++)
							{
								for (int num112 = num109; num112 < num110; num112++)
								{
									if (Main.tile[num111, num112] != null && ((Main.tile[num111, num112].active && (Main.tileSolid[(int)Main.tile[num111, num112].type] || (Main.tileSolidTop[(int)Main.tile[num111, num112].type] && Main.tile[num111, num112].frameY == 0))) || Main.tile[num111, num112].liquid > 64))
									{
										Vector2 vector13;
										vector13.X = (float)(num111 * 16);
										vector13.Y = (float)(num112 * 16);
										if (this.position.X + (float)this.width > vector13.X && this.position.X < vector13.X + 16f && this.position.Y + (float)this.height > vector13.Y && this.position.Y < vector13.Y + 16f)
										{
											flag11 = true;
											if (Main.rand.Next(100) == 0 && this.type != 117 && Main.tile[num111, num112].active)
											{
												WorldGen.KillTile(num111, num112, true, true, false);
											}
											if (Main.netMode != 1 && Main.tile[num111, num112].type == 2)
											{
												byte arg_6FE2_0 = Main.tile[num111, num112 - 1].type;
											}
										}
									}
								}
							}
						}
						if (!flag11 && (this.type == 7 || this.type == 10 || this.type == 13 || this.type == 39 || this.type == 95 || this.type == 98 || this.type == 117))
						{
							Rectangle rectangle = new Rectangle((int)this.position.X, (int)this.position.Y, this.width, this.height);
							int num113 = 1000;
							bool flag12 = true;
							for (int num114 = 0; num114 < 255; num114++)
							{
								if (Main.player[num114].active)
								{
									Rectangle rectangle2 = new Rectangle((int)Main.player[num114].position.X - num113, (int)Main.player[num114].position.Y - num113, num113 * 2, num113 * 2);
									if (rectangle.Intersects(rectangle2))
									{
										flag12 = false;
										break;
									}
								}
							}
							if (flag12)
							{
								flag11 = true;
							}
						}
						if (this.type >= 87 && this.type <= 92)
						{
							if (this.velocity.X < 0f)
							{
								this.spriteDirection = 1;
							}
							else
							{
								if (this.velocity.X > 0f)
								{
									this.spriteDirection = -1;
								}
							}
						}
						float num115 = 8f;
						float num116 = 0.07f;
						if (this.type == 95)
						{
							num115 = 5.5f;
							num116 = 0.045f;
						}
						if (this.type == 10)
						{
							num115 = 6f;
							num116 = 0.05f;
						}
						if (this.type == 13)
						{
							num115 = 10f;
							num116 = 0.07f;
						}
						if (this.type == 87)
						{
							num115 = 11f;
							num116 = 0.25f;
						}
						if (this.type == 117 && Main.wof >= 0)
						{
							float num117 = (float)Main.npc[Main.wof].life / (float)Main.npc[Main.wof].lifeMax;
							if ((double)num117 < 0.5)
							{
								num115 += 1f;
								num116 += 0.1f;
							}
							if ((double)num117 < 0.25)
							{
								num115 += 1f;
								num116 += 0.1f;
							}
							if ((double)num117 < 0.1)
							{
								num115 += 2f;
								num116 += 0.1f;
							}
						}
						Vector2 vector14 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
						float num118 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2);
						float num119 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2);
						num118 = (float)((int)(num118 / 16f) * 16);
						num119 = (float)((int)(num119 / 16f) * 16);
						vector14.X = (float)((int)(vector14.X / 16f) * 16);
						vector14.Y = (float)((int)(vector14.Y / 16f) * 16);
						num118 -= vector14.X;
						num119 -= vector14.Y;
						float num120 = (float)Math.Sqrt((double)(num118 * num118 + num119 * num119));
						if (this.ai[1] > 0f && this.ai[1] < (float)Main.npc.Length)
						{
							try
							{
								vector14 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
								num118 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - vector14.X;
								num119 = Main.npc[(int)this.ai[1]].position.Y + (float)(Main.npc[(int)this.ai[1]].height / 2) - vector14.Y;
							}
							catch
							{
							}
							this.rotation = (float)Math.Atan2((double)num119, (double)num118) + 1.57f;
							num120 = (float)Math.Sqrt((double)(num118 * num118 + num119 * num119));
							int num121 = this.width;
							if (this.type >= 87 && this.type <= 92)
							{
								num121 = 42;
							}
							num120 = (num120 - (float)num121) / num120;
							num118 *= num120;
							num119 *= num120;
							this.velocity = default(Vector2);
							this.position.X = this.position.X + num118;
							this.position.Y = this.position.Y + num119;
							if (this.type >= 87 && this.type <= 92)
							{
								if (num118 < 0f)
								{
									this.spriteDirection = 1;
									return;
								}
								if (num118 > 0f)
								{
									this.spriteDirection = -1;
									return;
								}
							}
						}
						else
						{
							if (!flag11)
							{
								this.TargetClosest(true);
								this.velocity.Y = this.velocity.Y + 0.11f;
								if (this.velocity.Y > num115)
								{
									this.velocity.Y = num115;
								}
								if ((double)(Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y)) < (double)num115 * 0.4)
								{
									if (this.velocity.X < 0f)
									{
										this.velocity.X = this.velocity.X - num116 * 1.1f;
									}
									else
									{
										this.velocity.X = this.velocity.X + num116 * 1.1f;
									}
								}
								else
								{
									if (this.velocity.Y == num115)
									{
										if (this.velocity.X < num118)
										{
											this.velocity.X = this.velocity.X + num116;
										}
										else
										{
											if (this.velocity.X > num118)
											{
												this.velocity.X = this.velocity.X - num116;
											}
										}
									}
									else
									{
										if (this.velocity.Y > 4f)
										{
											if (this.velocity.X < 0f)
											{
												this.velocity.X = this.velocity.X + num116 * 0.9f;
											}
											else
											{
												this.velocity.X = this.velocity.X - num116 * 0.9f;
											}
										}
									}
								}
							}
							else
							{
								if (this.type != 87 && this.type != 117 && this.soundDelay == 0)
								{
									float num122 = num120 / 40f;
									if (num122 < 10f)
									{
										num122 = 10f;
									}
									if (num122 > 20f)
									{
										num122 = 20f;
									}
									this.soundDelay = (int)num122;
									Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 1);
								}
								num120 = (float)Math.Sqrt((double)(num118 * num118 + num119 * num119));
								float num123 = Math.Abs(num118);
								float num124 = Math.Abs(num119);
								float num125 = num115 / num120;
								num118 *= num125;
								num119 *= num125;
								if ((this.type == 13 || this.type == 7) && !Main.player[this.target].zoneEvil)
								{
									bool flag13 = true;
									for (int num126 = 0; num126 < 255; num126++)
									{
										if (Main.player[num126].active && !Main.player[num126].dead && Main.player[num126].zoneEvil)
										{
											flag13 = false;
										}
									}
									if (flag13)
									{
										if (Main.netMode != 1 && (double)(this.position.Y / 16f) > (Main.rockLayer + (double)Main.maxTilesY) / 2.0)
										{
											this.active = false;
											int num127 = (int)this.ai[0];
											while (num127 > 0 && num127 < 200 && Main.npc[num127].active && Main.npc[num127].aiStyle == this.aiStyle)
											{
												int num128 = (int)Main.npc[num127].ai[0];
												Main.npc[num127].active = false;
												this.life = 0;
												if (Main.netMode == 2)
												{
													NetMessage.SendData(23, -1, -1, "", num127, 0f, 0f, 0f, 0);
												}
												num127 = num128;
											}
											if (Main.netMode == 2)
											{
												NetMessage.SendData(23, -1, -1, "", this.whoAmI, 0f, 0f, 0f, 0);
											}
										}
										num118 = 0f;
										num119 = num115;
									}
								}
								bool flag14 = false;
								if (this.type == 87)
								{
									if (((this.velocity.X > 0f && num118 < 0f) || (this.velocity.X < 0f && num118 > 0f) || (this.velocity.Y > 0f && num119 < 0f) || (this.velocity.Y < 0f && num119 > 0f)) && Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y) > num116 / 2f && num120 < 300f)
									{
										flag14 = true;
										if (Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y) < num115)
										{
											this.velocity *= 1.1f;
										}
									}
									if (this.position.Y > Main.player[this.target].position.Y || (double)(Main.player[this.target].position.Y / 16f) > Main.worldSurface || Main.player[this.target].dead)
									{
										flag14 = true;
										if (Math.Abs(this.velocity.X) < num115 / 2f)
										{
											if (this.velocity.X == 0f)
											{
												this.velocity.X = this.velocity.X - (float)this.direction;
											}
											this.velocity.X = this.velocity.X * 1.1f;
										}
										else
										{
											if (this.velocity.Y > -num115)
											{
												this.velocity.Y = this.velocity.Y - num116;
											}
										}
									}
								}
								if (!flag14)
								{
									if ((this.velocity.X > 0f && num118 > 0f) || (this.velocity.X < 0f && num118 < 0f) || (this.velocity.Y > 0f && num119 > 0f) || (this.velocity.Y < 0f && num119 < 0f))
									{
										if (this.velocity.X < num118)
										{
											this.velocity.X = this.velocity.X + num116;
										}
										else
										{
											if (this.velocity.X > num118)
											{
												this.velocity.X = this.velocity.X - num116;
											}
										}
										if (this.velocity.Y < num119)
										{
											this.velocity.Y = this.velocity.Y + num116;
										}
										else
										{
											if (this.velocity.Y > num119)
											{
												this.velocity.Y = this.velocity.Y - num116;
											}
										}
										if ((double)Math.Abs(num119) < (double)num115 * 0.2 && ((this.velocity.X > 0f && num118 < 0f) || (this.velocity.X < 0f && num118 > 0f)))
										{
											if (this.velocity.Y > 0f)
											{
												this.velocity.Y = this.velocity.Y + num116 * 2f;
											}
											else
											{
												this.velocity.Y = this.velocity.Y - num116 * 2f;
											}
										}
										if ((double)Math.Abs(num118) < (double)num115 * 0.2 && ((this.velocity.Y > 0f && num119 < 0f) || (this.velocity.Y < 0f && num119 > 0f)))
										{
											if (this.velocity.X > 0f)
											{
												this.velocity.X = this.velocity.X + num116 * 2f;
											}
											else
											{
												this.velocity.X = this.velocity.X - num116 * 2f;
											}
										}
									}
									else
									{
										if (num123 > num124)
										{
											if (this.velocity.X < num118)
											{
												this.velocity.X = this.velocity.X + num116 * 1.1f;
											}
											else
											{
												if (this.velocity.X > num118)
												{
													this.velocity.X = this.velocity.X - num116 * 1.1f;
												}
											}
											if ((double)(Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y)) < (double)num115 * 0.5)
											{
												if (this.velocity.Y > 0f)
												{
													this.velocity.Y = this.velocity.Y + num116;
												}
												else
												{
													this.velocity.Y = this.velocity.Y - num116;
												}
											}
										}
										else
										{
											if (this.velocity.Y < num119)
											{
												this.velocity.Y = this.velocity.Y + num116 * 1.1f;
											}
											else
											{
												if (this.velocity.Y > num119)
												{
													this.velocity.Y = this.velocity.Y - num116 * 1.1f;
												}
											}
											if ((double)(Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y)) < (double)num115 * 0.5)
											{
												if (this.velocity.X > 0f)
												{
													this.velocity.X = this.velocity.X + num116;
												}
												else
												{
													this.velocity.X = this.velocity.X - num116;
												}
											}
										}
									}
								}
							}
							this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) + 1.57f;
							if (this.type == 7 || this.type == 10 || this.type == 13 || this.type == 39 || this.type == 95 || this.type == 98 || this.type == 117)
							{
								if (flag11)
								{
									if (this.localAI[0] != 1f)
									{
										this.netUpdate = true;
									}
									this.localAI[0] = 1f;
								}
								else
								{
									if (this.localAI[0] != 0f)
									{
										this.netUpdate = true;
									}
									this.localAI[0] = 0f;
								}
								if (((this.velocity.X > 0f && this.oldVelocity.X < 0f) || (this.velocity.X < 0f && this.oldVelocity.X > 0f) || (this.velocity.Y > 0f && this.oldVelocity.Y < 0f) || (this.velocity.Y < 0f && this.oldVelocity.Y > 0f)) && !this.justHit)
								{
									this.netUpdate = true;
									return;
								}
							}
						}
					}
					break;
				case 7:
					{
						if (this.type == 142 && Main.netMode != 1 && !Main.xMas)
						{
							this.StrikeNPC(9999, 0f, 0, false, false);
							if (Main.netMode == 2)
							{
								NetMessage.SendData(28, -1, -1, "", this.whoAmI, 9999f, 0f, 0f, 0);
							}
						}
						int num129 = (int)(this.position.X + (float)(this.width / 2)) / 16;
						int num130 = (int)(this.position.Y + (float)this.height + 1f) / 16;
						if (this.type == 107)
						{
							NPC.savedGoblin = true;
						}
						if (this.type == 108)
						{
							NPC.savedWizard = true;
						}
						if (this.type == 124)
						{
							NPC.savedMech = true;
						}
						if (this.type == 46 && this.target == 255)
						{
							this.TargetClosest(true);
						}
						bool flag15 = false;
						this.directionY = -1;
						if (this.direction == 0)
						{
							this.direction = 1;
						}
						for (int num131 = 0; num131 < 255; num131++)
						{
							if (Main.player[num131].active && Main.player[num131].talkNPC == this.whoAmI)
							{
								flag15 = true;
								if (this.ai[0] != 0f)
								{
									this.netUpdate = true;
								}
								this.ai[0] = 0f;
								this.ai[1] = 300f;
								this.ai[2] = 100f;
								if (Main.player[num131].position.X + (float)(Main.player[num131].width / 2) < this.position.X + (float)(this.width / 2))
								{
									this.direction = -1;
								}
								else
								{
									this.direction = 1;
								}
							}
						}
						if (this.ai[3] > 0f)
						{
							this.life = -1;
							this.HitEffect(0, 10.0);
							this.active = false;
							if (this.type == 37)
							{
								Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
							}
						}
						if (this.type == 37 && Main.netMode != 1)
						{
							this.homeless = false;
							this.homeTileX = Main.dungeonX;
							this.homeTileY = Main.dungeonY;
							if (NPC.downedBoss3)
							{
								this.ai[3] = 1f;
								this.netUpdate = true;
							}
						}
						int num132 = this.homeTileY;
						if (Main.netMode != 1 && this.homeTileY > 0)
						{
							while (!WorldGen.SolidTile(this.homeTileX, num132) && num132 < Main.maxTilesY - 20)
							{
								num132++;
							}
						}
						if (Main.netMode != 1 && this.townNPC && (!Main.dayTime || Main.tileDungeon[(int)Main.tile[num129, num130].type]) && (num129 != this.homeTileX || num130 != num132) && !this.homeless)
						{
							bool flag16 = true;
							for (int num133 = 0; num133 < 2; num133++)
							{
								Rectangle rectangle3 = new Rectangle((int)(this.position.X + (float)(this.width / 2) - (float)(NPC.sWidth / 2) - (float)NPC.safeRangeX), (int)(this.position.Y + (float)(this.height / 2) - (float)(NPC.sHeight / 2) - (float)NPC.safeRangeY), NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
								if (num133 == 1)
								{
									rectangle3 = new Rectangle(this.homeTileX * 16 + 8 - NPC.sWidth / 2 - NPC.safeRangeX, num132 * 16 + 8 - NPC.sHeight / 2 - NPC.safeRangeY, NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
								}
								for (int num134 = 0; num134 < 255; num134++)
								{
									if (Main.player[num134].active)
									{
										Rectangle rectangle4 = new Rectangle((int)Main.player[num134].position.X, (int)Main.player[num134].position.Y, Main.player[num134].width, Main.player[num134].height);
										if (rectangle4.Intersects(rectangle3))
										{
											flag16 = false;
											break;
										}
									}
									if (!flag16)
									{
										break;
									}
								}
							}
							if (flag16)
							{
								if (this.type == 37 || !Collision.SolidTiles(this.homeTileX - 1, this.homeTileX + 1, num132 - 3, num132 - 1))
								{
									this.velocity.X = 0f;
									this.velocity.Y = 0f;
									this.position.X = (float)(this.homeTileX * 16 + 8 - this.width / 2);
									this.position.Y = (float)(num132 * 16 - this.height) - 0.1f;
									this.netUpdate = true;
								}
								else
								{
									this.homeless = true;
									WorldGen.QuickFindHome(this.whoAmI);
								}
							}
						}
						if (this.ai[0] == 0f)
						{
							if (this.ai[2] > 0f)
							{
								this.ai[2] -= 1f;
							}
							if (!Main.dayTime && !flag15 && this.type != 46)
							{
								if (Main.netMode != 1)
								{
									if (num129 == this.homeTileX && num130 == num132)
									{
										if (this.velocity.X != 0f)
										{
											this.netUpdate = true;
										}
										if ((double)this.velocity.X > 0.1)
										{
											this.velocity.X = this.velocity.X - 0.1f;
										}
										else
										{
											if ((double)this.velocity.X < -0.1)
											{
												this.velocity.X = this.velocity.X + 0.1f;
											}
											else
											{
												this.velocity.X = 0f;
											}
										}
									}
									else
									{
										if (!flag15)
										{
											if (num129 > this.homeTileX)
											{
												this.direction = -1;
											}
											else
											{
												this.direction = 1;
											}
											this.ai[0] = 1f;
											this.ai[1] = (float)(200 + Main.rand.Next(200));
											this.ai[2] = 0f;
											this.netUpdate = true;
										}
									}
								}
							}
							else
							{
								if ((double)this.velocity.X > 0.1)
								{
									this.velocity.X = this.velocity.X - 0.1f;
								}
								else
								{
									if ((double)this.velocity.X < -0.1)
									{
										this.velocity.X = this.velocity.X + 0.1f;
									}
									else
									{
										this.velocity.X = 0f;
									}
								}
								if (Main.netMode != 1)
								{
									if (this.ai[1] > 0f)
									{
										this.ai[1] -= 1f;
									}
									if (this.ai[1] <= 0f)
									{
										this.ai[0] = 1f;
										this.ai[1] = (float)(200 + Main.rand.Next(200));
										if (this.type == 46)
										{
											this.ai[1] += (float)Main.rand.Next(200, 400);
										}
										this.ai[2] = 0f;
										this.netUpdate = true;
									}
								}
							}
							if (Main.netMode != 1 && (Main.dayTime || (num129 == this.homeTileX && num130 == num132)))
							{
								if (num129 < this.homeTileX - 25 || num129 > this.homeTileX + 25)
								{
									if (this.ai[2] == 0f)
									{
										if (num129 < this.homeTileX - 50 && this.direction == -1)
										{
											this.direction = 1;
											this.netUpdate = true;
											return;
										}
										if (num129 > this.homeTileX + 50 && this.direction == 1)
										{
											this.direction = -1;
											this.netUpdate = true;
											return;
										}
									}
								}
								else
								{
									if (Main.rand.Next(80) == 0 && this.ai[2] == 0f)
									{
										this.ai[2] = 200f;
										this.direction *= -1;
										this.netUpdate = true;
										return;
									}
								}
							}
						}
						else
						{
							if (this.ai[0] == 1f)
							{
								if (Main.netMode != 1 && !Main.dayTime && num129 == this.homeTileX && num130 == this.homeTileY && this.type != 46)
								{
									this.ai[0] = 0f;
									this.ai[1] = (float)(200 + Main.rand.Next(200));
									this.ai[2] = 60f;
									this.netUpdate = true;
									return;
								}
								if (Main.netMode != 1 && !this.homeless && !Main.tileDungeon[(int)Main.tile[num129, num130].type] && (num129 < this.homeTileX - 35 || num129 > this.homeTileX + 35))
								{
									if (this.position.X < (float)(this.homeTileX * 16) && this.direction == -1)
									{
										this.ai[1] -= 5f;
									}
									else
									{
										if (this.position.X > (float)(this.homeTileX * 16) && this.direction == 1)
										{
											this.ai[1] -= 5f;
										}
									}
								}
								this.ai[1] -= 1f;
								if (this.ai[1] <= 0f)
								{
									this.ai[0] = 0f;
									this.ai[1] = (float)(300 + Main.rand.Next(300));
									if (this.type == 46)
									{
										this.ai[1] -= (float)Main.rand.Next(100);
									}
									this.ai[2] = 60f;
									this.netUpdate = true;
								}
								if (this.closeDoor && ((this.position.X + (float)(this.width / 2)) / 16f > (float)(this.doorX + 2) || (this.position.X + (float)(this.width / 2)) / 16f < (float)(this.doorX - 2)))
								{
									bool flag17 = WorldGen.CloseDoor(this.doorX, this.doorY, false);
									if (flag17)
									{
										this.closeDoor = false;
										NetMessage.SendData(19, -1, -1, "", 1, (float)this.doorX, (float)this.doorY, (float)this.direction, 0);
									}
									if ((this.position.X + (float)(this.width / 2)) / 16f > (float)(this.doorX + 4) || (this.position.X + (float)(this.width / 2)) / 16f < (float)(this.doorX - 4) || (this.position.Y + (float)(this.height / 2)) / 16f > (float)(this.doorY + 4) || (this.position.Y + (float)(this.height / 2)) / 16f < (float)(this.doorY - 4))
									{
										this.closeDoor = false;
									}
								}
								if (this.velocity.X < -1f || this.velocity.X > 1f)
								{
									if (this.velocity.Y == 0f)
									{
										this.velocity *= 0.8f;
									}
								}
								else
								{
									if ((double)this.velocity.X < 1.15 && this.direction == 1)
									{
										this.velocity.X = this.velocity.X + 0.07f;
										if (this.velocity.X > 1f)
										{
											this.velocity.X = 1f;
										}
									}
									else
									{
										if (this.velocity.X > -1f && this.direction == -1)
										{
											this.velocity.X = this.velocity.X - 0.07f;
											if (this.velocity.X > 1f)
											{
												this.velocity.X = 1f;
											}
										}
									}
								}
								if (this.velocity.Y == 0f)
								{
									if (this.position.X == this.ai[2])
									{
										this.direction *= -1;
									}
									this.ai[2] = -1f;
									int num135 = (int)((this.position.X + (float)(this.width / 2) + (float)(15 * this.direction)) / 16f);
									int num136 = (int)((this.position.Y + (float)this.height - 16f) / 16f);
									if (this.townNPC && Main.tile[num135, num136 - 2].active && Main.tile[num135, num136 - 2].type == 10 && (Main.rand.Next(10) == 0 || !Main.dayTime))
									{
										if (Main.netMode != 1)
										{
											bool flag18 = WorldGen.OpenDoor(num135, num136 - 2, this.direction);
											if (flag18)
											{
												this.closeDoor = true;
												this.doorX = num135;
												this.doorY = num136 - 2;
												NetMessage.SendData(19, -1, -1, "", 0, (float)num135, (float)(num136 - 2), (float)this.direction, 0);
												this.netUpdate = true;
												this.ai[1] += 80f;
												return;
											}
											if (WorldGen.OpenDoor(num135, num136 - 2, -this.direction))
											{
												this.closeDoor = true;
												this.doorX = num135;
												this.doorY = num136 - 2;
												NetMessage.SendData(19, -1, -1, "", 0, (float)num135, (float)(num136 - 2), (float)(-(float)this.direction), 0);
												this.netUpdate = true;
												this.ai[1] += 80f;
												return;
											}
											this.direction *= -1;
											this.netUpdate = true;
											return;
										}
									}
									else
									{
										if ((this.velocity.X < 0f && this.spriteDirection == -1) || (this.velocity.X > 0f && this.spriteDirection == 1))
										{
											if (Main.tile[num135, num136 - 2].active && Main.tileSolid[(int)Main.tile[num135, num136 - 2].type] && !Main.tileSolidTop[(int)Main.tile[num135, num136 - 2].type])
											{
												if ((this.direction == 1 && !Collision.SolidTiles(num135 - 2, num135 - 1, num136 - 5, num136 - 1)) || (this.direction == -1 && !Collision.SolidTiles(num135 + 1, num135 + 2, num136 - 5, num136 - 1)))
												{
													if (!Collision.SolidTiles(num135, num135, num136 - 5, num136 - 3))
													{
														this.velocity.Y = -6f;
														this.netUpdate = true;
													}
													else
													{
														this.direction *= -1;
														this.netUpdate = true;
													}
												}
												else
												{
													this.direction *= -1;
													this.netUpdate = true;
												}
											}
											else
											{
												if (Main.tile[num135, num136 - 1].active && Main.tileSolid[(int)Main.tile[num135, num136 - 1].type] && !Main.tileSolidTop[(int)Main.tile[num135, num136 - 1].type])
												{
													if ((this.direction == 1 && !Collision.SolidTiles(num135 - 2, num135 - 1, num136 - 4, num136 - 1)) || (this.direction == -1 && !Collision.SolidTiles(num135 + 1, num135 + 2, num136 - 4, num136 - 1)))
													{
														if (!Collision.SolidTiles(num135, num135, num136 - 4, num136 - 2))
														{
															this.velocity.Y = -5f;
															this.netUpdate = true;
														}
														else
														{
															this.direction *= -1;
															this.netUpdate = true;
														}
													}
													else
													{
														this.direction *= -1;
														this.netUpdate = true;
													}
												}
												else
												{
													if (Main.tile[num135, num136].active && Main.tileSolid[(int)Main.tile[num135, num136].type] && !Main.tileSolidTop[(int)Main.tile[num135, num136].type])
													{
														if ((this.direction == 1 && !Collision.SolidTiles(num135 - 2, num135, num136 - 3, num136 - 1)) || (this.direction == -1 && !Collision.SolidTiles(num135, num135 + 2, num136 - 3, num136 - 1)))
														{
															this.velocity.Y = -3.6f;
															this.netUpdate = true;
														}
														else
														{
															this.direction *= -1;
															this.netUpdate = true;
														}
													}
												}
											}
											try
											{
												if (num129 >= this.homeTileX - 35 && num129 <= this.homeTileX + 35 && (!Main.tile[num135, num136 + 1].active || !Main.tileSolid[(int)Main.tile[num135, num136 + 1].type]) && (!Main.tile[num135 - this.direction, num136 + 1].active || !Main.tileSolid[(int)Main.tile[num135 - this.direction, num136 + 1].type]) && (!Main.tile[num135, num136 + 2].active || !Main.tileSolid[(int)Main.tile[num135, num136 + 2].type]) && (!Main.tile[num135 - this.direction, num136 + 2].active || !Main.tileSolid[(int)Main.tile[num135 - this.direction, num136 + 2].type]) && (!Main.tile[num135, num136 + 3].active || !Main.tileSolid[(int)Main.tile[num135, num136 + 3].type]) && (!Main.tile[num135 - this.direction, num136 + 3].active || !Main.tileSolid[(int)Main.tile[num135 - this.direction, num136 + 3].type]) && (!Main.tile[num135, num136 + 4].active || !Main.tileSolid[(int)Main.tile[num135, num136 + 4].type]) && (!Main.tile[num135 - this.direction, num136 + 4].active || !Main.tileSolid[(int)Main.tile[num135 - this.direction, num136 + 4].type]) && this.type != 46)
												{
													this.direction *= -1;
													this.velocity.X = this.velocity.X * -1f;
													this.netUpdate = true;
												}
											}
											catch
											{
											}
											if (this.velocity.Y < 0f)
											{
												this.ai[2] = this.position.X;
											}
										}
										if (this.velocity.Y < 0f && this.wet)
										{
											this.velocity.Y = this.velocity.Y * 1.2f;
										}
										if (this.velocity.Y < 0f && this.type == 46)
										{
											this.velocity.Y = this.velocity.Y * 1.2f;
											return;
										}
									}
								}
							}
						}
					}
					break;
				case 8:
					this.TargetClosest(true);
					this.velocity.X = this.velocity.X * 0.93f;
					if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
					{
						this.velocity.X = 0f;
					}
					if (this.ai[0] == 0f)
					{
						this.ai[0] = 500f;
					}
					if (this.ai[2] != 0f && this.ai[3] != 0f)
					{
						Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 8);
						for (int num137 = 0; num137 < 50; num137++)
						{
							switch (this.type)
							{
								case 45:
								case 29:
									{
										Vector2 arg_9826_0 = new Vector2(this.position.X, this.position.Y);
										int arg_9826_1 = this.width;
										int arg_9826_2 = this.height;
										int arg_9826_3 = 27;
										float arg_9826_4 = 0f;
										float arg_9826_5 = 0f;
										int arg_9826_6 = 100;
										Color newColor = default(Color);
										int num138 = Dust.NewDust(arg_9826_0, arg_9826_1, arg_9826_2, arg_9826_3, arg_9826_4, arg_9826_5, arg_9826_6, newColor, (float)Main.rand.Next(1, 3));
										Dust expr_9835 = Main.dust[num138];
										expr_9835.velocity *= 3f;
										if (Main.dust[num138].scale > 1f)
										{
											Main.dust[num138].noGravity = true;
										}
									}
									break;
								case 32:
									{
										Vector2 arg_98C6_0 = new Vector2(this.position.X, this.position.Y);
										int arg_98C6_1 = this.width;
										int arg_98C6_2 = this.height;
										int arg_98C6_3 = 29;
										float arg_98C6_4 = 0f;
										float arg_98C6_5 = 0f;
										int arg_98C6_6 = 100;
										Color newColor = default(Color);
										int num139 = Dust.NewDust(arg_98C6_0, arg_98C6_1, arg_98C6_2, arg_98C6_3, arg_98C6_4, arg_98C6_5, arg_98C6_6, newColor, 2.5f);
										Dust expr_98D5 = Main.dust[num139];
										expr_98D5.velocity *= 3f;
										Main.dust[num139].noGravity = true;
									}
									break;
								default:
									{
										Vector2 arg_9941_0 = new Vector2(this.position.X, this.position.Y);
										int arg_9941_1 = this.width;
										int arg_9941_2 = this.height;
										int arg_9941_3 = 6;
										float arg_9941_4 = 0f;
										float arg_9941_5 = 0f;
										int arg_9941_6 = 100;
										Color newColor = default(Color);
										int num140 = Dust.NewDust(arg_9941_0, arg_9941_1, arg_9941_2, arg_9941_3, arg_9941_4, arg_9941_5, arg_9941_6, newColor, 2.5f);
										Dust expr_9950 = Main.dust[num140];
										expr_9950.velocity *= 3f;
										Main.dust[num140].noGravity = true;
									}
									break;
							}
						}
						this.position.X = this.ai[2] * 16f - (float)(this.width / 2) + 8f;
						this.position.Y = this.ai[3] * 16f - (float)this.height;
						this.velocity.X = 0f;
						this.velocity.Y = 0f;
						this.ai[2] = 0f;
						this.ai[3] = 0f;
						Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 8);
						for (int num141 = 0; num141 < 50; num141++)
						{
							switch (this.type)
							{
								case 45:
								case 29:
									{
										Vector2 arg_9A94_0 = new Vector2(this.position.X, this.position.Y);
										int arg_9A94_1 = this.width;
										int arg_9A94_2 = this.height;
										int arg_9A94_3 = 27;
										float arg_9A94_4 = 0f;
										float arg_9A94_5 = 0f;
										int arg_9A94_6 = 100;
										Color newColor = default(Color);
										int num142 = Dust.NewDust(arg_9A94_0, arg_9A94_1, arg_9A94_2, arg_9A94_3, arg_9A94_4, arg_9A94_5, arg_9A94_6, newColor, (float)Main.rand.Next(1, 3));
										Dust expr_9AA3 = Main.dust[num142];
										expr_9AA3.velocity *= 3f;
										if (Main.dust[num142].scale > 1f)
										{
											Main.dust[num142].noGravity = true;
										}
									}
									break;
								case 32:
									{
										Vector2 arg_9B34_0 = new Vector2(this.position.X, this.position.Y);
										int arg_9B34_1 = this.width;
										int arg_9B34_2 = this.height;
										int arg_9B34_3 = 29;
										float arg_9B34_4 = 0f;
										float arg_9B34_5 = 0f;
										int arg_9B34_6 = 100;
										Color newColor = default(Color);
										int num143 = Dust.NewDust(arg_9B34_0, arg_9B34_1, arg_9B34_2, arg_9B34_3, arg_9B34_4, arg_9B34_5, arg_9B34_6, newColor, 2.5f);
										Dust expr_9B43 = Main.dust[num143];
										expr_9B43.velocity *= 3f;
										Main.dust[num143].noGravity = true;
									}
									break;
								default:
									{
										Vector2 arg_9BAF_0 = new Vector2(this.position.X, this.position.Y);
										int arg_9BAF_1 = this.width;
										int arg_9BAF_2 = this.height;
										int arg_9BAF_3 = 6;
										float arg_9BAF_4 = 0f;
										float arg_9BAF_5 = 0f;
										int arg_9BAF_6 = 100;
										Color newColor = default(Color);
										int num144 = Dust.NewDust(arg_9BAF_0, arg_9BAF_1, arg_9BAF_2, arg_9BAF_3, arg_9BAF_4, arg_9BAF_5, arg_9BAF_6, newColor, 2.5f);
										Dust expr_9BBE = Main.dust[num144];
										expr_9BBE.velocity *= 3f;
										Main.dust[num144].noGravity = true;
									}
									break;
							}
						}
					}
					this.ai[0] += 1f;
					if (this.ai[0] == 100f || this.ai[0] == 200f || this.ai[0] == 300f)
					{
						this.ai[1] = 30f;
						this.netUpdate = true;
					}
					else
					{
						if (this.ai[0] >= 650f && Main.netMode != 1)
						{
							this.ai[0] = 1f;
							int num145 = (int)Main.player[this.target].position.X / 16;
							int num146 = (int)Main.player[this.target].position.Y / 16;
							int num147 = (int)this.position.X / 16;
							int num148 = (int)this.position.Y / 16;
							int num149 = 20;
							int num150 = 0;
							bool flag19 = false;
							if (Math.Abs(this.position.X - Main.player[this.target].position.X) + Math.Abs(this.position.Y - Main.player[this.target].position.Y) > 2000f)
							{
								num150 = 100;
								flag19 = true;
							}
							while (!flag19 && num150 < 100)
							{
								num150++;
								int num151 = Main.rand.Next(num145 - num149, num145 + num149);
								int num152 = Main.rand.Next(num146 - num149, num146 + num149);
								for (int num153 = num152; num153 < num146 + num149; num153++)
								{
									if ((num153 < num146 - 4 || num153 > num146 + 4 || num151 < num145 - 4 || num151 > num145 + 4) && (num153 < num148 - 1 || num153 > num148 + 1 || num151 < num147 - 1 || num151 > num147 + 1) && Main.tile[num151, num153].active)
									{
										bool flag20 = true;
										if (this.type == 32 && Main.tile[num151, num153 - 1].wall == 0)
										{
											flag20 = false;
										}
										else
										{
											if (Main.tile[num151, num153 - 1].lava)
											{
												flag20 = false;
											}
										}
										if (flag20 && Main.tileSolid[(int)Main.tile[num151, num153].type] && !Collision.SolidTiles(num151 - 1, num151 + 1, num153 - 4, num153 - 1))
										{
											this.ai[1] = 20f;
											this.ai[2] = (float)num151;
											this.ai[3] = (float)num153;
											flag19 = true;
											break;
										}
									}
								}
							}
							this.netUpdate = true;
						}
					}
					if (this.ai[1] > 0f)
					{
						this.ai[1] -= 1f;
						if (this.ai[1] == 25f)
						{
							Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 8);
							if (Main.netMode != 1)
							{
								switch (this.type)
								{
									case 45:
									case 29:
										NPC.NewNPC((int)this.position.X + this.width / 2, (int)this.position.Y - 8, 30, 0);
										break;
									case 32:
										NPC.NewNPC((int)this.position.X + this.width / 2, (int)this.position.Y - 8, 33, 0);
										break;
									default:
										NPC.NewNPC((int)this.position.X + this.width / 2 + this.direction * 8, (int)this.position.Y + 20, 25, 0);
										break;
								}
							}
						}
					}
					switch (this.type)
					{
						case 45:
						case 29:
							if (Main.rand.Next(5) == 0)
							{
								Vector2 arg_A04E_0 = new Vector2(this.position.X, this.position.Y + 2f);
								int arg_A04E_1 = this.width;
								int arg_A04E_2 = this.height;
								int arg_A04E_3 = 27;
								float arg_A04E_4 = this.velocity.X * 0.2f;
								float arg_A04E_5 = this.velocity.Y * 0.2f;
								int arg_A04E_6 = 100;
								Color newColor = default(Color);
								int num154 = Dust.NewDust(arg_A04E_0, arg_A04E_1, arg_A04E_2, arg_A04E_3, arg_A04E_4, arg_A04E_5, arg_A04E_6, newColor, 1.5f);
								Main.dust[num154].noGravity = true;
								Dust expr_A070_cp_0 = Main.dust[num154];
								expr_A070_cp_0.velocity.X = expr_A070_cp_0.velocity.X * 0.5f;
								Main.dust[num154].velocity.Y = -2f;
								return;
							}
							break;
						case 32:
							if (Main.rand.Next(2) == 0)
							{
								Vector2 arg_A11C_0 = new Vector2(this.position.X, this.position.Y + 2f);
								int arg_A11C_1 = this.width;
								int arg_A11C_2 = this.height;
								int arg_A11C_3 = 29;
								float arg_A11C_4 = this.velocity.X * 0.2f;
								float arg_A11C_5 = this.velocity.Y * 0.2f;
								int arg_A11C_6 = 100;
								Color newColor = default(Color);
								int num155 = Dust.NewDust(arg_A11C_0, arg_A11C_1, arg_A11C_2, arg_A11C_3, arg_A11C_4, arg_A11C_5, arg_A11C_6, newColor, 2f);
								Main.dust[num155].noGravity = true;
								Dust expr_A13E_cp_0 = Main.dust[num155];
								expr_A13E_cp_0.velocity.X = expr_A13E_cp_0.velocity.X * 1f;
								Dust expr_A15C_cp_0 = Main.dust[num155];
								expr_A15C_cp_0.velocity.Y = expr_A15C_cp_0.velocity.Y * 1f;
								return;
							}
							break;
						default:
							if (Main.rand.Next(2) == 0)
							{
								Vector2 arg_A1E3_0 = new Vector2(this.position.X, this.position.Y + 2f);
								int arg_A1E3_1 = this.width;
								int arg_A1E3_2 = this.height;
								int arg_A1E3_3 = 6;
								float arg_A1E3_4 = this.velocity.X * 0.2f;
								float arg_A1E3_5 = this.velocity.Y * 0.2f;
								int arg_A1E3_6 = 100;
								Color newColor = default(Color);
								int num156 = Dust.NewDust(arg_A1E3_0, arg_A1E3_1, arg_A1E3_2, arg_A1E3_3, arg_A1E3_4, arg_A1E3_5, arg_A1E3_6, newColor, 2f);
								Main.dust[num156].noGravity = true;
								Dust expr_A205_cp_0 = Main.dust[num156];
								expr_A205_cp_0.velocity.X = expr_A205_cp_0.velocity.X * 1f;
								Dust expr_A223_cp_0 = Main.dust[num156];
								expr_A223_cp_0.velocity.Y = expr_A223_cp_0.velocity.Y * 1f;
								return;
							}
							break;
					}
					break;
				default:
					if (this.aiStyle == 9)
					{
						if (this.target == 255)
						{
							this.TargetClosest(true);
							float num157 = 6f;
							if (this.type == 25)
							{
								num157 = 5f;
							}
							if (this.type == 112)
							{
								num157 = 7f;
							}
							Vector2 vector15 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
							float num158 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector15.X;
							float num159 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector15.Y;
							float num160 = (float)Math.Sqrt((double)(num158 * num158 + num159 * num159));
							num160 = num157 / num160;
							this.velocity.X = num158 * num160;
							this.velocity.Y = num159 * num160;
						}
						if (this.type == 112)
						{
							this.ai[0] += 1f;
							if (this.ai[0] > 3f)
							{
								this.ai[0] = 3f;
							}
							if (this.ai[0] == 2f)
							{
								this.position += this.velocity;
								Main.PlaySound(4, (int)this.position.X, (int)this.position.Y, 9);
								for (int num161 = 0; num161 < 20; num161++)
								{
									Vector2 arg_A445_0 = new Vector2(this.position.X, this.position.Y + 2f);
									int arg_A445_1 = this.width;
									int arg_A445_2 = this.height;
									int arg_A445_3 = 18;
									float arg_A445_4 = 0f;
									float arg_A445_5 = 0f;
									int arg_A445_6 = 100;
									Color newColor = default(Color);
									int num162 = Dust.NewDust(arg_A445_0, arg_A445_1, arg_A445_2, arg_A445_3, arg_A445_4, arg_A445_5, arg_A445_6, newColor, 1.8f);
									Dust expr_A454 = Main.dust[num162];
									expr_A454.velocity *= 1.3f;
									Dust expr_A471 = Main.dust[num162];
									expr_A471.velocity += this.velocity;
									Main.dust[num162].noGravity = true;
								}
							}
						}
						if (this.type == 112 && Collision.SolidCollision(this.position, this.width, this.height))
						{
							if (Main.netMode != 1)
							{
								int num163 = (int)(this.position.X + (float)(this.width / 2)) / 16;
								int num164 = (int)(this.position.Y + (float)(this.height / 2)) / 16;
								int num165 = 8;
								for (int num166 = num163 - num165; num166 <= num163 + num165; num166++)
								{
									for (int num167 = num164 - num165; num167 < num164 + num165; num167++)
									{
										if ((double)(Math.Abs(num166 - num163) + Math.Abs(num167 - num164)) < (double)num165 * 0.5)
										{
											switch (Main.tile[num166, num167].type)
											{
												case 2:
													Main.tile[num166, num167].type = 23;
													WorldGen.SquareTileFrame(num166, num167, true);
													if (Main.netMode == 2)
													{
														NetMessage.SendTileSquare(-1, num166, num167, 1);
													}
													break;
												case 1:
													Main.tile[num166, num167].type = 25;
													WorldGen.SquareTileFrame(num166, num167, true);
													if (Main.netMode == 2)
													{
														NetMessage.SendTileSquare(-1, num166, num167, 1);
													}
													break;
												case 53:
													Main.tile[num166, num167].type = 112;
													WorldGen.SquareTileFrame(num166, num167, true);
													if (Main.netMode == 2)
													{
														NetMessage.SendTileSquare(-1, num166, num167, 1);
													}
													break;
												case 109:
													Main.tile[num166, num167].type = 23;
													WorldGen.SquareTileFrame(num166, num167, true);
													if (Main.netMode == 2)
													{
														NetMessage.SendTileSquare(-1, num166, num167, 1);
													}
													break;
												case 117:
													Main.tile[num166, num167].type = 25;
													WorldGen.SquareTileFrame(num166, num167, true);
													if (Main.netMode == 2)
													{
														NetMessage.SendTileSquare(-1, num166, num167, 1);
													}
													break;
												case 116:
													Main.tile[num166, num167].type = 112;
													WorldGen.SquareTileFrame(num166, num167, true);
													if (Main.netMode == 2)
													{
														NetMessage.SendTileSquare(-1, num166, num167, 1);
													}
													break;
											}
										}
									}
								}
							}
							this.StrikeNPC(999, 0f, 0, false, false);
						}
						if (this.timeLeft > 100)
						{
							this.timeLeft = 100;
						}
						for (int num168 = 0; num168 < 2; num168++)
						{
							switch (this.type)
							{
								case 30:
									{
										Vector2 arg_A7EC_0 = new Vector2(this.position.X, this.position.Y + 2f);
										int arg_A7EC_1 = this.width;
										int arg_A7EC_2 = this.height;
										int arg_A7EC_3 = 27;
										float arg_A7EC_4 = this.velocity.X * 0.2f;
										float arg_A7EC_5 = this.velocity.Y * 0.2f;
										int arg_A7EC_6 = 100;
										Color newColor = default(Color);
										int num169 = Dust.NewDust(arg_A7EC_0, arg_A7EC_1, arg_A7EC_2, arg_A7EC_3, arg_A7EC_4, arg_A7EC_5, arg_A7EC_6, newColor, 2f);
										Main.dust[num169].noGravity = true;
										Dust expr_A809 = Main.dust[num169];
										expr_A809.velocity *= 0.3f;
										Dust expr_A82B_cp_0 = Main.dust[num169];
										expr_A82B_cp_0.velocity.X = expr_A82B_cp_0.velocity.X - this.velocity.X * 0.2f;
										Dust expr_A855_cp_0 = Main.dust[num169];
										expr_A855_cp_0.velocity.Y = expr_A855_cp_0.velocity.Y - this.velocity.Y * 0.2f;
									}
									break;
								case 33:
									{
										Vector2 arg_A8EA_0 = new Vector2(this.position.X, this.position.Y + 2f);
										int arg_A8EA_1 = this.width;
										int arg_A8EA_2 = this.height;
										int arg_A8EA_3 = 29;
										float arg_A8EA_4 = this.velocity.X * 0.2f;
										float arg_A8EA_5 = this.velocity.Y * 0.2f;
										int arg_A8EA_6 = 100;
										Color newColor = default(Color);
										int num170 = Dust.NewDust(arg_A8EA_0, arg_A8EA_1, arg_A8EA_2, arg_A8EA_3, arg_A8EA_4, arg_A8EA_5, arg_A8EA_6, newColor, 2f);
										Main.dust[num170].noGravity = true;
										Dust expr_A90C_cp_0 = Main.dust[num170];
										expr_A90C_cp_0.velocity.X = expr_A90C_cp_0.velocity.X * 0.3f;
										Dust expr_A92A_cp_0 = Main.dust[num170];
										expr_A92A_cp_0.velocity.Y = expr_A92A_cp_0.velocity.Y * 0.3f;
									}
									break;
								case 112:
									{
										Vector2 arg_A9B3_0 = new Vector2(this.position.X, this.position.Y + 2f);
										int arg_A9B3_1 = this.width;
										int arg_A9B3_2 = this.height;
										int arg_A9B3_3 = 18;
										float arg_A9B3_4 = this.velocity.X * 0.1f;
										float arg_A9B3_5 = this.velocity.Y * 0.1f;
										int arg_A9B3_6 = 80;
										Color newColor = default(Color);
										int num171 = Dust.NewDust(arg_A9B3_0, arg_A9B3_1, arg_A9B3_2, arg_A9B3_3, arg_A9B3_4, arg_A9B3_5, arg_A9B3_6, newColor, 1.3f);
										Dust expr_A9C2 = Main.dust[num171];
										expr_A9C2.velocity *= 0.3f;
										Main.dust[num171].noGravity = true;
									}
									break;
								default:
									{
										Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 1f, 0.3f, 0.1f);
										Vector2 arg_AA9B_0 = new Vector2(this.position.X, this.position.Y + 2f);
										int arg_AA9B_1 = this.width;
										int arg_AA9B_2 = this.height;
										int arg_AA9B_3 = 6;
										float arg_AA9B_4 = this.velocity.X * 0.2f;
										float arg_AA9B_5 = this.velocity.Y * 0.2f;
										int arg_AA9B_6 = 100;
										Color newColor = default(Color);
										int num172 = Dust.NewDust(arg_AA9B_0, arg_AA9B_1, arg_AA9B_2, arg_AA9B_3, arg_AA9B_4, arg_AA9B_5, arg_AA9B_6, newColor, 2f);
										Main.dust[num172].noGravity = true;
										Dust expr_AABD_cp_0 = Main.dust[num172];
										expr_AABD_cp_0.velocity.X = expr_AABD_cp_0.velocity.X * 0.3f;
										Dust expr_AADB_cp_0 = Main.dust[num172];
										expr_AADB_cp_0.velocity.Y = expr_AADB_cp_0.velocity.Y * 0.3f;
									}
									break;
							}
						}
						this.rotation += 0.4f * (float)this.direction;
						return;
					}
					switch (this.aiStyle)
					{
						case 10:
							{
								float num173 = 1f;
								float num174 = 0.011f;
								this.TargetClosest(true);
								Vector2 vector16 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
								float num175 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector16.X;
								float num176 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector16.Y;
								float num177 = (float)Math.Sqrt((double)(num175 * num175 + num176 * num176));
								float num178 = num177;
								this.ai[1] += 1f;
								if (this.ai[1] > 600f)
								{
									num174 *= 8f;
									num173 = 4f;
									if (this.ai[1] > 650f)
									{
										this.ai[1] = 0f;
									}
								}
								else
								{
									if (num178 < 250f)
									{
										this.ai[0] += 0.9f;
										if (this.ai[0] > 0f)
										{
											this.velocity.Y = this.velocity.Y + 0.019f;
										}
										else
										{
											this.velocity.Y = this.velocity.Y - 0.019f;
										}
										if (this.ai[0] < -100f || this.ai[0] > 100f)
										{
											this.velocity.X = this.velocity.X + 0.019f;
										}
										else
										{
											this.velocity.X = this.velocity.X - 0.019f;
										}
										if (this.ai[0] > 200f)
										{
											this.ai[0] = -200f;
										}
									}
								}
								if (num178 > 350f)
								{
									num173 = 5f;
									num174 = 0.3f;
								}
								else
								{
									if (num178 > 300f)
									{
										num173 = 3f;
										num174 = 0.2f;
									}
									else
									{
										if (num178 > 250f)
										{
											num173 = 1.5f;
											num174 = 0.1f;
										}
									}
								}
								num177 = num173 / num177;
								num175 *= num177;
								num176 *= num177;
								if (Main.player[this.target].dead)
								{
									num175 = (float)this.direction * num173 / 2f;
									num176 = -num173 / 2f;
								}
								if (this.velocity.X < num175)
								{
									this.velocity.X = this.velocity.X + num174;
								}
								else
								{
									if (this.velocity.X > num175)
									{
										this.velocity.X = this.velocity.X - num174;
									}
								}
								if (this.velocity.Y < num176)
								{
									this.velocity.Y = this.velocity.Y + num174;
								}
								else
								{
									if (this.velocity.Y > num176)
									{
										this.velocity.Y = this.velocity.Y - num174;
									}
								}
								if (num175 > 0f)
								{
									this.spriteDirection = -1;
									this.rotation = (float)Math.Atan2((double)num176, (double)num175);
								}
								if (num175 < 0f)
								{
									this.spriteDirection = 1;
									this.rotation = (float)Math.Atan2((double)num176, (double)num175) + 3.14f;
									return;
								}
							}
							break;
						case 11:
							if (this.ai[0] == 0f && Main.netMode != 1)
							{
								this.TargetClosest(true);
								this.ai[0] = 1f;
								if (this.type != 68)
								{
									int num179 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)this.position.Y + this.height / 2, 36, this.whoAmI);
									Main.npc[num179].ai[0] = -1f;
									Main.npc[num179].ai[1] = (float)this.whoAmI;
									Main.npc[num179].target = this.target;
									Main.npc[num179].netUpdate = true;
									num179 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)this.position.Y + this.height / 2, 36, this.whoAmI);
									Main.npc[num179].ai[0] = 1f;
									Main.npc[num179].ai[1] = (float)this.whoAmI;
									Main.npc[num179].ai[3] = 150f;
									Main.npc[num179].target = this.target;
									Main.npc[num179].netUpdate = true;
								}
							}
							if (this.type == 68 && this.ai[1] != 3f && this.ai[1] != 2f)
							{
								Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
								this.ai[1] = 2f;
							}
							if (Main.player[this.target].dead || Math.Abs(this.position.X - Main.player[this.target].position.X) > 2000f || Math.Abs(this.position.Y - Main.player[this.target].position.Y) > 2000f)
							{
								this.TargetClosest(true);
								if (Main.player[this.target].dead || Math.Abs(this.position.X - Main.player[this.target].position.X) > 2000f || Math.Abs(this.position.Y - Main.player[this.target].position.Y) > 2000f)
								{
									this.ai[1] = 3f;
								}
							}
							if (Main.dayTime && this.ai[1] != 3f && this.ai[1] != 2f)
							{
								this.ai[1] = 2f;
								Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
							}
							if (this.ai[1] == 0f)
							{
								this.defense = 10;
								this.ai[2] += 1f;
								if (this.ai[2] >= 800f)
								{
									this.ai[2] = 0f;
									this.ai[1] = 1f;
									this.TargetClosest(true);
									this.netUpdate = true;
								}
								this.rotation = this.velocity.X / 15f;
								if (this.position.Y > Main.player[this.target].position.Y - 250f)
								{
									if (this.velocity.Y > 0f)
									{
										this.velocity.Y = this.velocity.Y * 0.98f;
									}
									this.velocity.Y = this.velocity.Y - 0.02f;
									if (this.velocity.Y > 2f)
									{
										this.velocity.Y = 2f;
									}
								}
								else
								{
									if (this.position.Y < Main.player[this.target].position.Y - 250f)
									{
										if (this.velocity.Y < 0f)
										{
											this.velocity.Y = this.velocity.Y * 0.98f;
										}
										this.velocity.Y = this.velocity.Y + 0.02f;
										if (this.velocity.Y < -2f)
										{
											this.velocity.Y = -2f;
										}
									}
								}
								if (this.position.X + (float)(this.width / 2) > Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2))
								{
									if (this.velocity.X > 0f)
									{
										this.velocity.X = this.velocity.X * 0.98f;
									}
									this.velocity.X = this.velocity.X - 0.05f;
									if (this.velocity.X > 8f)
									{
										this.velocity.X = 8f;
									}
								}
								if (this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2))
								{
									if (this.velocity.X < 0f)
									{
										this.velocity.X = this.velocity.X * 0.98f;
									}
									this.velocity.X = this.velocity.X + 0.05f;
									if (this.velocity.X < -8f)
									{
										this.velocity.X = -8f;
									}
								}
							}
							else
							{
								if (this.ai[1] == 1f)
								{
									this.defense = 0;
									this.ai[2] += 1f;
									if (this.ai[2] == 2f)
									{
										Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
									}
									if (this.ai[2] >= 400f)
									{
										this.ai[2] = 0f;
										this.ai[1] = 0f;
									}
									this.rotation += (float)this.direction * 0.3f;
									Vector2 vector17 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
									float num180 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector17.X;
									float num181 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector17.Y;
									float num182 = (float)Math.Sqrt((double)(num180 * num180 + num181 * num181));
									num182 = 1.5f / num182;
									this.velocity.X = num180 * num182;
									this.velocity.Y = num181 * num182;
								}
								else
								{
									if (this.ai[1] == 2f)
									{
										this.damage = 9999;
										this.defense = 9999;
										this.rotation += (float)this.direction * 0.3f;
										Vector2 vector18 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
										float num183 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector18.X;
										float num184 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector18.Y;
										float num185 = (float)Math.Sqrt((double)(num183 * num183 + num184 * num184));
										num185 = 8f / num185;
										this.velocity.X = num183 * num185;
										this.velocity.Y = num184 * num185;
									}
									else
									{
										if (this.ai[1] == 3f)
										{
											this.velocity.Y = this.velocity.Y + 0.1f;
											if (this.velocity.Y < 0f)
											{
												this.velocity.Y = this.velocity.Y * 0.95f;
											}
											this.velocity.X = this.velocity.X * 0.95f;
											if (this.timeLeft > 500)
											{
												this.timeLeft = 500;
											}
										}
									}
								}
							}
							if (this.ai[1] != 2f && this.ai[1] != 3f && this.type != 68)
							{
								Vector2 arg_B869_0 = new Vector2(this.position.X + (float)(this.width / 2) - 15f - this.velocity.X * 5f, this.position.Y + (float)this.height - 2f);
								int arg_B869_1 = 30;
								int arg_B869_2 = 10;
								int arg_B869_3 = 5;
								float arg_B869_4 = -this.velocity.X * 0.2f;
								float arg_B869_5 = 3f;
								int arg_B869_6 = 0;
								Color newColor = default(Color);
								int num186 = Dust.NewDust(arg_B869_0, arg_B869_1, arg_B869_2, arg_B869_3, arg_B869_4, arg_B869_5, arg_B869_6, newColor, 2f);
								Main.dust[num186].noGravity = true;
								Dust expr_B88B_cp_0 = Main.dust[num186];
								expr_B88B_cp_0.velocity.X = expr_B88B_cp_0.velocity.X * 1.3f;
								Dust expr_B8A9_cp_0 = Main.dust[num186];
								expr_B8A9_cp_0.velocity.X = expr_B8A9_cp_0.velocity.X + this.velocity.X * 0.4f;
								Dust expr_B8D3_cp_0 = Main.dust[num186];
								expr_B8D3_cp_0.velocity.Y = expr_B8D3_cp_0.velocity.Y + (2f + this.velocity.Y);
								for (int num187 = 0; num187 < 2; num187++)
								{
									Vector2 arg_B94C_0 = new Vector2(this.position.X, this.position.Y + 120f);
									int arg_B94C_1 = this.width;
									int arg_B94C_2 = 60;
									int arg_B94C_3 = 5;
									float arg_B94C_4 = this.velocity.X;
									float arg_B94C_5 = this.velocity.Y;
									int arg_B94C_6 = 0;
									newColor = default(Color);
									num186 = Dust.NewDust(arg_B94C_0, arg_B94C_1, arg_B94C_2, arg_B94C_3, arg_B94C_4, arg_B94C_5, arg_B94C_6, newColor, 2f);
									Main.dust[num186].noGravity = true;
									Dust expr_B969 = Main.dust[num186];
									expr_B969.velocity -= this.velocity;
									Dust expr_B98C_cp_0 = Main.dust[num186];
									expr_B98C_cp_0.velocity.Y = expr_B98C_cp_0.velocity.Y + 5f;
								}
								return;
							}
							break;
						case 12:
							this.spriteDirection = -(int)this.ai[0];
							if (!Main.npc[(int)this.ai[1]].active || Main.npc[(int)this.ai[1]].aiStyle != 11)
							{
								this.ai[2] += 10f;
								if (this.ai[2] > 50f || Main.netMode != 2)
								{
									this.life = -1;
									this.HitEffect(0, 10.0);
									this.active = false;
								}
							}
							if (this.ai[2] == 0f || this.ai[2] == 3f)
							{
								if (Main.npc[(int)this.ai[1]].ai[1] == 3f && this.timeLeft > 10)
								{
									this.timeLeft = 10;
								}
								if (Main.npc[(int)this.ai[1]].ai[1] != 0f)
								{
									if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y - 100f)
									{
										if (this.velocity.Y > 0f)
										{
											this.velocity.Y = this.velocity.Y * 0.96f;
										}
										this.velocity.Y = this.velocity.Y - 0.07f;
										if (this.velocity.Y > 6f)
										{
											this.velocity.Y = 6f;
										}
									}
									else
									{
										if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 100f)
										{
											if (this.velocity.Y < 0f)
											{
												this.velocity.Y = this.velocity.Y * 0.96f;
											}
											this.velocity.Y = this.velocity.Y + 0.07f;
											if (this.velocity.Y < -6f)
											{
												this.velocity.Y = -6f;
											}
										}
									}
									if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 120f * this.ai[0])
									{
										if (this.velocity.X > 0f)
										{
											this.velocity.X = this.velocity.X * 0.96f;
										}
										this.velocity.X = this.velocity.X - 0.1f;
										if (this.velocity.X > 8f)
										{
											this.velocity.X = 8f;
										}
									}
									if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 120f * this.ai[0])
									{
										if (this.velocity.X < 0f)
										{
											this.velocity.X = this.velocity.X * 0.96f;
										}
										this.velocity.X = this.velocity.X + 0.1f;
										if (this.velocity.X < -8f)
										{
											this.velocity.X = -8f;
										}
									}
								}
								else
								{
									this.ai[3] += 1f;
									if (this.ai[3] >= 300f)
									{
										this.ai[2] += 1f;
										this.ai[3] = 0f;
										this.netUpdate = true;
									}
									if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y + 230f)
									{
										if (this.velocity.Y > 0f)
										{
											this.velocity.Y = this.velocity.Y * 0.96f;
										}
										this.velocity.Y = this.velocity.Y - 0.04f;
										if (this.velocity.Y > 3f)
										{
											this.velocity.Y = 3f;
										}
									}
									else
									{
										if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y + 230f)
										{
											if (this.velocity.Y < 0f)
											{
												this.velocity.Y = this.velocity.Y * 0.96f;
											}
											this.velocity.Y = this.velocity.Y + 0.04f;
											if (this.velocity.Y < -3f)
											{
												this.velocity.Y = -3f;
											}
										}
									}
									if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0])
									{
										if (this.velocity.X > 0f)
										{
											this.velocity.X = this.velocity.X * 0.96f;
										}
										this.velocity.X = this.velocity.X - 0.07f;
										if (this.velocity.X > 8f)
										{
											this.velocity.X = 8f;
										}
									}
									if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0])
									{
										if (this.velocity.X < 0f)
										{
											this.velocity.X = this.velocity.X * 0.96f;
										}
										this.velocity.X = this.velocity.X + 0.07f;
										if (this.velocity.X < -8f)
										{
											this.velocity.X = -8f;
										}
									}
								}
								Vector2 vector19 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
								float num188 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector19.X;
								float num189 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector19.Y;
								Math.Sqrt((double)(num188 * num188 + num189 * num189));
								this.rotation = (float)Math.Atan2((double)num189, (double)num188) + 1.57f;
								return;
							}
							if (this.ai[2] == 1f)
							{
								Vector2 vector20 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
								float num190 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector20.X;
								float num191 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector20.Y;
								float num192 = (float)Math.Sqrt((double)(num190 * num190 + num191 * num191));
								this.rotation = (float)Math.Atan2((double)num191, (double)num190) + 1.57f;
								this.velocity.X = this.velocity.X * 0.95f;
								this.velocity.Y = this.velocity.Y - 0.1f;
								if (this.velocity.Y < -8f)
								{
									this.velocity.Y = -8f;
								}
								if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 200f)
								{
									this.TargetClosest(true);
									this.ai[2] = 2f;
									vector20 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
									num190 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector20.X;
									num191 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector20.Y;
									num192 = (float)Math.Sqrt((double)(num190 * num190 + num191 * num191));
									num192 = 18f / num192;
									this.velocity.X = num190 * num192;
									this.velocity.Y = num191 * num192;
									this.netUpdate = true;
									return;
								}
							}
							else
							{
								if (this.ai[2] == 2f)
								{
									if (this.position.Y > Main.player[this.target].position.Y || this.velocity.Y < 0f)
									{
										this.ai[2] = 3f;
										return;
									}
								}
								else
								{
									if (this.ai[2] == 4f)
									{
										Vector2 vector21 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
										float num193 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector21.X;
										float num194 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector21.Y;
										float num195 = (float)Math.Sqrt((double)(num193 * num193 + num194 * num194));
										this.rotation = (float)Math.Atan2((double)num194, (double)num193) + 1.57f;
										this.velocity.Y = this.velocity.Y * 0.95f;
										this.velocity.X = this.velocity.X + 0.1f * -this.ai[0];
										if (this.velocity.X < -8f)
										{
											this.velocity.X = -8f;
										}
										if (this.velocity.X > 8f)
										{
											this.velocity.X = 8f;
										}
										if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 500f || this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) + 500f)
										{
											this.TargetClosest(true);
											this.ai[2] = 5f;
											vector21 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
											num193 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector21.X;
											num194 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector21.Y;
											num195 = (float)Math.Sqrt((double)(num193 * num193 + num194 * num194));
											num195 = 17f / num195;
											this.velocity.X = num193 * num195;
											this.velocity.Y = num194 * num195;
											this.netUpdate = true;
											return;
										}
									}
									else
									{
										if (this.ai[2] == 5f && ((this.velocity.X > 0f && this.position.X + (float)(this.width / 2) > Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2)) || (this.velocity.X < 0f && this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2))))
										{
											this.ai[2] = 0f;
											return;
										}
									}
								}
							}
							break;
						case 13:
							{
								if (!Main.tile[(int)this.ai[0], (int)this.ai[1]].active)
								{
									this.life = -1;
									this.HitEffect(0, 10.0);
									this.active = false;
									return;
								}
								this.TargetClosest(true);
								float num196 = 0.035f;
								float num197 = 150f;
								if (this.type == 43)
								{
									num197 = 250f;
								}
								if (this.type == 101)
								{
									num197 = 175f;
								}
								this.ai[2] += 1f;
								if (this.ai[2] > 300f)
								{
									num197 = (float)((int)((double)num197 * 1.3));
									if (this.ai[2] > 450f)
									{
										this.ai[2] = 0f;
									}
								}
								Vector2 vector22 = new Vector2(this.ai[0] * 16f + 8f, this.ai[1] * 16f + 8f);
								float num198 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - (float)(this.width / 2) - vector22.X;
								float num199 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - (float)(this.height / 2) - vector22.Y;
								float num200 = (float)Math.Sqrt((double)(num198 * num198 + num199 * num199));
								if (num200 > num197)
								{
									num200 = num197 / num200;
									num198 *= num200;
									num199 *= num200;
								}
								if (this.position.X < this.ai[0] * 16f + 8f + num198)
								{
									this.velocity.X = this.velocity.X + num196;
									if (this.velocity.X < 0f && num198 > 0f)
									{
										this.velocity.X = this.velocity.X + num196 * 1.5f;
									}
								}
								else
								{
									if (this.position.X > this.ai[0] * 16f + 8f + num198)
									{
										this.velocity.X = this.velocity.X - num196;
										if (this.velocity.X > 0f && num198 < 0f)
										{
											this.velocity.X = this.velocity.X - num196 * 1.5f;
										}
									}
								}
								if (this.position.Y < this.ai[1] * 16f + 8f + num199)
								{
									this.velocity.Y = this.velocity.Y + num196;
									if (this.velocity.Y < 0f && num199 > 0f)
									{
										this.velocity.Y = this.velocity.Y + num196 * 1.5f;
									}
								}
								else
								{
									if (this.position.Y > this.ai[1] * 16f + 8f + num199)
									{
										this.velocity.Y = this.velocity.Y - num196;
										if (this.velocity.Y > 0f && num199 < 0f)
										{
											this.velocity.Y = this.velocity.Y - num196 * 1.5f;
										}
									}
								}
								if (this.type == 43)
								{
									if (this.velocity.X > 3f)
									{
										this.velocity.X = 3f;
									}
									if (this.velocity.X < -3f)
									{
										this.velocity.X = -3f;
									}
									if (this.velocity.Y > 3f)
									{
										this.velocity.Y = 3f;
									}
									if (this.velocity.Y < -3f)
									{
										this.velocity.Y = -3f;
									}
								}
								else
								{
									if (this.velocity.X > 2f)
									{
										this.velocity.X = 2f;
									}
									if (this.velocity.X < -2f)
									{
										this.velocity.X = -2f;
									}
									if (this.velocity.Y > 2f)
									{
										this.velocity.Y = 2f;
									}
									if (this.velocity.Y < -2f)
									{
										this.velocity.Y = -2f;
									}
								}
								if (num198 > 0f)
								{
									this.spriteDirection = 1;
									this.rotation = (float)Math.Atan2((double)num199, (double)num198);
								}
								if (num198 < 0f)
								{
									this.spriteDirection = -1;
									this.rotation = (float)Math.Atan2((double)num199, (double)num198) + 3.14f;
								}
								if (this.collideX)
								{
									this.netUpdate = true;
									this.velocity.X = this.oldVelocity.X * -0.7f;
									if (this.velocity.X > 0f && this.velocity.X < 2f)
									{
										this.velocity.X = 2f;
									}
									if (this.velocity.X < 0f && this.velocity.X > -2f)
									{
										this.velocity.X = -2f;
									}
								}
								if (this.collideY)
								{
									this.netUpdate = true;
									this.velocity.Y = this.oldVelocity.Y * -0.7f;
									if (this.velocity.Y > 0f && this.velocity.Y < 2f)
									{
										this.velocity.Y = 2f;
									}
									if (this.velocity.Y < 0f && this.velocity.Y > -2f)
									{
										this.velocity.Y = -2f;
									}
								}
								if (Main.netMode != 1 && this.type == 101 && !Main.player[this.target].dead)
								{
									if (this.justHit)
									{
										this.localAI[0] = 0f;
									}
									this.localAI[0] += 1f;
									if (this.localAI[0] >= 120f)
									{
										if (!Collision.SolidCollision(this.position, this.width, this.height) && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
										{
											float num201 = 10f;
											vector22 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
											num198 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector22.X + (float)Main.rand.Next(-10, 11);
											num199 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector22.Y + (float)Main.rand.Next(-10, 11);
											num200 = (float)Math.Sqrt((double)(num198 * num198 + num199 * num199));
											num200 = num201 / num200;
											num198 *= num200;
											num199 *= num200;
											int num202 = 22;
											int num203 = 96;
											int num204 = Projectile.NewProjectile(vector22.X, vector22.Y, num198, num199, num203, num202, 0f, Main.myPlayer);
											Main.projectile[num204].timeLeft = 300;
											this.localAI[0] = 0f;
											return;
										}
										this.localAI[0] = 100f;
										return;
									}
								}
							}
							break;
						case 14:
							if (this.type == 60)
							{
								Vector2 arg_D0B7_0 = new Vector2(this.position.X, this.position.Y);
								int arg_D0B7_1 = this.width;
								int arg_D0B7_2 = this.height;
								int arg_D0B7_3 = 6;
								float arg_D0B7_4 = this.velocity.X * 0.2f;
								float arg_D0B7_5 = this.velocity.Y * 0.2f;
								int arg_D0B7_6 = 100;
								Color newColor = default(Color);
								int num205 = Dust.NewDust(arg_D0B7_0, arg_D0B7_1, arg_D0B7_2, arg_D0B7_3, arg_D0B7_4, arg_D0B7_5, arg_D0B7_6, newColor, 2f);
								Main.dust[num205].noGravity = true;
							}
							this.noGravity = true;
							if (this.collideX)
							{
								this.velocity.X = this.oldVelocity.X * -0.5f;
								if (this.direction == -1 && this.velocity.X > 0f && this.velocity.X < 2f)
								{
									this.velocity.X = 2f;
								}
								if (this.direction == 1 && this.velocity.X < 0f && this.velocity.X > -2f)
								{
									this.velocity.X = -2f;
								}
							}
							if (this.collideY)
							{
								this.velocity.Y = this.oldVelocity.Y * -0.5f;
								if (this.velocity.Y > 0f && this.velocity.Y < 1f)
								{
									this.velocity.Y = 1f;
								}
								if (this.velocity.Y < 0f && this.velocity.Y > -1f)
								{
									this.velocity.Y = -1f;
								}
							}
							this.TargetClosest(true);
							if (this.direction == -1 && this.velocity.X > -4f)
							{
								this.velocity.X = this.velocity.X - 0.1f;
								if (this.velocity.X > 4f)
								{
									this.velocity.X = this.velocity.X - 0.1f;
								}
								else
								{
									if (this.velocity.X > 0f)
									{
										this.velocity.X = this.velocity.X + 0.05f;
									}
								}
								if (this.velocity.X < -4f)
								{
									this.velocity.X = -4f;
								}
							}
							else
							{
								if (this.direction == 1 && this.velocity.X < 4f)
								{
									this.velocity.X = this.velocity.X + 0.1f;
									if (this.velocity.X < -4f)
									{
										this.velocity.X = this.velocity.X + 0.1f;
									}
									else
									{
										if (this.velocity.X < 0f)
										{
											this.velocity.X = this.velocity.X - 0.05f;
										}
									}
									if (this.velocity.X > 4f)
									{
										this.velocity.X = 4f;
									}
								}
							}
							if (this.directionY == -1 && (double)this.velocity.Y > -1.5)
							{
								this.velocity.Y = this.velocity.Y - 0.04f;
								if ((double)this.velocity.Y > 1.5)
								{
									this.velocity.Y = this.velocity.Y - 0.05f;
								}
								else
								{
									if (this.velocity.Y > 0f)
									{
										this.velocity.Y = this.velocity.Y + 0.03f;
									}
								}
								if ((double)this.velocity.Y < -1.5)
								{
									this.velocity.Y = -1.5f;
								}
							}
							else
							{
								if (this.directionY == 1 && (double)this.velocity.Y < 1.5)
								{
									this.velocity.Y = this.velocity.Y + 0.04f;
									if ((double)this.velocity.Y < -1.5)
									{
										this.velocity.Y = this.velocity.Y + 0.05f;
									}
									else
									{
										if (this.velocity.Y < 0f)
										{
											this.velocity.Y = this.velocity.Y - 0.03f;
										}
									}
									if ((double)this.velocity.Y > 1.5)
									{
										this.velocity.Y = 1.5f;
									}
								}
							}
							if (this.type == 49 || this.type == 51 || this.type == 60 || this.type == 62 || this.type == 66 || this.type == 93 || this.type == 137)
							{
								if (this.wet)
								{
									if (this.velocity.Y > 0f)
									{
										this.velocity.Y = this.velocity.Y * 0.95f;
									}
									this.velocity.Y = this.velocity.Y - 0.5f;
									if (this.velocity.Y < -4f)
									{
										this.velocity.Y = -4f;
									}
									this.TargetClosest(true);
								}
								if (this.type == 60)
								{
									if (this.direction == -1 && this.velocity.X > -4f)
									{
										this.velocity.X = this.velocity.X - 0.1f;
										if (this.velocity.X > 4f)
										{
											this.velocity.X = this.velocity.X - 0.07f;
										}
										else
										{
											if (this.velocity.X > 0f)
											{
												this.velocity.X = this.velocity.X + 0.03f;
											}
										}
										if (this.velocity.X < -4f)
										{
											this.velocity.X = -4f;
										}
									}
									else
									{
										if (this.direction == 1 && this.velocity.X < 4f)
										{
											this.velocity.X = this.velocity.X + 0.1f;
											if (this.velocity.X < -4f)
											{
												this.velocity.X = this.velocity.X + 0.07f;
											}
											else
											{
												if (this.velocity.X < 0f)
												{
													this.velocity.X = this.velocity.X - 0.03f;
												}
											}
											if (this.velocity.X > 4f)
											{
												this.velocity.X = 4f;
											}
										}
									}
									if (this.directionY == -1 && (double)this.velocity.Y > -1.5)
									{
										this.velocity.Y = this.velocity.Y - 0.04f;
										if ((double)this.velocity.Y > 1.5)
										{
											this.velocity.Y = this.velocity.Y - 0.03f;
										}
										else
										{
											if (this.velocity.Y > 0f)
											{
												this.velocity.Y = this.velocity.Y + 0.02f;
											}
										}
										if ((double)this.velocity.Y < -1.5)
										{
											this.velocity.Y = -1.5f;
										}
									}
									else
									{
										if (this.directionY == 1 && (double)this.velocity.Y < 1.5)
										{
											this.velocity.Y = this.velocity.Y + 0.04f;
											if ((double)this.velocity.Y < -1.5)
											{
												this.velocity.Y = this.velocity.Y + 0.03f;
											}
											else
											{
												if (this.velocity.Y < 0f)
												{
													this.velocity.Y = this.velocity.Y - 0.02f;
												}
											}
											if ((double)this.velocity.Y > 1.5)
											{
												this.velocity.Y = 1.5f;
											}
										}
									}
								}
								else
								{
									if (this.direction == -1 && this.velocity.X > -4f)
									{
										this.velocity.X = this.velocity.X - 0.1f;
										if (this.velocity.X > 4f)
										{
											this.velocity.X = this.velocity.X - 0.1f;
										}
										else
										{
											if (this.velocity.X > 0f)
											{
												this.velocity.X = this.velocity.X + 0.05f;
											}
										}
										if (this.velocity.X < -4f)
										{
											this.velocity.X = -4f;
										}
									}
									else
									{
										if (this.direction == 1 && this.velocity.X < 4f)
										{
											this.velocity.X = this.velocity.X + 0.1f;
											if (this.velocity.X < -4f)
											{
												this.velocity.X = this.velocity.X + 0.1f;
											}
											else
											{
												if (this.velocity.X < 0f)
												{
													this.velocity.X = this.velocity.X - 0.05f;
												}
											}
											if (this.velocity.X > 4f)
											{
												this.velocity.X = 4f;
											}
										}
									}
									if (this.directionY == -1 && (double)this.velocity.Y > -1.5)
									{
										this.velocity.Y = this.velocity.Y - 0.04f;
										if ((double)this.velocity.Y > 1.5)
										{
											this.velocity.Y = this.velocity.Y - 0.05f;
										}
										else
										{
											if (this.velocity.Y > 0f)
											{
												this.velocity.Y = this.velocity.Y + 0.03f;
											}
										}
										if ((double)this.velocity.Y < -1.5)
										{
											this.velocity.Y = -1.5f;
										}
									}
									else
									{
										if (this.directionY == 1 && (double)this.velocity.Y < 1.5)
										{
											this.velocity.Y = this.velocity.Y + 0.04f;
											if ((double)this.velocity.Y < -1.5)
											{
												this.velocity.Y = this.velocity.Y + 0.05f;
											}
											else
											{
												if (this.velocity.Y < 0f)
												{
													this.velocity.Y = this.velocity.Y - 0.03f;
												}
											}
											if ((double)this.velocity.Y > 1.5)
											{
												this.velocity.Y = 1.5f;
											}
										}
									}
								}
							}
							this.ai[1] += 1f;
							if (this.ai[1] > 200f)
							{
								if (!Main.player[this.target].wet && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
								{
									this.ai[1] = 0f;
								}
								float num206 = 0.2f;
								float num207 = 0.1f;
								float num208 = 4f;
								float num209 = 1.5f;
								if (this.type == 48 || this.type == 62 || this.type == 66)
								{
									num206 = 0.12f;
									num207 = 0.07f;
									num208 = 3f;
									num209 = 1.25f;
								}
								if (this.ai[1] > 1000f)
								{
									this.ai[1] = 0f;
								}
								this.ai[2] += 1f;
								if (this.ai[2] > 0f)
								{
									if (this.velocity.Y < num209)
									{
										this.velocity.Y = this.velocity.Y + num207;
									}
								}
								else
								{
									if (this.velocity.Y > -num209)
									{
										this.velocity.Y = this.velocity.Y - num207;
									}
								}
								if (this.ai[2] < -150f || this.ai[2] > 150f)
								{
									if (this.velocity.X < num208)
									{
										this.velocity.X = this.velocity.X + num206;
									}
								}
								else
								{
									if (this.velocity.X > -num208)
									{
										this.velocity.X = this.velocity.X - num206;
									}
								}
								if (this.ai[2] > 300f)
								{
									this.ai[2] = -300f;
								}
							}
							if (Main.netMode != 1)
							{
								if (this.type == 48)
								{
									this.ai[0] += 1f;
									if (this.ai[0] == 30f || this.ai[0] == 60f || this.ai[0] == 90f)
									{
										if (Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
										{
											float num210 = 6f;
											Vector2 vector23 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
											float num211 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector23.X + (float)Main.rand.Next(-100, 101);
											float num212 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector23.Y + (float)Main.rand.Next(-100, 101);
											float num213 = (float)Math.Sqrt((double)(num211 * num211 + num212 * num212));
											num213 = num210 / num213;
											num211 *= num213;
											num212 *= num213;
											int num214 = 15;
											int num215 = 38;
											int num216 = Projectile.NewProjectile(vector23.X, vector23.Y, num211, num212, num215, num214, 0f, Main.myPlayer);
											Main.projectile[num216].timeLeft = 300;
										}
									}
									else
									{
										if (this.ai[0] >= (float)(400 + Main.rand.Next(400)))
										{
											this.ai[0] = 0f;
										}
									}
								}
								if (this.type == 62 || this.type == 66)
								{
									this.ai[0] += 1f;
									if (this.ai[0] == 20f || this.ai[0] == 40f || this.ai[0] == 60f || this.ai[0] == 80f)
									{
										if (Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
										{
											float num217 = 0.2f;
											Vector2 vector24 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
											float num218 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector24.X + (float)Main.rand.Next(-100, 101);
											float num219 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector24.Y + (float)Main.rand.Next(-100, 101);
											float num220 = (float)Math.Sqrt((double)(num218 * num218 + num219 * num219));
											num220 = num217 / num220;
											num218 *= num220;
											num219 *= num220;
											int num221 = 21;
											int num222 = 44;
											int num223 = Projectile.NewProjectile(vector24.X, vector24.Y, num218, num219, num222, num221, 0f, Main.myPlayer);
											Main.projectile[num223].timeLeft = 300;
											return;
										}
									}
									else
									{
										if (this.ai[0] >= (float)(300 + Main.rand.Next(300)))
										{
											this.ai[0] = 0f;
											return;
										}
									}
								}
							}
							break;
						case 15:
							{
								this.aiAction = 0;
								if (this.ai[3] == 0f && this.life > 0)
								{
									this.ai[3] = (float)this.lifeMax;
								}
								if (this.ai[2] == 0f)
								{
									this.ai[0] = -100f;
									this.ai[2] = 1f;
									this.TargetClosest(true);
								}
								if (this.velocity.Y == 0f)
								{
									this.velocity.X = this.velocity.X * 0.8f;
									if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
									{
										this.velocity.X = 0f;
									}
									this.ai[0] += 2f;
									if ((double)this.life < (double)this.lifeMax * 0.8)
									{
										this.ai[0] += 1f;
									}
									if ((double)this.life < (double)this.lifeMax * 0.6)
									{
										this.ai[0] += 1f;
									}
									if ((double)this.life < (double)this.lifeMax * 0.4)
									{
										this.ai[0] += 2f;
									}
									if ((double)this.life < (double)this.lifeMax * 0.2)
									{
										this.ai[0] += 3f;
									}
									if ((double)this.life < (double)this.lifeMax * 0.1)
									{
										this.ai[0] += 4f;
									}
									if (this.ai[0] >= 0f)
									{
										this.netUpdate = true;
										this.TargetClosest(true);
										if (this.ai[1] == 3f)
										{
											this.velocity.Y = -13f;
											this.velocity.X = this.velocity.X + 3.5f * (float)this.direction;
											this.ai[0] = -200f;
											this.ai[1] = 0f;
										}
										else
										{
											if (this.ai[1] == 2f)
											{
												this.velocity.Y = -6f;
												this.velocity.X = this.velocity.X + 4.5f * (float)this.direction;
												this.ai[0] = -120f;
												this.ai[1] += 1f;
											}
											else
											{
												this.velocity.Y = -8f;
												this.velocity.X = this.velocity.X + 4f * (float)this.direction;
												this.ai[0] = -120f;
												this.ai[1] += 1f;
											}
										}
									}
									else
									{
										if (this.ai[0] >= -30f)
										{
											this.aiAction = 1;
										}
									}
								}
								else
								{
									if (this.target < 255 && ((this.direction == 1 && this.velocity.X < 3f) || (this.direction == -1 && this.velocity.X > -3f)))
									{
										if ((this.direction == -1 && (double)this.velocity.X < 0.1) || (this.direction == 1 && (double)this.velocity.X > -0.1))
										{
											this.velocity.X = this.velocity.X + 0.2f * (float)this.direction;
										}
										else
										{
											this.velocity.X = this.velocity.X * 0.93f;
										}
									}
								}
								int num224 = Dust.NewDust(this.position, this.width, this.height, 4, this.velocity.X, this.velocity.Y, 255, new Color(0, 80, 255, 80), this.scale * 1.2f);
								Main.dust[num224].noGravity = true;
								Dust expr_E716 = Main.dust[num224];
								expr_E716.velocity *= 0.5f;
								if (this.life > 0)
								{
									float num225 = (float)this.life / (float)this.lifeMax;
									num225 = num225 * 0.5f + 0.75f;
									if (num225 != this.scale)
									{
										this.position.X = this.position.X + (float)(this.width / 2);
										this.position.Y = this.position.Y + (float)this.height;
										this.scale = num225;
										this.width = (int)(98f * this.scale);
										this.height = (int)(92f * this.scale);
										this.position.X = this.position.X - (float)(this.width / 2);
										this.position.Y = this.position.Y - (float)this.height;
									}
									if (Main.netMode != 1)
									{
										int num226 = (int)((double)this.lifeMax * 0.05);
										if ((float)(this.life + num226) < this.ai[3])
										{
											this.ai[3] = (float)this.life;
											int num227 = Main.rand.Next(1, 4);
											for (int num228 = 0; num228 < num227; num228++)
											{
												int x = (int)(this.position.X + (float)Main.rand.Next(this.width - 32));
												int y = (int)(this.position.Y + (float)Main.rand.Next(this.height - 32));
												int num229 = NPC.NewNPC(x, y, 1, 0);
												Main.npc[num229].SetDefaults(1, -1f);
												Main.npc[num229].velocity.X = (float)Main.rand.Next(-15, 16) * 0.1f;
												Main.npc[num229].velocity.Y = (float)Main.rand.Next(-30, 1) * 0.1f;
												Main.npc[num229].ai[1] = (float)Main.rand.Next(3);
												if (Main.netMode == 2 && num229 < 200)
												{
													NetMessage.SendData(23, -1, -1, "", num229, 0f, 0f, 0f, 0);
												}
											}
											return;
										}
									}
								}
							}
							break;
						case 16:
							if (this.direction == 0)
							{
								this.TargetClosest(true);
							}
							if (this.wet)
							{
								bool flag21 = false;
								if (this.type != 55)
								{
									this.TargetClosest(false);
									if (Main.player[this.target].wet && !Main.player[this.target].dead)
									{
										flag21 = true;
									}
								}
								if (!flag21)
								{
									if (this.collideX)
									{
										this.velocity.X = this.velocity.X * -1f;
										this.direction *= -1;
										this.netUpdate = true;
									}
									if (this.collideY)
									{
										this.netUpdate = true;
										if (this.velocity.Y > 0f)
										{
											this.velocity.Y = Math.Abs(this.velocity.Y) * -1f;
											this.directionY = -1;
											this.ai[0] = -1f;
										}
										else
										{
											if (this.velocity.Y < 0f)
											{
												this.velocity.Y = Math.Abs(this.velocity.Y);
												this.directionY = 1;
												this.ai[0] = 1f;
											}
										}
									}
								}
								if (this.type == 102)
								{
									Lighting.addLight((int)(this.position.X + (float)(this.width / 2) + (float)(this.direction * (this.width + 8))) / 16, (int)(this.position.Y + 2f) / 16, 0.07f, 0.04f, 0.025f);
								}
								if (flag21)
								{
									this.TargetClosest(true);
									if (this.type == 65 || this.type == 102)
									{
										this.velocity.X = this.velocity.X + (float)this.direction * 0.15f;
										this.velocity.Y = this.velocity.Y + (float)this.directionY * 0.15f;
										if (this.velocity.X > 5f)
										{
											this.velocity.X = 5f;
										}
										if (this.velocity.X < -5f)
										{
											this.velocity.X = -5f;
										}
										if (this.velocity.Y > 3f)
										{
											this.velocity.Y = 3f;
										}
										if (this.velocity.Y < -3f)
										{
											this.velocity.Y = -3f;
										}
									}
									else
									{
										this.velocity.X = this.velocity.X + (float)this.direction * 0.1f;
										this.velocity.Y = this.velocity.Y + (float)this.directionY * 0.1f;
										if (this.velocity.X > 3f)
										{
											this.velocity.X = 3f;
										}
										if (this.velocity.X < -3f)
										{
											this.velocity.X = -3f;
										}
										if (this.velocity.Y > 2f)
										{
											this.velocity.Y = 2f;
										}
										if (this.velocity.Y < -2f)
										{
											this.velocity.Y = -2f;
										}
									}
								}
								else
								{
									this.velocity.X = this.velocity.X + (float)this.direction * 0.1f;
									if (this.velocity.X < -1f || this.velocity.X > 1f)
									{
										this.velocity.X = this.velocity.X * 0.95f;
									}
									if (this.ai[0] == -1f)
									{
										this.velocity.Y = this.velocity.Y - 0.01f;
										if ((double)this.velocity.Y < -0.3)
										{
											this.ai[0] = 1f;
										}
									}
									else
									{
										this.velocity.Y = this.velocity.Y + 0.01f;
										if ((double)this.velocity.Y > 0.3)
										{
											this.ai[0] = -1f;
										}
									}
									int num230 = (int)(this.position.X + (float)(this.width / 2)) / 16;
									int num231 = (int)(this.position.Y + (float)(this.height / 2)) / 16;
									if (Main.tile[num230, num231 - 1].liquid > 128)
									{
										if (Main.tile[num230, num231 + 1].active)
										{
											this.ai[0] = -1f;
										}
										else
										{
											if (Main.tile[num230, num231 + 2].active)
											{
												this.ai[0] = -1f;
											}
										}
									}
									if ((double)this.velocity.Y > 0.4 || (double)this.velocity.Y < -0.4)
									{
										this.velocity.Y = this.velocity.Y * 0.95f;
									}
								}
							}
							else
							{
								if (this.velocity.Y == 0f)
								{
									if (this.type == 65)
									{
										this.velocity.X = this.velocity.X * 0.94f;
										if ((double)this.velocity.X > -0.2 && (double)this.velocity.X < 0.2)
										{
											this.velocity.X = 0f;
										}
									}
									else
									{
										if (Main.netMode != 1)
										{
											this.velocity.Y = (float)Main.rand.Next(-50, -20) * 0.1f;
											this.velocity.X = (float)Main.rand.Next(-20, 20) * 0.1f;
											this.netUpdate = true;
										}
									}
								}
								this.velocity.Y = this.velocity.Y + 0.3f;
								if (this.velocity.Y > 10f)
								{
									this.velocity.Y = 10f;
								}
								this.ai[0] = 1f;
							}
							this.rotation = this.velocity.Y * (float)this.direction * 0.1f;
							if ((double)this.rotation < -0.2)
							{
								this.rotation = -0.2f;
							}
							if ((double)this.rotation > 0.2)
							{
								this.rotation = 0.2f;
								return;
							}
							break;
						case 17:
							this.noGravity = true;
							if (this.ai[0] == 0f)
							{
								this.noGravity = false;
								this.TargetClosest(true);
								if (Main.netMode != 1)
								{
									if (this.velocity.X != 0f || this.velocity.Y < 0f || (double)this.velocity.Y > 0.3)
									{
										this.ai[0] = 1f;
										this.netUpdate = true;
									}
									else
									{
										Rectangle rectangle5 = new Rectangle((int)Main.player[this.target].position.X, (int)Main.player[this.target].position.Y, Main.player[this.target].width, Main.player[this.target].height);
										Rectangle rectangle6 = new Rectangle((int)this.position.X - 100, (int)this.position.Y - 100, this.width + 200, this.height + 200);
										if (rectangle6.Intersects(rectangle5) || this.life < this.lifeMax)
										{
											this.ai[0] = 1f;
											this.velocity.Y = this.velocity.Y - 6f;
											this.netUpdate = true;
										}
									}
								}
							}
							else
							{
								if (!Main.player[this.target].dead)
								{
									if (this.collideX)
									{
										this.velocity.X = this.oldVelocity.X * -0.5f;
										if (this.direction == -1 && this.velocity.X > 0f && this.velocity.X < 2f)
										{
											this.velocity.X = 2f;
										}
										if (this.direction == 1 && this.velocity.X < 0f && this.velocity.X > -2f)
										{
											this.velocity.X = -2f;
										}
									}
									if (this.collideY)
									{
										this.velocity.Y = this.oldVelocity.Y * -0.5f;
										if (this.velocity.Y > 0f && this.velocity.Y < 1f)
										{
											this.velocity.Y = 1f;
										}
										if (this.velocity.Y < 0f && this.velocity.Y > -1f)
										{
											this.velocity.Y = -1f;
										}
									}
									this.TargetClosest(true);
									if (this.direction == -1 && this.velocity.X > -3f)
									{
										this.velocity.X = this.velocity.X - 0.1f;
										if (this.velocity.X > 3f)
										{
											this.velocity.X = this.velocity.X - 0.1f;
										}
										else
										{
											if (this.velocity.X > 0f)
											{
												this.velocity.X = this.velocity.X - 0.05f;
											}
										}
										if (this.velocity.X < -3f)
										{
											this.velocity.X = -3f;
										}
									}
									else
									{
										if (this.direction == 1 && this.velocity.X < 3f)
										{
											this.velocity.X = this.velocity.X + 0.1f;
											if (this.velocity.X < -3f)
											{
												this.velocity.X = this.velocity.X + 0.1f;
											}
											else
											{
												if (this.velocity.X < 0f)
												{
													this.velocity.X = this.velocity.X + 0.05f;
												}
											}
											if (this.velocity.X > 3f)
											{
												this.velocity.X = 3f;
											}
										}
									}
									float num232 = Math.Abs(this.position.X + (float)(this.width / 2) - (Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2)));
									float num233 = Main.player[this.target].position.Y - (float)(this.height / 2);
									if (num232 > 50f)
									{
										num233 -= 100f;
									}
									if (this.position.Y < num233)
									{
										this.velocity.Y = this.velocity.Y + 0.05f;
										if (this.velocity.Y < 0f)
										{
											this.velocity.Y = this.velocity.Y + 0.01f;
										}
									}
									else
									{
										this.velocity.Y = this.velocity.Y - 0.05f;
										if (this.velocity.Y > 0f)
										{
											this.velocity.Y = this.velocity.Y - 0.01f;
										}
									}
									if (this.velocity.Y < -3f)
									{
										this.velocity.Y = -3f;
									}
									if (this.velocity.Y > 3f)
									{
										this.velocity.Y = 3f;
									}
								}
							}
							if (this.wet)
							{
								if (this.velocity.Y > 0f)
								{
									this.velocity.Y = this.velocity.Y * 0.95f;
								}
								this.velocity.Y = this.velocity.Y - 0.5f;
								if (this.velocity.Y < -4f)
								{
									this.velocity.Y = -4f;
								}
								this.TargetClosest(true);
								return;
							}
							break;
						case 18:
							{
								if (this.type == 63)
								{
									Lighting.addLight((int)(this.position.X + (float)(this.height / 2)) / 16, (int)(this.position.Y + (float)(this.height / 2)) / 16, 0.05f, 0.15f, 0.4f);
								}
								else
								{
									if (this.type == 103)
									{
										Lighting.addLight((int)(this.position.X + (float)(this.height / 2)) / 16, (int)(this.position.Y + (float)(this.height / 2)) / 16, 0.05f, 0.45f, 0.1f);
									}
									else
									{
										Lighting.addLight((int)(this.position.X + (float)(this.height / 2)) / 16, (int)(this.position.Y + (float)(this.height / 2)) / 16, 0.35f, 0.05f, 0.2f);
									}
								}
								if (this.direction == 0)
								{
									this.TargetClosest(true);
								}
								if (!this.wet)
								{
									this.rotation += this.velocity.X * 0.1f;
									if (this.velocity.Y == 0f)
									{
										this.velocity.X = this.velocity.X * 0.98f;
										if ((double)this.velocity.X > -0.01 && (double)this.velocity.X < 0.01)
										{
											this.velocity.X = 0f;
										}
									}
									this.velocity.Y = this.velocity.Y + 0.2f;
									if (this.velocity.Y > 10f)
									{
										this.velocity.Y = 10f;
									}
									this.ai[0] = 1f;
									return;
								}
								if (this.collideX)
								{
									this.velocity.X = this.velocity.X * -1f;
									this.direction *= -1;
								}
								if (this.collideY)
								{
									if (this.velocity.Y > 0f)
									{
										this.velocity.Y = Math.Abs(this.velocity.Y) * -1f;
										this.directionY = -1;
										this.ai[0] = -1f;
									}
									else
									{
										if (this.velocity.Y < 0f)
										{
											this.velocity.Y = Math.Abs(this.velocity.Y);
											this.directionY = 1;
											this.ai[0] = 1f;
										}
									}
								}
								bool flag22 = false;
								if (!this.friendly)
								{
									this.TargetClosest(false);
									if (Main.player[this.target].wet && !Main.player[this.target].dead)
									{
										flag22 = true;
									}
								}
								if (flag22)
								{
									this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) + 1.57f;
									this.velocity *= 0.98f;
									float num234 = 0.2f;
									if (this.type == 103)
									{
										this.velocity *= 0.98f;
										num234 = 0.6f;
									}
									if (this.velocity.X > -num234 && this.velocity.X < num234 && this.velocity.Y > -num234 && this.velocity.Y < num234)
									{
										this.TargetClosest(true);
										float num235 = 7f;
										if (this.type == 103)
										{
											num235 = 9f;
										}
										Vector2 vector25 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
										float num236 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector25.X;
										float num237 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector25.Y;
										float num238 = (float)Math.Sqrt((double)(num236 * num236 + num237 * num237));
										num238 = num235 / num238;
										num236 *= num238;
										num237 *= num238;
										this.velocity.X = num236;
										this.velocity.Y = num237;
										return;
									}
								}
								else
								{
									this.velocity.X = this.velocity.X + (float)this.direction * 0.02f;
									this.rotation = this.velocity.X * 0.4f;
									if (this.velocity.X < -1f || this.velocity.X > 1f)
									{
										this.velocity.X = this.velocity.X * 0.95f;
									}
									if (this.ai[0] == -1f)
									{
										this.velocity.Y = this.velocity.Y - 0.01f;
										if (this.velocity.Y < -1f)
										{
											this.ai[0] = 1f;
										}
									}
									else
									{
										this.velocity.Y = this.velocity.Y + 0.01f;
										if (this.velocity.Y > 1f)
										{
											this.ai[0] = -1f;
										}
									}
									int num239 = (int)(this.position.X + (float)(this.width / 2)) / 16;
									int num240 = (int)(this.position.Y + (float)(this.height / 2)) / 16;
									if (Main.tile[num239, num240 - 1].liquid > 128)
									{
										if (Main.tile[num239, num240 + 1].active)
										{
											this.ai[0] = -1f;
										}
										else
										{
											if (Main.tile[num239, num240 + 2].active)
											{
												this.ai[0] = -1f;
											}
										}
									}
									else
									{
										this.ai[0] = 1f;
									}
									if ((double)this.velocity.Y > 1.2 || (double)this.velocity.Y < -1.2)
									{
										this.velocity.Y = this.velocity.Y * 0.99f;
										return;
									}
								}
							}
							break;
						default:
							if (this.aiStyle == 19)
							{
								this.TargetClosest(true);
								float num241 = 12f;
								Vector2 vector26 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
								float num242 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector26.X;
								float num243 = Main.player[this.target].position.Y - vector26.Y;
								float num244 = (float)Math.Sqrt((double)(num242 * num242 + num243 * num243));
								num244 = num241 / num244;
								num242 *= num244;
								num243 *= num244;
								bool flag23 = false;
								if (this.directionY < 0)
								{
									this.rotation = (float)(Math.Atan2((double)num243, (double)num242) + 1.57);
									flag23 = ((double)this.rotation >= -1.2 && (double)this.rotation <= 1.2);
									if ((double)this.rotation < -0.8)
									{
										this.rotation = -0.8f;
									}
									else
									{
										if ((double)this.rotation > 0.8)
										{
											this.rotation = 0.8f;
										}
									}
									if (this.velocity.X != 0f)
									{
										this.velocity.X = this.velocity.X * 0.9f;
										if ((double)this.velocity.X > -0.1 || (double)this.velocity.X < 0.1)
										{
											this.netUpdate = true;
											this.velocity.X = 0f;
										}
									}
								}
								if (this.ai[0] > 0f)
								{
									if (this.ai[0] == 200f)
									{
										Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 5);
									}
									this.ai[0] -= 1f;
								}
								if (Main.netMode != 1 && flag23 && this.ai[0] == 0f && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
								{
									this.ai[0] = 200f;
									int num245 = 10;
									int num246 = 31;
									int num247 = Projectile.NewProjectile(vector26.X, vector26.Y, num242, num243, num246, num245, 0f, Main.myPlayer);
									Main.projectile[num247].ai[0] = 2f;
									Main.projectile[num247].timeLeft = 300;
									Main.projectile[num247].friendly = false;
									NetMessage.SendData(27, -1, -1, "", num247, 0f, 0f, 0f, 0);
									this.netUpdate = true;
								}
								try
								{
									int num248 = (int)this.position.X / 16;
									int num249 = (int)(this.position.X + (float)(this.width / 2)) / 16;
									int num250 = (int)(this.position.X + (float)this.width) / 16;
									int num251 = (int)(this.position.Y + (float)this.height) / 16;
									bool flag24 = false;
									if ((Main.tile[num248, num251].active && Main.tileSolid[(int)Main.tile[num248, num251].type]) || (Main.tile[num249, num251].active && Main.tileSolid[(int)Main.tile[num249, num251].type]) || (Main.tile[num250, num251].active && Main.tileSolid[(int)Main.tile[num250, num251].type]))
									{
										flag24 = true;
									}
									if (flag24)
									{
										this.noGravity = true;
										this.noTileCollide = true;
										this.velocity.Y = -0.2f;
									}
									else
									{
										this.noGravity = false;
										this.noTileCollide = false;
										if (Main.rand.Next(2) == 0)
										{
											Vector2 arg_103EF_0 = new Vector2(this.position.X - 4f, this.position.Y + (float)this.height - 8f);
											int arg_103EF_1 = this.width + 8;
											int arg_103EF_2 = 24;
											int arg_103EF_3 = 32;
											float arg_103EF_4 = 0f;
											float arg_103EF_5 = this.velocity.Y / 2f;
											int arg_103EF_6 = 0;
											Color newColor = default(Color);
											int num252 = Dust.NewDust(arg_103EF_0, arg_103EF_1, arg_103EF_2, arg_103EF_3, arg_103EF_4, arg_103EF_5, arg_103EF_6, newColor, 1f);
											Dust expr_10407_cp_0 = Main.dust[num252];
											expr_10407_cp_0.velocity.X = expr_10407_cp_0.velocity.X * 0.4f;
											Dust expr_10427_cp_0 = Main.dust[num252];
											expr_10427_cp_0.velocity.Y = expr_10427_cp_0.velocity.Y * -1f;
											if (Main.rand.Next(2) == 0)
											{
												Main.dust[num252].noGravity = true;
												Main.dust[num252].scale += 0.2f;
											}
										}
									}
									return;
								}
								catch
								{
									return;
								}
							}
							switch (this.aiStyle)
							{
								case 20:
									if (this.ai[0] == 0f)
									{
										if (Main.netMode != 1)
										{
											this.TargetClosest(true);
											this.direction *= -1;
											this.directionY *= -1;
											this.position.Y = this.position.Y + (float)(this.height / 2 + 8);
											this.ai[1] = this.position.X + (float)(this.width / 2);
											this.ai[2] = this.position.Y + (float)(this.height / 2);
											if (this.direction == 0)
											{
												this.direction = 1;
											}
											if (this.directionY == 0)
											{
												this.directionY = 1;
											}
											this.ai[3] = 1f + (float)Main.rand.Next(15) * 0.1f;
											this.velocity.Y = (float)(this.directionY * 6) * this.ai[3];
											this.ai[0] += 1f;
											this.netUpdate = true;
											return;
										}
										this.ai[1] = this.position.X + (float)(this.width / 2);
										this.ai[2] = this.position.Y + (float)(this.height / 2);
										return;
									}
									else
									{
										float num253 = 6f * this.ai[3];
										float num254 = 0.2f * this.ai[3];
										float num255 = num253 / num254 / 2f;
										if (this.ai[0] >= 1f && this.ai[0] < (float)((int)num255))
										{
											this.velocity.Y = (float)this.directionY * num253;
											this.ai[0] += 1f;
											return;
										}
										if (this.ai[0] >= (float)((int)num255))
										{
											this.netUpdate = true;
											this.velocity.Y = 0f;
											this.directionY *= -1;
											this.velocity.X = num253 * (float)this.direction;
											this.ai[0] = -1f;
											return;
										}
										if (this.directionY > 0)
										{
											if (this.velocity.Y >= num253)
											{
												this.netUpdate = true;
												this.directionY *= -1;
												this.velocity.Y = num253;
											}
										}
										else
										{
											if (this.directionY < 0 && this.velocity.Y <= -num253)
											{
												this.directionY *= -1;
												this.velocity.Y = -num253;
											}
										}
										if (this.direction > 0)
										{
											if (this.velocity.X >= num253)
											{
												this.direction *= -1;
												this.velocity.X = num253;
											}
										}
										else
										{
											if (this.direction < 0 && this.velocity.X <= -num253)
											{
												this.direction *= -1;
												this.velocity.X = -num253;
											}
										}
										this.velocity.X = this.velocity.X + num254 * (float)this.direction;
										this.velocity.Y = this.velocity.Y + num254 * (float)this.directionY;
										return;
									}
								default:
									if (this.aiStyle == 21)
									{
										if (this.ai[0] == 0f)
										{
											this.TargetClosest(true);
											this.directionY = 1;
											this.ai[0] = 1f;
										}
										int num256 = 6;
										if (this.ai[1] == 0f)
										{
											this.rotation += (float)(this.direction * this.directionY) * 0.13f;
											if (this.collideY)
											{
												this.ai[0] = 2f;
											}
											if (!this.collideY && this.ai[0] == 2f)
											{
												this.direction = -this.direction;
												this.ai[1] = 1f;
												this.ai[0] = 1f;
											}
											if (this.collideX)
											{
												this.directionY = -this.directionY;
												this.ai[1] = 1f;
											}
										}
										else
										{
											this.rotation -= (float)(this.direction * this.directionY) * 0.13f;
											if (this.collideX)
											{
												this.ai[0] = 2f;
											}
											if (!this.collideX && this.ai[0] == 2f)
											{
												this.directionY = -this.directionY;
												this.ai[1] = 0f;
												this.ai[0] = 1f;
											}
											if (this.collideY)
											{
												this.direction = -this.direction;
												this.ai[1] = 0f;
											}
										}
										this.velocity.X = (float)(num256 * this.direction);
										this.velocity.Y = (float)(num256 * this.directionY);
										float num257 = (float)(270 - (int)Main.mouseTextColor) / 400f;
										Lighting.addLight((int)(this.position.X + (float)(this.width / 2)) / 16, (int)(this.position.Y + (float)(this.height / 2)) / 16, 0.9f, 0.3f + num257, 0.2f);
										return;
									}
									if (this.aiStyle == 22)
									{
										bool flag25 = false;
										if (this.justHit)
										{
											this.ai[2] = 0f;
										}
										if (this.ai[2] >= 0f)
										{
											int num258 = 16;
											bool flag26 = false;
											bool flag27 = false;
											if (this.position.X > this.ai[0] - (float)num258 && this.position.X < this.ai[0] + (float)num258)
											{
												flag26 = true;
											}
											else
											{
												if ((this.velocity.X < 0f && this.direction > 0) || (this.velocity.X > 0f && this.direction < 0))
												{
													flag26 = true;
												}
											}
											num258 += 24;
											if (this.position.Y > this.ai[1] - (float)num258 && this.position.Y < this.ai[1] + (float)num258)
											{
												flag27 = true;
											}
											if (flag26 && flag27)
											{
												this.ai[2] += 1f;
												if (this.ai[2] >= 30f && num258 == 16)
												{
													flag25 = true;
												}
												if (this.ai[2] >= 60f)
												{
													this.ai[2] = -200f;
													this.direction *= -1;
													this.velocity.X = this.velocity.X * -1f;
													this.collideX = false;
												}
											}
											else
											{
												this.ai[0] = this.position.X;
												this.ai[1] = this.position.Y;
												this.ai[2] = 0f;
											}
											this.TargetClosest(true);
										}
										else
										{
											this.ai[2] += 1f;
											if (Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) > this.position.X + (float)(this.width / 2))
											{
												this.direction = -1;
											}
											else
											{
												this.direction = 1;
											}
										}
										int num259 = (int)((this.position.X + (float)(this.width / 2)) / 16f) + this.direction * 2;
										int num260 = (int)((this.position.Y + (float)this.height) / 16f);
										bool flag28 = true;
										bool flag29 = false;
										int num261 = 3;
										if (this.type == 122)
										{
											if (this.justHit)
											{
												this.ai[3] = 0f;
												this.localAI[1] = 0f;
											}
											float num262 = 7f;
											Vector2 vector27 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
											float num263 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector27.X;
											float num264 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector27.Y;
											float num265 = (float)Math.Sqrt((double)(num263 * num263 + num264 * num264));
											num265 = num262 / num265;
											num263 *= num265;
											num264 *= num265;
											if (Main.netMode != 1 && this.ai[3] == 32f)
											{
												int num266 = 25;
												int num267 = 84;
												Projectile.NewProjectile(vector27.X, vector27.Y, num263, num264, num267, num266, 0f, Main.myPlayer);
											}
											num261 = 8;
											if (this.ai[3] > 0f)
											{
												this.ai[3] += 1f;
												if (this.ai[3] >= 64f)
												{
													this.ai[3] = 0f;
												}
											}
											if (Main.netMode != 1 && this.ai[3] == 0f)
											{
												this.localAI[1] += 1f;
												if (this.localAI[1] > 120f && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
												{
													this.localAI[1] = 0f;
													this.ai[3] = 1f;
													this.netUpdate = true;
												}
											}
										}
										else
										{
											if (this.type == 75)
											{
												num261 = 4;
												if (Main.rand.Next(6) == 0)
												{
													int num268 = Dust.NewDust(this.position, this.width, this.height, 55, 0f, 0f, 200, this.color, 1f);
													Dust expr_10F84 = Main.dust[num268];
													expr_10F84.velocity *= 0.3f;
												}
												if (Main.rand.Next(40) == 0)
												{
													Main.PlaySound(27, (int)this.position.X, (int)this.position.Y, 1);
												}
											}
										}
										for (int num269 = num260; num269 < num260 + num261; num269++)
										{
											if ((Main.tile[num259, num269].active && Main.tileSolid[(int)Main.tile[num259, num269].type]) || Main.tile[num259, num269].liquid > 0)
											{
												if (num269 <= num260 + 1)
												{
													flag29 = true;
												}
												flag28 = false;
												break;
											}
										}
										if (flag25)
										{
											flag29 = false;
											flag28 = true;
										}
										if (flag28)
										{
											if (this.type == 75)
											{
												this.velocity.Y = this.velocity.Y + 0.2f;
												if (this.velocity.Y > 2f)
												{
													this.velocity.Y = 2f;
												}
											}
											else
											{
												this.velocity.Y = this.velocity.Y + 0.1f;
												if (this.velocity.Y > 3f)
												{
													this.velocity.Y = 3f;
												}
											}
										}
										else
										{
											if (this.type == 75)
											{
												if ((this.directionY < 0 && this.velocity.Y > 0f) || flag29)
												{
													this.velocity.Y = this.velocity.Y - 0.2f;
												}
											}
											else
											{
												if (this.directionY < 0 && this.velocity.Y > 0f)
												{
													this.velocity.Y = this.velocity.Y - 0.1f;
												}
											}
											if (this.velocity.Y < -4f)
											{
												this.velocity.Y = -4f;
											}
										}
										if (this.type == 75 && this.wet)
										{
											this.velocity.Y = this.velocity.Y - 0.2f;
											if (this.velocity.Y < -2f)
											{
												this.velocity.Y = -2f;
											}
										}
										if (this.collideX)
										{
											this.velocity.X = this.oldVelocity.X * -0.4f;
											if (this.direction == -1 && this.velocity.X > 0f && this.velocity.X < 1f)
											{
												this.velocity.X = 1f;
											}
											if (this.direction == 1 && this.velocity.X < 0f && this.velocity.X > -1f)
											{
												this.velocity.X = -1f;
											}
										}
										if (this.collideY)
										{
											this.velocity.Y = this.oldVelocity.Y * -0.25f;
											if (this.velocity.Y > 0f && this.velocity.Y < 1f)
											{
												this.velocity.Y = 1f;
											}
											if (this.velocity.Y < 0f && this.velocity.Y > -1f)
											{
												this.velocity.Y = -1f;
											}
										}
										float num270 = 2f;
										if (this.type == 75)
										{
											num270 = 3f;
										}
										if (this.direction == -1 && this.velocity.X > -num270)
										{
											this.velocity.X = this.velocity.X - 0.1f;
											if (this.velocity.X > num270)
											{
												this.velocity.X = this.velocity.X - 0.1f;
											}
											else
											{
												if (this.velocity.X > 0f)
												{
													this.velocity.X = this.velocity.X + 0.05f;
												}
											}
											if (this.velocity.X < -num270)
											{
												this.velocity.X = -num270;
											}
										}
										else
										{
											if (this.direction == 1 && this.velocity.X < num270)
											{
												this.velocity.X = this.velocity.X + 0.1f;
												if (this.velocity.X < -num270)
												{
													this.velocity.X = this.velocity.X + 0.1f;
												}
												else
												{
													if (this.velocity.X < 0f)
													{
														this.velocity.X = this.velocity.X - 0.05f;
													}
												}
												if (this.velocity.X > num270)
												{
													this.velocity.X = num270;
												}
											}
										}
										if (this.directionY == -1 && (double)this.velocity.Y > -1.5)
										{
											this.velocity.Y = this.velocity.Y - 0.04f;
											if ((double)this.velocity.Y > 1.5)
											{
												this.velocity.Y = this.velocity.Y - 0.05f;
											}
											else
											{
												if (this.velocity.Y > 0f)
												{
													this.velocity.Y = this.velocity.Y + 0.03f;
												}
											}
											if ((double)this.velocity.Y < -1.5)
											{
												this.velocity.Y = -1.5f;
											}
										}
										else
										{
											if (this.directionY == 1 && (double)this.velocity.Y < 1.5)
											{
												this.velocity.Y = this.velocity.Y + 0.04f;
												if ((double)this.velocity.Y < -1.5)
												{
													this.velocity.Y = this.velocity.Y + 0.05f;
												}
												else
												{
													if (this.velocity.Y < 0f)
													{
														this.velocity.Y = this.velocity.Y - 0.03f;
													}
												}
												if ((double)this.velocity.Y > 1.5)
												{
													this.velocity.Y = 1.5f;
												}
											}
										}
										if (this.type == 122)
										{
											Lighting.addLight((int)this.position.X / 16, (int)this.position.Y / 16, 0.4f, 0f, 0.25f);
											return;
										}
									}
									else
									{
										if (this.aiStyle == 23)
										{
											this.noGravity = true;
											this.noTileCollide = true;
											if (this.type == 83)
											{
												Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.2f, 0.05f, 0.3f);
											}
											else
											{
												Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.05f, 0.2f, 0.3f);
											}
											if (this.target < 0 || this.target == 255 || Main.player[this.target].dead)
											{
												this.TargetClosest(true);
											}
											if (this.ai[0] == 0f)
											{
												float num271 = 9f;
												Vector2 vector28 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
												float num272 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector28.X;
												float num273 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector28.Y;
												float num274 = (float)Math.Sqrt((double)(num272 * num272 + num273 * num273));
												num274 = num271 / num274;
												num272 *= num274;
												num273 *= num274;
												this.velocity.X = num272;
												this.velocity.Y = num273;
												this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) + 0.785f;
												this.ai[0] = 1f;
												this.ai[1] = 0f;
												return;
											}
											if (this.ai[0] == 1f)
											{
												if (this.justHit)
												{
													this.ai[0] = 2f;
													this.ai[1] = 0f;
												}
												this.velocity *= 0.99f;
												this.ai[1] += 1f;
												if (this.ai[1] >= 100f)
												{
													this.ai[0] = 2f;
													this.ai[1] = 0f;
													this.velocity.X = 0f;
													this.velocity.Y = 0f;
													return;
												}
											}
											else
											{
												if (this.justHit)
												{
													this.ai[0] = 2f;
													this.ai[1] = 0f;
												}
												this.velocity *= 0.96f;
												this.ai[1] += 1f;
												float num275 = this.ai[1] / 120f;
												num275 = 0.1f + num275 * 0.4f;
												this.rotation += num275 * (float)this.direction;
												if (this.ai[1] >= 120f)
												{
													this.netUpdate = true;
													this.ai[0] = 0f;
													this.ai[1] = 0f;
													return;
												}
											}
										}
										else
										{
											if (this.aiStyle == 24)
											{
												this.noGravity = true;
												if (this.ai[0] == 0f)
												{
													this.noGravity = false;
													this.TargetClosest(true);
													if (Main.netMode != 1)
													{
														if (this.velocity.X != 0f || this.velocity.Y < 0f || (double)this.velocity.Y > 0.3)
														{
															this.ai[0] = 1f;
															this.netUpdate = true;
															this.direction = -this.direction;
														}
														else
														{
															Rectangle rectangle7 = new Rectangle((int)Main.player[this.target].position.X, (int)Main.player[this.target].position.Y, Main.player[this.target].width, Main.player[this.target].height);
															Rectangle rectangle8 = new Rectangle((int)this.position.X - 100, (int)this.position.Y - 100, this.width + 200, this.height + 200);
															if (rectangle8.Intersects(rectangle7) || this.life < this.lifeMax)
															{
																this.ai[0] = 1f;
																this.velocity.Y = this.velocity.Y - 6f;
																this.netUpdate = true;
																this.direction = -this.direction;
															}
														}
													}
												}
												else
												{
													if (!Main.player[this.target].dead)
													{
														if (this.collideX)
														{
															this.direction *= -1;
															this.velocity.X = this.oldVelocity.X * -0.5f;
															if (this.direction == -1 && this.velocity.X > 0f && this.velocity.X < 2f)
															{
																this.velocity.X = 2f;
															}
															if (this.direction == 1 && this.velocity.X < 0f && this.velocity.X > -2f)
															{
																this.velocity.X = -2f;
															}
														}
														if (this.collideY)
														{
															this.velocity.Y = this.oldVelocity.Y * -0.5f;
															if (this.velocity.Y > 0f && this.velocity.Y < 1f)
															{
																this.velocity.Y = 1f;
															}
															if (this.velocity.Y < 0f && this.velocity.Y > -1f)
															{
																this.velocity.Y = -1f;
															}
														}
														if (this.direction == -1 && this.velocity.X > -3f)
														{
															this.velocity.X = this.velocity.X - 0.1f;
															if (this.velocity.X > 3f)
															{
																this.velocity.X = this.velocity.X - 0.1f;
															}
															else
															{
																if (this.velocity.X > 0f)
																{
																	this.velocity.X = this.velocity.X - 0.05f;
																}
															}
															if (this.velocity.X < -3f)
															{
																this.velocity.X = -3f;
															}
														}
														else
														{
															if (this.direction == 1 && this.velocity.X < 3f)
															{
																this.velocity.X = this.velocity.X + 0.1f;
																if (this.velocity.X < -3f)
																{
																	this.velocity.X = this.velocity.X + 0.1f;
																}
																else
																{
																	if (this.velocity.X < 0f)
																	{
																		this.velocity.X = this.velocity.X + 0.05f;
																	}
																}
																if (this.velocity.X > 3f)
																{
																	this.velocity.X = 3f;
																}
															}
														}
														int num276 = (int)((this.position.X + (float)(this.width / 2)) / 16f) + this.direction;
														int num277 = (int)((this.position.Y + (float)this.height) / 16f);
														bool flag30 = true;
														int num278 = 15;
														bool flag31 = false;
														for (int num279 = num277; num279 < num277 + num278; num279++)
														{
															if ((Main.tile[num276, num279].active && Main.tileSolid[(int)Main.tile[num276, num279].type]) || Main.tile[num276, num279].liquid > 0)
															{
																if (num279 < num277 + 5)
																{
																	flag31 = true;
																}
																flag30 = false;
																break;
															}
														}
														if (flag30)
														{
															this.velocity.Y = this.velocity.Y + 0.1f;
														}
														else
														{
															this.velocity.Y = this.velocity.Y - 0.1f;
														}
														if (flag31)
														{
															this.velocity.Y = this.velocity.Y - 0.2f;
														}
														if (this.velocity.Y > 3f)
														{
															this.velocity.Y = 3f;
														}
														if (this.velocity.Y < -4f)
														{
															this.velocity.Y = -4f;
														}
													}
												}
												if (this.wet)
												{
													if (this.velocity.Y > 0f)
													{
														this.velocity.Y = this.velocity.Y * 0.95f;
													}
													this.velocity.Y = this.velocity.Y - 0.5f;
													if (this.velocity.Y < -4f)
													{
														this.velocity.Y = -4f;
													}
													this.TargetClosest(true);
													return;
												}
											}
											else
											{
												if (this.aiStyle == 25)
												{
													if (this.ai[3] == 0f)
													{
														this.position.X = this.position.X + 8f;
														if (this.position.Y / 16f > (float)(Main.maxTilesY - 200))
														{
															this.ai[3] = 3f;
														}
														else
														{
															if ((double)(this.position.Y / 16f) > Main.worldSurface)
															{
																this.ai[3] = 2f;
															}
															else
															{
																this.ai[3] = 1f;
															}
														}
													}
													if (this.ai[0] == 0f)
													{
														this.TargetClosest(true);
														if (Main.netMode != 1)
														{
															if (this.velocity.X != 0f || this.velocity.Y < 0f || (double)this.velocity.Y > 0.3)
															{
																this.ai[0] = 1f;
																this.netUpdate = true;
																return;
															}
															Rectangle rectangle9 = new Rectangle((int)Main.player[this.target].position.X, (int)Main.player[this.target].position.Y, Main.player[this.target].width, Main.player[this.target].height);
															Rectangle rectangle10 = new Rectangle((int)this.position.X - 100, (int)this.position.Y - 100, this.width + 200, this.height + 200);
															if (rectangle10.Intersects(rectangle9) || this.life < this.lifeMax)
															{
																this.ai[0] = 1f;
																this.netUpdate = true;
																return;
															}
														}
													}
													else
													{
														if (this.velocity.Y == 0f)
														{
															this.ai[2] += 1f;
															int num280 = 20;
															if (this.ai[1] == 0f)
															{
																num280 = 12;
															}
															if (this.ai[2] < (float)num280)
															{
																this.velocity.X = this.velocity.X * 0.9f;
																return;
															}
															this.ai[2] = 0f;
															this.TargetClosest(true);
															this.spriteDirection = this.direction;
															this.ai[1] += 1f;
															if (this.ai[1] == 2f)
															{
																this.velocity.X = (float)this.direction * 2.5f;
																this.velocity.Y = -8f;
																this.ai[1] = 0f;
															}
															else
															{
																this.velocity.X = (float)this.direction * 3.5f;
																this.velocity.Y = -4f;
															}
															this.netUpdate = true;
															return;
														}
														else
														{
															if (this.direction == 1 && this.velocity.X < 1f)
															{
																this.velocity.X = this.velocity.X + 0.1f;
																return;
															}
															if (this.direction == -1 && this.velocity.X > -1f)
															{
																this.velocity.X = this.velocity.X - 0.1f;
																return;
															}
														}
													}
												}
												else
												{
													if (this.aiStyle == 26)
													{
														int num281 = 30;
														bool flag32 = false;
														if (this.velocity.Y == 0f && ((this.velocity.X > 0f && this.direction < 0) || (this.velocity.X < 0f && this.direction > 0)))
														{
															flag32 = true;
															this.ai[3] += 1f;
														}
														if (this.position.X == this.oldPosition.X || this.ai[3] >= (float)num281 || flag32)
														{
															this.ai[3] += 1f;
														}
														else
														{
															if (this.ai[3] > 0f)
															{
																this.ai[3] -= 1f;
															}
														}
														if (this.ai[3] > (float)(num281 * 10))
														{
															this.ai[3] = 0f;
														}
														if (this.justHit)
														{
															this.ai[3] = 0f;
														}
														if (this.ai[3] == (float)num281)
														{
															this.netUpdate = true;
														}
														if (this.ai[3] < (float)num281)
														{
															this.TargetClosest(true);
														}
														else
														{
															if (this.velocity.X == 0f)
															{
																if (this.velocity.Y == 0f)
																{
																	this.ai[0] += 1f;
																	if (this.ai[0] >= 2f)
																	{
																		this.direction *= -1;
																		this.spriteDirection = this.direction;
																		this.ai[0] = 0f;
																	}
																}
															}
															else
															{
																this.ai[0] = 0f;
															}
															this.directionY = -1;
															if (this.direction == 0)
															{
																this.direction = 1;
															}
														}
														float num282 = 6f;
														if (this.velocity.Y == 0f || this.wet || (this.velocity.X <= 0f && this.direction < 0) || (this.velocity.X >= 0f && this.direction > 0))
														{
															if (this.velocity.X < -num282 || this.velocity.X > num282)
															{
																if (this.velocity.Y == 0f)
																{
																	this.velocity *= 0.8f;
																}
															}
															else
															{
																if (this.velocity.X < num282 && this.direction == 1)
																{
																	this.velocity.X = this.velocity.X + 0.07f;
																	if (this.velocity.X > num282)
																	{
																		this.velocity.X = num282;
																	}
																}
																else
																{
																	if (this.velocity.X > -num282 && this.direction == -1)
																	{
																		this.velocity.X = this.velocity.X - 0.07f;
																		if (this.velocity.X < -num282)
																		{
																			this.velocity.X = -num282;
																		}
																	}
																}
															}
														}
														if (this.velocity.Y == 0f)
														{
															int num283 = (int)((this.position.X + (float)(this.width / 2) + (float)((this.width / 2 + 2) * this.direction) + this.velocity.X * 5f) / 16f);
															int num284 = (int)((this.position.Y + (float)this.height - 15f) / 16f);
															if ((this.velocity.X < 0f && this.spriteDirection == -1) || (this.velocity.X > 0f && this.spriteDirection == 1))
															{
																if (Main.tile[num283, num284 - 2].active && Main.tileSolid[(int)Main.tile[num283, num284 - 2].type])
																{
																	if (Main.tile[num283, num284 - 3].active && Main.tileSolid[(int)Main.tile[num283, num284 - 3].type])
																	{
																		this.velocity.Y = -8.5f;
																		this.netUpdate = true;
																		return;
																	}
																	this.velocity.Y = -7.5f;
																	this.netUpdate = true;
																	return;
																}
																else
																{
																	if (Main.tile[num283, num284 - 1].active && Main.tileSolid[(int)Main.tile[num283, num284 - 1].type])
																	{
																		this.velocity.Y = -7f;
																		this.netUpdate = true;
																		return;
																	}
																	if (Main.tile[num283, num284].active && Main.tileSolid[(int)Main.tile[num283, num284].type])
																	{
																		this.velocity.Y = -6f;
																		this.netUpdate = true;
																		return;
																	}
																	if ((this.directionY < 0 || Math.Abs(this.velocity.X) > 3f) && (!Main.tile[num283, num284 + 1].active || !Main.tileSolid[(int)Main.tile[num283, num284 + 1].type]) && (!Main.tile[num283 + this.direction, num284 + 1].active || !Main.tileSolid[(int)Main.tile[num283 + this.direction, num284 + 1].type]))
																	{
																		this.velocity.Y = -8f;
																		this.netUpdate = true;
																		return;
																	}
																}
															}
														}
													}
													else
													{
														if (this.aiStyle == 27)
														{
															if (this.position.X < 160f || this.position.X > (float)((Main.maxTilesX - 10) * 16))
															{
																this.active = false;
															}
															if (this.localAI[0] == 0f)
															{
																this.localAI[0] = 1f;
																Main.wofB = -1;
																Main.wofT = -1;
															}
															this.ai[1] += 1f;
															if (this.ai[2] == 0f)
															{
																if ((double)this.life < (double)this.lifeMax * 0.5)
																{
																	this.ai[1] += 1f;
																}
																if ((double)this.life < (double)this.lifeMax * 0.2)
																{
																	this.ai[1] += 1f;
																}
																if (this.ai[1] > 2700f)
																{
																	this.ai[2] = 1f;
																}
															}
															if (this.ai[2] > 0f && this.ai[1] > 60f)
															{
																int num285 = 3;
																if ((double)this.life < (double)this.lifeMax * 0.3)
																{
																	num285++;
																}
																this.ai[2] += 1f;
																this.ai[1] = 0f;
																if (this.ai[2] > (float)num285)
																{
																	this.ai[2] = 0f;
																}
																if (Main.netMode != 1)
																{
																	int num286 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)(this.height / 2) + 20f), 117, 1);
																	Main.npc[num286].velocity.X = (float)(this.direction * 8);
																}
															}
															this.localAI[3] += 1f;
															if (this.localAI[3] >= (float)(600 + Main.rand.Next(1000)))
															{
																this.localAI[3] = (float)(-(float)Main.rand.Next(200));
																Main.PlaySound(4, (int)this.position.X, (int)this.position.Y, 10);
															}
															Main.wof = this.whoAmI;
															int num287 = (int)(this.position.X / 16f);
															int num288 = (int)((this.position.X + (float)this.width) / 16f);
															int num289 = (int)((this.position.Y + (float)(this.height / 2)) / 16f);
															int num290 = 0;
															int num291 = num289 + 7;
															while (num290 < 15 && num291 > Main.maxTilesY - 200)
															{
																num291++;
																for (int num292 = num287; num292 <= num288; num292++)
																{
																	try
																	{
																		if (WorldGen.SolidTile(num292, num291) || Main.tile[num292, num291].liquid > 0)
																		{
																			num290++;
																		}
																	}
																	catch
																	{
																		num290 += 15;
																	}
																}
															}
															num291 += 4;
															if (Main.wofB == -1)
															{
																Main.wofB = num291 * 16;
															}
															else
															{
																if (Main.wofB > num291 * 16)
																{
																	Main.wofB--;
																	if (Main.wofB < num291 * 16)
																	{
																		Main.wofB = num291 * 16;
																	}
																}
																else
																{
																	if (Main.wofB < num291 * 16)
																	{
																		Main.wofB++;
																		if (Main.wofB > num291 * 16)
																		{
																			Main.wofB = num291 * 16;
																		}
																	}
																}
															}
															num290 = 0;
															num291 = num289 - 7;
															while (num290 < 15 && num291 < Main.maxTilesY - 10)
															{
																num291--;
																for (int num293 = num287; num293 <= num288; num293++)
																{
																	try
																	{
																		if (WorldGen.SolidTile(num293, num291) || Main.tile[num293, num291].liquid > 0)
																		{
																			num290++;
																		}
																	}
																	catch
																	{
																		num290 += 15;
																	}
																}
															}
															num291 -= 4;
															if (Main.wofT == -1)
															{
																Main.wofT = num291 * 16;
															}
															else
															{
																if (Main.wofT > num291 * 16)
																{
																	Main.wofT--;
																	if (Main.wofT < num291 * 16)
																	{
																		Main.wofT = num291 * 16;
																	}
																}
																else
																{
																	if (Main.wofT < num291 * 16)
																	{
																		Main.wofT++;
																		if (Main.wofT > num291 * 16)
																		{
																			Main.wofT = num291 * 16;
																		}
																	}
																}
															}
															float num294 = (float)((Main.wofB + Main.wofT) / 2 - this.height / 2);
															if (this.position.Y > num294 + 1f)
															{
																this.velocity.Y = -1f;
															}
															else
															{
																if (this.position.Y < num294 - 1f)
																{
																	this.velocity.Y = 1f;
																}
															}
															this.velocity.Y = 0f;
															this.position.Y = num294;
															float num295 = 1.5f;
															if ((double)this.life < (double)this.lifeMax * 0.75)
															{
																num295 += 0.25f;
															}
															if ((double)this.life < (double)this.lifeMax * 0.5)
															{
																num295 += 0.4f;
															}
															if ((double)this.life < (double)this.lifeMax * 0.25)
															{
																num295 += 0.5f;
															}
															if ((double)this.life < (double)this.lifeMax * 0.1)
															{
																num295 += 0.6f;
															}
															if (this.velocity.X == 0f)
															{
																this.TargetClosest(true);
																this.velocity.X = (float)this.direction;
															}
															if (this.velocity.X < 0f)
															{
																this.velocity.X = -num295;
																this.direction = -1;
															}
															else
															{
																this.velocity.X = num295;
																this.direction = 1;
															}
															this.spriteDirection = this.direction;
															Vector2 vector29 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
															float num296 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector29.X;
															float num297 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector29.Y;
															float num298 = (float)Math.Sqrt((double)(num296 * num296 + num297 * num297));
															num296 *= num298;
															num297 *= num298;
															if (this.direction > 0)
															{
																if (Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) > this.position.X + (float)(this.width / 2))
																{
																	this.rotation = (float)Math.Atan2((double)(-(double)num297), (double)(-(double)num296)) + 3.14f;
																}
																else
																{
																	this.rotation = 0f;
																}
															}
															else
															{
																if (Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) < this.position.X + (float)(this.width / 2))
																{
																	this.rotation = (float)Math.Atan2((double)num297, (double)num296) + 3.14f;
																}
																else
																{
																	this.rotation = 0f;
																}
															}
															if (this.localAI[0] == 1f && Main.netMode != 1)
															{
																this.localAI[0] = 2f;
																num294 = (float)((Main.wofB + Main.wofT) / 2);
																num294 = (num294 + (float)Main.wofT) / 2f;
																int num299 = NPC.NewNPC((int)this.position.X, (int)num294, 114, this.whoAmI);
																Main.npc[num299].ai[0] = 1f;
																num294 = (float)((Main.wofB + Main.wofT) / 2);
																num294 = (num294 + (float)Main.wofB) / 2f;
																num299 = NPC.NewNPC((int)this.position.X, (int)num294, 114, this.whoAmI);
																Main.npc[num299].ai[0] = -1f;
																num294 = (float)((Main.wofB + Main.wofT) / 2);
																num294 = (num294 + (float)Main.wofB) / 2f;
																for (int num300 = 0; num300 < 11; num300++)
																{
																	num299 = NPC.NewNPC((int)this.position.X, (int)num294, 115, this.whoAmI);
																	Main.npc[num299].ai[0] = (float)num300 * 0.1f - 0.05f;
																}
																return;
															}
														}
														else
														{
															if (this.aiStyle == 28)
															{
																if (Main.wof < 0)
																{
																	this.active = false;
																	return;
																}
																this.realLife = Main.wof;
																this.TargetClosest(true);
																this.position.X = Main.npc[Main.wof].position.X;
																this.direction = Main.npc[Main.wof].direction;
																this.spriteDirection = this.direction;
																float num301 = (float)((Main.wofB + Main.wofT) / 2);
																if (this.ai[0] > 0f)
																{
																	num301 = (num301 + (float)Main.wofT) / 2f;
																}
																else
																{
																	num301 = (num301 + (float)Main.wofB) / 2f;
																}
																num301 -= (float)(this.height / 2);
																if (this.position.Y > num301 + 1f)
																{
																	this.velocity.Y = -1f;
																}
																else
																{
																	if (this.position.Y < num301 - 1f)
																	{
																		this.velocity.Y = 1f;
																	}
																	else
																	{
																		this.velocity.Y = 0f;
																		this.position.Y = num301;
																	}
																}
																if (this.velocity.Y > 5f)
																{
																	this.velocity.Y = 5f;
																}
																if (this.velocity.Y < -5f)
																{
																	this.velocity.Y = -5f;
																}
																Vector2 vector30 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																float num302 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector30.X;
																float num303 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector30.Y;
																float num304 = (float)Math.Sqrt((double)(num302 * num302 + num303 * num303));
																num302 *= num304;
																num303 *= num304;
																bool flag33 = true;
																if (this.direction > 0)
																{
																	if (Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) > this.position.X + (float)(this.width / 2))
																	{
																		this.rotation = (float)Math.Atan2((double)(-(double)num303), (double)(-(double)num302)) + 3.14f;
																	}
																	else
																	{
																		this.rotation = 0f;
																		flag33 = false;
																	}
																}
																else
																{
																	if (Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) < this.position.X + (float)(this.width / 2))
																	{
																		this.rotation = (float)Math.Atan2((double)num303, (double)num302) + 3.14f;
																	}
																	else
																	{
																		this.rotation = 0f;
																		flag33 = false;
																	}
																}
																if (Main.netMode != 1)
																{
																	int num305 = 4;
																	this.localAI[1] += 1f;
																	if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.75)
																	{
																		this.localAI[1] += 1f;
																		num305++;
																	}
																	if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.5)
																	{
																		this.localAI[1] += 1f;
																		num305++;
																	}
																	if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.25)
																	{
																		this.localAI[1] += 1f;
																		num305 += 2;
																	}
																	if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.1)
																	{
																		this.localAI[1] += 2f;
																		num305 += 3;
																	}
																	if (this.localAI[2] == 0f)
																	{
																		if (this.localAI[1] > 600f)
																		{
																			this.localAI[2] = 1f;
																			this.localAI[1] = 0f;
																			return;
																		}
																	}
																	else
																	{
																		if (this.localAI[1] > 45f && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
																		{
																			this.localAI[1] = 0f;
																			this.localAI[2] += 1f;
																			if (this.localAI[2] >= (float)num305)
																			{
																				this.localAI[2] = 0f;
																			}
																			if (flag33)
																			{
																				float num306 = 9f;
																				int num307 = 11;
																				int num308 = 83;
																				if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.5)
																				{
																					num307++;
																					num306 += 1f;
																				}
																				if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.25)
																				{
																					num307++;
																					num306 += 1f;
																				}
																				if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.1)
																				{
																					num307 += 2;
																					num306 += 2f;
																				}
																				vector30 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																				num302 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector30.X;
																				num303 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector30.Y;
																				num304 = (float)Math.Sqrt((double)(num302 * num302 + num303 * num303));
																				num304 = num306 / num304;
																				num302 *= num304;
																				num303 *= num304;
																				vector30.X += num302;
																				vector30.Y += num303;
																				Projectile.NewProjectile(vector30.X, vector30.Y, num302, num303, num308, num307, 0f, Main.myPlayer);
																				return;
																			}
																		}
																	}
																}
															}
															else
															{
																if (this.aiStyle == 29)
																{
																	if (this.justHit)
																	{
																		this.ai[1] = 10f;
																	}
																	if (Main.wof < 0)
																	{
																		this.active = false;
																		return;
																	}
																	this.TargetClosest(true);
																	float num309 = 0.1f;
																	float num310 = 300f;
																	if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.25)
																	{
																		this.damage = 75;
																		this.defense = 40;
																		num310 = 900f;
																	}
																	else
																	{
																		if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.5)
																		{
																			this.damage = 60;
																			this.defense = 30;
																			num310 = 700f;
																		}
																		else
																		{
																			if ((double)Main.npc[Main.wof].life < (double)Main.npc[Main.wof].lifeMax * 0.75)
																			{
																				this.damage = 45;
																				this.defense = 20;
																				num310 = 500f;
																			}
																		}
																	}
																	float num311 = Main.npc[Main.wof].position.X + (float)(Main.npc[Main.wof].width / 2);
																	float num312 = Main.npc[Main.wof].position.Y;
																	float num313 = (float)(Main.wofB - Main.wofT);
																	num312 = (float)Main.wofT + num313 * this.ai[0];
																	this.ai[2] += 1f;
																	if (this.ai[2] > 100f)
																	{
																		num310 = (float)((int)(num310 * 1.3f));
																		if (this.ai[2] > 200f)
																		{
																			this.ai[2] = 0f;
																		}
																	}
																	Vector2 vector31 = new Vector2(num311, num312);
																	float num314 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - (float)(this.width / 2) - vector31.X;
																	float num315 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - (float)(this.height / 2) - vector31.Y;
																	float num316 = (float)Math.Sqrt((double)(num314 * num314 + num315 * num315));
																	if (this.ai[1] == 0f)
																	{
																		if (num316 > num310)
																		{
																			num316 = num310 / num316;
																			num314 *= num316;
																			num315 *= num316;
																		}
																		if (this.position.X < num311 + num314)
																		{
																			this.velocity.X = this.velocity.X + num309;
																			if (this.velocity.X < 0f && num314 > 0f)
																			{
																				this.velocity.X = this.velocity.X + num309 * 2.5f;
																			}
																		}
																		else
																		{
																			if (this.position.X > num311 + num314)
																			{
																				this.velocity.X = this.velocity.X - num309;
																				if (this.velocity.X > 0f && num314 < 0f)
																				{
																					this.velocity.X = this.velocity.X - num309 * 2.5f;
																				}
																			}
																		}
																		if (this.position.Y < num312 + num315)
																		{
																			this.velocity.Y = this.velocity.Y + num309;
																			if (this.velocity.Y < 0f && num315 > 0f)
																			{
																				this.velocity.Y = this.velocity.Y + num309 * 2.5f;
																			}
																		}
																		else
																		{
																			if (this.position.Y > num312 + num315)
																			{
																				this.velocity.Y = this.velocity.Y - num309;
																				if (this.velocity.Y > 0f && num315 < 0f)
																				{
																					this.velocity.Y = this.velocity.Y - num309 * 2.5f;
																				}
																			}
																		}
																		if (this.velocity.X > 4f)
																		{
																			this.velocity.X = 4f;
																		}
																		if (this.velocity.X < -4f)
																		{
																			this.velocity.X = -4f;
																		}
																		if (this.velocity.Y > 4f)
																		{
																			this.velocity.Y = 4f;
																		}
																		if (this.velocity.Y < -4f)
																		{
																			this.velocity.Y = -4f;
																		}
																	}
																	else
																	{
																		if (this.ai[1] > 0f)
																		{
																			this.ai[1] -= 1f;
																		}
																		else
																		{
																			this.ai[1] = 0f;
																		}
																	}
																	if (num314 > 0f)
																	{
																		this.spriteDirection = 1;
																		this.rotation = (float)Math.Atan2((double)num315, (double)num314);
																	}
																	if (num314 < 0f)
																	{
																		this.spriteDirection = -1;
																		this.rotation = (float)Math.Atan2((double)num315, (double)num314) + 3.14f;
																	}
																	Lighting.addLight((int)(this.position.X + (float)(this.width / 2)) / 16, (int)(this.position.Y + (float)(this.height / 2)) / 16, 0.3f, 0.2f, 0.1f);
																	return;
																}
																else
																{
																	if (this.aiStyle == 30)
																	{
																		if (this.target < 0 || this.target == 255 || Main.player[this.target].dead || !Main.player[this.target].active)
																		{
																			this.TargetClosest(true);
																		}
																		bool dead2 = Main.player[this.target].dead;
																		float num317 = this.position.X + (float)(this.width / 2) - Main.player[this.target].position.X - (float)(Main.player[this.target].width / 2);
																		float num318 = this.position.Y + (float)this.height - 59f - Main.player[this.target].position.Y - (float)(Main.player[this.target].height / 2);
																		float num319 = (float)Math.Atan2((double)num318, (double)num317) + 1.57f;
																		if (num319 < 0f)
																		{
																			num319 += 6.283f;
																		}
																		else
																		{
																			if ((double)num319 > 6.283)
																			{
																				num319 -= 6.283f;
																			}
																		}
																		float num320 = 0.1f;
																		if (this.rotation < num319)
																		{
																			if ((double)(num319 - this.rotation) > 3.1415)
																			{
																				this.rotation -= num320;
																			}
																			else
																			{
																				this.rotation += num320;
																			}
																		}
																		else
																		{
																			if (this.rotation > num319)
																			{
																				if ((double)(this.rotation - num319) > 3.1415)
																				{
																					this.rotation += num320;
																				}
																				else
																				{
																					this.rotation -= num320;
																				}
																			}
																		}
																		if (this.rotation > num319 - num320 && this.rotation < num319 + num320)
																		{
																			this.rotation = num319;
																		}
																		if (this.rotation < 0f)
																		{
																			this.rotation += 6.283f;
																		}
																		else
																		{
																			if ((double)this.rotation > 6.283)
																			{
																				this.rotation -= 6.283f;
																			}
																		}
																		if (this.rotation > num319 - num320 && this.rotation < num319 + num320)
																		{
																			this.rotation = num319;
																		}
																		if (Main.rand.Next(5) == 0)
																		{
																			Vector2 arg_1469E_0 = new Vector2(this.position.X, this.position.Y + (float)this.height * 0.25f);
																			int arg_1469E_1 = this.width;
																			int arg_1469E_2 = (int)((float)this.height * 0.5f);
																			int arg_1469E_3 = 5;
																			float arg_1469E_4 = this.velocity.X;
																			float arg_1469E_5 = 2f;
																			int arg_1469E_6 = 0;
																			Color newColor = default(Color);
																			int num321 = Dust.NewDust(arg_1469E_0, arg_1469E_1, arg_1469E_2, arg_1469E_3, arg_1469E_4, arg_1469E_5, arg_1469E_6, newColor, 1f);
																			Dust expr_146B6_cp_0 = Main.dust[num321];
																			expr_146B6_cp_0.velocity.X = expr_146B6_cp_0.velocity.X * 0.5f;
																			Dust expr_146D6_cp_0 = Main.dust[num321];
																			expr_146D6_cp_0.velocity.Y = expr_146D6_cp_0.velocity.Y * 0.1f;
																		}
																		if (Main.dayTime || dead2)
																		{
																			this.velocity.Y = this.velocity.Y - 0.04f;
																			if (this.timeLeft > 10)
																			{
																				this.timeLeft = 10;
																				return;
																			}
																		}
																		else
																		{
																			if (this.ai[0] == 0f)
																			{
																				if (this.ai[1] == 0f)
																				{
																					float num322 = 7f;
																					float num323 = 0.1f;
																					int num324 = 1;
																					if (this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)Main.player[this.target].width)
																					{
																						num324 = -1;
																					}
																					Vector2 vector32 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																					float num325 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) + (float)(num324 * 300) - vector32.X;
																					float num326 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - 300f - vector32.Y;
																					float num327 = (float)Math.Sqrt((double)(num325 * num325 + num326 * num326));
																					float num328 = num327;
																					num327 = num322 / num327;
																					num325 *= num327;
																					num326 *= num327;
																					if (this.velocity.X < num325)
																					{
																						this.velocity.X = this.velocity.X + num323;
																						if (this.velocity.X < 0f && num325 > 0f)
																						{
																							this.velocity.X = this.velocity.X + num323;
																						}
																					}
																					else
																					{
																						if (this.velocity.X > num325)
																						{
																							this.velocity.X = this.velocity.X - num323;
																							if (this.velocity.X > 0f && num325 < 0f)
																							{
																								this.velocity.X = this.velocity.X - num323;
																							}
																						}
																					}
																					if (this.velocity.Y < num326)
																					{
																						this.velocity.Y = this.velocity.Y + num323;
																						if (this.velocity.Y < 0f && num326 > 0f)
																						{
																							this.velocity.Y = this.velocity.Y + num323;
																						}
																					}
																					else
																					{
																						if (this.velocity.Y > num326)
																						{
																							this.velocity.Y = this.velocity.Y - num323;
																							if (this.velocity.Y > 0f && num326 < 0f)
																							{
																								this.velocity.Y = this.velocity.Y - num323;
																							}
																						}
																					}
																					this.ai[2] += 1f;
																					if (this.ai[2] >= 600f)
																					{
																						this.ai[1] = 1f;
																						this.ai[2] = 0f;
																						this.ai[3] = 0f;
																						this.target = 255;
																						this.netUpdate = true;
																					}
																					else
																					{
																						if (this.position.Y + (float)this.height < Main.player[this.target].position.Y && num328 < 400f)
																						{
																							if (!Main.player[this.target].dead)
																							{
																								this.ai[3] += 1f;
																							}
																							if (this.ai[3] >= 60f)
																							{
																								this.ai[3] = 0f;
																								vector32 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																								num325 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector32.X;
																								num326 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector32.Y;
																								if (Main.netMode != 1)
																								{
																									float num329 = 9f;
																									int num330 = 20;
																									int num331 = 83;
																									num327 = (float)Math.Sqrt((double)(num325 * num325 + num326 * num326));
																									num327 = num329 / num327;
																									num325 *= num327;
																									num326 *= num327;
																									num325 += (float)Main.rand.Next(-40, 41) * 0.08f;
																									num326 += (float)Main.rand.Next(-40, 41) * 0.08f;
																									vector32.X += num325 * 15f;
																									vector32.Y += num326 * 15f;
																									Projectile.NewProjectile(vector32.X, vector32.Y, num325, num326, num331, num330, 0f, Main.myPlayer);
																								}
																							}
																						}
																					}
																				}
																				else
																				{
																					if (this.ai[1] == 1f)
																					{
																						this.rotation = num319;
																						float num332 = 12f;
																						Vector2 vector33 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						float num333 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector33.X;
																						float num334 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector33.Y;
																						float num335 = (float)Math.Sqrt((double)(num333 * num333 + num334 * num334));
																						num335 = num332 / num335;
																						this.velocity.X = num333 * num335;
																						this.velocity.Y = num334 * num335;
																						this.ai[1] = 2f;
																					}
																					else
																					{
																						if (this.ai[1] == 2f)
																						{
																							this.ai[2] += 1f;
																							if (this.ai[2] >= 25f)
																							{
																								this.velocity.X = this.velocity.X * 0.96f;
																								this.velocity.Y = this.velocity.Y * 0.96f;
																								if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
																								{
																									this.velocity.X = 0f;
																								}
																								if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
																								{
																									this.velocity.Y = 0f;
																								}
																							}
																							else
																							{
																								this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) - 1.57f;
																							}
																							if (this.ai[2] >= 70f)
																							{
																								this.ai[3] += 1f;
																								this.ai[2] = 0f;
																								this.target = 255;
																								this.rotation = num319;
																								if (this.ai[3] >= 4f)
																								{
																									this.ai[1] = 0f;
																									this.ai[3] = 0f;
																								}
																								else
																								{
																									this.ai[1] = 1f;
																								}
																							}
																						}
																					}
																				}
																				if ((double)this.life < (double)this.lifeMax * 0.5)
																				{
																					this.ai[0] = 1f;
																					this.ai[1] = 0f;
																					this.ai[2] = 0f;
																					this.ai[3] = 0f;
																					this.netUpdate = true;
																					return;
																				}
																			}
																			else
																			{
																				if (this.ai[0] == 1f || this.ai[0] == 2f)
																				{
																					if (this.ai[0] == 1f)
																					{
																						this.ai[2] += 0.005f;
																						if ((double)this.ai[2] > 0.5)
																						{
																							this.ai[2] = 0.5f;
																						}
																					}
																					else
																					{
																						this.ai[2] -= 0.005f;
																						if (this.ai[2] < 0f)
																						{
																							this.ai[2] = 0f;
																						}
																					}
																					this.rotation += this.ai[2];
																					this.ai[1] += 1f;
																					Color newColor;
																					if (this.ai[1] == 100f)
																					{
																						this.ai[0] += 1f;
																						this.ai[1] = 0f;
																						if (this.ai[0] == 3f)
																						{
																							this.ai[2] = 0f;
																						}
																						else
																						{
																							Main.PlaySound(3, (int)this.position.X, (int)this.position.Y, 1);
																							for (int num336 = 0; num336 < 2; num336++)
																							{
																								Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 143, 1f);
																								Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 7, 1f);
																								Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 6, 1f);
																							}
																							for (int num337 = 0; num337 < 20; num337++)
																							{
																								Vector2 arg_15288_0 = this.position;
																								int arg_15288_1 = this.width;
																								int arg_15288_2 = this.height;
																								int arg_15288_3 = 5;
																								float arg_15288_4 = (float)Main.rand.Next(-30, 31) * 0.2f;
																								float arg_15288_5 = (float)Main.rand.Next(-30, 31) * 0.2f;
																								int arg_15288_6 = 0;
																								newColor = default(Color);
																								Dust.NewDust(arg_15288_0, arg_15288_1, arg_15288_2, arg_15288_3, arg_15288_4, arg_15288_5, arg_15288_6, newColor, 1f);
																							}
																							Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
																						}
																					}
																					Vector2 arg_15311_0 = this.position;
																					int arg_15311_1 = this.width;
																					int arg_15311_2 = this.height;
																					int arg_15311_3 = 5;
																					float arg_15311_4 = (float)Main.rand.Next(-30, 31) * 0.2f;
																					float arg_15311_5 = (float)Main.rand.Next(-30, 31) * 0.2f;
																					int arg_15311_6 = 0;
																					newColor = default(Color);
																					Dust.NewDust(arg_15311_0, arg_15311_1, arg_15311_2, arg_15311_3, arg_15311_4, arg_15311_5, arg_15311_6, newColor, 1f);
																					this.velocity.X = this.velocity.X * 0.98f;
																					this.velocity.Y = this.velocity.Y * 0.98f;
																					if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
																					{
																						this.velocity.X = 0f;
																					}
																					if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
																					{
																						this.velocity.Y = 0f;
																						return;
																					}
																				}
																				else
																				{
																					this.damage = (int)((double)this.defDamage * 1.5);
																					this.defense = this.defDefense + 15;
																					this.soundHit = 4;
																					if (this.ai[1] == 0f)
																					{
																						float num338 = 8f;
																						float num339 = 0.15f;
																						Vector2 vector34 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						float num340 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector34.X;
																						float num341 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - 300f - vector34.Y;
																						float num342 = (float)Math.Sqrt((double)(num340 * num340 + num341 * num341));
																						num342 = num338 / num342;
																						num340 *= num342;
																						num341 *= num342;
																						if (this.velocity.X < num340)
																						{
																							this.velocity.X = this.velocity.X + num339;
																							if (this.velocity.X < 0f && num340 > 0f)
																							{
																								this.velocity.X = this.velocity.X + num339;
																							}
																						}
																						else
																						{
																							if (this.velocity.X > num340)
																							{
																								this.velocity.X = this.velocity.X - num339;
																								if (this.velocity.X > 0f && num340 < 0f)
																								{
																									this.velocity.X = this.velocity.X - num339;
																								}
																							}
																						}
																						if (this.velocity.Y < num341)
																						{
																							this.velocity.Y = this.velocity.Y + num339;
																							if (this.velocity.Y < 0f && num341 > 0f)
																							{
																								this.velocity.Y = this.velocity.Y + num339;
																							}
																						}
																						else
																						{
																							if (this.velocity.Y > num341)
																							{
																								this.velocity.Y = this.velocity.Y - num339;
																								if (this.velocity.Y > 0f && num341 < 0f)
																								{
																									this.velocity.Y = this.velocity.Y - num339;
																								}
																							}
																						}
																						this.ai[2] += 1f;
																						if (this.ai[2] >= 300f)
																						{
																							this.ai[1] = 1f;
																							this.ai[2] = 0f;
																							this.ai[3] = 0f;
																							this.TargetClosest(true);
																							this.netUpdate = true;
																						}
																						vector34 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						num340 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector34.X;
																						num341 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector34.Y;
																						this.rotation = (float)Math.Atan2((double)num341, (double)num340) - 1.57f;
																						if (Main.netMode != 1)
																						{
																							this.localAI[1] += 1f;
																							if ((double)this.life < (double)this.lifeMax * 0.75)
																							{
																								this.localAI[1] += 1f;
																							}
																							if ((double)this.life < (double)this.lifeMax * 0.5)
																							{
																								this.localAI[1] += 1f;
																							}
																							if ((double)this.life < (double)this.lifeMax * 0.25)
																							{
																								this.localAI[1] += 1f;
																							}
																							if ((double)this.life < (double)this.lifeMax * 0.1)
																							{
																								this.localAI[1] += 2f;
																							}
																							if (this.localAI[1] > 140f && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
																							{
																								this.localAI[1] = 0f;
																								float num343 = 9f;
																								int num344 = 25;
																								int num345 = 100;
																								num342 = (float)Math.Sqrt((double)(num340 * num340 + num341 * num341));
																								num342 = num343 / num342;
																								num340 *= num342;
																								num341 *= num342;
																								vector34.X += num340 * 15f;
																								vector34.Y += num341 * 15f;
																								Projectile.NewProjectile(vector34.X, vector34.Y, num340, num341, num345, num344, 0f, Main.myPlayer);
																								return;
																							}
																						}
																					}
																					else
																					{
																						int num346 = 1;
																						if (this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)Main.player[this.target].width)
																						{
																							num346 = -1;
																						}
																						float num347 = 8f;
																						float num348 = 0.2f;
																						Vector2 vector35 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						float num349 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) + (float)(num346 * 340) - vector35.X;
																						float num350 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector35.Y;
																						float num351 = (float)Math.Sqrt((double)(num349 * num349 + num350 * num350));
																						num351 = num347 / num351;
																						num349 *= num351;
																						num350 *= num351;
																						if (this.velocity.X < num349)
																						{
																							this.velocity.X = this.velocity.X + num348;
																							if (this.velocity.X < 0f && num349 > 0f)
																							{
																								this.velocity.X = this.velocity.X + num348;
																							}
																						}
																						else
																						{
																							if (this.velocity.X > num349)
																							{
																								this.velocity.X = this.velocity.X - num348;
																								if (this.velocity.X > 0f && num349 < 0f)
																								{
																									this.velocity.X = this.velocity.X - num348;
																								}
																							}
																						}
																						if (this.velocity.Y < num350)
																						{
																							this.velocity.Y = this.velocity.Y + num348;
																							if (this.velocity.Y < 0f && num350 > 0f)
																							{
																								this.velocity.Y = this.velocity.Y + num348;
																							}
																						}
																						else
																						{
																							if (this.velocity.Y > num350)
																							{
																								this.velocity.Y = this.velocity.Y - num348;
																								if (this.velocity.Y > 0f && num350 < 0f)
																								{
																									this.velocity.Y = this.velocity.Y - num348;
																								}
																							}
																						}
																						vector35 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						num349 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector35.X;
																						num350 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector35.Y;
																						this.rotation = (float)Math.Atan2((double)num350, (double)num349) - 1.57f;
																						if (Main.netMode != 1)
																						{
																							this.localAI[1] += 1f;
																							if ((double)this.life < (double)this.lifeMax * 0.75)
																							{
																								this.localAI[1] += 1f;
																							}
																							if ((double)this.life < (double)this.lifeMax * 0.5)
																							{
																								this.localAI[1] += 1f;
																							}
																							if ((double)this.life < (double)this.lifeMax * 0.25)
																							{
																								this.localAI[1] += 1f;
																							}
																							if ((double)this.life < (double)this.lifeMax * 0.1)
																							{
																								this.localAI[1] += 2f;
																							}
																							if (this.localAI[1] > 45f && Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
																							{
																								this.localAI[1] = 0f;
																								float num352 = 9f;
																								int num353 = 20;
																								int num354 = 100;
																								num351 = (float)Math.Sqrt((double)(num349 * num349 + num350 * num350));
																								num351 = num352 / num351;
																								num349 *= num351;
																								num350 *= num351;
																								vector35.X += num349 * 15f;
																								vector35.Y += num350 * 15f;
																								Projectile.NewProjectile(vector35.X, vector35.Y, num349, num350, num354, num353, 0f, Main.myPlayer);
																							}
																						}
																						this.ai[2] += 1f;
																						if (this.ai[2] >= 200f)
																						{
																							this.ai[1] = 0f;
																							this.ai[2] = 0f;
																							this.ai[3] = 0f;
																							this.TargetClosest(true);
																							this.netUpdate = true;
																							return;
																						}
																					}
																				}
																			}
																		}
																	}
																	else
																	{
																		if (this.aiStyle == 31)
																		{
																			if (this.target < 0 || this.target == 255 || Main.player[this.target].dead || !Main.player[this.target].active)
																			{
																				this.TargetClosest(true);
																			}
																			bool dead3 = Main.player[this.target].dead;
																			float num355 = this.position.X + (float)(this.width / 2) - Main.player[this.target].position.X - (float)(Main.player[this.target].width / 2);
																			float num356 = this.position.Y + (float)this.height - 59f - Main.player[this.target].position.Y - (float)(Main.player[this.target].height / 2);
																			float num357 = (float)Math.Atan2((double)num356, (double)num355) + 1.57f;
																			if (num357 < 0f)
																			{
																				num357 += 6.283f;
																			}
																			else
																			{
																				if ((double)num357 > 6.283)
																				{
																					num357 -= 6.283f;
																				}
																			}
																			float num358 = 0.15f;
																			if (this.rotation < num357)
																			{
																				if ((double)(num357 - this.rotation) > 3.1415)
																				{
																					this.rotation -= num358;
																				}
																				else
																				{
																					this.rotation += num358;
																				}
																			}
																			else
																			{
																				if (this.rotation > num357)
																				{
																					if ((double)(this.rotation - num357) > 3.1415)
																					{
																						this.rotation += num358;
																					}
																					else
																					{
																						this.rotation -= num358;
																					}
																				}
																			}
																			if (this.rotation > num357 - num358 && this.rotation < num357 + num358)
																			{
																				this.rotation = num357;
																			}
																			if (this.rotation < 0f)
																			{
																				this.rotation += 6.283f;
																			}
																			else
																			{
																				if ((double)this.rotation > 6.283)
																				{
																					this.rotation -= 6.283f;
																				}
																			}
																			if (this.rotation > num357 - num358 && this.rotation < num357 + num358)
																			{
																				this.rotation = num357;
																			}
																			if (Main.rand.Next(5) == 0)
																			{
																				Vector2 arg_162EF_0 = new Vector2(this.position.X, this.position.Y + (float)this.height * 0.25f);
																				int arg_162EF_1 = this.width;
																				int arg_162EF_2 = (int)((float)this.height * 0.5f);
																				int arg_162EF_3 = 5;
																				float arg_162EF_4 = this.velocity.X;
																				float arg_162EF_5 = 2f;
																				int arg_162EF_6 = 0;
																				Color newColor = default(Color);
																				int num359 = Dust.NewDust(arg_162EF_0, arg_162EF_1, arg_162EF_2, arg_162EF_3, arg_162EF_4, arg_162EF_5, arg_162EF_6, newColor, 1f);
																				Dust expr_16307_cp_0 = Main.dust[num359];
																				expr_16307_cp_0.velocity.X = expr_16307_cp_0.velocity.X * 0.5f;
																				Dust expr_16327_cp_0 = Main.dust[num359];
																				expr_16327_cp_0.velocity.Y = expr_16327_cp_0.velocity.Y * 0.1f;
																			}
																			if (Main.dayTime || dead3)
																			{
																				this.velocity.Y = this.velocity.Y - 0.04f;
																				if (this.timeLeft > 10)
																				{
																					this.timeLeft = 10;
																					return;
																				}
																			}
																			else
																			{
																				if (this.ai[0] == 0f)
																				{
																					if (this.ai[1] == 0f)
																					{
																						this.TargetClosest(true);
																						float num360 = 12f;
																						float num361 = 0.4f;
																						int num362 = 1;
																						if (this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)Main.player[this.target].width)
																						{
																							num362 = -1;
																						}
																						Vector2 vector36 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						float num363 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) + (float)(num362 * 400) - vector36.X;
																						float num364 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector36.Y;
																						float num365 = (float)Math.Sqrt((double)(num363 * num363 + num364 * num364));
																						num365 = num360 / num365;
																						num363 *= num365;
																						num364 *= num365;
																						if (this.velocity.X < num363)
																						{
																							this.velocity.X = this.velocity.X + num361;
																							if (this.velocity.X < 0f && num363 > 0f)
																							{
																								this.velocity.X = this.velocity.X + num361;
																							}
																						}
																						else
																						{
																							if (this.velocity.X > num363)
																							{
																								this.velocity.X = this.velocity.X - num361;
																								if (this.velocity.X > 0f && num363 < 0f)
																								{
																									this.velocity.X = this.velocity.X - num361;
																								}
																							}
																						}
																						if (this.velocity.Y < num364)
																						{
																							this.velocity.Y = this.velocity.Y + num361;
																							if (this.velocity.Y < 0f && num364 > 0f)
																							{
																								this.velocity.Y = this.velocity.Y + num361;
																							}
																						}
																						else
																						{
																							if (this.velocity.Y > num364)
																							{
																								this.velocity.Y = this.velocity.Y - num361;
																								if (this.velocity.Y > 0f && num364 < 0f)
																								{
																									this.velocity.Y = this.velocity.Y - num361;
																								}
																							}
																						}
																						this.ai[2] += 1f;
																						if (this.ai[2] >= 600f)
																						{
																							this.ai[1] = 1f;
																							this.ai[2] = 0f;
																							this.ai[3] = 0f;
																							this.target = 255;
																							this.netUpdate = true;
																						}
																						else
																						{
																							if (!Main.player[this.target].dead)
																							{
																								this.ai[3] += 1f;
																							}
																							if (this.ai[3] >= 60f)
																							{
																								this.ai[3] = 0f;
																								vector36 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																								num363 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector36.X;
																								num364 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector36.Y;
																								if (Main.netMode != 1)
																								{
																									float num366 = 12f;
																									int num367 = 25;
																									int num368 = 96;
																									num365 = (float)Math.Sqrt((double)(num363 * num363 + num364 * num364));
																									num365 = num366 / num365;
																									num363 *= num365;
																									num364 *= num365;
																									num363 += (float)Main.rand.Next(-40, 41) * 0.05f;
																									num364 += (float)Main.rand.Next(-40, 41) * 0.05f;
																									vector36.X += num363 * 4f;
																									vector36.Y += num364 * 4f;
																									Projectile.NewProjectile(vector36.X, vector36.Y, num363, num364, num368, num367, 0f, Main.myPlayer);
																								}
																							}
																						}
																					}
																					else
																					{
																						if (this.ai[1] == 1f)
																						{
																							this.rotation = num357;
																							float num369 = 13f;
																							Vector2 vector37 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																							float num370 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector37.X;
																							float num371 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector37.Y;
																							float num372 = (float)Math.Sqrt((double)(num370 * num370 + num371 * num371));
																							num372 = num369 / num372;
																							this.velocity.X = num370 * num372;
																							this.velocity.Y = num371 * num372;
																							this.ai[1] = 2f;
																						}
																						else
																						{
																							if (this.ai[1] == 2f)
																							{
																								this.ai[2] += 1f;
																								if (this.ai[2] >= 8f)
																								{
																									this.velocity.X = this.velocity.X * 0.9f;
																									this.velocity.Y = this.velocity.Y * 0.9f;
																									if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
																									{
																										this.velocity.X = 0f;
																									}
																									if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
																									{
																										this.velocity.Y = 0f;
																									}
																								}
																								else
																								{
																									this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) - 1.57f;
																								}
																								if (this.ai[2] >= 42f)
																								{
																									this.ai[3] += 1f;
																									this.ai[2] = 0f;
																									this.target = 255;
																									this.rotation = num357;
																									if (this.ai[3] >= 10f)
																									{
																										this.ai[1] = 0f;
																										this.ai[3] = 0f;
																									}
																									else
																									{
																										this.ai[1] = 1f;
																									}
																								}
																							}
																						}
																					}
																					if ((double)this.life < (double)this.lifeMax * 0.5)
																					{
																						this.ai[0] = 1f;
																						this.ai[1] = 0f;
																						this.ai[2] = 0f;
																						this.ai[3] = 0f;
																						this.netUpdate = true;
																						return;
																					}
																				}
																				else
																				{
																					if (this.ai[0] == 1f || this.ai[0] == 2f)
																					{
																						if (this.ai[0] == 1f)
																						{
																							this.ai[2] += 0.005f;
																							if ((double)this.ai[2] > 0.5)
																							{
																								this.ai[2] = 0.5f;
																							}
																						}
																						else
																						{
																							this.ai[2] -= 0.005f;
																							if (this.ai[2] < 0f)
																							{
																								this.ai[2] = 0f;
																							}
																						}
																						this.rotation += this.ai[2];
																						this.ai[1] += 1f;
																						Color newColor;
																						if (this.ai[1] == 100f)
																						{
																							this.ai[0] += 1f;
																							this.ai[1] = 0f;
																							if (this.ai[0] == 3f)
																							{
																								this.ai[2] = 0f;
																							}
																							else
																							{
																								Main.PlaySound(3, (int)this.position.X, (int)this.position.Y, 1);
																								for (int num373 = 0; num373 < 2; num373++)
																								{
																									Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 144, 1f);
																									Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 7, 1f);
																									Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 6, 1f);
																								}
																								for (int num374 = 0; num374 < 20; num374++)
																								{
																									Vector2 arg_16E96_0 = this.position;
																									int arg_16E96_1 = this.width;
																									int arg_16E96_2 = this.height;
																									int arg_16E96_3 = 5;
																									float arg_16E96_4 = (float)Main.rand.Next(-30, 31) * 0.2f;
																									float arg_16E96_5 = (float)Main.rand.Next(-30, 31) * 0.2f;
																									int arg_16E96_6 = 0;
																									newColor = default(Color);
																									Dust.NewDust(arg_16E96_0, arg_16E96_1, arg_16E96_2, arg_16E96_3, arg_16E96_4, arg_16E96_5, arg_16E96_6, newColor, 1f);
																								}
																								Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
																							}
																						}
																						Vector2 arg_16F1F_0 = this.position;
																						int arg_16F1F_1 = this.width;
																						int arg_16F1F_2 = this.height;
																						int arg_16F1F_3 = 5;
																						float arg_16F1F_4 = (float)Main.rand.Next(-30, 31) * 0.2f;
																						float arg_16F1F_5 = (float)Main.rand.Next(-30, 31) * 0.2f;
																						int arg_16F1F_6 = 0;
																						newColor = default(Color);
																						Dust.NewDust(arg_16F1F_0, arg_16F1F_1, arg_16F1F_2, arg_16F1F_3, arg_16F1F_4, arg_16F1F_5, arg_16F1F_6, newColor, 1f);
																						this.velocity.X = this.velocity.X * 0.98f;
																						this.velocity.Y = this.velocity.Y * 0.98f;
																						if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
																						{
																							this.velocity.X = 0f;
																						}
																						if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
																						{
																							this.velocity.Y = 0f;
																							return;
																						}
																					}
																					else
																					{
																						this.soundHit = 4;
																						this.damage = (int)((double)this.defDamage * 1.5);
																						this.defense = this.defDefense + 25;
																						if (this.ai[1] == 0f)
																						{
																							float num375 = 4f;
																							float num376 = 0.1f;
																							int num377 = 1;
																							if (this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)Main.player[this.target].width)
																							{
																								num377 = -1;
																							}
																							Vector2 vector38 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																							float num378 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) + (float)(num377 * 180) - vector38.X;
																							float num379 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector38.Y;
																							float num380 = (float)Math.Sqrt((double)(num378 * num378 + num379 * num379));
																							num380 = num375 / num380;
																							num378 *= num380;
																							num379 *= num380;
																							if (this.velocity.X < num378)
																							{
																								this.velocity.X = this.velocity.X + num376;
																								if (this.velocity.X < 0f && num378 > 0f)
																								{
																									this.velocity.X = this.velocity.X + num376;
																								}
																							}
																							else
																							{
																								if (this.velocity.X > num378)
																								{
																									this.velocity.X = this.velocity.X - num376;
																									if (this.velocity.X > 0f && num378 < 0f)
																									{
																										this.velocity.X = this.velocity.X - num376;
																									}
																								}
																							}
																							if (this.velocity.Y < num379)
																							{
																								this.velocity.Y = this.velocity.Y + num376;
																								if (this.velocity.Y < 0f && num379 > 0f)
																								{
																									this.velocity.Y = this.velocity.Y + num376;
																								}
																							}
																							else
																							{
																								if (this.velocity.Y > num379)
																								{
																									this.velocity.Y = this.velocity.Y - num376;
																									if (this.velocity.Y > 0f && num379 < 0f)
																									{
																										this.velocity.Y = this.velocity.Y - num376;
																									}
																								}
																							}
																							this.ai[2] += 1f;
																							if (this.ai[2] >= 400f)
																							{
																								this.ai[1] = 1f;
																								this.ai[2] = 0f;
																								this.ai[3] = 0f;
																								this.target = 255;
																								this.netUpdate = true;
																							}
																							if (Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
																							{
																								this.localAI[2] += 1f;
																								if (this.localAI[2] > 22f)
																								{
																									this.localAI[2] = 0f;
																									Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 34);
																								}
																								if (Main.netMode != 1)
																								{
																									this.localAI[1] += 1f;
																									if ((double)this.life < (double)this.lifeMax * 0.75)
																									{
																										this.localAI[1] += 1f;
																									}
																									if ((double)this.life < (double)this.lifeMax * 0.5)
																									{
																										this.localAI[1] += 1f;
																									}
																									if ((double)this.life < (double)this.lifeMax * 0.25)
																									{
																										this.localAI[1] += 1f;
																									}
																									if ((double)this.life < (double)this.lifeMax * 0.1)
																									{
																										this.localAI[1] += 2f;
																									}
																									if (this.localAI[1] > 8f)
																									{
																										this.localAI[1] = 0f;
																										float num381 = 6f;
																										int num382 = 30;
																										int num383 = 101;
																										vector38 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																										num378 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector38.X;
																										num379 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector38.Y;
																										num380 = (float)Math.Sqrt((double)(num378 * num378 + num379 * num379));
																										num380 = num381 / num380;
																										num378 *= num380;
																										num379 *= num380;
																										num379 += (float)Main.rand.Next(-40, 41) * 0.01f;
																										num378 += (float)Main.rand.Next(-40, 41) * 0.01f;
																										num379 += this.velocity.Y * 0.5f;
																										num378 += this.velocity.X * 0.5f;
																										vector38.X -= num378 * 1f;
																										vector38.Y -= num379 * 1f;
																										Projectile.NewProjectile(vector38.X, vector38.Y, num378, num379, num383, num382, 0f, Main.myPlayer);
																										return;
																									}
																								}
																							}
																						}
																						else
																						{
																							if (this.ai[1] == 1f)
																							{
																								Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
																								this.rotation = num357;
																								float num384 = 14f;
																								Vector2 vector39 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																								float num385 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector39.X;
																								float num386 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector39.Y;
																								float num387 = (float)Math.Sqrt((double)(num385 * num385 + num386 * num386));
																								num387 = num384 / num387;
																								this.velocity.X = num385 * num387;
																								this.velocity.Y = num386 * num387;
																								this.ai[1] = 2f;
																								return;
																							}
																							if (this.ai[1] == 2f)
																							{
																								this.ai[2] += 1f;
																								if (this.ai[2] >= 50f)
																								{
																									this.velocity.X = this.velocity.X * 0.93f;
																									this.velocity.Y = this.velocity.Y * 0.93f;
																									if ((double)this.velocity.X > -0.1 && (double)this.velocity.X < 0.1)
																									{
																										this.velocity.X = 0f;
																									}
																									if ((double)this.velocity.Y > -0.1 && (double)this.velocity.Y < 0.1)
																									{
																										this.velocity.Y = 0f;
																									}
																								}
																								else
																								{
																									this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) - 1.57f;
																								}
																								if (this.ai[2] >= 80f)
																								{
																									this.ai[3] += 1f;
																									this.ai[2] = 0f;
																									this.target = 255;
																									this.rotation = num357;
																									if (this.ai[3] >= 6f)
																									{
																										this.ai[1] = 0f;
																										this.ai[3] = 0f;
																										return;
																									}
																									this.ai[1] = 1f;
																									return;
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		else
																		{
																			if (this.aiStyle == 32)
																			{
																				this.damage = this.defDamage;
																				this.defense = this.defDefense;
																				if (this.ai[0] == 0f && Main.netMode != 1)
																				{
																					this.TargetClosest(true);
																					this.ai[0] = 1f;
																					if (this.type != 68)
																					{
																						int num388 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)this.position.Y + this.height / 2, 128, this.whoAmI);
																						Main.npc[num388].ai[0] = -1f;
																						Main.npc[num388].ai[1] = (float)this.whoAmI;
																						Main.npc[num388].target = this.target;
																						Main.npc[num388].netUpdate = true;
																						num388 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)this.position.Y + this.height / 2, 129, this.whoAmI);
																						Main.npc[num388].ai[0] = 1f;
																						Main.npc[num388].ai[1] = (float)this.whoAmI;
																						Main.npc[num388].target = this.target;
																						Main.npc[num388].netUpdate = true;
																						num388 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)this.position.Y + this.height / 2, 130, this.whoAmI);
																						Main.npc[num388].ai[0] = -1f;
																						Main.npc[num388].ai[1] = (float)this.whoAmI;
																						Main.npc[num388].target = this.target;
																						Main.npc[num388].ai[3] = 150f;
																						Main.npc[num388].netUpdate = true;
																						num388 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)this.position.Y + this.height / 2, 131, this.whoAmI);
																						Main.npc[num388].ai[0] = 1f;
																						Main.npc[num388].ai[1] = (float)this.whoAmI;
																						Main.npc[num388].target = this.target;
																						Main.npc[num388].netUpdate = true;
																						Main.npc[num388].ai[3] = 150f;
																					}
																				}
																				if (this.type == 68 && this.ai[1] != 3f && this.ai[1] != 2f)
																				{
																					Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
																					this.ai[1] = 2f;
																				}
																				if (Main.player[this.target].dead || Math.Abs(this.position.X - Main.player[this.target].position.X) > 6000f || Math.Abs(this.position.Y - Main.player[this.target].position.Y) > 6000f)
																				{
																					this.TargetClosest(true);
																					if (Main.player[this.target].dead || Math.Abs(this.position.X - Main.player[this.target].position.X) > 6000f || Math.Abs(this.position.Y - Main.player[this.target].position.Y) > 6000f)
																					{
																						this.ai[1] = 3f;
																					}
																				}
																				if (Main.dayTime && this.ai[1] != 3f && this.ai[1] != 2f)
																				{
																					this.ai[1] = 2f;
																					Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
																				}
																				if (this.ai[1] == 0f)
																				{
																					this.ai[2] += 1f;
																					if (this.ai[2] >= 600f)
																					{
																						this.ai[2] = 0f;
																						this.ai[1] = 1f;
																						this.TargetClosest(true);
																						this.netUpdate = true;
																					}
																					this.rotation = this.velocity.X / 15f;
																					if (this.position.Y > Main.player[this.target].position.Y - 200f)
																					{
																						if (this.velocity.Y > 0f)
																						{
																							this.velocity.Y = this.velocity.Y * 0.98f;
																						}
																						this.velocity.Y = this.velocity.Y - 0.1f;
																						if (this.velocity.Y > 2f)
																						{
																							this.velocity.Y = 2f;
																						}
																					}
																					else
																					{
																						if (this.position.Y < Main.player[this.target].position.Y - 500f)
																						{
																							if (this.velocity.Y < 0f)
																							{
																								this.velocity.Y = this.velocity.Y * 0.98f;
																							}
																							this.velocity.Y = this.velocity.Y + 0.1f;
																							if (this.velocity.Y < -2f)
																							{
																								this.velocity.Y = -2f;
																							}
																						}
																					}
																					if (this.position.X + (float)(this.width / 2) > Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) + 100f)
																					{
																						if (this.velocity.X > 0f)
																						{
																							this.velocity.X = this.velocity.X * 0.98f;
																						}
																						this.velocity.X = this.velocity.X - 0.1f;
																						if (this.velocity.X > 8f)
																						{
																							this.velocity.X = 8f;
																						}
																					}
																					if (this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - 100f)
																					{
																						if (this.velocity.X < 0f)
																						{
																							this.velocity.X = this.velocity.X * 0.98f;
																						}
																						this.velocity.X = this.velocity.X + 0.1f;
																						if (this.velocity.X < -8f)
																						{
																							this.velocity.X = -8f;
																							return;
																						}
																					}
																				}
																				else
																				{
																					if (this.ai[1] == 1f)
																					{
																						this.defense *= 2;
																						this.damage *= 2;
																						this.ai[2] += 1f;
																						if (this.ai[2] == 2f)
																						{
																							Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
																						}
																						if (this.ai[2] >= 400f)
																						{
																							this.ai[2] = 0f;
																							this.ai[1] = 0f;
																						}
																						this.rotation += (float)this.direction * 0.3f;
																						Vector2 vector40 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						float num389 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector40.X;
																						float num390 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector40.Y;
																						float num391 = (float)Math.Sqrt((double)(num389 * num389 + num390 * num390));
																						num391 = 2f / num391;
																						this.velocity.X = num389 * num391;
																						this.velocity.Y = num390 * num391;
																						return;
																					}
																					if (this.ai[1] == 2f)
																					{
																						this.damage = 9999;
																						this.defense = 9999;
																						this.rotation += (float)this.direction * 0.3f;
																						Vector2 vector41 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						float num392 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector41.X;
																						float num393 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector41.Y;
																						float num394 = (float)Math.Sqrt((double)(num392 * num392 + num393 * num393));
																						num394 = 8f / num394;
																						this.velocity.X = num392 * num394;
																						this.velocity.Y = num393 * num394;
																						return;
																					}
																					if (this.ai[1] == 3f)
																					{
																						this.velocity.Y = this.velocity.Y + 0.1f;
																						if (this.velocity.Y < 0f)
																						{
																							this.velocity.Y = this.velocity.Y * 0.95f;
																						}
																						this.velocity.X = this.velocity.X * 0.95f;
																						if (this.timeLeft > 500)
																						{
																							this.timeLeft = 500;
																							return;
																						}
																					}
																				}
																			}
																			else
																			{
																				if (this.aiStyle == 33)
																				{
																					Vector2 vector42 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																					float num395 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector42.X;
																					float num396 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector42.Y;
																					float num397 = (float)Math.Sqrt((double)(num395 * num395 + num396 * num396));
																					if (this.ai[2] != 99f)
																					{
																						if (num397 > 800f)
																						{
																							this.ai[2] = 99f;
																						}
																					}
																					else
																					{
																						if (num397 < 400f)
																						{
																							this.ai[2] = 0f;
																						}
																					}
																					this.spriteDirection = -(int)this.ai[0];
																					if (!Main.npc[(int)this.ai[1]].active || Main.npc[(int)this.ai[1]].aiStyle != 32)
																					{
																						this.ai[2] += 10f;
																						if (this.ai[2] > 50f || Main.netMode != 2)
																						{
																							this.life = -1;
																							this.HitEffect(0, 10.0);
																							this.active = false;
																						}
																					}
																					if (this.ai[2] == 99f)
																					{
																						if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y)
																						{
																							if (this.velocity.Y > 0f)
																							{
																								this.velocity.Y = this.velocity.Y * 0.96f;
																							}
																							this.velocity.Y = this.velocity.Y - 0.1f;
																							if (this.velocity.Y > 8f)
																							{
																								this.velocity.Y = 8f;
																							}
																						}
																						else
																						{
																							if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y)
																							{
																								if (this.velocity.Y < 0f)
																								{
																									this.velocity.Y = this.velocity.Y * 0.96f;
																								}
																								this.velocity.Y = this.velocity.Y + 0.1f;
																								if (this.velocity.Y < -8f)
																								{
																									this.velocity.Y = -8f;
																								}
																							}
																						}
																						if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2))
																						{
																							if (this.velocity.X > 0f)
																							{
																								this.velocity.X = this.velocity.X * 0.96f;
																							}
																							this.velocity.X = this.velocity.X - 0.5f;
																							if (this.velocity.X > 12f)
																							{
																								this.velocity.X = 12f;
																							}
																						}
																						if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2))
																						{
																							if (this.velocity.X < 0f)
																							{
																								this.velocity.X = this.velocity.X * 0.96f;
																							}
																							this.velocity.X = this.velocity.X + 0.5f;
																							if (this.velocity.X < -12f)
																							{
																								this.velocity.X = -12f;
																								return;
																							}
																						}
																					}
																					else
																					{
																						if (this.ai[2] == 0f || this.ai[2] == 3f)
																						{
																							if (Main.npc[(int)this.ai[1]].ai[1] == 3f && this.timeLeft > 10)
																							{
																								this.timeLeft = 10;
																							}
																							if (Main.npc[(int)this.ai[1]].ai[1] != 0f)
																							{
																								this.TargetClosest(true);
																								if (Main.player[this.target].dead)
																								{
																									this.velocity.Y = this.velocity.Y + 0.1f;
																									if (this.velocity.Y > 16f)
																									{
																										this.velocity.Y = 16f;
																									}
																								}
																								else
																								{
																									Vector2 vector43 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									float num398 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector43.X;
																									float num399 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector43.Y;
																									float num400 = (float)Math.Sqrt((double)(num398 * num398 + num399 * num399));
																									num400 = 7f / num400;
																									num398 *= num400;
																									num399 *= num400;
																									this.rotation = (float)Math.Atan2((double)num399, (double)num398) - 1.57f;
																									if (this.velocity.X > num398)
																									{
																										if (this.velocity.X > 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.97f;
																										}
																										this.velocity.X = this.velocity.X - 0.05f;
																									}
																									if (this.velocity.X < num398)
																									{
																										if (this.velocity.X < 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.97f;
																										}
																										this.velocity.X = this.velocity.X + 0.05f;
																									}
																									if (this.velocity.Y > num399)
																									{
																										if (this.velocity.Y > 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.97f;
																										}
																										this.velocity.Y = this.velocity.Y - 0.05f;
																									}
																									if (this.velocity.Y < num399)
																									{
																										if (this.velocity.Y < 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.97f;
																										}
																										this.velocity.Y = this.velocity.Y + 0.05f;
																									}
																								}
																								this.ai[3] += 1f;
																								if (this.ai[3] >= 600f)
																								{
																									this.ai[2] = 0f;
																									this.ai[3] = 0f;
																									this.netUpdate = true;
																								}
																							}
																							else
																							{
																								this.ai[3] += 1f;
																								if (this.ai[3] >= 300f)
																								{
																									this.ai[2] += 1f;
																									this.ai[3] = 0f;
																									this.netUpdate = true;
																								}
																								if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y + 320f)
																								{
																									if (this.velocity.Y > 0f)
																									{
																										this.velocity.Y = this.velocity.Y * 0.96f;
																									}
																									this.velocity.Y = this.velocity.Y - 0.04f;
																									if (this.velocity.Y > 3f)
																									{
																										this.velocity.Y = 3f;
																									}
																								}
																								else
																								{
																									if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y + 260f)
																									{
																										if (this.velocity.Y < 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.96f;
																										}
																										this.velocity.Y = this.velocity.Y + 0.04f;
																										if (this.velocity.Y < -3f)
																										{
																											this.velocity.Y = -3f;
																										}
																									}
																								}
																								if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2))
																								{
																									if (this.velocity.X > 0f)
																									{
																										this.velocity.X = this.velocity.X * 0.96f;
																									}
																									this.velocity.X = this.velocity.X - 0.3f;
																									if (this.velocity.X > 12f)
																									{
																										this.velocity.X = 12f;
																									}
																								}
																								if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 250f)
																								{
																									if (this.velocity.X < 0f)
																									{
																										this.velocity.X = this.velocity.X * 0.96f;
																									}
																									this.velocity.X = this.velocity.X + 0.3f;
																									if (this.velocity.X < -12f)
																									{
																										this.velocity.X = -12f;
																									}
																								}
																							}
																							Vector2 vector44 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																							float num401 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector44.X;
																							float num402 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector44.Y;
																							Math.Sqrt((double)(num401 * num401 + num402 * num402));
																							this.rotation = (float)Math.Atan2((double)num402, (double)num401) + 1.57f;
																							return;
																						}
																						if (this.ai[2] == 1f)
																						{
																							Vector2 vector45 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																							float num403 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector45.X;
																							float num404 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector45.Y;
																							float num405 = (float)Math.Sqrt((double)(num403 * num403 + num404 * num404));
																							this.rotation = (float)Math.Atan2((double)num404, (double)num403) + 1.57f;
																							this.velocity.X = this.velocity.X * 0.95f;
																							this.velocity.Y = this.velocity.Y - 0.1f;
																							if (this.velocity.Y < -8f)
																							{
																								this.velocity.Y = -8f;
																							}
																							if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 200f)
																							{
																								this.TargetClosest(true);
																								this.ai[2] = 2f;
																								vector45 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																								num403 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector45.X;
																								num404 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector45.Y;
																								num405 = (float)Math.Sqrt((double)(num403 * num403 + num404 * num404));
																								num405 = 22f / num405;
																								this.velocity.X = num403 * num405;
																								this.velocity.Y = num404 * num405;
																								this.netUpdate = true;
																								return;
																							}
																						}
																						else
																						{
																							if (this.ai[2] == 2f)
																							{
																								if (this.position.Y > Main.player[this.target].position.Y || this.velocity.Y < 0f)
																								{
																									this.ai[2] = 3f;
																									return;
																								}
																							}
																							else
																							{
																								if (this.ai[2] == 4f)
																								{
																									this.TargetClosest(true);
																									Vector2 vector46 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									float num406 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector46.X;
																									float num407 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector46.Y;
																									float num408 = (float)Math.Sqrt((double)(num406 * num406 + num407 * num407));
																									num408 = 7f / num408;
																									num406 *= num408;
																									num407 *= num408;
																									if (this.velocity.X > num406)
																									{
																										if (this.velocity.X > 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.97f;
																										}
																										this.velocity.X = this.velocity.X - 0.05f;
																									}
																									if (this.velocity.X < num406)
																									{
																										if (this.velocity.X < 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.97f;
																										}
																										this.velocity.X = this.velocity.X + 0.05f;
																									}
																									if (this.velocity.Y > num407)
																									{
																										if (this.velocity.Y > 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.97f;
																										}
																										this.velocity.Y = this.velocity.Y - 0.05f;
																									}
																									if (this.velocity.Y < num407)
																									{
																										if (this.velocity.Y < 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.97f;
																										}
																										this.velocity.Y = this.velocity.Y + 0.05f;
																									}
																									this.ai[3] += 1f;
																									if (this.ai[3] >= 600f)
																									{
																										this.ai[2] = 0f;
																										this.ai[3] = 0f;
																										this.netUpdate = true;
																									}
																									vector46 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									num406 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector46.X;
																									num407 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector46.Y;
																									num408 = (float)Math.Sqrt((double)(num406 * num406 + num407 * num407));
																									this.rotation = (float)Math.Atan2((double)num407, (double)num406) + 1.57f;
																									return;
																								}
																								if (this.ai[2] == 5f && ((this.velocity.X > 0f && this.position.X + (float)(this.width / 2) > Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2)) || (this.velocity.X < 0f && this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2))))
																								{
																									this.ai[2] = 0f;
																									return;
																								}
																							}
																						}
																					}
																				}
																				else
																				{
																					if (this.aiStyle == 34)
																					{
																						this.spriteDirection = -(int)this.ai[0];
																						Vector2 vector47 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																						float num409 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector47.X;
																						float num410 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector47.Y;
																						float num411 = (float)Math.Sqrt((double)(num409 * num409 + num410 * num410));
																						if (this.ai[2] != 99f)
																						{
																							if (num411 > 800f)
																							{
																								this.ai[2] = 99f;
																							}
																						}
																						else
																						{
																							if (num411 < 400f)
																							{
																								this.ai[2] = 0f;
																							}
																						}
																						if (!Main.npc[(int)this.ai[1]].active || Main.npc[(int)this.ai[1]].aiStyle != 32)
																						{
																							this.ai[2] += 10f;
																							if (this.ai[2] > 50f || Main.netMode != 2)
																							{
																								this.life = -1;
																								this.HitEffect(0, 10.0);
																								this.active = false;
																							}
																						}
																						if (this.ai[2] == 99f)
																						{
																							if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y)
																							{
																								if (this.velocity.Y > 0f)
																								{
																									this.velocity.Y = this.velocity.Y * 0.96f;
																								}
																								this.velocity.Y = this.velocity.Y - 0.1f;
																								if (this.velocity.Y > 8f)
																								{
																									this.velocity.Y = 8f;
																								}
																							}
																							else
																							{
																								if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y)
																								{
																									if (this.velocity.Y < 0f)
																									{
																										this.velocity.Y = this.velocity.Y * 0.96f;
																									}
																									this.velocity.Y = this.velocity.Y + 0.1f;
																									if (this.velocity.Y < -8f)
																									{
																										this.velocity.Y = -8f;
																									}
																								}
																							}
																							if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2))
																							{
																								if (this.velocity.X > 0f)
																								{
																									this.velocity.X = this.velocity.X * 0.96f;
																								}
																								this.velocity.X = this.velocity.X - 0.5f;
																								if (this.velocity.X > 12f)
																								{
																									this.velocity.X = 12f;
																								}
																							}
																							if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2))
																							{
																								if (this.velocity.X < 0f)
																								{
																									this.velocity.X = this.velocity.X * 0.96f;
																								}
																								this.velocity.X = this.velocity.X + 0.5f;
																								if (this.velocity.X < -12f)
																								{
																									this.velocity.X = -12f;
																									return;
																								}
																							}
																						}
																						else
																						{
																							if (this.ai[2] == 0f || this.ai[2] == 3f)
																							{
																								if (Main.npc[(int)this.ai[1]].ai[1] == 3f && this.timeLeft > 10)
																								{
																									this.timeLeft = 10;
																								}
																								if (Main.npc[(int)this.ai[1]].ai[1] != 0f)
																								{
																									this.TargetClosest(true);
																									this.TargetClosest(true);
																									if (Main.player[this.target].dead)
																									{
																										this.velocity.Y = this.velocity.Y + 0.1f;
																										if (this.velocity.Y > 16f)
																										{
																											this.velocity.Y = 16f;
																										}
																									}
																									else
																									{
																										Vector2 vector48 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																										float num412 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector48.X;
																										float num413 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector48.Y;
																										float num414 = (float)Math.Sqrt((double)(num412 * num412 + num413 * num413));
																										num414 = 12f / num414;
																										num412 *= num414;
																										num413 *= num414;
																										this.rotation = (float)Math.Atan2((double)num413, (double)num412) - 1.57f;
																										if (Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y) < 2f)
																										{
																											this.rotation = (float)Math.Atan2((double)num413, (double)num412) - 1.57f;
																											this.velocity.X = num412;
																											this.velocity.Y = num413;
																											this.netUpdate = true;
																										}
																										else
																										{
																											this.velocity *= 0.97f;
																										}
																										this.ai[3] += 1f;
																										if (this.ai[3] >= 600f)
																										{
																											this.ai[2] = 0f;
																											this.ai[3] = 0f;
																											this.netUpdate = true;
																										}
																									}
																								}
																								else
																								{
																									this.ai[3] += 1f;
																									if (this.ai[3] >= 600f)
																									{
																										this.ai[2] += 1f;
																										this.ai[3] = 0f;
																										this.netUpdate = true;
																									}
																									if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y + 300f)
																									{
																										if (this.velocity.Y > 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.96f;
																										}
																										this.velocity.Y = this.velocity.Y - 0.1f;
																										if (this.velocity.Y > 3f)
																										{
																											this.velocity.Y = 3f;
																										}
																									}
																									else
																									{
																										if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y + 230f)
																										{
																											if (this.velocity.Y < 0f)
																											{
																												this.velocity.Y = this.velocity.Y * 0.96f;
																											}
																											this.velocity.Y = this.velocity.Y + 0.1f;
																											if (this.velocity.Y < -3f)
																											{
																												this.velocity.Y = -3f;
																											}
																										}
																									}
																									if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) + 250f)
																									{
																										if (this.velocity.X > 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.94f;
																										}
																										this.velocity.X = this.velocity.X - 0.3f;
																										if (this.velocity.X > 9f)
																										{
																											this.velocity.X = 9f;
																										}
																									}
																									if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2))
																									{
																										if (this.velocity.X < 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.94f;
																										}
																										this.velocity.X = this.velocity.X + 0.2f;
																										if (this.velocity.X < -8f)
																										{
																											this.velocity.X = -8f;
																										}
																									}
																								}
																								Vector2 vector49 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																								float num415 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector49.X;
																								float num416 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector49.Y;
																								Math.Sqrt((double)(num415 * num415 + num416 * num416));
																								this.rotation = (float)Math.Atan2((double)num416, (double)num415) + 1.57f;
																								return;
																							}
																							if (this.ai[2] == 1f)
																							{
																								if (this.velocity.Y > 0f)
																								{
																									this.velocity.Y = this.velocity.Y * 0.9f;
																								}
																								Vector2 vector50 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																								float num417 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 280f * this.ai[0] - vector50.X;
																								float num418 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector50.Y;
																								float num419 = (float)Math.Sqrt((double)(num417 * num417 + num418 * num418));
																								this.rotation = (float)Math.Atan2((double)num418, (double)num417) + 1.57f;
																								this.velocity.X = (this.velocity.X * 5f + Main.npc[(int)this.ai[1]].velocity.X) / 6f;
																								this.velocity.X = this.velocity.X + 0.5f;
																								this.velocity.Y = this.velocity.Y - 0.5f;
																								if (this.velocity.Y < -9f)
																								{
																									this.velocity.Y = -9f;
																								}
																								if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 280f)
																								{
																									this.TargetClosest(true);
																									this.ai[2] = 2f;
																									vector50 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									num417 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector50.X;
																									num418 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector50.Y;
																									num419 = (float)Math.Sqrt((double)(num417 * num417 + num418 * num418));
																									num419 = 20f / num419;
																									this.velocity.X = num417 * num419;
																									this.velocity.Y = num418 * num419;
																									this.netUpdate = true;
																									return;
																								}
																							}
																							else
																							{
																								if (this.ai[2] == 2f)
																								{
																									if (this.position.Y > Main.player[this.target].position.Y || this.velocity.Y < 0f)
																									{
																										if (this.ai[3] >= 4f)
																										{
																											this.ai[2] = 3f;
																											this.ai[3] = 0f;
																											return;
																										}
																										this.ai[2] = 1f;
																										this.ai[3] += 1f;
																										return;
																									}
																								}
																								else
																								{
																									if (this.ai[2] == 4f)
																									{
																										Vector2 vector51 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																										float num420 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector51.X;
																										float num421 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector51.Y;
																										float num422 = (float)Math.Sqrt((double)(num420 * num420 + num421 * num421));
																										this.rotation = (float)Math.Atan2((double)num421, (double)num420) + 1.57f;
																										this.velocity.Y = (this.velocity.Y * 5f + Main.npc[(int)this.ai[1]].velocity.Y) / 6f;
																										this.velocity.X = this.velocity.X + 0.5f;
																										if (this.velocity.X > 12f)
																										{
																											this.velocity.X = 12f;
																										}
																										if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 500f || this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) + 500f)
																										{
																											this.TargetClosest(true);
																											this.ai[2] = 5f;
																											vector51 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																											num420 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector51.X;
																											num421 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector51.Y;
																											num422 = (float)Math.Sqrt((double)(num420 * num420 + num421 * num421));
																											num422 = 17f / num422;
																											this.velocity.X = num420 * num422;
																											this.velocity.Y = num421 * num422;
																											this.netUpdate = true;
																											return;
																										}
																									}
																									else
																									{
																										if (this.ai[2] == 5f && this.position.X + (float)(this.width / 2) < Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - 100f)
																										{
																											if (this.ai[3] >= 4f)
																											{
																												this.ai[2] = 0f;
																												this.ai[3] = 0f;
																												return;
																											}
																											this.ai[2] = 4f;
																											this.ai[3] += 1f;
																											return;
																										}
																									}
																								}
																							}
																						}
																					}
																					else
																					{
																						if (this.aiStyle == 35)
																						{
																							this.spriteDirection = -(int)this.ai[0];
																							if (!Main.npc[(int)this.ai[1]].active || Main.npc[(int)this.ai[1]].aiStyle != 32)
																							{
																								this.ai[2] += 10f;
																								if (this.ai[2] > 50f || Main.netMode != 2)
																								{
																									this.life = -1;
																									this.HitEffect(0, 10.0);
																									this.active = false;
																								}
																							}
																							if (this.ai[2] == 0f)
																							{
																								if (Main.npc[(int)this.ai[1]].ai[1] == 3f && this.timeLeft > 10)
																								{
																									this.timeLeft = 10;
																								}
																								if (Main.npc[(int)this.ai[1]].ai[1] != 0f)
																								{
																									this.localAI[0] += 2f;
																									if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y - 100f)
																									{
																										if (this.velocity.Y > 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.96f;
																										}
																										this.velocity.Y = this.velocity.Y - 0.07f;
																										if (this.velocity.Y > 6f)
																										{
																											this.velocity.Y = 6f;
																										}
																									}
																									else
																									{
																										if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 100f)
																										{
																											if (this.velocity.Y < 0f)
																											{
																												this.velocity.Y = this.velocity.Y * 0.96f;
																											}
																											this.velocity.Y = this.velocity.Y + 0.07f;
																											if (this.velocity.Y < -6f)
																											{
																												this.velocity.Y = -6f;
																											}
																										}
																									}
																									if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 120f * this.ai[0])
																									{
																										if (this.velocity.X > 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.96f;
																										}
																										this.velocity.X = this.velocity.X - 0.1f;
																										if (this.velocity.X > 8f)
																										{
																											this.velocity.X = 8f;
																										}
																									}
																									if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 120f * this.ai[0])
																									{
																										if (this.velocity.X < 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.96f;
																										}
																										this.velocity.X = this.velocity.X + 0.1f;
																										if (this.velocity.X < -8f)
																										{
																											this.velocity.X = -8f;
																										}
																									}
																								}
																								else
																								{
																									this.ai[3] += 1f;
																									if (this.ai[3] >= 1100f)
																									{
																										this.localAI[0] = 0f;
																										this.ai[2] = 1f;
																										this.ai[3] = 0f;
																										this.netUpdate = true;
																									}
																									if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y - 150f)
																									{
																										if (this.velocity.Y > 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.96f;
																										}
																										this.velocity.Y = this.velocity.Y - 0.04f;
																										if (this.velocity.Y > 3f)
																										{
																											this.velocity.Y = 3f;
																										}
																									}
																									else
																									{
																										if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 150f)
																										{
																											if (this.velocity.Y < 0f)
																											{
																												this.velocity.Y = this.velocity.Y * 0.96f;
																											}
																											this.velocity.Y = this.velocity.Y + 0.04f;
																											if (this.velocity.Y < -3f)
																											{
																												this.velocity.Y = -3f;
																											}
																										}
																									}
																									if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) + 200f)
																									{
																										if (this.velocity.X > 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.96f;
																										}
																										this.velocity.X = this.velocity.X - 0.2f;
																										if (this.velocity.X > 8f)
																										{
																											this.velocity.X = 8f;
																										}
																									}
																									if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) + 160f)
																									{
																										if (this.velocity.X < 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.96f;
																										}
																										this.velocity.X = this.velocity.X + 0.2f;
																										if (this.velocity.X < -8f)
																										{
																											this.velocity.X = -8f;
																										}
																									}
																								}
																								Vector2 vector52 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																								float num423 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 200f * this.ai[0] - vector52.X;
																								float num424 = Main.npc[(int)this.ai[1]].position.Y + 230f - vector52.Y;
																								float num425 = (float)Math.Sqrt((double)(num423 * num423 + num424 * num424));
																								this.rotation = (float)Math.Atan2((double)num424, (double)num423) + 1.57f;
																								if (Main.netMode != 1)
																								{
																									this.localAI[0] += 1f;
																									if (this.localAI[0] > 140f)
																									{
																										this.localAI[0] = 0f;
																										float num426 = 12f;
																										int num427 = 0;
																										int num428 = 102;
																										num425 = num426 / num425;
																										num423 = -num423 * num425;
																										num424 = -num424 * num425;
																										num423 += (float)Main.rand.Next(-40, 41) * 0.01f;
																										num424 += (float)Main.rand.Next(-40, 41) * 0.01f;
																										vector52.X += num423 * 4f;
																										vector52.Y += num424 * 4f;
																										Projectile.NewProjectile(vector52.X, vector52.Y, num423, num424, num428, num427, 0f, Main.myPlayer);
																										return;
																									}
																								}
																							}
																							else
																							{
																								if (this.ai[2] == 1f)
																								{
																									this.ai[3] += 1f;
																									if (this.ai[3] >= 300f)
																									{
																										this.localAI[0] = 0f;
																										this.ai[2] = 0f;
																										this.ai[3] = 0f;
																										this.netUpdate = true;
																									}
																									Vector2 vector53 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									float num429 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - vector53.X;
																									float num430 = Main.npc[(int)this.ai[1]].position.Y - vector53.Y;
																									num430 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - 80f - vector53.Y;
																									float num431 = (float)Math.Sqrt((double)(num429 * num429 + num430 * num430));
																									num431 = 6f / num431;
																									num429 *= num431;
																									num430 *= num431;
																									if (this.velocity.X > num429)
																									{
																										if (this.velocity.X > 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.9f;
																										}
																										this.velocity.X = this.velocity.X - 0.04f;
																									}
																									if (this.velocity.X < num429)
																									{
																										if (this.velocity.X < 0f)
																										{
																											this.velocity.X = this.velocity.X * 0.9f;
																										}
																										this.velocity.X = this.velocity.X + 0.04f;
																									}
																									if (this.velocity.Y > num430)
																									{
																										if (this.velocity.Y > 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.9f;
																										}
																										this.velocity.Y = this.velocity.Y - 0.08f;
																									}
																									if (this.velocity.Y < num430)
																									{
																										if (this.velocity.Y < 0f)
																										{
																											this.velocity.Y = this.velocity.Y * 0.9f;
																										}
																										this.velocity.Y = this.velocity.Y + 0.08f;
																									}
																									this.TargetClosest(true);
																									vector53 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									num429 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector53.X;
																									num430 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector53.Y;
																									num431 = (float)Math.Sqrt((double)(num429 * num429 + num430 * num430));
																									this.rotation = (float)Math.Atan2((double)num430, (double)num429) - 1.57f;
																									if (Main.netMode != 1)
																									{
																										this.localAI[0] += 1f;
																										if (this.localAI[0] > 40f)
																										{
																											this.localAI[0] = 0f;
																											float num432 = 10f;
																											int num433 = 0;
																											int num434 = 102;
																											num431 = num432 / num431;
																											num429 *= num431;
																											num430 *= num431;
																											num429 += (float)Main.rand.Next(-40, 41) * 0.01f;
																											num430 += (float)Main.rand.Next(-40, 41) * 0.01f;
																											vector53.X += num429 * 4f;
																											vector53.Y += num430 * 4f;
																											Projectile.NewProjectile(vector53.X, vector53.Y, num429, num430, num434, num433, 0f, Main.myPlayer);
																											return;
																										}
																									}
																								}
																							}
																						}
																						else
																						{
																							if (this.aiStyle == 36)
																							{
																								this.spriteDirection = -(int)this.ai[0];
																								if (!Main.npc[(int)this.ai[1]].active || Main.npc[(int)this.ai[1]].aiStyle != 32)
																								{
																									this.ai[2] += 10f;
																									if (this.ai[2] > 50f || Main.netMode != 2)
																									{
																										this.life = -1;
																										this.HitEffect(0, 10.0);
																										this.active = false;
																									}
																								}
																								if (this.ai[2] == 0f || this.ai[2] == 3f)
																								{
																									if (Main.npc[(int)this.ai[1]].ai[1] == 3f && this.timeLeft > 10)
																									{
																										this.timeLeft = 10;
																									}
																									if (Main.npc[(int)this.ai[1]].ai[1] != 0f)
																									{
																										this.localAI[0] += 3f;
																										if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y - 100f)
																										{
																											if (this.velocity.Y > 0f)
																											{
																												this.velocity.Y = this.velocity.Y * 0.96f;
																											}
																											this.velocity.Y = this.velocity.Y - 0.07f;
																											if (this.velocity.Y > 6f)
																											{
																												this.velocity.Y = 6f;
																											}
																										}
																										else
																										{
																											if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 100f)
																											{
																												if (this.velocity.Y < 0f)
																												{
																													this.velocity.Y = this.velocity.Y * 0.96f;
																												}
																												this.velocity.Y = this.velocity.Y + 0.07f;
																												if (this.velocity.Y < -6f)
																												{
																													this.velocity.Y = -6f;
																												}
																											}
																										}
																										if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 120f * this.ai[0])
																										{
																											if (this.velocity.X > 0f)
																											{
																												this.velocity.X = this.velocity.X * 0.96f;
																											}
																											this.velocity.X = this.velocity.X - 0.1f;
																											if (this.velocity.X > 8f)
																											{
																												this.velocity.X = 8f;
																											}
																										}
																										if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 120f * this.ai[0])
																										{
																											if (this.velocity.X < 0f)
																											{
																												this.velocity.X = this.velocity.X * 0.96f;
																											}
																											this.velocity.X = this.velocity.X + 0.1f;
																											if (this.velocity.X < -8f)
																											{
																												this.velocity.X = -8f;
																											}
																										}
																									}
																									else
																									{
																										this.ai[3] += 1f;
																										if (this.ai[3] >= 800f)
																										{
																											this.ai[2] += 1f;
																											this.ai[3] = 0f;
																											this.netUpdate = true;
																										}
																										if (this.position.Y > Main.npc[(int)this.ai[1]].position.Y - 100f)
																										{
																											if (this.velocity.Y > 0f)
																											{
																												this.velocity.Y = this.velocity.Y * 0.96f;
																											}
																											this.velocity.Y = this.velocity.Y - 0.1f;
																											if (this.velocity.Y > 3f)
																											{
																												this.velocity.Y = 3f;
																											}
																										}
																										else
																										{
																											if (this.position.Y < Main.npc[(int)this.ai[1]].position.Y - 100f)
																											{
																												if (this.velocity.Y < 0f)
																												{
																													this.velocity.Y = this.velocity.Y * 0.96f;
																												}
																												this.velocity.Y = this.velocity.Y + 0.1f;
																												if (this.velocity.Y < -3f)
																												{
																													this.velocity.Y = -3f;
																												}
																											}
																										}
																										if (this.position.X + (float)(this.width / 2) > Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 180f * this.ai[0])
																										{
																											if (this.velocity.X > 0f)
																											{
																												this.velocity.X = this.velocity.X * 0.96f;
																											}
																											this.velocity.X = this.velocity.X - 0.14f;
																											if (this.velocity.X > 8f)
																											{
																												this.velocity.X = 8f;
																											}
																										}
																										if (this.position.X + (float)(this.width / 2) < Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - 180f * this.ai[0])
																										{
																											if (this.velocity.X < 0f)
																											{
																												this.velocity.X = this.velocity.X * 0.96f;
																											}
																											this.velocity.X = this.velocity.X + 0.14f;
																											if (this.velocity.X < -8f)
																											{
																												this.velocity.X = -8f;
																											}
																										}
																									}
																									this.TargetClosest(true);
																									Vector2 vector54 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									float num435 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector54.X;
																									float num436 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector54.Y;
																									float num437 = (float)Math.Sqrt((double)(num435 * num435 + num436 * num436));
																									this.rotation = (float)Math.Atan2((double)num436, (double)num435) - 1.57f;
																									if (Main.netMode != 1)
																									{
																										this.localAI[0] += 1f;
																										if (this.localAI[0] > 200f)
																										{
																											this.localAI[0] = 0f;
																											float num438 = 8f;
																											int num439 = 25;
																											int num440 = 100;
																											num437 = num438 / num437;
																											num435 *= num437;
																											num436 *= num437;
																											num435 += (float)Main.rand.Next(-40, 41) * 0.05f;
																											num436 += (float)Main.rand.Next(-40, 41) * 0.05f;
																											vector54.X += num435 * 8f;
																											vector54.Y += num436 * 8f;
																											Projectile.NewProjectile(vector54.X, vector54.Y, num435, num436, num440, num439, 0f, Main.myPlayer);
																											return;
																										}
																									}
																								}
																								else
																								{
																									if (this.ai[2] == 1f)
																									{
																										this.ai[3] += 1f;
																										if (this.ai[3] >= 200f)
																										{
																											this.localAI[0] = 0f;
																											this.ai[2] = 0f;
																											this.ai[3] = 0f;
																											this.netUpdate = true;
																										}
																										Vector2 vector55 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																										float num441 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - 350f - vector55.X;
																										float num442 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - 20f - vector55.Y;
																										float num443 = (float)Math.Sqrt((double)(num441 * num441 + num442 * num442));
																										num443 = 7f / num443;
																										num441 *= num443;
																										num442 *= num443;
																										if (this.velocity.X > num441)
																										{
																											if (this.velocity.X > 0f)
																											{
																												this.velocity.X = this.velocity.X * 0.9f;
																											}
																											this.velocity.X = this.velocity.X - 0.1f;
																										}
																										if (this.velocity.X < num441)
																										{
																											if (this.velocity.X < 0f)
																											{
																												this.velocity.X = this.velocity.X * 0.9f;
																											}
																											this.velocity.X = this.velocity.X + 0.1f;
																										}
																										if (this.velocity.Y > num442)
																										{
																											if (this.velocity.Y > 0f)
																											{
																												this.velocity.Y = this.velocity.Y * 0.9f;
																											}
																											this.velocity.Y = this.velocity.Y - 0.03f;
																										}
																										if (this.velocity.Y < num442)
																										{
																											if (this.velocity.Y < 0f)
																											{
																												this.velocity.Y = this.velocity.Y * 0.9f;
																											}
																											this.velocity.Y = this.velocity.Y + 0.03f;
																										}
																										this.TargetClosest(true);
																										vector55 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																										num441 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector55.X;
																										num442 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2) - vector55.Y;
																										num443 = (float)Math.Sqrt((double)(num441 * num441 + num442 * num442));
																										this.rotation = (float)Math.Atan2((double)num442, (double)num441) - 1.57f;
																										if (Main.netMode == 1)
																										{
																											this.localAI[0] += 1f;
																											if (this.localAI[0] > 80f)
																											{
																												this.localAI[0] = 0f;
																												float num444 = 10f;
																												int num445 = 25;
																												int num446 = 100;
																												num443 = num444 / num443;
																												num441 *= num443;
																												num442 *= num443;
																												num441 += (float)Main.rand.Next(-40, 41) * 0.05f;
																												num442 += (float)Main.rand.Next(-40, 41) * 0.05f;
																												vector55.X += num441 * 8f;
																												vector55.Y += num442 * 8f;
																												Projectile.NewProjectile(vector55.X, vector55.Y, num441, num442, num446, num445, 0f, Main.myPlayer);
																												return;
																											}
																										}
																									}
																								}
																							}
																							else
																							{
																								if (this.aiStyle == 37)
																								{
																									if (this.ai[3] > 0f)
																									{
																										this.realLife = (int)this.ai[3];
																									}
																									if (this.target < 0 || this.target == 255 || Main.player[this.target].dead)
																									{
																										this.TargetClosest(true);
																									}
																									if (this.type > 134)
																									{
																										bool flag34 = false;
																										if (this.ai[1] <= 0f)
																										{
																											flag34 = true;
																										}
																										else
																										{
																											if (Main.npc[(int)this.ai[1]].life <= 0)
																											{
																												flag34 = true;
																											}
																										}
																										if (flag34)
																										{
																											this.life = 0;
																											this.HitEffect(0, 10.0);
																											this.checkDead();
																										}
																									}
																									if (Main.netMode != 1)
																									{
																										if (this.ai[0] == 0f && this.type == 134)
																										{
																											this.ai[3] = (float)this.whoAmI;
																											this.realLife = this.whoAmI;
																											int num447 = this.whoAmI;
																											int num448 = 80;
																											for (int num449 = 0; num449 <= num448; num449++)
																											{
																												int num450 = 135;
																												if (num449 == num448)
																												{
																													num450 = 136;
																												}
																												int num451 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), num450, this.whoAmI);
																												Main.npc[num451].ai[3] = (float)this.whoAmI;
																												Main.npc[num451].realLife = this.whoAmI;
																												Main.npc[num451].ai[1] = (float)num447;
																												Main.npc[num447].ai[0] = (float)num451;
																												NetMessage.SendData(23, -1, -1, "", num451, 0f, 0f, 0f, 0);
																												num447 = num451;
																											}
																										}
																										if (this.type == 135)
																										{
																											this.localAI[0] += (float)Main.rand.Next(4);
																											if (this.localAI[0] >= (float)Main.rand.Next(1400, 26000))
																											{
																												this.localAI[0] = 0f;
																												this.TargetClosest(true);
																												if (Collision.CanHit(this.position, this.width, this.height, Main.player[this.target].position, Main.player[this.target].width, Main.player[this.target].height))
																												{
																													float num452 = 8f;
																													Vector2 vector56 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)(this.height / 2));
																													float num453 = Main.player[this.target].position.X + (float)Main.player[this.target].width * 0.5f - vector56.X + (float)Main.rand.Next(-20, 21);
																													float num454 = Main.player[this.target].position.Y + (float)Main.player[this.target].height * 0.5f - vector56.Y + (float)Main.rand.Next(-20, 21);
																													float num455 = (float)Math.Sqrt((double)(num453 * num453 + num454 * num454));
																													num455 = num452 / num455;
																													num453 *= num455;
																													num454 *= num455;
																													num453 += (float)Main.rand.Next(-20, 21) * 0.05f;
																													num454 += (float)Main.rand.Next(-20, 21) * 0.05f;
																													int num456 = 22;
																													int num457 = 100;
																													vector56.X += num453 * 5f;
																													vector56.Y += num454 * 5f;
																													int num458 = Projectile.NewProjectile(vector56.X, vector56.Y, num453, num454, num457, num456, 0f, Main.myPlayer);
																													Main.projectile[num458].timeLeft = 300;
																													this.netUpdate = true;
																												}
																											}
																										}
																									}
																									int num459 = (int)(this.position.X / 16f) - 1;
																									int num460 = (int)((this.position.X + (float)this.width) / 16f) + 2;
																									int num461 = (int)(this.position.Y / 16f) - 1;
																									int num462 = (int)((this.position.Y + (float)this.height) / 16f) + 2;
																									if (num459 < 0)
																									{
																										num459 = 0;
																									}
																									if (num460 > Main.maxTilesX)
																									{
																										num460 = Main.maxTilesX;
																									}
																									if (num461 < 0)
																									{
																										num461 = 0;
																									}
																									if (num462 > Main.maxTilesY)
																									{
																										num462 = Main.maxTilesY;
																									}
																									bool flag35 = false;
																									if (!flag35)
																									{
																										for (int num463 = num459; num463 < num460; num463++)
																										{
																											for (int num464 = num461; num464 < num462; num464++)
																											{
																												if (Main.tile[num463, num464] != null && ((Main.tile[num463, num464].active && (Main.tileSolid[(int)Main.tile[num463, num464].type] || (Main.tileSolidTop[(int)Main.tile[num463, num464].type] && Main.tile[num463, num464].frameY == 0))) || Main.tile[num463, num464].liquid > 64))
																												{
																													Vector2 vector57;
																													vector57.X = (float)(num463 * 16);
																													vector57.Y = (float)(num464 * 16);
																													if (this.position.X + (float)this.width > vector57.X && this.position.X < vector57.X + 16f && this.position.Y + (float)this.height > vector57.Y && this.position.Y < vector57.Y + 16f)
																													{
																														flag35 = true;
																														break;
																													}
																												}
																											}
																										}
																									}
																									if (!flag35)
																									{
																										if (this.type != 135 || this.ai[2] != 1f)
																										{
																											Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.3f, 0.1f, 0.05f);
																										}
																										this.localAI[1] = 1f;
																										if (this.type == 134)
																										{
																											Rectangle rectangle11 = new Rectangle((int)this.position.X, (int)this.position.Y, this.width, this.height);
																											int num465 = 1000;
																											bool flag36 = true;
																											if (this.position.Y > Main.player[this.target].position.Y)
																											{
																												for (int num466 = 0; num466 < 255; num466++)
																												{
																													if (Main.player[num466].active)
																													{
																														Rectangle rectangle12 = new Rectangle((int)Main.player[num466].position.X - num465, (int)Main.player[num466].position.Y - num465, num465 * 2, num465 * 2);
																														if (rectangle11.Intersects(rectangle12))
																														{
																															flag36 = false;
																															break;
																														}
																													}
																												}
																												if (flag36)
																												{
																													flag35 = true;
																												}
																											}
																										}
																									}
																									else
																									{
																										this.localAI[1] = 0f;
																									}
																									float num467 = 16f;
																									if (Main.dayTime || Main.player[this.target].dead)
																									{
																										flag35 = false;
																										this.velocity.Y = this.velocity.Y + 1f;
																										if ((double)this.position.Y > Main.worldSurface * 16.0)
																										{
																											this.velocity.Y = this.velocity.Y + 1f;
																											num467 = 32f;
																										}
																										if ((double)this.position.Y > Main.rockLayer * 16.0)
																										{
																											for (int num468 = 0; num468 < 200; num468++)
																											{
																												if (Main.npc[num468].aiStyle == this.aiStyle)
																												{
																													Main.npc[num468].active = false;
																												}
																											}
																										}
																									}
																									float num469 = 0.1f;
																									float num470 = 0.15f;
																									Vector2 vector58 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																									float num471 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2);
																									float num472 = Main.player[this.target].position.Y + (float)(Main.player[this.target].height / 2);
																									num471 = (float)((int)(num471 / 16f) * 16);
																									num472 = (float)((int)(num472 / 16f) * 16);
																									vector58.X = (float)((int)(vector58.X / 16f) * 16);
																									vector58.Y = (float)((int)(vector58.Y / 16f) * 16);
																									num471 -= vector58.X;
																									num472 -= vector58.Y;
																									float num473 = (float)Math.Sqrt((double)(num471 * num471 + num472 * num472));
																									if (this.ai[1] > 0f && this.ai[1] < (float)Main.npc.Length)
																									{
																										try
																										{
																											vector58 = new Vector2(this.position.X + (float)this.width * 0.5f, this.position.Y + (float)this.height * 0.5f);
																											num471 = Main.npc[(int)this.ai[1]].position.X + (float)(Main.npc[(int)this.ai[1]].width / 2) - vector58.X;
																											num472 = Main.npc[(int)this.ai[1]].position.Y + (float)(Main.npc[(int)this.ai[1]].height / 2) - vector58.Y;
																										}
																										catch
																										{
																										}
																										this.rotation = (float)Math.Atan2((double)num472, (double)num471) + 1.57f;
																										num473 = (float)Math.Sqrt((double)(num471 * num471 + num472 * num472));
																										int num474 = (int)(44f * this.scale);
																										num473 = (num473 - (float)num474) / num473;
																										num471 *= num473;
																										num472 *= num473;
																										this.velocity = default(Vector2);
																										this.position.X = this.position.X + num471;
																										this.position.Y = this.position.Y + num472;
																										return;
																									}
																									if (!flag35)
																									{
																										this.TargetClosest(true);
																										this.velocity.Y = this.velocity.Y + 0.15f;
																										if (this.velocity.Y > num467)
																										{
																											this.velocity.Y = num467;
																										}
																										if ((double)(Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y)) < (double)num467 * 0.4)
																										{
																											if (this.velocity.X < 0f)
																											{
																												this.velocity.X = this.velocity.X - num469 * 1.1f;
																											}
																											else
																											{
																												this.velocity.X = this.velocity.X + num469 * 1.1f;
																											}
																										}
																										else
																										{
																											if (this.velocity.Y == num467)
																											{
																												if (this.velocity.X < num471)
																												{
																													this.velocity.X = this.velocity.X + num469;
																												}
																												else
																												{
																													if (this.velocity.X > num471)
																													{
																														this.velocity.X = this.velocity.X - num469;
																													}
																												}
																											}
																											else
																											{
																												if (this.velocity.Y > 4f)
																												{
																													if (this.velocity.X < 0f)
																													{
																														this.velocity.X = this.velocity.X + num469 * 0.9f;
																													}
																													else
																													{
																														this.velocity.X = this.velocity.X - num469 * 0.9f;
																													}
																												}
																											}
																										}
																									}
																									else
																									{
																										if (this.soundDelay == 0)
																										{
																											float num475 = num473 / 40f;
																											if (num475 < 10f)
																											{
																												num475 = 10f;
																											}
																											if (num475 > 20f)
																											{
																												num475 = 20f;
																											}
																											this.soundDelay = (int)num475;
																											Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 1);
																										}
																										num473 = (float)Math.Sqrt((double)(num471 * num471 + num472 * num472));
																										float num476 = Math.Abs(num471);
																										float num477 = Math.Abs(num472);
																										float num478 = num467 / num473;
																										num471 *= num478;
																										num472 *= num478;
																										if (((this.velocity.X > 0f && num471 > 0f) || (this.velocity.X < 0f && num471 < 0f)) && ((this.velocity.Y > 0f && num472 > 0f) || (this.velocity.Y < 0f && num472 < 0f)))
																										{
																											if (this.velocity.X < num471)
																											{
																												this.velocity.X = this.velocity.X + num470;
																											}
																											else
																											{
																												if (this.velocity.X > num471)
																												{
																													this.velocity.X = this.velocity.X - num470;
																												}
																											}
																											if (this.velocity.Y < num472)
																											{
																												this.velocity.Y = this.velocity.Y + num470;
																											}
																											else
																											{
																												if (this.velocity.Y > num472)
																												{
																													this.velocity.Y = this.velocity.Y - num470;
																												}
																											}
																										}
																										if ((this.velocity.X > 0f && num471 > 0f) || (this.velocity.X < 0f && num471 < 0f) || (this.velocity.Y > 0f && num472 > 0f) || (this.velocity.Y < 0f && num472 < 0f))
																										{
																											if (this.velocity.X < num471)
																											{
																												this.velocity.X = this.velocity.X + num469;
																											}
																											else
																											{
																												if (this.velocity.X > num471)
																												{
																													this.velocity.X = this.velocity.X - num469;
																												}
																											}
																											if (this.velocity.Y < num472)
																											{
																												this.velocity.Y = this.velocity.Y + num469;
																											}
																											else
																											{
																												if (this.velocity.Y > num472)
																												{
																													this.velocity.Y = this.velocity.Y - num469;
																												}
																											}
																											if ((double)Math.Abs(num472) < (double)num467 * 0.2 && ((this.velocity.X > 0f && num471 < 0f) || (this.velocity.X < 0f && num471 > 0f)))
																											{
																												if (this.velocity.Y > 0f)
																												{
																													this.velocity.Y = this.velocity.Y + num469 * 2f;
																												}
																												else
																												{
																													this.velocity.Y = this.velocity.Y - num469 * 2f;
																												}
																											}
																											if ((double)Math.Abs(num471) < (double)num467 * 0.2 && ((this.velocity.Y > 0f && num472 < 0f) || (this.velocity.Y < 0f && num472 > 0f)))
																											{
																												if (this.velocity.X > 0f)
																												{
																													this.velocity.X = this.velocity.X + num469 * 2f;
																												}
																												else
																												{
																													this.velocity.X = this.velocity.X - num469 * 2f;
																												}
																											}
																										}
																										else
																										{
																											if (num476 > num477)
																											{
																												if (this.velocity.X < num471)
																												{
																													this.velocity.X = this.velocity.X + num469 * 1.1f;
																												}
																												else
																												{
																													if (this.velocity.X > num471)
																													{
																														this.velocity.X = this.velocity.X - num469 * 1.1f;
																													}
																												}
																												if ((double)(Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y)) < (double)num467 * 0.5)
																												{
																													if (this.velocity.Y > 0f)
																													{
																														this.velocity.Y = this.velocity.Y + num469;
																													}
																													else
																													{
																														this.velocity.Y = this.velocity.Y - num469;
																													}
																												}
																											}
																											else
																											{
																												if (this.velocity.Y < num472)
																												{
																													this.velocity.Y = this.velocity.Y + num469 * 1.1f;
																												}
																												else
																												{
																													if (this.velocity.Y > num472)
																													{
																														this.velocity.Y = this.velocity.Y - num469 * 1.1f;
																													}
																												}
																												if ((double)(Math.Abs(this.velocity.X) + Math.Abs(this.velocity.Y)) < (double)num467 * 0.5)
																												{
																													if (this.velocity.X > 0f)
																													{
																														this.velocity.X = this.velocity.X + num469;
																													}
																													else
																													{
																														this.velocity.X = this.velocity.X - num469;
																													}
																												}
																											}
																										}
																									}
																									this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) + 1.57f;
																									if (this.type == 134)
																									{
																										if (flag35)
																										{
																											if (this.localAI[0] != 1f)
																											{
																												this.netUpdate = true;
																											}
																											this.localAI[0] = 1f;
																										}
																										else
																										{
																											if (this.localAI[0] != 0f)
																											{
																												this.netUpdate = true;
																											}
																											this.localAI[0] = 0f;
																										}
																										if (((this.velocity.X > 0f && this.oldVelocity.X < 0f) || (this.velocity.X < 0f && this.oldVelocity.X > 0f) || (this.velocity.Y > 0f && this.oldVelocity.Y < 0f) || (this.velocity.Y < 0f && this.oldVelocity.Y > 0f)) && !this.justHit)
																										{
																											this.netUpdate = true;
																											return;
																										}
																									}
																								}
																								else
																								{
																									if (this.aiStyle == 38)
																									{
																										float num479 = 4f;
																										float num480 = 1f;
																										if (this.type == 143)
																										{
																											num479 = 3f;
																											num480 = 0.7f;
																										}
																										if (this.type == 145)
																										{
																											num479 = 3.5f;
																											num480 = 0.8f;
																										}
																										if (this.type == 143)
																										{
																											this.ai[2] += 1f;
																											if (this.ai[2] >= 120f)
																											{
																												this.ai[2] = 0f;
																												if (Main.netMode != 1)
																												{
																													Vector2 vector59 = new Vector2(this.position.X + (float)this.width * 0.5f - (float)(this.direction * 12), this.position.Y + (float)this.height * 0.5f);
																													float speedX = (float)(12 * this.spriteDirection);
																													float speedY = 0f;
																													if (Main.netMode != 1)
																													{
																														int num481 = 25;
																														int num482 = 110;
																														int num483 = Projectile.NewProjectile(vector59.X, vector59.Y, speedX, speedY, num482, num481, 0f, Main.myPlayer);
																														Main.projectile[num483].ai[0] = 2f;
																														Main.projectile[num483].timeLeft = 300;
																														Main.projectile[num483].friendly = false;
																														NetMessage.SendData(27, -1, -1, "", num483, 0f, 0f, 0f, 0);
																														this.netUpdate = true;
																													}
																												}
																											}
																										}
																										if (this.type == 144 && this.ai[1] >= 3f)
																										{
																											this.TargetClosest(true);
																											this.spriteDirection = this.direction;
																											if (this.velocity.Y == 0f)
																											{
																												this.velocity.X = this.velocity.X * 0.9f;
																												this.ai[2] += 1f;
																												if ((double)this.velocity.X > -0.3 && (double)this.velocity.X < 0.3)
																												{
																													this.velocity.X = 0f;
																												}
																												if (this.ai[2] >= 200f)
																												{
																													this.ai[2] = 0f;
																													this.ai[1] = 0f;
																												}
																											}
																										}
																										else
																										{
																											if (this.type == 145 && this.ai[1] >= 3f)
																											{
																												this.TargetClosest(true);
																												if (this.velocity.Y == 0f)
																												{
																													this.velocity.X = this.velocity.X * 0.9f;
																													this.ai[2] += 1f;
																													if ((double)this.velocity.X > -0.3 && (double)this.velocity.X < 0.3)
																													{
																														this.velocity.X = 0f;
																													}
																													if (this.ai[2] >= 16f)
																													{
																														this.ai[2] = 0f;
																														this.ai[1] = 0f;
																													}
																												}
																												if (this.velocity.X == 0f && this.velocity.Y == 0f && this.ai[2] == 8f)
																												{
																													float num484 = 10f;
																													Vector2 vector60 = new Vector2(this.position.X + (float)this.width * 0.5f - (float)(this.direction * 12), this.position.Y + (float)this.height * 0.25f);
																													float num485 = Main.player[this.target].position.X + (float)(Main.player[this.target].width / 2) - vector60.X;
																													float num486 = Main.player[this.target].position.Y - vector60.Y;
																													float num487 = (float)Math.Sqrt((double)(num485 * num485 + num486 * num486));
																													num487 = num484 / num487;
																													num485 *= num487;
																													num486 *= num487;
																													if (Main.netMode != 1)
																													{
																														int num488 = 35;
																														int num489 = 109;
																														int num490 = Projectile.NewProjectile(vector60.X, vector60.Y, num485, num486, num489, num488, 0f, Main.myPlayer);
																														Main.projectile[num490].ai[0] = 2f;
																														Main.projectile[num490].timeLeft = 300;
																														Main.projectile[num490].friendly = false;
																														NetMessage.SendData(27, -1, -1, "", num490, 0f, 0f, 0f, 0);
																														this.netUpdate = true;
																													}
																												}
																											}
																											else
																											{
																												if (this.velocity.Y == 0f)
																												{
																													if (this.localAI[2] == this.position.X)
																													{
																														this.direction *= -1;
																														this.ai[3] = 60f;
																													}
																													this.localAI[2] = this.position.X;
																													if (this.ai[3] == 0f)
																													{
																														this.TargetClosest(true);
																													}
																													this.ai[0] += 1f;
																													if (this.ai[0] > 2f)
																													{
																														this.ai[0] = 0f;
																														this.ai[1] += 1f;
																														this.velocity.Y = -8.2f;
																														this.velocity.X = this.velocity.X + (float)this.direction * num480 * 1.1f;
																													}
																													else
																													{
																														this.velocity.Y = -6f;
																														this.velocity.X = this.velocity.X + (float)this.direction * num480 * 0.9f;
																													}
																													this.spriteDirection = this.direction;
																												}
																												this.velocity.X = this.velocity.X + (float)this.direction * num480 * 0.01f;
																											}
																										}
																										if (this.ai[3] > 0f)
																										{
																											this.ai[3] -= 1f;
																										}
																										if (this.velocity.X > num479 && this.direction > 0)
																										{
																											this.velocity.X = 4f;
																										}
																										if (this.velocity.X < -num479 && this.direction < 0)
																										{
																											this.velocity.X = -4f;
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									break;
							}
							break;
					}
					break;
			}
		}
		public void FindFrame()
		{
			int num = 1;
			if (!Main.dedServ)
			{

			}
			int num2 = 0;
			if (this.aiAction == 0)
			{
				if (this.velocity.Y < 0f)
				{
					num2 = 2;
				}
				else
				{
					if (this.velocity.Y > 0f)
					{
						num2 = 3;
					}
					else
					{
						if (this.velocity.X != 0f)
						{
							num2 = 1;
						}
						else
						{
							num2 = 0;
						}
					}
				}
			}
			else
			{
				if (this.aiAction == 1)
				{
					num2 = 4;
				}
			}
			if (this.type == 1 || this.type == 16 || this.type == 59 || this.type == 71 || this.type == 81 || this.type == 138)
			{
				this.frameCounter += 1.0;
				if (num2 > 0)
				{
					this.frameCounter += 1.0;
				}
				if (num2 == 4)
				{
					this.frameCounter += 1.0;
				}
				if (this.frameCounter >= 8.0)
				{
					this.frame.Y = this.frame.Y + num;
					this.frameCounter = 0.0;
				}
				if (this.frame.Y >= num * Main.npcFrameCount[this.type])
				{
					this.frame.Y = 0;
				}
			}
			if (this.type == 141)
			{
				this.spriteDirection = this.direction;
				if (this.velocity.Y != 0f)
				{
					this.frame.Y = num * 2;
				}
				else
				{
					this.frameCounter += 1.0;
					if (this.frameCounter >= 8.0)
					{
						this.frame.Y = this.frame.Y + num;
						this.frameCounter = 0.0;
					}
					if (this.frame.Y > num)
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 143)
			{
				if (this.velocity.Y > 0f)
				{
					this.frameCounter += 1.0;
				}
				else
				{
					if (this.velocity.Y < 0f)
					{
						this.frameCounter -= 1.0;
					}
				}
				if (this.frameCounter < 6.0)
				{
					this.frame.Y = num;
				}
				else
				{
					if (this.frameCounter < 12.0)
					{
						this.frame.Y = num * 2;
					}
					else
					{
						if (this.frameCounter < 18.0)
						{
							this.frame.Y = num * 3;
						}
					}
				}
				if (this.frameCounter < 0.0)
				{
					this.frameCounter = 0.0;
				}
				if (this.frameCounter > 17.0)
				{
					this.frameCounter = 17.0;
				}
			}
			if (this.type == 144)
			{
				if (this.velocity.X == 0f && this.velocity.Y == 0f)
				{
					this.localAI[3] += 1f;
					if (this.localAI[3] < 6f)
					{
						this.frame.Y = 0;
					}
					else
					{
						if (this.localAI[3] < 12f)
						{
							this.frame.Y = num;
						}
					}
					if (this.localAI[3] >= 11f)
					{
						this.localAI[3] = 0f;
					}
				}
				else
				{
					if (this.velocity.Y > 0f)
					{
						this.frameCounter += 1.0;
					}
					else
					{
						if (this.velocity.Y < 0f)
						{
							this.frameCounter -= 1.0;
						}
					}
					if (this.frameCounter < 6.0)
					{
						this.frame.Y = num * 2;
					}
					else
					{
						if (this.frameCounter < 12.0)
						{
							this.frame.Y = num * 3;
						}
						else
						{
							if (this.frameCounter < 18.0)
							{
								this.frame.Y = num * 4;
							}
						}
					}
					if (this.frameCounter < 0.0)
					{
						this.frameCounter = 0.0;
					}
					if (this.frameCounter > 17.0)
					{
						this.frameCounter = 17.0;
					}
				}
			}
			if (this.type == 145)
			{
				if (this.velocity.X == 0f && this.velocity.Y == 0f)
				{
					if (this.ai[2] < 4f)
					{
						this.frame.Y = 0;
					}
					else
					{
						if (this.ai[2] < 8f)
						{
							this.frame.Y = num;
						}
						else
						{
							if (this.ai[2] < 12f)
							{
								this.frame.Y = num * 2;
							}
							else
							{
								if (this.ai[2] < 16f)
								{
									this.frame.Y = num * 3;
								}
							}
						}
					}
				}
				else
				{
					if (this.velocity.Y > 0f)
					{
						this.frameCounter += 1.0;
					}
					else
					{
						if (this.velocity.Y < 0f)
						{
							this.frameCounter -= 1.0;
						}
					}
					if (this.frameCounter < 6.0)
					{
						this.frame.Y = num * 4;
					}
					else
					{
						if (this.frameCounter < 12.0)
						{
							this.frame.Y = num * 5;
						}
						else
						{
							if (this.frameCounter < 18.0)
							{
								this.frame.Y = num * 6;
							}
						}
					}
					if (this.frameCounter < 0.0)
					{
						this.frameCounter = 0.0;
					}
					if (this.frameCounter > 17.0)
					{
						this.frameCounter = 17.0;
					}
				}
			}
			if (this.type == 50)
			{
				if (this.velocity.Y != 0f)
				{
					this.frame.Y = num * 4;
				}
				else
				{
					this.frameCounter += 1.0;
					if (num2 > 0)
					{
						this.frameCounter += 1.0;
					}
					if (num2 == 4)
					{
						this.frameCounter += 1.0;
					}
					if (this.frameCounter >= 8.0)
					{
						this.frame.Y = this.frame.Y + num;
						this.frameCounter = 0.0;
					}
					if (this.frame.Y >= num * 4)
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 135)
			{
				if (this.ai[2] == 0f)
				{
					this.frame.Y = 0;
				}
				else
				{
					this.frame.Y = num;
				}
			}
			if (this.type == 85)
			{
				if (this.ai[0] == 0f)
				{
					this.frameCounter = 0.0;
					this.frame.Y = 0;
				}
				else
				{
					int num3 = 3;
					if (this.velocity.Y == 0f)
					{
						this.frameCounter -= 1.0;
					}
					else
					{
						this.frameCounter += 1.0;
					}
					if (this.frameCounter < 0.0)
					{
						this.frameCounter = 0.0;
					}
					if (this.frameCounter > (double)(num3 * 4))
					{
						this.frameCounter = (double)(num3 * 4);
					}
					if (this.frameCounter < (double)num3)
					{
						this.frame.Y = num;
					}
					else
					{
						if (this.frameCounter < (double)(num3 * 2))
						{
							this.frame.Y = num * 2;
						}
						else
						{
							if (this.frameCounter < (double)(num3 * 3))
							{
								this.frame.Y = num * 3;
							}
							else
							{
								if (this.frameCounter < (double)(num3 * 4))
								{
									this.frame.Y = num * 4;
								}
								else
								{
									if (this.frameCounter < (double)(num3 * 5))
									{
										this.frame.Y = num * 5;
									}
									else
									{
										if (this.frameCounter < (double)(num3 * 6))
										{
											this.frame.Y = num * 4;
										}
										else
										{
											if (this.frameCounter < (double)(num3 * 7))
											{
												this.frame.Y = num * 3;
											}
											else
											{
												this.frame.Y = num * 2;
												if (this.frameCounter >= (double)(num3 * 8))
												{
													this.frameCounter = (double)num3;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				if (this.ai[3] == 2f)
				{
					this.frame.Y = this.frame.Y + num * 6;
				}
				else
				{
					if (this.ai[3] == 3f)
					{
						this.frame.Y = this.frame.Y + num * 12;
					}
				}
			}
			if (this.type == 113 || this.type == 114)
			{
				if (this.ai[2] == 0f)
				{
					this.frameCounter += 1.0;
					if (this.frameCounter >= 12.0)
					{
						this.frame.Y = this.frame.Y + num;
						this.frameCounter = 0.0;
					}
					if (this.frame.Y >= num * Main.npcFrameCount[this.type])
					{
						this.frame.Y = 0;
					}
				}
				else
				{
					this.frame.Y = 0;
					this.frameCounter = -60.0;
				}
			}
			if (this.type == 61)
			{
				this.spriteDirection = this.direction;
				this.rotation = this.velocity.X * 0.1f;
				if (this.velocity.X == 0f && this.velocity.Y == 0f)
				{
					this.frame.Y = 0;
					this.frameCounter = 0.0;
				}
				else
				{
					this.frameCounter += 1.0;
					if (this.frameCounter < 4.0)
					{
						this.frame.Y = num;
					}
					else
					{
						this.frame.Y = num * 2;
						if (this.frameCounter >= 7.0)
						{
							this.frameCounter = 0.0;
						}
					}
				}
			}
			if (this.type == 122)
			{
				this.spriteDirection = this.direction;
				this.rotation = this.velocity.X * 0.05f;
				if (this.ai[3] > 0f)
				{
					int num4 = (int)(this.ai[3] / 8f);
					this.frameCounter = 0.0;
					this.frame.Y = (num4 + 3) * num;
				}
				else
				{
					this.frameCounter += 1.0;
					if (this.frameCounter >= 8.0)
					{
						this.frame.Y = this.frame.Y + num;
						this.frameCounter = 0.0;
					}
					if (this.frame.Y >= num * 3)
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 74)
			{
				this.spriteDirection = this.direction;
				this.rotation = this.velocity.X * 0.1f;
				if (this.velocity.X == 0f && this.velocity.Y == 0f)
				{
					this.frame.Y = num * 4;
					this.frameCounter = 0.0;
				}
				else
				{
					this.frameCounter += 1.0;
					if (this.frameCounter >= 4.0)
					{
						this.frame.Y = this.frame.Y + num;
						this.frameCounter = 0.0;
					}
					if (this.frame.Y >= num * Main.npcFrameCount[this.type])
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 62 || this.type == 66)
			{
				this.spriteDirection = this.direction;
				this.rotation = this.velocity.X * 0.1f;
				this.frameCounter += 1.0;
				if (this.frameCounter < 6.0)
				{
					this.frame.Y = 0;
				}
				else
				{
					this.frame.Y = num;
					if (this.frameCounter >= 11.0)
					{
						this.frameCounter = 0.0;
					}
				}
			}
			if (this.type == 63 || this.type == 64 || this.type == 103)
			{
				this.frameCounter += 1.0;
				if (this.frameCounter < 6.0)
				{
					this.frame.Y = 0;
				}
				else
				{
					if (this.frameCounter < 12.0)
					{
						this.frame.Y = num;
					}
					else
					{
						if (this.frameCounter < 18.0)
						{
							this.frame.Y = num * 2;
						}
						else
						{
							this.frame.Y = num * 3;
							if (this.frameCounter >= 23.0)
							{
								this.frameCounter = 0.0;
							}
						}
					}
				}
			}
			if (this.type == 2 || this.type == 23 || this.type == 121)
			{
				if (this.type == 2)
				{
					if (this.velocity.X > 0f)
					{
						this.spriteDirection = 1;
						this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X);
					}
					if (this.velocity.X < 0f)
					{
						this.spriteDirection = -1;
						this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) + 3.14f;
					}
				}
				else
				{
					if (this.type == 2 || this.type == 121)
					{
						if (this.velocity.X > 0f)
						{
							this.spriteDirection = 1;
						}
						if (this.velocity.X < 0f)
						{
							this.spriteDirection = -1;
						}
						this.rotation = this.velocity.X * 0.1f;
					}
				}
				this.frameCounter += 1.0;
				if (this.frameCounter >= 8.0)
				{
					this.frame.Y = this.frame.Y + num;
					this.frameCounter = 0.0;
				}
				if (this.frame.Y >= num * Main.npcFrameCount[this.type])
				{
					this.frame.Y = 0;
				}
			}
			if (this.type == 133)
			{
				if (this.velocity.X > 0f)
				{
					this.spriteDirection = 1;
					this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X);
				}
				if (this.velocity.X < 0f)
				{
					this.spriteDirection = -1;
					this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) + 3.14f;
				}
				this.frameCounter += 1.0;
				if (this.frameCounter >= 8.0)
				{
					this.frame.Y = num;
				}
				else
				{
					this.frame.Y = 0;
				}
				if (this.frameCounter >= 16.0)
				{
					this.frame.Y = 0;
					this.frameCounter = 0.0;
				}
				if ((double)this.life < (double)this.lifeMax * 0.5)
				{
					this.frame.Y = this.frame.Y + num * 2;
				}
			}
			if (this.type == 116)
			{
				if (this.velocity.X > 0f)
				{
					this.spriteDirection = 1;
					this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X);
				}
				if (this.velocity.X < 0f)
				{
					this.spriteDirection = -1;
					this.rotation = (float)Math.Atan2((double)this.velocity.Y, (double)this.velocity.X) + 3.14f;
				}
				this.frameCounter += 1.0;
				if (this.frameCounter >= 5.0)
				{
					this.frame.Y = this.frame.Y + num;
					this.frameCounter = 0.0;
				}
				if (this.frame.Y >= num * Main.npcFrameCount[this.type])
				{
					this.frame.Y = 0;
				}
			}
			if (this.type == 75)
			{
				if (this.velocity.X > 0f)
				{
					this.spriteDirection = 1;
				}
				else
				{
					this.spriteDirection = -1;
				}
				this.rotation = this.velocity.X * 0.1f;
				this.frameCounter += 1.0;
				if (this.frameCounter >= 4.0)
				{
					this.frame.Y = this.frame.Y + num;
					this.frameCounter = 0.0;
				}
				if (this.frame.Y >= num * Main.npcFrameCount[this.type])
				{
					this.frame.Y = 0;
				}
			}
			if (this.type == 55 || this.type == 57 || this.type == 58 || this.type == 102)
			{
				this.spriteDirection = this.direction;
				this.frameCounter += 1.0;
				if (this.wet)
				{
					if (this.frameCounter < 6.0)
					{
						this.frame.Y = 0;
					}
					else
					{
						if (this.frameCounter < 12.0)
						{
							this.frame.Y = num;
						}
						else
						{
							if (this.frameCounter < 18.0)
							{
								this.frame.Y = num * 2;
							}
							else
							{
								if (this.frameCounter < 24.0)
								{
									this.frame.Y = num * 3;
								}
								else
								{
									this.frameCounter = 0.0;
								}
							}
						}
					}
				}
				else
				{
					if (this.frameCounter < 6.0)
					{
						this.frame.Y = num * 4;
					}
					else
					{
						if (this.frameCounter < 12.0)
						{
							this.frame.Y = num * 5;
						}
						else
						{
							this.frameCounter = 0.0;
						}
					}
				}
			}
			if (this.type == 69)
			{
				if (this.ai[0] < 190f)
				{
					this.frameCounter += 1.0;
					if (this.frameCounter >= 6.0)
					{
						this.frameCounter = 0.0;
						this.frame.Y = this.frame.Y + num;
						if (this.frame.Y / num >= Main.npcFrameCount[this.type] - 1)
						{
							this.frame.Y = 0;
						}
					}
				}
				else
				{
					this.frameCounter = 0.0;
					this.frame.Y = num * (Main.npcFrameCount[this.type] - 1);
				}
			}
			if (this.type == 86)
			{
				if (this.velocity.Y == 0f || this.wet)
				{
					if (this.velocity.X < -2f)
					{
						this.spriteDirection = -1;
					}
					else
					{
						if (this.velocity.X > 2f)
						{
							this.spriteDirection = 1;
						}
						else
						{
							this.spriteDirection = this.direction;
						}
					}
				}
				if (this.velocity.Y != 0f)
				{
					this.frame.Y = num * 15;
					this.frameCounter = 0.0;
				}
				else
				{
					if (this.velocity.X == 0f)
					{
						this.frameCounter = 0.0;
						this.frame.Y = 0;
					}
					else
					{
						if (Math.Abs(this.velocity.X) < 3f)
						{
							this.frameCounter += (double)Math.Abs(this.velocity.X);
							if (this.frameCounter >= 6.0)
							{
								this.frameCounter = 0.0;
								this.frame.Y = this.frame.Y + num;
								if (this.frame.Y / num >= 9)
								{
									this.frame.Y = num;
								}
								if (this.frame.Y / num <= 0)
								{
									this.frame.Y = num;
								}
							}
						}
						else
						{
							this.frameCounter += (double)Math.Abs(this.velocity.X);
							if (this.frameCounter >= 10.0)
							{
								this.frameCounter = 0.0;
								this.frame.Y = this.frame.Y + num;
								if (this.frame.Y / num >= 15)
								{
									this.frame.Y = num * 9;
								}
								if (this.frame.Y / num <= 8)
								{
									this.frame.Y = num * 9;
								}
							}
						}
					}
				}
			}
			if (this.type == 127)
			{
				if (this.ai[1] == 0f)
				{
					this.frameCounter += 1.0;
					if (this.frameCounter >= 12.0)
					{
						this.frameCounter = 0.0;
						this.frame.Y = this.frame.Y + num;
						if (this.frame.Y / num >= 2)
						{
							this.frame.Y = 0;
						}
					}
				}
				else
				{
					this.frameCounter = 0.0;
					this.frame.Y = num * 2;
				}
			}
			if (this.type == 129)
			{
				if (this.velocity.Y == 0f)
				{
					this.spriteDirection = this.direction;
				}
				this.frameCounter += 1.0;
				if (this.frameCounter >= 2.0)
				{
					this.frameCounter = 0.0;
					this.frame.Y = this.frame.Y + num;
					if (this.frame.Y / num >= Main.npcFrameCount[this.type])
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 130)
			{
				if (this.velocity.Y == 0f)
				{
					this.spriteDirection = this.direction;
				}
				this.frameCounter += 1.0;
				if (this.frameCounter >= 8.0)
				{
					this.frameCounter = 0.0;
					this.frame.Y = this.frame.Y + num;
					if (this.frame.Y / num >= Main.npcFrameCount[this.type])
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 67)
			{
				if (this.velocity.Y == 0f)
				{
					this.spriteDirection = this.direction;
				}
				this.frameCounter += 1.0;
				if (this.frameCounter >= 6.0)
				{
					this.frameCounter = 0.0;
					this.frame.Y = this.frame.Y + num;
					if (this.frame.Y / num >= Main.npcFrameCount[this.type])
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 109)
			{
				if (this.velocity.Y == 0f && ((this.velocity.X <= 0f && this.direction < 0) || (this.velocity.X >= 0f && this.direction > 0)))
				{
					this.spriteDirection = this.direction;
				}
				this.frameCounter += (double)Math.Abs(this.velocity.X);
				if (this.frameCounter >= 7.0)
				{
					this.frameCounter -= 7.0;
					this.frame.Y = this.frame.Y + num;
					if (this.frame.Y / num >= Main.npcFrameCount[this.type])
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 83 || this.type == 84)
			{
				if (this.ai[0] == 2f)
				{
					this.frameCounter = 0.0;
					this.frame.Y = 0;
				}
				else
				{
					this.frameCounter += 1.0;
					if (this.frameCounter >= 4.0)
					{
						this.frameCounter = 0.0;
						this.frame.Y = this.frame.Y + num;
						if (this.frame.Y / num >= Main.npcFrameCount[this.type])
						{
							this.frame.Y = 0;
						}
					}
				}
			}
			if (this.type == 72)
			{
				this.frameCounter += 1.0;
				if (this.frameCounter >= 3.0)
				{
					this.frameCounter = 0.0;
					this.frame.Y = this.frame.Y + num;
					if (this.frame.Y / num >= Main.npcFrameCount[this.type])
					{
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 65)
			{
				this.spriteDirection = this.direction;
				this.frameCounter += 1.0;
				if (this.wet)
				{
					if (this.frameCounter < 6.0)
					{
						this.frame.Y = 0;
					}
					else
					{
						if (this.frameCounter < 12.0)
						{
							this.frame.Y = num;
						}
						else
						{
							if (this.frameCounter < 18.0)
							{
								this.frame.Y = num * 2;
							}
							else
							{
								if (this.frameCounter < 24.0)
								{
									this.frame.Y = num * 3;
								}
								else
								{
									this.frameCounter = 0.0;
								}
							}
						}
					}
				}
			}
			if (this.type == 48 || this.type == 49 || this.type == 51 || this.type == 60 || this.type == 82 || this.type == 93 || this.type == 137)
			{
				if (this.velocity.X > 0f)
				{
					this.spriteDirection = 1;
				}
				if (this.velocity.X < 0f)
				{
					this.spriteDirection = -1;
				}
				this.rotation = this.velocity.X * 0.1f;
				this.frameCounter += 1.0;
				if (this.frameCounter >= 6.0)
				{
					this.frame.Y = this.frame.Y + num;
					this.frameCounter = 0.0;
				}
				if (this.frame.Y >= num * 4)
				{
					this.frame.Y = 0;
				}
			}
			if (this.type == 42)
			{
				this.frameCounter += 1.0;
				if (this.frameCounter < 2.0)
				{
					this.frame.Y = 0;
				}
				else
				{
					if (this.frameCounter < 4.0)
					{
						this.frame.Y = num;
					}
					else
					{
						if (this.frameCounter < 6.0)
						{
							this.frame.Y = num * 2;
						}
						else
						{
							if (this.frameCounter < 8.0)
							{
								this.frame.Y = num;
							}
							else
							{
								this.frameCounter = 0.0;
							}
						}
					}
				}
			}
			if (this.type == 43 || this.type == 56)
			{
				this.frameCounter += 1.0;
				if (this.frameCounter < 6.0)
				{
					this.frame.Y = 0;
				}
				else
				{
					if (this.frameCounter < 12.0)
					{
						this.frame.Y = num;
					}
					else
					{
						if (this.frameCounter < 18.0)
						{
							this.frame.Y = num * 2;
						}
						else
						{
							if (this.frameCounter < 24.0)
							{
								this.frame.Y = num;
							}
						}
					}
				}
				if (this.frameCounter == 23.0)
				{
					this.frameCounter = 0.0;
				}
			}
			if (this.type == 115)
			{
				this.frameCounter += 1.0;
				if (this.frameCounter < 3.0)
				{
					this.frame.Y = 0;
				}
				else
				{
					if (this.frameCounter < 6.0)
					{
						this.frame.Y = num;
					}
					else
					{
						if (this.frameCounter < 12.0)
						{
							this.frame.Y = num * 2;
						}
						else
						{
							if (this.frameCounter < 15.0)
							{
								this.frame.Y = num;
							}
						}
					}
				}
				if (this.frameCounter == 15.0)
				{
					this.frameCounter = 0.0;
				}
			}
			if (this.type == 101)
			{
				this.frameCounter += 1.0;
				if (this.frameCounter > 6.0)
				{
					this.frame.Y = this.frame.Y + num * 2;
					this.frameCounter = 0.0;
				}
				if (this.frame.Y > num * 2)
				{
					this.frame.Y = 0;
				}
			}
			if (this.type == 17 || this.type == 18 || this.type == 19 || this.type == 20 || this.type == 22 || this.type == 142 || this.type == 38 || this.type == 26 || this.type == 27 || this.type == 28 || this.type == 31 || this.type == 21 || this.type == 44 || this.type == 54 || this.type == 37 || this.type == 73 || this.type == 77 || this.type == 78 || this.type == 79 || this.type == 80 || this.type == 104 || this.type == 107 || this.type == 108 || this.type == 120 || this.type == 124 || this.type == 140)
			{
				if (this.velocity.Y == 0f)
				{
					if (this.direction == 1)
					{
						this.spriteDirection = 1;
					}
					if (this.direction == -1)
					{
						this.spriteDirection = -1;
					}
					if (this.velocity.X == 0f)
					{
						if (this.type == 140)
						{
							this.frame.Y = num;
							this.frameCounter = 0.0;
						}
						else
						{
							this.frame.Y = 0;
							this.frameCounter = 0.0;
						}
					}
					else
					{
						this.frameCounter += (double)(Math.Abs(this.velocity.X) * 2f);
						this.frameCounter += 1.0;
						if (this.frameCounter > 6.0)
						{
							this.frame.Y = this.frame.Y + num;
							this.frameCounter = 0.0;
						}
						if (this.frame.Y / num >= Main.npcFrameCount[this.type])
						{
							this.frame.Y = num * 2;
						}
					}
				}
				else
				{
					this.frameCounter = 0.0;
					this.frame.Y = num;
					if (this.type == 21 || this.type == 31 || this.type == 44 || this.type == 77 || this.type == 78 || this.type == 79 || this.type == 80 || this.type == 120 || this.type == 140)
					{
						this.frame.Y = 0;
					}
				}
			}
			else
			{
				if (this.type == 110)
				{
					if (this.velocity.Y == 0f)
					{
						if (this.direction == 1)
						{
							this.spriteDirection = 1;
						}
						if (this.direction == -1)
						{
							this.spriteDirection = -1;
						}
						if (this.ai[2] > 0f)
						{
							this.spriteDirection = this.direction;
							this.frame.Y = num * (int)this.ai[2];
							this.frameCounter = 0.0;
						}
						else
						{
							if (this.frame.Y < num * 6)
							{
								this.frame.Y = num * 6;
							}
							this.frameCounter += (double)(Math.Abs(this.velocity.X) * 2f);
							this.frameCounter += (double)this.velocity.X;
							if (this.frameCounter > 6.0)
							{
								this.frame.Y = this.frame.Y + num;
								this.frameCounter = 0.0;
							}
							if (this.frame.Y / num >= Main.npcFrameCount[this.type])
							{
								this.frame.Y = num * 6;
							}
						}
					}
					else
					{
						this.frameCounter = 0.0;
						this.frame.Y = 0;
					}
				}
			}
			if (this.type == 111)
			{
				if (this.velocity.Y == 0f)
				{
					if (this.direction == 1)
					{
						this.spriteDirection = 1;
					}
					if (this.direction == -1)
					{
						this.spriteDirection = -1;
					}
					if (this.ai[2] > 0f)
					{
						this.spriteDirection = this.direction;
						this.frame.Y = num * ((int)this.ai[2] - 1);
						this.frameCounter = 0.0;
					}
					else
					{
						if (this.frame.Y < num * 7)
						{
							this.frame.Y = num * 7;
						}
						this.frameCounter += (double)(Math.Abs(this.velocity.X) * 2f);
						this.frameCounter += (double)(this.velocity.X * 1.3f);
						if (this.frameCounter > 6.0)
						{
							this.frame.Y = this.frame.Y + num;
							this.frameCounter = 0.0;
						}
						if (this.frame.Y / num >= Main.npcFrameCount[this.type])
						{
							this.frame.Y = num * 7;
						}
					}
				}
				else
				{
					this.frameCounter = 0.0;
					this.frame.Y = num * 6;
				}
			}
			else
			{
				if (this.type == 3 || this.type == 52 || this.type == 53 || this.type == 132)
				{
					if (this.velocity.Y == 0f)
					{
						if (this.direction == 1)
						{
							this.spriteDirection = 1;
						}
						if (this.direction == -1)
						{
							this.spriteDirection = -1;
						}
					}
					if (this.velocity.Y != 0f || (this.direction == -1 && this.velocity.X > 0f) || (this.direction == 1 && this.velocity.X < 0f))
					{
						this.frameCounter = 0.0;
						this.frame.Y = num * 2;
					}
					else
					{
						if (this.velocity.X == 0f)
						{
							this.frameCounter = 0.0;
							this.frame.Y = 0;
						}
						else
						{
							this.frameCounter += (double)Math.Abs(this.velocity.X);
							if (this.frameCounter < 8.0)
							{
								this.frame.Y = 0;
							}
							else
							{
								if (this.frameCounter < 16.0)
								{
									this.frame.Y = num;
								}
								else
								{
									if (this.frameCounter < 24.0)
									{
										this.frame.Y = num * 2;
									}
									else
									{
										if (this.frameCounter < 32.0)
										{
											this.frame.Y = num;
										}
										else
										{
											this.frameCounter = 0.0;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					if (this.type == 46 || this.type == 47)
					{
						if (this.velocity.Y == 0f)
						{
							if (this.direction == 1)
							{
								this.spriteDirection = 1;
							}
							if (this.direction == -1)
							{
								this.spriteDirection = -1;
							}
							if (this.velocity.X == 0f)
							{
								this.frame.Y = 0;
								this.frameCounter = 0.0;
							}
							else
							{
								this.frameCounter += (double)(Math.Abs(this.velocity.X) * 1f);
								this.frameCounter += 1.0;
								if (this.frameCounter > 6.0)
								{
									this.frame.Y = this.frame.Y + num;
									this.frameCounter = 0.0;
								}
								if (this.frame.Y / num >= Main.npcFrameCount[this.type])
								{
									this.frame.Y = 0;
								}
							}
						}
						else
						{
							if (this.velocity.Y < 0f)
							{
								this.frameCounter = 0.0;
								this.frame.Y = num * 4;
							}
							else
							{
								if (this.velocity.Y > 0f)
								{
									this.frameCounter = 0.0;
									this.frame.Y = num * 6;
								}
							}
						}
					}
					else
					{
						if (this.type == 4 || this.type == 125 || this.type == 126)
						{
							this.frameCounter += 1.0;
							if (this.frameCounter < 7.0)
							{
								this.frame.Y = 0;
							}
							else
							{
								if (this.frameCounter < 14.0)
								{
									this.frame.Y = num;
								}
								else
								{
									if (this.frameCounter < 21.0)
									{
										this.frame.Y = num * 2;
									}
									else
									{
										this.frameCounter = 0.0;
										this.frame.Y = 0;
									}
								}
							}
							if (this.ai[0] > 1f)
							{
								this.frame.Y = this.frame.Y + num * 3;
							}
						}
						else
						{
							if (this.type == 5)
							{
								this.frameCounter += 1.0;
								if (this.frameCounter >= 8.0)
								{
									this.frame.Y = this.frame.Y + num;
									this.frameCounter = 0.0;
								}
								if (this.frame.Y >= num * Main.npcFrameCount[this.type])
								{
									this.frame.Y = 0;
								}
							}
							else
							{
								if (this.type == 94)
								{
									this.frameCounter += 1.0;
									if (this.frameCounter < 6.0)
									{
										this.frame.Y = 0;
									}
									else
									{
										if (this.frameCounter < 12.0)
										{
											this.frame.Y = num;
										}
										else
										{
											if (this.frameCounter < 18.0)
											{
												this.frame.Y = num * 2;
											}
											else
											{
												this.frame.Y = num;
												if (this.frameCounter >= 23.0)
												{
													this.frameCounter = 0.0;
												}
											}
										}
									}
								}
								else
								{
									if (this.type == 6)
									{
										this.frameCounter += 1.0;
										if (this.frameCounter >= 8.0)
										{
											this.frame.Y = this.frame.Y + num;
											this.frameCounter = 0.0;
										}
										if (this.frame.Y >= num * Main.npcFrameCount[this.type])
										{
											this.frame.Y = 0;
										}
									}
									else
									{
										if (this.type == 24)
										{
											if (this.velocity.Y == 0f)
											{
												if (this.direction == 1)
												{
													this.spriteDirection = 1;
												}
												if (this.direction == -1)
												{
													this.spriteDirection = -1;
												}
											}
											if (this.ai[1] > 0f)
											{
												if (this.frame.Y < 4)
												{
													this.frameCounter = 0.0;
												}
												this.frameCounter += 1.0;
												if (this.frameCounter <= 4.0)
												{
													this.frame.Y = num * 4;
												}
												else
												{
													if (this.frameCounter <= 8.0)
													{
														this.frame.Y = num * 5;
													}
													else
													{
														if (this.frameCounter <= 12.0)
														{
															this.frame.Y = num * 6;
														}
														else
														{
															if (this.frameCounter <= 16.0)
															{
																this.frame.Y = num * 7;
															}
															else
															{
																if (this.frameCounter <= 20.0)
																{
																	this.frame.Y = num * 8;
																}
																else
																{
																	this.frame.Y = num * 9;
																	this.frameCounter = 100.0;
																}
															}
														}
													}
												}
											}
											else
											{
												this.frameCounter += 1.0;
												if (this.frameCounter <= 4.0)
												{
													this.frame.Y = 0;
												}
												else
												{
													if (this.frameCounter <= 8.0)
													{
														this.frame.Y = num;
													}
													else
													{
														if (this.frameCounter <= 12.0)
														{
															this.frame.Y = num * 2;
														}
														else
														{
															this.frame.Y = num * 3;
															if (this.frameCounter >= 16.0)
															{
																this.frameCounter = 0.0;
															}
														}
													}
												}
											}
										}
										else
										{
											if (this.type == 29 || this.type == 32 || this.type == 45)
											{
												if (this.velocity.Y == 0f)
												{
													if (this.direction == 1)
													{
														this.spriteDirection = 1;
													}
													if (this.direction == -1)
													{
														this.spriteDirection = -1;
													}
												}
												this.frame.Y = 0;
												if (this.velocity.Y != 0f)
												{
													this.frame.Y = this.frame.Y + num;
												}
												else
												{
													if (this.ai[1] > 0f)
													{
														this.frame.Y = this.frame.Y + num * 2;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (this.type == 34)
			{
				this.frameCounter += 1.0;
				if (this.frameCounter >= 4.0)
				{
					this.frame.Y = this.frame.Y + num;
					this.frameCounter = 0.0;
				}
				if (this.frame.Y >= num * Main.npcFrameCount[this.type])
				{
					this.frame.Y = 0;
				}
			}
		}
		public void TargetClosest(bool faceTarget = true)
		{
			float num = -1f;
			for (int i = 0; i < 255; i++)
			{
				if (Main.player[i].active && !Main.player[i].dead && (num == -1f || Math.Abs(Main.player[i].position.X + (float)(Main.player[i].width / 2) - this.position.X + (float)(this.width / 2)) + Math.Abs(Main.player[i].position.Y + (float)(Main.player[i].height / 2) - this.position.Y + (float)(this.height / 2)) < num))
				{
					num = Math.Abs(Main.player[i].position.X + (float)(Main.player[i].width / 2) - this.position.X + (float)(this.width / 2)) + Math.Abs(Main.player[i].position.Y + (float)(Main.player[i].height / 2) - this.position.Y + (float)(this.height / 2));
					this.target = i;
				}
			}
			if (this.target < 0 || this.target >= 255)
			{
				this.target = 0;
			}
			this.targetRect = new Rectangle((int)Main.player[this.target].position.X, (int)Main.player[this.target].position.Y, Main.player[this.target].width, Main.player[this.target].height);
			if (Main.player[this.target].dead)
			{
				faceTarget = false;
			}
			if (faceTarget)
			{
				this.direction = 1;
				if ((float)(this.targetRect.X + this.targetRect.Width / 2) < this.position.X + (float)(this.width / 2))
				{
					this.direction = -1;
				}
				this.directionY = 1;
				if ((float)(this.targetRect.Y + this.targetRect.Height / 2) < this.position.Y + (float)(this.height / 2))
				{
					this.directionY = -1;
				}
			}
			if (this.confused)
			{
				this.direction *= -1;
			}
			if ((this.direction != this.oldDirection || this.directionY != this.oldDirectionY || this.target != this.oldTarget) && !this.collideX && !this.collideY)
			{
				this.netUpdate = true;
			}
		}
		public void CheckActive()
		{
			if (this.active)
			{
				if (this.type == 8 || this.type == 9 || this.type == 11 || this.type == 12 || this.type == 14 || this.type == 15 || this.type == 40 || this.type == 41 || this.type == 96 || this.type == 97 || this.type == 99 || this.type == 100 || (this.type > 87 && this.type <= 92) || this.type == 118 || this.type == 119 || this.type == 113 || this.type == 114 || this.type == 115)
				{
					return;
				}
				if (this.type >= 134 && this.type <= 136)
				{
					return;
				}
				if (this.townNPC)
				{
					Rectangle rectangle = new Rectangle((int)(this.position.X + (float)(this.width / 2) - (float)NPC.townRangeX), (int)(this.position.Y + (float)(this.height / 2) - (float)NPC.townRangeY), NPC.townRangeX * 2, NPC.townRangeY * 2);
					for (int i = 0; i < 255; i++)
					{
						if (Main.player[i].active && rectangle.Intersects(new Rectangle((int)Main.player[i].position.X, (int)Main.player[i].position.Y, Main.player[i].width, Main.player[i].height)))
						{
							Main.player[i].townNPCs += this.npcSlots;
						}
					}
					return;
				}
				bool flag = false;
				Rectangle rectangle2 = new Rectangle((int)(this.position.X + (float)(this.width / 2) - (float)NPC.activeRangeX), (int)(this.position.Y + (float)(this.height / 2) - (float)NPC.activeRangeY), NPC.activeRangeX * 2, NPC.activeRangeY * 2);
				Rectangle rectangle3 = new Rectangle((int)((double)(this.position.X + (float)(this.width / 2)) - (double)NPC.sWidth * 0.5 - (double)this.width), (int)((double)(this.position.Y + (float)(this.height / 2)) - (double)NPC.sHeight * 0.5 - (double)this.height), NPC.sWidth + this.width * 2, NPC.sHeight + this.height * 2);
				for (int j = 0; j < 255; j++)
				{
					if (Main.player[j].active)
					{
						if (rectangle2.Intersects(new Rectangle((int)Main.player[j].position.X, (int)Main.player[j].position.Y, Main.player[j].width, Main.player[j].height)))
						{
							flag = true;
							if (this.type != 25 && this.type != 30 && this.type != 33 && this.lifeMax > 0)
							{
								Main.player[j].activeNPCs += this.npcSlots;
							}
						}
						if (rectangle3.Intersects(new Rectangle((int)Main.player[j].position.X, (int)Main.player[j].position.Y, Main.player[j].width, Main.player[j].height)))
						{
							this.timeLeft = NPC.activeTime;
						}
						if (this.type == 7 || this.type == 10 || this.type == 13 || this.type == 39 || this.type == 87)
						{
							flag = true;
						}
						if (this.boss || this.type == 35 || this.type == 36 || this.type == 127 || this.type == 128 || this.type == 129 || this.type == 130 || this.type == 131)
						{
							flag = true;
						}
					}
				}
				this.timeLeft--;
				if (this.timeLeft <= 0)
				{
					flag = false;
				}
				if (!flag && Main.netMode != 1)
				{
					NPC.noSpawnCycle = true;
					this.active = false;
					if (Main.netMode == 2)
					{
						this.netSkip = -1;
						this.life = 0;
						NetMessage.SendData(23, -1, -1, "", this.whoAmI, 0f, 0f, 0f, 0);
					}
					if (this.aiStyle == 6)
					{
						for (int k = (int)this.ai[0]; k > 0; k = (int)Main.npc[k].ai[0])
						{
							if (Main.npc[k].active)
							{
								Main.npc[k].active = false;
								if (Main.netMode == 2)
								{
									Main.npc[k].life = 0;
									Main.npc[k].netSkip = -1;
									NetMessage.SendData(23, -1, -1, "", k, 0f, 0f, 0f, 0);
								}
							}
						}
					}
				}
			}
		}
		public static void SpawnNPC()
		{
			if (NPC.noSpawnCycle)
			{
				NPC.noSpawnCycle = false;
				return;
			}
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < 255; i++)
			{
				if (Main.player[i].active)
				{
					num3++;
				}
			}
			for (int j = 0; j < 255; j++)
			{
				if (Main.player[j].active && !Main.player[j].dead)
				{
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = false;
					if (Main.player[j].active && Main.invasionType > 0 && Main.invasionDelay == 0 && Main.invasionSize > 0 && (double)Main.player[j].position.Y < Main.worldSurface * 16.0 + (double)NPC.sHeight)
					{
						int num4 = 3000;
						if ((double)Main.player[j].position.X > Main.invasionX * 16.0 - (double)num4 && (double)Main.player[j].position.X < Main.invasionX * 16.0 + (double)num4)
						{
							flag4 = true;
						}
					}
					flag = false;
					NPC.spawnRate = NPC.defaultSpawnRate;
					NPC.maxSpawns = NPC.defaultMaxSpawns;
					if (Main.hardMode)
					{
						NPC.spawnRate = (int)((double)NPC.defaultSpawnRate * 0.9);
						NPC.maxSpawns = NPC.defaultMaxSpawns + 1;
					}
					if (Main.player[j].position.Y > (float)((Main.maxTilesY - 200) * 16))
					{
						NPC.maxSpawns = (int)((float)NPC.maxSpawns * 2f);
					}
					else
					{
						if ((double)Main.player[j].position.Y > Main.rockLayer * 16.0 + (double)NPC.sHeight)
						{
							NPC.spawnRate = (int)((double)NPC.spawnRate * 0.4);
							NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.9f);
						}
						else
						{
							if ((double)Main.player[j].position.Y > Main.worldSurface * 16.0 + (double)NPC.sHeight)
							{
								if (Main.hardMode)
								{
									NPC.spawnRate = (int)((double)NPC.spawnRate * 0.45);
									NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.8f);
								}
								else
								{
									NPC.spawnRate = (int)((double)NPC.spawnRate * 0.5);
									NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.7f);
								}
							}
							else
							{
								if (!Main.dayTime)
								{
									NPC.spawnRate = (int)((double)NPC.spawnRate * 0.6);
									NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.3f);
									if (Main.bloodMoon)
									{
										NPC.spawnRate = (int)((double)NPC.spawnRate * 0.3);
										NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.8f);
									}
								}
							}
						}
					}
					if (Main.player[j].zoneDungeon)
					{
						NPC.spawnRate = (int)((double)NPC.spawnRate * 0.4);
						NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.7f);
					}
					else
					{
						if (Main.player[j].zoneJungle)
						{
							NPC.spawnRate = (int)((double)NPC.spawnRate * 0.4);
							NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.5f);
						}
						else
						{
							if (Main.player[j].zoneEvil)
							{
								NPC.spawnRate = (int)((double)NPC.spawnRate * 0.65);
								NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.3f);
							}
							else
							{
								if (Main.player[j].zoneMeteor)
								{
									NPC.spawnRate = (int)((double)NPC.spawnRate * 0.4);
									NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.1f);
								}
							}
						}
					}
					if (Main.player[j].zoneHoly && (double)Main.player[j].position.Y > Main.rockLayer * 16.0 + (double)NPC.sHeight)
					{
						NPC.spawnRate = (int)((double)NPC.spawnRate * 0.65);
						NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.3f);
					}
					if (Main.wof >= 0 && Main.player[j].position.Y > (float)((Main.maxTilesY - 200) * 16))
					{
						NPC.maxSpawns = (int)((float)NPC.maxSpawns * 0.3f);
						NPC.spawnRate *= 3;
					}
					if ((double)Main.player[j].activeNPCs < (double)NPC.maxSpawns * 0.2)
					{
						NPC.spawnRate = (int)((float)NPC.spawnRate * 0.6f);
					}
					else
					{
						if ((double)Main.player[j].activeNPCs < (double)NPC.maxSpawns * 0.4)
						{
							NPC.spawnRate = (int)((float)NPC.spawnRate * 0.7f);
						}
						else
						{
							if ((double)Main.player[j].activeNPCs < (double)NPC.maxSpawns * 0.6)
							{
								NPC.spawnRate = (int)((float)NPC.spawnRate * 0.8f);
							}
							else
							{
								if ((double)Main.player[j].activeNPCs < (double)NPC.maxSpawns * 0.8)
								{
									NPC.spawnRate = (int)((float)NPC.spawnRate * 0.9f);
								}
							}
						}
					}
					if ((double)(Main.player[j].position.Y * 16f) > (Main.worldSurface + Main.rockLayer) / 2.0 || Main.player[j].zoneEvil)
					{
						if ((double)Main.player[j].activeNPCs < (double)NPC.maxSpawns * 0.2)
						{
							NPC.spawnRate = (int)((float)NPC.spawnRate * 0.7f);
						}
						else
						{
							if ((double)Main.player[j].activeNPCs < (double)NPC.maxSpawns * 0.4)
							{
								NPC.spawnRate = (int)((float)NPC.spawnRate * 0.9f);
							}
						}
					}
					if (Main.player[j].inventory[Main.player[j].selectedItem].type == 148)
					{
						NPC.spawnRate = (int)((double)NPC.spawnRate * 0.75);
						NPC.maxSpawns = (int)((float)NPC.maxSpawns * 1.5f);
					}
					if (Main.player[j].enemySpawns)
					{
						NPC.spawnRate = (int)((double)NPC.spawnRate * 0.5);
						NPC.maxSpawns = (int)((float)NPC.maxSpawns * 2f);
					}
					if ((double)NPC.spawnRate < (double)NPC.defaultSpawnRate * 0.1)
					{
						NPC.spawnRate = (int)((double)NPC.defaultSpawnRate * 0.1);
					}
					if (NPC.maxSpawns > NPC.defaultMaxSpawns * 3)
					{
						NPC.maxSpawns = NPC.defaultMaxSpawns * 3;
					}
					if (flag4)
					{
						NPC.maxSpawns = (int)((double)NPC.defaultMaxSpawns * (2.0 + 0.3 * (double)num3));
						NPC.spawnRate = 20;
					}
					if (Main.player[j].zoneDungeon && !NPC.downedBoss3)
					{
						NPC.spawnRate = 10;
					}
					bool flag6 = false;
					if (!flag4 && (!Main.bloodMoon || Main.dayTime) && !Main.player[j].zoneDungeon && !Main.player[j].zoneEvil && !Main.player[j].zoneMeteor)
					{
						if (Main.player[j].townNPCs == 1f)
						{
							flag3 = true;
							if (Main.rand.Next(3) <= 1)
							{
								flag6 = true;
								NPC.maxSpawns = (int)((double)((float)NPC.maxSpawns) * 0.6);
							}
							else
							{
								NPC.spawnRate = (int)((float)NPC.spawnRate * 2f);
							}
						}
						else
						{
							if (Main.player[j].townNPCs == 2f)
							{
								flag3 = true;
								if (Main.rand.Next(3) == 0)
								{
									flag6 = true;
									NPC.maxSpawns = (int)((double)((float)NPC.maxSpawns) * 0.6);
								}
								else
								{
									NPC.spawnRate = (int)((float)NPC.spawnRate * 3f);
								}
							}
							else
							{
								if (Main.player[j].townNPCs >= 3f)
								{
									flag3 = true;
									flag6 = true;
									NPC.maxSpawns = (int)((double)((float)NPC.maxSpawns) * 0.6);
								}
							}
						}
					}
					if (Main.player[j].active && !Main.player[j].dead && Main.player[j].activeNPCs < (float)NPC.maxSpawns && Main.rand.Next(NPC.spawnRate) == 0)
					{
						int num5 = (int)(Main.player[j].position.X / 16f) - NPC.spawnRangeX;
						int num6 = (int)(Main.player[j].position.X / 16f) + NPC.spawnRangeX;
						int num7 = (int)(Main.player[j].position.Y / 16f) - NPC.spawnRangeY;
						int num8 = (int)(Main.player[j].position.Y / 16f) + NPC.spawnRangeY;
						int num9 = (int)(Main.player[j].position.X / 16f) - NPC.safeRangeX;
						int num10 = (int)(Main.player[j].position.X / 16f) + NPC.safeRangeX;
						int num11 = (int)(Main.player[j].position.Y / 16f) - NPC.safeRangeY;
						int num12 = (int)(Main.player[j].position.Y / 16f) + NPC.safeRangeY;
						if (num5 < 0)
						{
							num5 = 0;
						}
						if (num6 > Main.maxTilesX)
						{
							num6 = Main.maxTilesX;
						}
						if (num7 < 0)
						{
							num7 = 0;
						}
						if (num8 > Main.maxTilesY)
						{
							num8 = Main.maxTilesY;
						}
						int k = 0;
						while (k < 50)
						{
							int num13 = Main.rand.Next(num5, num6);
							int num14 = Main.rand.Next(num7, num8);
							if (Main.tile[num13, num14].active && Main.tileSolid[(int)Main.tile[num13, num14].type])
							{
								goto IL_C34;
							}
							if (!Main.wallHouse[(int)Main.tile[num13, num14].wall])
							{
								if (!flag4 && (double)num14 < Main.worldSurface * 0.34999999403953552 && !flag6 && ((double)num13 < (double)Main.maxTilesX * 0.45 || (double)num13 > (double)Main.maxTilesX * 0.55 || Main.hardMode))
								{
									byte arg_A98_0 = Main.tile[num13, num14].type;
									num = num13;
									num2 = num14;
									flag = true;
									flag2 = true;
								}
								else
								{
									if (!flag4 && (double)num14 < Main.worldSurface * 0.44999998807907104 && !flag6 && Main.hardMode && Main.rand.Next(10) == 0)
									{
										byte arg_AEC_0 = Main.tile[num13, num14].type;
										num = num13;
										num2 = num14;
										flag = true;
										flag2 = true;
									}
									else
									{
										int l = num14;
										while (l < Main.maxTilesY)
										{
											if (Main.tile[num13, l].active && Main.tileSolid[(int)Main.tile[num13, l].type])
											{
												if (num13 < num9 || num13 > num10 || l < num11 || l > num12)
												{
													byte arg_B5A_0 = Main.tile[num13, l].type;
													num = num13;
													num2 = l;
													flag = true;
													break;
												}
												break;
											}
											else
											{
												l++;
											}
										}
									}
								}
								if (!flag)
								{
									goto IL_C34;
								}
								int num15 = num - NPC.spawnSpaceX / 2;
								int num16 = num + NPC.spawnSpaceX / 2;
								int num17 = num2 - NPC.spawnSpaceY;
								int num18 = num2;
								if (num15 < 0)
								{
									flag = false;
								}
								if (num16 > Main.maxTilesX)
								{
									flag = false;
								}
								if (num17 < 0)
								{
									flag = false;
								}
								if (num18 > Main.maxTilesY)
								{
									flag = false;
								}
								if (flag)
								{
									for (int m = num15; m < num16; m++)
									{
										for (int n = num17; n < num18; n++)
										{
											if (Main.tile[m, n].active && Main.tileSolid[(int)Main.tile[m, n].type])
											{
												flag = false;
												break;
											}
											if (Main.tile[m, n].lava)
											{
												flag = false;
												break;
											}
										}
									}
									goto IL_C34;
								}
								goto IL_C34;
							}
							IL_C3A:
							k++;
							continue;
							IL_C34:
							if (!flag && !flag)
							{
								goto IL_C3A;
							}
							break;
						}
					}
					if (flag)
					{
						Rectangle rectangle = new Rectangle(num * 16, num2 * 16, 16, 16);
						for (int num19 = 0; num19 < 255; num19++)
						{
							if (Main.player[num19].active)
							{
								Rectangle rectangle2 = new Rectangle((int)(Main.player[num19].position.X + (float)(Main.player[num19].width / 2) - (float)(NPC.sWidth / 2) - (float)NPC.safeRangeX), (int)(Main.player[num19].position.Y + (float)(Main.player[num19].height / 2) - (float)(NPC.sHeight / 2) - (float)NPC.safeRangeY), NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
								if (rectangle.Intersects(rectangle2))
								{
									flag = false;
								}
							}
						}
					}
					if (flag)
					{
						if (Main.player[j].zoneDungeon && (!Main.tileDungeon[(int)Main.tile[num, num2].type] || Main.tile[num, num2 - 1].wall == 0))
						{
							flag = false;
						}
						if (Main.tile[num, num2 - 1].liquid > 0 && Main.tile[num, num2 - 2].liquid > 0 && !Main.tile[num, num2 - 1].lava)
						{
							flag5 = true;
						}
					}
					if (flag)
					{
						flag = false;
						int num20 = (int)Main.tile[num, num2].type;
						int num21 = 200;
						if (flag2)
						{
							if (Main.hardMode && Main.rand.Next(10) == 0 && !NPC.AnyNPCs(87))
							{
								NPC.NewNPC(num * 16 + 8, num2 * 16, 87, 1);
							}
							else
							{
								NPC.NewNPC(num * 16 + 8, num2 * 16, 48, 0);
							}
						}
						else
						{
							if (flag4)
							{
								if (Main.invasionType == 1)
								{
									if (Main.rand.Next(9) == 0)
									{
										NPC.NewNPC(num * 16 + 8, num2 * 16, 29, 0);
									}
									else
									{
										if (Main.rand.Next(5) == 0)
										{
											NPC.NewNPC(num * 16 + 8, num2 * 16, 26, 0);
										}
										else
										{
											if (Main.rand.Next(3) == 0)
											{
												NPC.NewNPC(num * 16 + 8, num2 * 16, 111, 0);
											}
											else
											{
												if (Main.rand.Next(3) == 0)
												{
													NPC.NewNPC(num * 16 + 8, num2 * 16, 27, 0);
												}
												else
												{
													NPC.NewNPC(num * 16 + 8, num2 * 16, 28, 0);
												}
											}
										}
									}
								}
								else
								{
									if (Main.invasionType == 2)
									{
										if (Main.rand.Next(7) == 0)
										{
											NPC.NewNPC(num * 16 + 8, num2 * 16, 145, 0);
										}
										else
										{
											if (Main.rand.Next(3) == 0)
											{
												NPC.NewNPC(num * 16 + 8, num2 * 16, 143, 0);
											}
											else
											{
												NPC.NewNPC(num * 16 + 8, num2 * 16, 144, 0);
											}
										}
									}
								}
							}
							else
							{
								if (flag5 && (num < 250 || num > Main.maxTilesX - 250) && num20 == 53 && (double)num2 < Main.rockLayer)
								{
									if (Main.rand.Next(8) == 0)
									{
										NPC.NewNPC(num * 16 + 8, num2 * 16, 65, 0);
									}
									if (Main.rand.Next(3) == 0)
									{
										NPC.NewNPC(num * 16 + 8, num2 * 16, 67, 0);
									}
									else
									{
										NPC.NewNPC(num * 16 + 8, num2 * 16, 64, 0);
									}
								}
								else
								{
									if (flag5 && (((double)num2 > Main.rockLayer && Main.rand.Next(2) == 0) || num20 == 60))
									{
										if (Main.hardMode && Main.rand.Next(3) > 0)
										{
											NPC.NewNPC(num * 16 + 8, num2 * 16, 102, 0);
										}
										else
										{
											NPC.NewNPC(num * 16 + 8, num2 * 16, 58, 0);
										}
									}
									else
									{
										if (flag5 && (double)num2 > Main.worldSurface && Main.rand.Next(3) == 0)
										{
											if (Main.hardMode)
											{
												NPC.NewNPC(num * 16 + 8, num2 * 16, 103, 0);
											}
											else
											{
												NPC.NewNPC(num * 16 + 8, num2 * 16, 63, 0);
											}
										}
										else
										{
											if (flag5 && Main.rand.Next(4) == 0)
											{
												if (Main.player[j].zoneEvil)
												{
													NPC.NewNPC(num * 16 + 8, num2 * 16, 57, 0);
												}
												else
												{
													NPC.NewNPC(num * 16 + 8, num2 * 16, 55, 0);
												}
											}
											else
											{
												if (NPC.downedGoblins && Main.rand.Next(20) == 0 && !flag5 && (double)num2 >= Main.rockLayer && num2 < Main.maxTilesY - 210 && !NPC.savedGoblin && !NPC.AnyNPCs(105))
												{
													NPC.NewNPC(num * 16 + 8, num2 * 16, 105, 0);
												}
												else
												{
													if (Main.hardMode && Main.rand.Next(20) == 0 && !flag5 && (double)num2 >= Main.rockLayer && num2 < Main.maxTilesY - 210 && !NPC.savedWizard && !NPC.AnyNPCs(106))
													{
														NPC.NewNPC(num * 16 + 8, num2 * 16, 106, 0);
													}
													else
													{
														if (flag6)
														{
															if (flag5)
															{
																NPC.NewNPC(num * 16 + 8, num2 * 16, 55, 0);
															}
															else
															{
																if (num20 != 2 && num20 != 109 && num20 != 147 && (double)num2 <= Main.worldSurface)
																{
																	return;
																}
																if (Main.rand.Next(2) == 0 && (double)num2 <= Main.worldSurface)
																{
																	NPC.NewNPC(num * 16 + 8, num2 * 16, 74, 0);
																}
																else
																{
																	NPC.NewNPC(num * 16 + 8, num2 * 16, 46, 0);
																}
															}
														}
														else
														{
															if (Main.player[j].zoneDungeon)
															{
																if (!NPC.downedBoss3)
																{
																	num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 68, 0);
																}
																else
																{
																	if (!NPC.savedMech && Main.rand.Next(5) == 0 && !flag5 && !NPC.AnyNPCs(123) && (double)num2 > Main.rockLayer)
																	{
																		NPC.NewNPC(num * 16 + 8, num2 * 16, 123, 0);
																	}
																	else
																	{
																		if (Main.rand.Next(37) == 0)
																		{
																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 71, 0);
																		}
																		else
																		{
																			if (Main.rand.Next(4) == 0 && !NPC.NearSpikeBall(num, num2))
																			{
																				num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 70, 0);
																			}
																			else
																			{
																				if (Main.rand.Next(15) == 0)
																				{
																					num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 72, 0);
																				}
																				else
																				{
																					if (Main.rand.Next(9) == 0)
																					{
																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 34, 0);
																					}
																					else
																					{
																						if (Main.rand.Next(7) == 0)
																						{
																							num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 32, 0);
																						}
																						else
																						{
																							num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 31, 0);
																							if (Main.rand.Next(4) == 0)
																							{
																								Main.npc[num21].SetDefaults("Big Boned");
																							}
																							else
																							{
																								if (Main.rand.Next(5) == 0)
																								{
																									Main.npc[num21].SetDefaults("Short Bones");
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
															else
															{
																if (Main.player[j].zoneMeteor)
																{
																	num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 23, 0);
																}
																else
																{
																	if (Main.player[j].zoneEvil && Main.rand.Next(65) == 0)
																	{
																		if (Main.hardMode && Main.rand.Next(4) != 0)
																		{
																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 98, 1);
																		}
																		else
																		{
																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 7, 1);
																		}
																	}
																	else
																	{
																		if (Main.hardMode && (double)num2 > Main.worldSurface && Main.rand.Next(75) == 0)
																		{
																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 85, 0);
																		}
																		else
																		{
																			if (Main.hardMode && Main.tile[num, num2 - 1].wall == 2 && Main.rand.Next(20) == 0)
																			{
																				num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 85, 0);
																			}
																			else
																			{
																				if (Main.hardMode && (double)num2 <= Main.worldSurface && !Main.dayTime && (Main.rand.Next(20) == 0 || (Main.rand.Next(5) == 0 && Main.moonPhase == 4)))
																				{
																					num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 82, 0);
																				}
																				else
																				{
																					if (num20 == 60 && Main.rand.Next(500) == 0 && !Main.dayTime)
																					{
																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 52, 0);
																					}
																					else
																					{
																						if (num20 == 60 && (double)num2 > (Main.worldSurface + Main.rockLayer) / 2.0)
																						{
																							if (Main.rand.Next(3) == 0)
																							{
																								num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 43, 0);
																								Main.npc[num21].ai[0] = (float)num;
																								Main.npc[num21].ai[1] = (float)num2;
																								Main.npc[num21].netUpdate = true;
																							}
																							else
																							{
																								num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 42, 0);
																								if (Main.rand.Next(4) == 0)
																								{
																									Main.npc[num21].SetDefaults("Little Stinger");
																								}
																								else
																								{
																									if (Main.rand.Next(4) == 0)
																									{
																										Main.npc[num21].SetDefaults("Big Stinger");
																									}
																								}
																							}
																						}
																						else
																						{
																							if (num20 == 60 && Main.rand.Next(4) == 0)
																							{
																								num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 51, 0);
																							}
																							else
																							{
																								if (num20 == 60 && Main.rand.Next(8) == 0)
																								{
																									num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 56, 0);
																									Main.npc[num21].ai[0] = (float)num;
																									Main.npc[num21].ai[1] = (float)num2;
																									Main.npc[num21].netUpdate = true;
																								}
																								else
																								{
																									if (Main.hardMode && num20 == 53 && Main.rand.Next(3) == 0)
																									{
																										num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 78, 0);
																									}
																									else
																									{
																										if (Main.hardMode && num20 == 112 && Main.rand.Next(2) == 0)
																										{
																											num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 79, 0);
																										}
																										else
																										{
																											if (Main.hardMode && num20 == 116 && Main.rand.Next(2) == 0)
																											{
																												num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 80, 0);
																											}
																											else
																											{
																												if (Main.hardMode && !flag5 && (double)num2 < Main.rockLayer && (num20 == 116 || num20 == 117 || num20 == 109))
																												{
																													if (!Main.dayTime && Main.rand.Next(2) == 0)
																													{
																														num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 122, 0);
																													}
																													else
																													{
																														if (Main.rand.Next(10) == 0)
																														{
																															num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 86, 0);
																														}
																														else
																														{
																															num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 75, 0);
																														}
																													}
																												}
																												else
																												{
																													if (!flag3 && Main.hardMode && Main.rand.Next(50) == 0 && !flag5 && (double)num2 >= Main.rockLayer && (num20 == 116 || num20 == 117 || num20 == 109))
																													{
																														num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 84, 0);
																													}
																													else
																													{
																														if ((num20 == 22 && Main.player[j].zoneEvil) || num20 == 23 || num20 == 25 || num20 == 112)
																														{
																															if (Main.hardMode && (double)num2 >= Main.rockLayer && Main.rand.Next(3) == 0)
																															{
																																num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 101, 0);
																																Main.npc[num21].ai[0] = (float)num;
																																Main.npc[num21].ai[1] = (float)num2;
																																Main.npc[num21].netUpdate = true;
																															}
																															else
																															{
																																if (Main.hardMode && Main.rand.Next(3) == 0)
																																{
																																	if (Main.rand.Next(3) == 0)
																																	{
																																		num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 121, 0);
																																	}
																																	else
																																	{
																																		num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 81, 0);
																																	}
																																}
																																else
																																{
																																	if (Main.hardMode && (double)num2 >= Main.rockLayer && Main.rand.Next(40) == 0)
																																	{
																																		num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 83, 0);
																																	}
																																	else
																																	{
																																		if (Main.hardMode && (Main.rand.Next(2) == 0 || (double)num2 > Main.rockLayer))
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 94, 0);
																																		}
																																		else
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 6, 0);
																																			if (Main.rand.Next(3) == 0)
																																			{
																																				Main.npc[num21].SetDefaults("Little Eater");
																																			}
																																			else
																																			{
																																				if (Main.rand.Next(3) == 0)
																																				{
																																					Main.npc[num21].SetDefaults("Big Eater");
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																														else
																														{
																															if ((double)num2 <= Main.worldSurface)
																															{
																																if (Main.dayTime)
																																{
																																	int num22 = Math.Abs(num - Main.spawnTileX);
																																	if (num22 < Main.maxTilesX / 3 && Main.rand.Next(15) == 0 && (num20 == 2 || num20 == 109 || num20 == 147))
																																	{
																																		NPC.NewNPC(num * 16 + 8, num2 * 16, 46, 0);
																																	}
																																	else
																																	{
																																		if (num22 < Main.maxTilesX / 3 && Main.rand.Next(15) == 0 && (num20 == 2 || num20 == 109 || num20 == 147))
																																		{
																																			NPC.NewNPC(num * 16 + 8, num2 * 16, 74, 0);
																																		}
																																		else
																																		{
																																			if (num22 > Main.maxTilesX / 3 && num20 == 2 && Main.rand.Next(300) == 0 && !NPC.AnyNPCs(50))
																																			{
																																				num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 50, 0);
																																			}
																																			else
																																			{
																																				if (num20 == 53 && Main.rand.Next(5) == 0 && !flag5)
																																				{
																																					num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 69, 0);
																																				}
																																				else
																																				{
																																					if (num20 == 53 && !flag5)
																																					{
																																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 61, 0);
																																					}
																																					else
																																					{
																																						if (num22 > Main.maxTilesX / 3 && Main.rand.Next(15) == 0)
																																						{
																																							num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 73, 0);
																																						}
																																						else
																																						{
																																							num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 1, 0);
																																							if (num20 == 60)
																																							{
																																								Main.npc[num21].SetDefaults("Jungle Slime");
																																							}
																																							else
																																							{
																																								if (Main.rand.Next(3) == 0 || num22 < 200)
																																								{
																																									Main.npc[num21].SetDefaults("Green Slime");
																																								}
																																								else
																																								{
																																									if (Main.rand.Next(10) == 0 && num22 > 400)
																																									{
																																										Main.npc[num21].SetDefaults("Purple Slime");
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																																else
																																{
																																	if (Main.rand.Next(6) == 0 || (Main.moonPhase == 4 && Main.rand.Next(2) == 0))
																																	{
																																		if (Main.hardMode && Main.rand.Next(3) == 0)
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 133, 0);
																																		}
																																		else
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 2, 0);
																																		}
																																	}
																																	else
																																	{
																																		if (Main.hardMode && Main.rand.Next(50) == 0 && Main.bloodMoon && !NPC.AnyNPCs(109))
																																		{
																																			NPC.NewNPC(num * 16 + 8, num2 * 16, 109, 0);
																																		}
																																		else
																																		{
																																			if (Main.rand.Next(250) == 0 && Main.bloodMoon)
																																			{
																																				NPC.NewNPC(num * 16 + 8, num2 * 16, 53, 0);
																																			}
																																			else
																																			{
																																				if (Main.moonPhase == 0 && Main.hardMode && Main.rand.Next(3) != 0)
																																				{
																																					NPC.NewNPC(num * 16 + 8, num2 * 16, 104, 0);
																																				}
																																				else
																																				{
																																					if (Main.hardMode && Main.rand.Next(3) == 0)
																																					{
																																						NPC.NewNPC(num * 16 + 8, num2 * 16, 140, 0);
																																					}
																																					else
																																					{
																																						if (Main.rand.Next(3) == 0)
																																						{
																																							NPC.NewNPC(num * 16 + 8, num2 * 16, 132, 0);
																																						}
																																						else
																																						{
																																							NPC.NewNPC(num * 16 + 8, num2 * 16, 3, 0);
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																															else
																															{
																																if ((double)num2 <= Main.rockLayer)
																																{
																																	if (!flag3 && Main.rand.Next(50) == 0)
																																	{
																																		if (Main.hardMode)
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 95, 1);
																																		}
																																		else
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 10, 1);
																																		}
																																	}
																																	else
																																	{
																																		if (Main.hardMode && Main.rand.Next(3) == 0)
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 140, 0);
																																		}
																																		else
																																		{
																																			if (Main.hardMode && Main.rand.Next(4) != 0)
																																			{
																																				num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 141, 0);
																																			}
																																			else
																																			{
																																				num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 1, 0);
																																				if (Main.rand.Next(5) == 0)
																																				{
																																					Main.npc[num21].SetDefaults("Yellow Slime");
																																				}
																																				else
																																				{
																																					if (Main.rand.Next(2) == 0)
																																					{
																																						Main.npc[num21].SetDefaults("Blue Slime");
																																					}
																																					else
																																					{
																																						Main.npc[num21].SetDefaults("Red Slime");
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																																else
																																{
																																	if (num2 > Main.maxTilesY - 190)
																																	{
																																		if (Main.rand.Next(40) == 0 && !NPC.AnyNPCs(39))
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 39, 1);
																																		}
																																		else
																																		{
																																			if (Main.rand.Next(14) == 0)
																																			{
																																				num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 24, 0);
																																			}
																																			else
																																			{
																																				if (Main.rand.Next(8) == 0)
																																				{
																																					if (Main.rand.Next(7) == 0)
																																					{
																																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 66, 0);
																																					}
																																					else
																																					{
																																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 62, 0);
																																					}
																																				}
																																				else
																																				{
																																					if (Main.rand.Next(3) == 0)
																																					{
																																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 59, 0);
																																					}
																																					else
																																					{
																																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 60, 0);
																																					}
																																				}
																																			}
																																		}
																																	}
																																	else
																																	{
																																		if ((num20 == 116 || num20 == 117) && !flag3 && Main.rand.Next(8) == 0)
																																		{
																																			num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 120, 0);
																																		}
																																		else
																																		{
																																			if (!flag3 && Main.rand.Next(75) == 0 && !Main.player[j].zoneHoly)
																																			{
																																				if (Main.hardMode)
																																				{
																																					num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 95, 1);
																																				}
																																				else
																																				{
																																					num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 10, 1);
																																				}
																																			}
																																			else
																																			{
																																				if (!Main.hardMode && Main.rand.Next(10) == 0)
																																				{
																																					num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 16, 0);
																																				}
																																				else
																																				{
																																					if (!Main.hardMode && Main.rand.Next(4) == 0)
																																					{
																																						num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 1, 0);
																																						if (Main.player[j].zoneJungle)
																																						{
																																							Main.npc[num21].SetDefaults("Jungle Slime");
																																						}
																																						else
																																						{
																																							Main.npc[num21].SetDefaults("Black Slime");
																																						}
																																					}
																																					else
																																					{
																																						if (Main.rand.Next(2) == 0)
																																						{
																																							if ((double)num2 > (Main.rockLayer + (double)Main.maxTilesY) / 2.0 && Main.rand.Next(700) == 0)
																																							{
																																								num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 45, 0);
																																							}
																																							else
																																							{
																																								if (Main.hardMode && Main.rand.Next(10) != 0)
																																								{
																																									if (Main.rand.Next(2) == 0)
																																									{
																																										num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 77, 0);
																																										if ((double)num2 > (Main.rockLayer + (double)Main.maxTilesY) / 2.0 && Main.rand.Next(5) == 0)
																																										{
																																											Main.npc[num21].SetDefaults("Heavy Skeleton");
																																										}
																																									}
																																									else
																																									{
																																										num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 110, 0);
																																									}
																																								}
																																								else
																																								{
																																									if (Main.rand.Next(15) == 0)
																																									{
																																										num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 44, 0);
																																									}
																																									else
																																									{
																																										num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 21, 0);
																																									}
																																								}
																																							}
																																						}
																																						else
																																						{
																																							if (Main.hardMode && (Main.player[j].zoneHoly & Main.rand.Next(2) == 0))
																																							{
																																								num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 138, 0);
																																							}
																																							else
																																							{
																																								if (Main.player[j].zoneJungle)
																																								{
																																									num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 51, 0);
																																								}
																																								else
																																								{
																																									if (Main.hardMode && Main.player[j].zoneHoly)
																																									{
																																										num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 137, 0);
																																									}
																																									else
																																									{
																																										if (Main.hardMode && Main.rand.Next(6) > 0)
																																										{
																																											num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 93, 0);
																																										}
																																										else
																																										{
																																											num21 = NPC.NewNPC(num * 16 + 8, num2 * 16, 49, 0);
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						if (Main.npc[num21].type == 1 && Main.rand.Next(250) == 0)
						{
							Main.npc[num21].SetDefaults("Pinky");
						}
						if (Main.netMode == 2 && num21 < 200)
						{
							NetMessage.SendData(23, -1, -1, "", num21, 0f, 0f, 0f, 0);
							return;
						}
						break;
					}
				}
			}
		}
		public static void SpawnWOF(Vector2 pos)
		{
			if (pos.Y / 16f < (float)(Main.maxTilesY - 205))
			{
				return;
			}
			if (Main.wof >= 0)
			{
				return;
			}
			if (Main.netMode == 1)
			{
				return;
			}
			Player.FindClosest(pos, 16, 16);
			int num = 1;
			if (pos.X / 16f > (float)(Main.maxTilesX / 2))
			{
				num = -1;
			}
			bool flag = false;
			int num2 = (int)pos.X;
			while (!flag)
			{
				flag = true;
				for (int i = 0; i < 255; i++)
				{
					if (Main.player[i].active && Main.player[i].position.X > (float)(num2 - 1200) && Main.player[i].position.X < (float)(num2 + 1200))
					{
						num2 -= num * 16;
						flag = false;
					}
				}
				if (num2 / 16 < 20 || num2 / 16 > Main.maxTilesX - 20)
				{
					flag = true;
				}
			}
			int num3 = (int)pos.Y;
			int num4 = num2 / 16;
			int num5 = num3 / 16;
			int num6 = 0;
			try
			{
				while (WorldGen.SolidTile(num4, num5 - num6) || Main.tile[num4, num5 - num6].liquid >= 100)
				{
					if (!WorldGen.SolidTile(num4, num5 + num6) && Main.tile[num4, num5 + num6].liquid < 100)
					{
						num5 += num6;
						goto IL_162;
					}
					num6++;
				}
				num5 -= num6;
			}
			catch
			{
			}
			IL_162:
			num3 = num5 * 16;
			int num7 = NPC.NewNPC(num2, num3, 113, 0);
			if (Main.npc[num7].displayName == "")
			{
				Main.npc[num7].displayName = Main.npc[num7].name;
			}
            if (Main.netMode == 0)
            {
                Main.NewText(Main.npc[num7].displayName + " " + Lang.misc[16], (byte)175, (byte)75, byte.MaxValue);
            }
            else
            {
                if (Main.netMode != 2)
                    return;
                NetMessage.SendData(25, -1, -1, Main.npc[num7].displayName + " " + Lang.misc[16], (int) byte.MaxValue, 175f, 75f, (float) byte.MaxValue, 0);
            }
		}
        public static void SpawnOnPlayer(int plr, int Type)
        {
            if (Main.netMode == 1)
                return;
            bool flag = false;
            int num1 = 0;
            int num2 = 0;
            int minValue1 = (int)((double)Main.player[plr].position.X / 16.0) - NPC.spawnRangeX * 2;
            int maxValue1 = (int)((double)Main.player[plr].position.X / 16.0) + NPC.spawnRangeX * 2;
            int minValue2 = (int)((double)Main.player[plr].position.Y / 16.0) - NPC.spawnRangeY * 2;
            int maxValue2 = (int)((double)Main.player[plr].position.Y / 16.0) + NPC.spawnRangeY * 2;
            int num3 = (int)((double)Main.player[plr].position.X / 16.0) - NPC.safeRangeX;
            int num4 = (int)((double)Main.player[plr].position.X / 16.0) + NPC.safeRangeX;
            int num5 = (int)((double)Main.player[plr].position.Y / 16.0) - NPC.safeRangeY;
            int num6 = (int)((double)Main.player[plr].position.Y / 16.0) + NPC.safeRangeY;
            if (minValue1 < 0)
                minValue1 = 0;
            if (maxValue1 > Main.maxTilesX)
                maxValue1 = Main.maxTilesX;
            if (minValue2 < 0)
                minValue2 = 0;
            if (maxValue2 > Main.maxTilesY)
                maxValue2 = Main.maxTilesY;
            for (int index1 = 0; index1 < 1000; ++index1)
            {
                for (int index2 = 0; index2 < 100; ++index2)
                {
                    int index3 = Main.rand.Next(minValue1, maxValue1);
                    int index4 = Main.rand.Next(minValue2, maxValue2);
                    if (!Main.tile[index3, index4].active || !Main.tileSolid[(int)Main.tile[index3, index4].type])
                    {
                        if (!Main.wallHouse[(int)Main.tile[index3, index4].wall] || index1 >= 999)
                        {
                            for (int index5 = index4; index5 < Main.maxTilesY; ++index5)
                            {
                                if (Main.tile[index3, index5].active && Main.tileSolid[(int)Main.tile[index3, index5].type])
                                {
                                    if (index3 < num3 || index3 > num4 || (index5 < num5 || index5 > num6) || index1 == 999)
                                    {
                                        int num7 = (int)Main.tile[index3, index5].type;
                                        num1 = index3;
                                        num2 = index5;
                                        flag = true;
                                        break;
                                    }
                                    else
                                        break;
                                }
                            }
                            if (flag && index1 < 999)
                            {
                                int num7 = num1 - NPC.spawnSpaceX / 2;
                                int num8 = num1 + NPC.spawnSpaceX / 2;
                                int num9 = num2 - NPC.spawnSpaceY;
                                int num10 = num2;
                                if (num7 < 0)
                                    flag = false;
                                if (num8 > Main.maxTilesX)
                                    flag = false;
                                if (num9 < 0)
                                    flag = false;
                                if (num10 > Main.maxTilesY)
                                    flag = false;
                                if (flag)
                                {
                                    for (int index5 = num7; index5 < num8; ++index5)
                                    {
                                        for (int index6 = num9; index6 < num10; ++index6)
                                        {
                                            if (Main.tile[index5, index6].active && Main.tileSolid[(int)Main.tile[index5, index6].type])
                                            {
                                                flag = false;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                            continue;
                    }
                    if (flag || flag)
                        break;
                }
                if (flag && index1 < 999)
                {
                    Rectangle rectangle1 = new Rectangle(num1 * 16, num2 * 16, 16, 16);
                    for (int index2 = 0; index2 < (int)byte.MaxValue; ++index2)
                    {
                        if (Main.player[index2].active)
                        {
                            Rectangle rectangle2 = new Rectangle((int)((double)Main.player[index2].position.X + (double)(Main.player[index2].width / 2) - (double)(NPC.sWidth / 2) - (double)NPC.safeRangeX), (int)((double)Main.player[index2].position.Y + (double)(Main.player[index2].height / 2) - (double)(NPC.sHeight / 2) - (double)NPC.safeRangeY), NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
                            if (rectangle1.Intersects(rectangle2))
                                flag = false;
                        }
                    }
                }
                if (flag)
                    break;
            }
            if (!flag)
                return;
            int number = NPC.NewNPC(num1 * 16 + 8, num2 * 16, Type, 1);
            if (number == 200)
                return;
            Main.npc[number].target = plr;
            Main.npc[number].timeLeft *= 20;
            string str = Main.npc[number].name;
            if (Main.npc[number].displayName != "")
                str = Main.npc[number].displayName;
            if (Main.netMode == 2 && number < 200)
                NetMessage.SendData(23, -1, -1, "", number, 0.0f, 0.0f, 0.0f, 0);
            if (Type == 125)
            {
                if (Main.netMode == 0)
                {
                    Main.NewText("The Twins " + Lang.misc[16], (byte)175, (byte)75, byte.MaxValue);
                }
                else
                {
                    if (Main.netMode != 2)
                        return;
                    NetMessage.SendData(25, -1, -1, "The Twins " + Lang.misc[16], (int)byte.MaxValue, 175f, 75f, (float)byte.MaxValue, 0);
                }
            }
            else
            {
                if (Type == 82 || Type == 126 || Type == 50)
                    return;
                if (Main.netMode == 0)
                {
                    Main.NewText(str + " " + Lang.misc[16], (byte)175, (byte)75, byte.MaxValue);
                }
                else
                {
                    if (Main.netMode != 2)
                        return;
                    NetMessage.SendData(25, -1, -1, str + " " + Lang.misc[16], (int)byte.MaxValue, 175f, 75f, (float)byte.MaxValue, 0);
                }
            }
        }
		public static int NewNPC(int X, int Y, int Type, int Start = 0)
		{
			int num = -1;
			for (int i = Start; i < 200; i++)
			{
				if (!Main.npc[i].active)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				Main.npc[num] = new NPC();
				Main.npc[num].SetDefaults(Type, -1f);
				Main.npc[num].position.X = (float)(X - Main.npc[num].width / 2);
				Main.npc[num].position.Y = (float)(Y - Main.npc[num].height);
				Main.npc[num].active = true;
				Main.npc[num].timeLeft = (int)((double)NPC.activeTime * 1.25);
				Main.npc[num].wet = Collision.WetCollision(Main.npc[num].position, Main.npc[num].width, Main.npc[num].height);
                if (Type == 50)
                {
                    if (Main.netMode == 0)
                        Main.NewText(Main.npc[num].name + " " + Lang.misc[16], (byte)175, (byte)75, byte.MaxValue);
                    else if (Main.netMode == 2)
                        NetMessage.SendData(25, -1, -1, Main.npc[num].name + " " + Lang.misc[16], (int)byte.MaxValue, 175f, 75f, (float)byte.MaxValue, 0);
                }
				return num;
			}
			return 200;
		}
		public void Transform(int newType)
		{
			if (Main.netMode != 1)
			{
				Vector2 vector = this.velocity;
				this.position.Y = this.position.Y + (float)this.height;
				int num = this.spriteDirection;
				this.SetDefaults(newType, -1f);
				this.spriteDirection = num;
				this.TargetClosest(true);
				this.velocity = vector;
				this.position.Y = this.position.Y - (float)this.height;
				if (newType == 107 || newType == 108)
				{
					this.homeTileX = (int)(this.position.X + (float)(this.width / 2)) / 16;
					this.homeTileY = (int)(this.position.Y + (float)this.height) / 16;
					this.homeless = true;
				}
				if (Main.netMode == 2)
				{
					this.netUpdate = true;
					NetMessage.SendData(23, -1, -1, "", this.whoAmI, 0f, 0f, 0f, 0);
				}
			}
		}
		public double StrikeNPC(int Damage, float knockBack, int hitDirection, bool crit = false, bool noEffect = false)
		{
			if (!this.active || this.life <= 0)
			{
				return 0.0;
			}
			double num = (double)Damage;
			num = Main.CalculateDamage((int)num, this.defense);
			if (crit)
			{
				num *= 2.0;
			}
			if (Damage != 9999 && this.lifeMax > 1)
			{
				if (this.friendly)
				{
					CombatText.NewText(new Rectangle((int)this.position.X, (int)this.position.Y, this.width, this.height), new Color(255, 80, 90, 255), string.Concat((int)num), crit);
				}
				else
				{
					CombatText.NewText(new Rectangle((int)this.position.X, (int)this.position.Y, this.width, this.height), new Color(255, 160, 80, 255), string.Concat((int)num), crit);
				}
			}
			if (num >= 1.0)
			{
				this.justHit = true;
				if (this.townNPC)
				{
					this.ai[0] = 1f;
					this.ai[1] = (float)(300 + Main.rand.Next(300));
					this.ai[2] = 0f;
					this.direction = hitDirection;
					this.netUpdate = true;
				}
				if (this.aiStyle == 8 && Main.netMode != 1)
				{
					this.ai[0] = 400f;
					this.TargetClosest(true);
				}
				if (this.realLife >= 0)
				{
					Main.npc[this.realLife].life -= (int)num;
					this.life = Main.npc[this.realLife].life;
					this.lifeMax = Main.npc[this.realLife].lifeMax;
				}
				else
				{
					this.life -= (int)num;
				}
				if (knockBack > 0f && this.knockBackResist > 0f)
				{
					float num2 = knockBack * this.knockBackResist;
					if (num2 > 8f)
					{
						num2 = 8f;
					}
					if (crit)
					{
						num2 *= 1.4f;
					}
					if (num * 10.0 < (double)this.lifeMax)
					{
						if (hitDirection < 0 && this.velocity.X > -num2)
						{
							if (this.velocity.X > 0f)
							{
								this.velocity.X = this.velocity.X - num2;
							}
							this.velocity.X = this.velocity.X - num2;
							if (this.velocity.X < -num2)
							{
								this.velocity.X = -num2;
							}
						}
						else
						{
							if (hitDirection > 0 && this.velocity.X < num2)
							{
								if (this.velocity.X < 0f)
								{
									this.velocity.X = this.velocity.X + num2;
								}
								this.velocity.X = this.velocity.X + num2;
								if (this.velocity.X > num2)
								{
									this.velocity.X = num2;
								}
							}
						}
						if (!this.noGravity)
						{
							num2 *= -0.75f;
						}
						else
						{
							num2 *= -0.5f;
						}
						if (this.velocity.Y > num2)
						{
							this.velocity.Y = this.velocity.Y + num2;
							if (this.velocity.Y < num2)
							{
								this.velocity.Y = num2;
							}
						}
					}
					else
					{
						if (!this.noGravity)
						{
							this.velocity.Y = -num2 * 0.75f * this.knockBackResist;
						}
						else
						{
							this.velocity.Y = -num2 * 0.5f * this.knockBackResist;
						}
						this.velocity.X = num2 * (float)hitDirection * this.knockBackResist;
					}
				}
				if ((this.type == 113 || this.type == 114) && this.life <= 0)
				{
					for (int i = 0; i < 200; i++)
					{
						if (Main.npc[i].active && (Main.npc[i].type == 113 || Main.npc[i].type == 114))
						{
							Main.npc[i].HitEffect(hitDirection, num);
						}
					}
				}
				else
				{
					this.HitEffect(hitDirection, num);
				}
				if (this.soundHit > 0)
				{
					Main.PlaySound(3, (int)this.position.X, (int)this.position.Y, this.soundHit);
				}
				if (this.realLife >= 0)
				{
					Main.npc[this.realLife].checkDead();
				}
				else
				{
					this.checkDead();
				}
				return num;
			}
			return 0.0;
		}
        public void checkDead()
        {
            if (!this.active || this.realLife >= 0 && this.realLife != this.whoAmI || this.life > 0)
                return;
            NPC.noSpawnCycle = true;
            if (this.townNPC && this.type != 37)
            {
                string str = this.name;
                if (this.displayName != "")
                    str = this.displayName;
                if (Main.netMode == 0)
                    Main.NewText(str + Lang.misc[19], byte.MaxValue, (byte)25, (byte)25);
                else if (Main.netMode == 2)
                    NetMessage.SendData(25, -1, -1, str + Lang.misc[19], (int)byte.MaxValue, (float)byte.MaxValue, 25f, 25f, 0);
                if (Main.netMode != 1)
                {
                    Main.chrName[this.type] = "";
                    NPC.setNames();
                    NetMessage.SendData(56, -1, -1, "", this.type, 0.0f, 0.0f, 0.0f, 0);
                }
            }
            if (this.townNPC && Main.netMode != 1 && (this.homeless && WorldGen.spawnNPC == this.type))
                WorldGen.spawnNPC = 0;
            if (this.soundKilled > 0)
                Main.PlaySound(4, (int)this.position.X, (int)this.position.Y, this.soundKilled);
            this.NPCLoot();
            this.active = false;
            if (this.type != 26 && this.type != 27 && (this.type != 28 && this.type != 29) && (this.type != 111 && this.type != 143 && (this.type != 144 && this.type != 145)))
                return;
            --Main.invasionSize;
        }
        public void NPCLoot()
        {
            if (Main.hardMode && this.lifeMax > 1 && (this.damage > 0 && !this.friendly) && ((double)this.position.Y > Main.rockLayer * 16.0 && Main.rand.Next(7) == 0 && (this.type != 121 && (double)this.value > 0.0)))
            {
                if (Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].zoneEvil)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 521, 1, false, 0);
                if (Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].zoneHoly)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 520, 1, false, 0);
            }
            if (Main.xMas && this.lifeMax > 1 && (this.damage > 0 && !this.friendly) && (this.type != 121 && (double)this.value > 0.0 && Main.rand.Next(13) == 0))
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, Main.rand.Next(599, 602), 1, false, 0);
            if (this.type == 109 && !NPC.downedClown)
            {
                NPC.downedClown = true;
                if (Main.netMode == 2)
                    NetMessage.SendData(7, -1, -1, "", 0, 0.0f, 0.0f, 0.0f, 0);
            }
            if (this.type == 85 && (double)this.value > 0.0)
            {
                int num = Main.rand.Next(7);
                if (num == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 437, 1, false, -1);
                if (num == 1)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 517, 1, false, -1);
                if (num == 2)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 535, 1, false, -1);
                if (num == 3)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 536, 1, false, -1);
                if (num == 4)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 532, 1, false, -1);
                if (num == 5)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 393, 1, false, -1);
                if (num == 6)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 554, 1, false, -1);
            }
            if (this.type == 87)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 575, Main.rand.Next(5, 11), false, 0);
            if (this.type == 143 || this.type == 144 || this.type == 145)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 593, Main.rand.Next(5, 11), false, 0);
            if (this.type == 79)
            {
                if (Main.rand.Next(10) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 527, 1, false, 0);
            }
            else if (this.type == 80 && Main.rand.Next(10) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 528, 1, false, 0);
            if (this.type == 101 || this.type == 98)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 522, Main.rand.Next(2, 6), false, 0);
            if (this.type == 86)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 526, 1, false, 0);
            if (this.type == 113)
            {
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 367, 1, false, -1);
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, Main.rand.Next(489, 492), 1, false, -1);
                }
                else
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 514, 1, false, -1);
                            break;
                        case 1:
                            Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 426, 1, false, -1);
                            break;
                        case 2:
                            Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 434, 1, false, -1);
                            break;
                    }
                }
                if (Main.netMode != 1)
                {
                    int num1 = (int)((double)this.position.X + (double)(this.width / 2)) / 16;
                    int num2 = (int)((double)this.position.Y + (double)(this.height / 2)) / 16;
                    int num3 = this.width / 2 / 16 + 1;
                    for (int index1 = num1 - num3; index1 <= num1 + num3; ++index1)
                    {
                        for (int index2 = num2 - num3; index2 <= num2 + num3; ++index2)
                        {
                            if ((index1 == num1 - num3 || index1 == num1 + num3 || (index2 == num2 - num3 || index2 == num2 + num3)) && !Main.tile[index1, index2].active)
                            {
                                Main.tile[index1, index2].type = (byte)140;
                                Main.tile[index1, index2].active = true;
                            }
                            Main.tile[index1, index2].lava = false;
                            Main.tile[index1, index2].liquid = (byte)0;
                            if (Main.netMode == 2)
                                NetMessage.SendTileSquare(-1, index1, index2, 1);
                            else
                                WorldGen.SquareTileFrame(index1, index2, true);
                        }
                    }
                }
            }
            if (this.type == 1 || this.type == 16 || (this.type == 138 || this.type == 141))
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 23, Main.rand.Next(1, 3), false, 0);
            if (this.type == 75)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 501, Main.rand.Next(1, 4), false, 0);
            if (this.type == 81)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 23, Main.rand.Next(2, 5), false, 0);
            if (this.type == 122)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 23, Main.rand.Next(5, 11), false, 0);
            if (this.type == 71)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 327, 1, false, 0);
            if (this.type == 2)
            {
                if (Main.rand.Next(3) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 38, 1, false, 0);
                else if (Main.rand.Next(100) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 236, 1, false, 0);
            }
            if (this.type == 104 && Main.rand.Next(60) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 485, 1, false, -1);
            if (this.type == 58)
            {
                if (Main.rand.Next(500) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 263, 1, false, 0);
                else if (Main.rand.Next(40) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 118, 1, false, 0);
            }
            if (this.type == 102 && Main.rand.Next(500) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 263, 1, false, 0);
            if ((this.type == 3 || this.type == 132) && Main.rand.Next(50) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 216, 1, false, -1);
            if (this.type == 66)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 267, 1, false, 0);
            if (this.type == 62 && Main.rand.Next(50) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 272, 1, false, -1);
            if (this.type == 52)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 251, 1, false, 0);
            if (this.type == 53)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 239, 1, false, 0);
            if (this.type == 54)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 260, 1, false, 0);
            if (this.type == 55)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 261, 1, false, 0);
            if (this.type == 69 && Main.rand.Next(7) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 323, 1, false, 0);
            if (this.type == 73)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 362, Main.rand.Next(1, 3), false, 0);
            if (this.type == 4)
            {
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 47, Main.rand.Next(30) + 20, false, 0);
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 56, Main.rand.Next(20) + 10, false, 0);
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 56, Main.rand.Next(20) + 10, false, 0);
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 56, Main.rand.Next(20) + 10, false, 0);
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 59, Main.rand.Next(3) + 1, false, 0);
            }
            if ((this.type == 6 || this.type == 94) && Main.rand.Next(3) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 68, 1, false, 0);
            if (this.type == 7 || this.type == 8 || this.type == 9)
            {
                if (Main.rand.Next(3) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 68, Main.rand.Next(1, 3), false, 0);
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 69, Main.rand.Next(3, 9), false, 0);
            }
            if ((this.type == 10 || this.type == 11 || (this.type == 12 || this.type == 95) || (this.type == 96 || this.type == 97)) && Main.rand.Next(500) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 215, 1, false, 0);
            if (this.type == 47 && Main.rand.Next(75) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 243, 1, false, 0);
            if (this.type == 13 || this.type == 14 || this.type == 15)
            {
                int Stack = Main.rand.Next(1, 3);
                if (Main.rand.Next(2) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 86, Stack, false, 0);
                if (Main.rand.Next(2) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 56, Main.rand.Next(2, 6), false, 0);
                if (this.boss)
                {
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 56, Main.rand.Next(10, 30), false, 0);
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 56, Main.rand.Next(10, 31), false, 0);
                }
                if (Main.rand.Next(3) == 0 && Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statLife < Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statLifeMax)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 58, 1, false, 0);
            }
            if (this.type == 116 || this.type == 117 || (this.type == 118 || this.type == 119) || this.type == 139)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 58, 1, false, 0);
            if (this.type == 63 || this.type == 64 || this.type == 103)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 282, Main.rand.Next(1, 5), false, 0);
            if (this.type == 21 || this.type == 44)
            {
                if (Main.rand.Next(25) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 118, 1, false, 0);
                else if (this.type == 44)
                {
                    if (Main.rand.Next(20) == 0)
                        Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, Main.rand.Next(410, 412), 1, false, 0);
                    else
                        Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 166, Main.rand.Next(1, 4), false, 0);
                }
            }
            if (this.type == 45)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 238, 1, false, 0);
            if (this.type == 50)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, Main.rand.Next(256, 259), 1, false, 0);
            if (this.type == 23 && Main.rand.Next(50) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 116, 1, false, 0);
            if (this.type == 24 && Main.rand.Next(300) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 244, 1, false, 0);
            if (this.type == 31 || this.type == 32 || this.type == 34)
            {
                if (Main.rand.Next(65) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 327, 1, false, 0);
                else
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 154, Main.rand.Next(1, 4), false, 0);
            }
            if (this.type == 26 || this.type == 27 || (this.type == 28 || this.type == 29) || this.type == 111)
            {
                if (Main.rand.Next(200) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 160, 1, false, 0);
                else if (Main.rand.Next(2) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 161, Main.rand.Next(1, 6), false, 0);
            }
            if (this.type == 42 && Main.rand.Next(2) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 209, 1, false, 0);
            if (this.type == 43 && Main.rand.Next(4) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 210, 1, false, 0);
            if (this.type == 65)
            {
                if (Main.rand.Next(50) == 0)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 268, 1, false, 0);
                else
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 319, 1, false, 0);
            }
            if (this.type == 48 && Main.rand.Next(2) == 0)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 320, 1, false, 0);
            if (this.type == 125 || this.type == 126)
            {
                int Type = 125;
                if (this.type == 125)
                    Type = 126;
                if (!NPC.AnyNPCs(Type))
                {
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 549, Main.rand.Next(20, 31), false, 0);
                }
                else
                {
                    this.value = 0.0f;
                    this.boss = false;
                }
            }
            else if (this.type == (int)sbyte.MaxValue)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 547, Main.rand.Next(20, 31), false, 0);
            else if (this.type == 134)
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 548, Main.rand.Next(20, 31), false, 0);
            if (this.boss)
            {
                if (this.type == 4)
                    NPC.downedBoss1 = true;
                else if (this.type == 13 || this.type == 14 || this.type == 15)
                {
                    NPC.downedBoss2 = true;
                    this.name = "Eater of Worlds";
                }
                else if (this.type == 35)
                {
                    NPC.downedBoss3 = true;
                    this.name = "Skeletron";
                }
                else
                    this.name = this.displayName;
                string str = this.name;
                if (this.displayName != "")
                    str = this.displayName;
                int Stack = Main.rand.Next(5, 16);
                int Type = 28;
                if (this.type == 113)
                    Type = 188;
                if (this.type > 113)
                    Type = 499;
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, Type, Stack, false, 0);
                int num = Main.rand.Next(5) + 5;
                for (int index = 0; index < num; ++index)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 58, 1, false, 0);
                if (this.type == 125 || this.type == 126)
                {
                    if (Main.netMode == 0)
                        Main.NewText("The Twins " + Lang.misc[17], (byte)175, (byte)75, byte.MaxValue);
                    else if (Main.netMode == 2)
                        NetMessage.SendData(25, -1, -1, "The Twins " + Lang.misc[17], (int)byte.MaxValue, 175f, 75f, (float)byte.MaxValue, 0);
                }
                else if (Main.netMode == 0)
                    Main.NewText(str + " " + Lang.misc[17], (byte)175, (byte)75, byte.MaxValue);
                else if (Main.netMode == 2)
                    NetMessage.SendData(25, -1, -1, str + " " + Lang.misc[17], (int)byte.MaxValue, 175f, 75f, (float)byte.MaxValue, 0);
                if (this.type == 113 && Main.netMode != 1)
                    WorldGen.StartHardmode();
                if (Main.netMode == 2)
                    NetMessage.SendData(7, -1, -1, "", 0, 0.0f, 0.0f, 0.0f, 0);
            }
            if (Main.rand.Next(6) == 0 && this.lifeMax > 1 && this.damage > 0)
            {
                if (Main.rand.Next(2) == 0 && Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statMana < Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statManaMax)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 184, 1, false, 0);
                else if (Main.rand.Next(2) == 0 && Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statLife < Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statLifeMax)
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 58, 1, false, 0);
            }
            if (Main.rand.Next(2) == 0 && this.lifeMax > 1 && (this.damage > 0 && Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statMana < Main.player[(int)Player.FindClosest(this.position, this.width, this.height)].statManaMax))
                Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 184, 1, false, 0);
            float num4 = this.value * (float)(1.0 + (double)Main.rand.Next(-20, 21) * 0.00999999977648258);
            if (Main.rand.Next(5) == 0)
                num4 *= (float)(1.0 + (double)Main.rand.Next(5, 11) * 0.00999999977648258);
            if (Main.rand.Next(10) == 0)
                num4 *= (float)(1.0 + (double)Main.rand.Next(10, 21) * 0.00999999977648258);
            if (Main.rand.Next(15) == 0)
                num4 *= (float)(1.0 + (double)Main.rand.Next(15, 31) * 0.00999999977648258);
            if (Main.rand.Next(20) == 0)
                num4 *= (float)(1.0 + (double)Main.rand.Next(20, 41) * 0.00999999977648258);
            while ((int)num4 > 0)
            {
                if ((double)num4 > 1000000.0)
                {
                    int Stack = (int)((double)num4 / 1000000.0);
                    if (Stack > 50 && Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(3) + 1;
                    if (Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(3) + 1;
                    num4 -= (float)(1000000 * Stack);
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 74, Stack, false, 0);
                }
                else if ((double)num4 > 10000.0)
                {
                    int Stack = (int)((double)num4 / 10000.0);
                    if (Stack > 50 && Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(3) + 1;
                    if (Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(3) + 1;
                    num4 -= (float)(10000 * Stack);
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 73, Stack, false, 0);
                }
                else if ((double)num4 > 100.0)
                {
                    int Stack = (int)((double)num4 / 100.0);
                    if (Stack > 50 && Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(3) + 1;
                    if (Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(3) + 1;
                    num4 -= (float)(100 * Stack);
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 72, Stack, false, 0);
                }
                else
                {
                    int Stack = (int)num4;
                    if (Stack > 50 && Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(3) + 1;
                    if (Main.rand.Next(5) == 0)
                        Stack /= Main.rand.Next(4) + 1;
                    if (Stack < 1)
                        Stack = 1;
                    num4 -= (float)Stack;
                    Item.NewItem((int)this.position.X, (int)this.position.Y, this.width, this.height, 71, Stack, false, 0);
                }
            }
        }
		public void HitEffect(int hitDirection = 0, double dmg = 10.0)
		{
			if (!this.active)
			{
				return;
			}
			if (this.type == 1 || this.type == 16 || this.type == 71)
			{
				if (this.life > 0)
				{
					int num = 0;
					while ((double)num < dmg / (double)this.lifeMax * 100.0)
					{
						Dust.NewDust(this.position, this.width, this.height, 4, (float)hitDirection, -1f, this.alpha, this.color, 1f);
						num++;
					}
				}
				else
				{
					for (int i = 0; i < 50; i++)
					{
						Dust.NewDust(this.position, this.width, this.height, 4, (float)(2 * hitDirection), -2f, this.alpha, this.color, 1f);
					}
					if (Main.netMode != 1 && this.type == 16)
					{
						int num2 = Main.rand.Next(2) + 2;
						for (int j = 0; j < num2; j++)
						{
							int num3 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), 1, 0);
							Main.npc[num3].SetDefaults("Baby Slime");
							Main.npc[num3].velocity.X = this.velocity.X * 2f;
							Main.npc[num3].velocity.Y = this.velocity.Y;
							NPC expr_186_cp_0 = Main.npc[num3];
							expr_186_cp_0.velocity.X = expr_186_cp_0.velocity.X + ((float)Main.rand.Next(-20, 20) * 0.1f + (float)(j * this.direction) * 0.3f);
							NPC expr_1C4_cp_0 = Main.npc[num3];
							expr_1C4_cp_0.velocity.Y = expr_1C4_cp_0.velocity.Y - ((float)Main.rand.Next(0, 10) * 0.1f + (float)j);
							Main.npc[num3].ai[1] = (float)j;
							if (Main.netMode == 2 && num3 < 200)
							{
								NetMessage.SendData(23, -1, -1, "", num3, 0f, 0f, 0f, 0);
							}
						}
					}
				}
			}
			if (this.type == 143 || this.type == 144 || this.type == 145)
			{
				if (this.life > 0)
				{
					int num4 = 0;
					while ((double)num4 < dmg / (double)this.lifeMax * 100.0)
					{
						Vector2 arg_297_0 = this.position;
						int arg_297_1 = this.width;
						int arg_297_2 = this.height;
						int arg_297_3 = 76;
						float arg_297_4 = (float)hitDirection;
						float arg_297_5 = -1f;
						int arg_297_6 = 0;
						Color newColor = default(Color);
						int num5 = Dust.NewDust(arg_297_0, arg_297_1, arg_297_2, arg_297_3, arg_297_4, arg_297_5, arg_297_6, newColor, 1f);
						Main.dust[num5].noGravity = true;
						num4++;
					}
				}
				else
				{
					for (int k = 0; k < 50; k++)
					{
						Vector2 arg_2FC_0 = this.position;
						int arg_2FC_1 = this.width;
						int arg_2FC_2 = this.height;
						int arg_2FC_3 = 76;
						float arg_2FC_4 = (float)hitDirection;
						float arg_2FC_5 = -1f;
						int arg_2FC_6 = 0;
						Color newColor = default(Color);
						int num6 = Dust.NewDust(arg_2FC_0, arg_2FC_1, arg_2FC_2, arg_2FC_3, arg_2FC_4, arg_2FC_5, arg_2FC_6, newColor, 1f);
						Main.dust[num6].noGravity = true;
						Main.dust[num6].scale *= 1.2f;
					}
				}
			}
			if (this.type == 141)
			{
				if (this.life > 0)
				{
					int num7 = 0;
					while ((double)num7 < dmg / (double)this.lifeMax * 100.0)
					{
						Dust.NewDust(this.position, this.width, this.height, 4, (float)hitDirection, -1f, this.alpha, new Color(210, 230, 140), 1f);
						num7++;
					}
				}
				else
				{
					for (int l = 0; l < 50; l++)
					{
						Dust.NewDust(this.position, this.width, this.height, 4, (float)(2 * hitDirection), -2f, this.alpha, new Color(210, 230, 140), 1f);
					}
				}
			}
			if (this.type == 112)
			{
				for (int m = 0; m < 20; m++)
				{
					Vector2 arg_464_0 = new Vector2(this.position.X, this.position.Y + 2f);
					int arg_464_1 = this.width;
					int arg_464_2 = this.height;
					int arg_464_3 = 18;
					float arg_464_4 = 0f;
					float arg_464_5 = 0f;
					int arg_464_6 = 100;
					Color newColor = default(Color);
					int num8 = Dust.NewDust(arg_464_0, arg_464_1, arg_464_2, arg_464_3, arg_464_4, arg_464_5, arg_464_6, newColor, 2f);
					if (Main.rand.Next(2) == 0)
					{
						Main.dust[num8].scale *= 0.6f;
					}
					else
					{
						Dust expr_49B = Main.dust[num8];
						expr_49B.velocity *= 1.4f;
						Main.dust[num8].noGravity = true;
					}
				}
			}
			if (this.type == 81 || this.type == 121)
			{
				if (this.life > 0)
				{
					int num9 = 0;
					while ((double)num9 < dmg / (double)this.lifeMax * 100.0)
					{
						Dust.NewDust(this.position, this.width, this.height, 14, 0f, 0f, this.alpha, this.color, 1f);
						num9++;
					}
				}
				else
				{
					for (int n = 0; n < 50; n++)
					{
						int num10 = Dust.NewDust(this.position, this.width, this.height, 14, (float)hitDirection, 0f, this.alpha, this.color, 1f);
						Dust expr_58A = Main.dust[num10];
						expr_58A.velocity *= 2f;
					}
					if (Main.netMode != 1)
					{
						if (this.type == 121)
						{
							int num11 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), 81, 0);
							Main.npc[num11].SetDefaults("Slimer2");
							Main.npc[num11].velocity.X = this.velocity.X;
							Main.npc[num11].velocity.Y = this.velocity.Y;
							Gore.NewGore(this.position, this.velocity, 94, this.scale);
							if (Main.netMode == 2 && num11 < 200)
							{
								NetMessage.SendData(23, -1, -1, "", num11, 0f, 0f, 0f, 0);
							}
						}
						else
						{
							if (this.scale >= 1f)
							{
								int num12 = Main.rand.Next(2) + 2;
								for (int num13 = 0; num13 < num12; num13++)
								{
									int num14 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), 1, 0);
									Main.npc[num14].SetDefaults("Slimeling");
									Main.npc[num14].velocity.X = this.velocity.X * 3f;
									Main.npc[num14].velocity.Y = this.velocity.Y;
									NPC expr_752_cp_0 = Main.npc[num14];
									expr_752_cp_0.velocity.X = expr_752_cp_0.velocity.X + ((float)Main.rand.Next(-10, 10) * 0.1f + (float)(num13 * this.direction) * 0.3f);
									NPC expr_791_cp_0 = Main.npc[num14];
									expr_791_cp_0.velocity.Y = expr_791_cp_0.velocity.Y - ((float)Main.rand.Next(0, 10) * 0.1f + (float)num13);
									Main.npc[num14].ai[1] = (float)num13;
									if (Main.netMode == 2 && num14 < 200)
									{
										NetMessage.SendData(23, -1, -1, "", num14, 0f, 0f, 0f, 0);
									}
								}
							}
						}
					}
				}
			}
			if (this.type == 120 || this.type == 137 || this.type == 138)
			{
				if (this.life > 0)
				{
					int num15 = 0;
					while ((double)num15 < dmg / (double)this.lifeMax * 50.0)
					{
						Vector2 arg_86E_0 = this.position;
						int arg_86E_1 = this.width;
						int arg_86E_2 = this.height;
						int arg_86E_3 = 71;
						float arg_86E_4 = 0f;
						float arg_86E_5 = 0f;
						int arg_86E_6 = 200;
						Color newColor = default(Color);
						int num16 = Dust.NewDust(arg_86E_0, arg_86E_1, arg_86E_2, arg_86E_3, arg_86E_4, arg_86E_5, arg_86E_6, newColor, 1f);
						Dust expr_87D = Main.dust[num16];
						expr_87D.velocity *= 1.5f;
						num15++;
					}
				}
				else
				{
					for (int num17 = 0; num17 < 50; num17++)
					{
						Vector2 arg_8E6_0 = this.position;
						int arg_8E6_1 = this.width;
						int arg_8E6_2 = this.height;
						int arg_8E6_3 = 71;
						float arg_8E6_4 = (float)hitDirection;
						float arg_8E6_5 = 0f;
						int arg_8E6_6 = 200;
						Color newColor = default(Color);
						int num18 = Dust.NewDust(arg_8E6_0, arg_8E6_1, arg_8E6_2, arg_8E6_3, arg_8E6_4, arg_8E6_5, arg_8E6_6, newColor, 1f);
						Dust expr_8F5 = Main.dust[num18];
						expr_8F5.velocity *= 1.5f;
					}
				}
			}
			if (this.type == 122)
			{
				if (this.life > 0)
				{
					int num19 = 0;
					while ((double)num19 < dmg / (double)this.lifeMax * 50.0)
					{
						Vector2 arg_963_0 = this.position;
						int arg_963_1 = this.width;
						int arg_963_2 = this.height;
						int arg_963_3 = 72;
						float arg_963_4 = 0f;
						float arg_963_5 = 0f;
						int arg_963_6 = 200;
						Color newColor = default(Color);
						int num20 = Dust.NewDust(arg_963_0, arg_963_1, arg_963_2, arg_963_3, arg_963_4, arg_963_5, arg_963_6, newColor, 1f);
						Dust expr_972 = Main.dust[num20];
						expr_972.velocity *= 1.5f;
						num19++;
					}
				}
				else
				{
					for (int num21 = 0; num21 < 50; num21++)
					{
						Vector2 arg_9DB_0 = this.position;
						int arg_9DB_1 = this.width;
						int arg_9DB_2 = this.height;
						int arg_9DB_3 = 72;
						float arg_9DB_4 = (float)hitDirection;
						float arg_9DB_5 = 0f;
						int arg_9DB_6 = 200;
						Color newColor = default(Color);
						int num22 = Dust.NewDust(arg_9DB_0, arg_9DB_1, arg_9DB_2, arg_9DB_3, arg_9DB_4, arg_9DB_5, arg_9DB_6, newColor, 1f);
						Dust expr_9EA = Main.dust[num22];
						expr_9EA.velocity *= 1.5f;
					}
				}
			}
			if (this.type == 75)
			{
				if (this.life > 0)
				{
					int num23 = 0;
					while ((double)num23 < dmg / (double)this.lifeMax * 50.0)
					{
						Dust.NewDust(this.position, this.width, this.height, 55, 0f, 0f, 200, this.color, 1f);
						num23++;
					}
				}
				else
				{
					for (int num24 = 0; num24 < 50; num24++)
					{
						int num25 = Dust.NewDust(this.position, this.width, this.height, 55, (float)hitDirection, 0f, 200, this.color, 1f);
						Dust expr_AB9 = Main.dust[num25];
						expr_AB9.velocity *= 2f;
					}
				}
			}
			if (this.type == 63 || this.type == 64 || this.type == 103)
			{
				Color newColor2 = new Color(50, 120, 255, 100);
				if (this.type == 64)
				{
					newColor2 = new Color(225, 70, 140, 100);
				}
				if (this.type == 103)
				{
					newColor2 = new Color(70, 225, 140, 100);
				}
				if (this.life > 0)
				{
					int num26 = 0;
					while ((double)num26 < dmg / (double)this.lifeMax * 50.0)
					{
						Dust.NewDust(this.position, this.width, this.height, 4, (float)hitDirection, -1f, 0, newColor2, 1f);
						num26++;
					}
					return;
				}
				for (int num27 = 0; num27 < 25; num27++)
				{
					Dust.NewDust(this.position, this.width, this.height, 4, (float)(2 * hitDirection), -2f, 0, newColor2, 1f);
				}
				return;
			}
			else
			{
				if (this.type != 59 && this.type != 60)
				{
					if (this.type == 50)
					{
						if (this.life > 0)
						{
							int num28 = 0;
							while ((double)num28 < dmg / (double)this.lifeMax * 300.0)
							{
								Dust.NewDust(this.position, this.width, this.height, 4, (float)hitDirection, -1f, 175, new Color(0, 80, 255, 100), 1f);
								num28++;
							}
							return;
						}
						for (int num29 = 0; num29 < 200; num29++)
						{
							Dust.NewDust(this.position, this.width, this.height, 4, (float)(2 * hitDirection), -2f, 175, new Color(0, 80, 255, 100), 1f);
						}
						if (Main.netMode != 1)
						{
							int num30 = Main.rand.Next(4) + 4;
							for (int num31 = 0; num31 < num30; num31++)
							{
								int x = (int)(this.position.X + (float)Main.rand.Next(this.width - 32));
								int y = (int)(this.position.Y + (float)Main.rand.Next(this.height - 32));
								int num32 = NPC.NewNPC(x, y, 1, 0);
								Main.npc[num32].SetDefaults(1, -1f);
								Main.npc[num32].velocity.X = (float)Main.rand.Next(-15, 16) * 0.1f;
								Main.npc[num32].velocity.Y = (float)Main.rand.Next(-30, 1) * 0.1f;
								Main.npc[num32].ai[1] = (float)Main.rand.Next(3);
								if (Main.netMode == 2 && num32 < 200)
								{
									NetMessage.SendData(23, -1, -1, "", num32, 0f, 0f, 0f, 0);
								}
							}
							return;
						}
					}
					else
					{
						if (this.type == 49 || this.type == 51 || this.type == 93)
						{
							if (this.life > 0)
							{
								int num33 = 0;
								while ((double)num33 < dmg / (double)this.lifeMax * 30.0)
								{
									Vector2 arg_EEC_0 = this.position;
									int arg_EEC_1 = this.width;
									int arg_EEC_2 = this.height;
									int arg_EEC_3 = 5;
									float arg_EEC_4 = (float)hitDirection;
									float arg_EEC_5 = -1f;
									int arg_EEC_6 = 0;
									Color newColor = default(Color);
									Dust.NewDust(arg_EEC_0, arg_EEC_1, arg_EEC_2, arg_EEC_3, arg_EEC_4, arg_EEC_5, arg_EEC_6, newColor, 1f);
									num33++;
								}
								return;
							}
							for (int num34 = 0; num34 < 15; num34++)
							{
								Vector2 arg_F42_0 = this.position;
								int arg_F42_1 = this.width;
								int arg_F42_2 = this.height;
								int arg_F42_3 = 5;
								float arg_F42_4 = (float)(2 * hitDirection);
								float arg_F42_5 = -2f;
								int arg_F42_6 = 0;
								Color newColor = default(Color);
								Dust.NewDust(arg_F42_0, arg_F42_1, arg_F42_2, arg_F42_3, arg_F42_4, arg_F42_5, arg_F42_6, newColor, 1f);
							}
							if (this.type == 51)
							{
								Gore.NewGore(this.position, this.velocity, 83, 1f);
								return;
							}
							if (this.type == 93)
							{
								Gore.NewGore(this.position, this.velocity, 107, 1f);
								return;
							}
							Gore.NewGore(this.position, this.velocity, 82, 1f);
							return;
						}
						else
						{
							if (this.type == 46 || this.type == 55 || this.type == 67 || this.type == 74 || this.type == 102)
							{
								if (this.life > 0)
								{
									int num35 = 0;
									while ((double)num35 < dmg / (double)this.lifeMax * 20.0)
									{
										Vector2 arg_1023_0 = this.position;
										int arg_1023_1 = this.width;
										int arg_1023_2 = this.height;
										int arg_1023_3 = 5;
										float arg_1023_4 = (float)hitDirection;
										float arg_1023_5 = -1f;
										int arg_1023_6 = 0;
										Color newColor = default(Color);
										Dust.NewDust(arg_1023_0, arg_1023_1, arg_1023_2, arg_1023_3, arg_1023_4, arg_1023_5, arg_1023_6, newColor, 1f);
										num35++;
									}
									return;
								}
								for (int num36 = 0; num36 < 10; num36++)
								{
									Vector2 arg_1079_0 = this.position;
									int arg_1079_1 = this.width;
									int arg_1079_2 = this.height;
									int arg_1079_3 = 5;
									float arg_1079_4 = (float)(2 * hitDirection);
									float arg_1079_5 = -2f;
									int arg_1079_6 = 0;
									Color newColor = default(Color);
									Dust.NewDust(arg_1079_0, arg_1079_1, arg_1079_2, arg_1079_3, arg_1079_4, arg_1079_5, arg_1079_6, newColor, 1f);
								}
								if (this.type == 46)
								{
									Gore.NewGore(this.position, this.velocity, 76, 1f);
									Gore.NewGore(new Vector2(this.position.X, this.position.Y), this.velocity, 77, 1f);
									return;
								}
								if (this.type == 67)
								{
									Gore.NewGore(this.position, this.velocity, 95, 1f);
									Gore.NewGore(this.position, this.velocity, 95, 1f);
									Gore.NewGore(this.position, this.velocity, 96, 1f);
									return;
								}
								if (this.type == 74)
								{
									Gore.NewGore(this.position, this.velocity, 100, 1f);
									return;
								}
								if (this.type == 102)
								{
									Gore.NewGore(this.position, this.velocity, 116, 1f);
									return;
								}
							}
							else
							{
								if (this.type == 47 || this.type == 57 || this.type == 58)
								{
									if (this.life > 0)
									{
										int num37 = 0;
										while ((double)num37 < dmg / (double)this.lifeMax * 20.0)
										{
											Vector2 arg_11D7_0 = this.position;
											int arg_11D7_1 = this.width;
											int arg_11D7_2 = this.height;
											int arg_11D7_3 = 5;
											float arg_11D7_4 = (float)hitDirection;
											float arg_11D7_5 = -1f;
											int arg_11D7_6 = 0;
											Color newColor = default(Color);
											Dust.NewDust(arg_11D7_0, arg_11D7_1, arg_11D7_2, arg_11D7_3, arg_11D7_4, arg_11D7_5, arg_11D7_6, newColor, 1f);
											num37++;
										}
										return;
									}
									for (int num38 = 0; num38 < 10; num38++)
									{
										Vector2 arg_122D_0 = this.position;
										int arg_122D_1 = this.width;
										int arg_122D_2 = this.height;
										int arg_122D_3 = 5;
										float arg_122D_4 = (float)(2 * hitDirection);
										float arg_122D_5 = -2f;
										int arg_122D_6 = 0;
										Color newColor = default(Color);
										Dust.NewDust(arg_122D_0, arg_122D_1, arg_122D_2, arg_122D_3, arg_122D_4, arg_122D_5, arg_122D_6, newColor, 1f);
									}
									if (this.type == 57)
									{
										Gore.NewGore(new Vector2(this.position.X, this.position.Y), this.velocity, 84, 1f);
										return;
									}
									if (this.type == 58)
									{
										Gore.NewGore(new Vector2(this.position.X, this.position.Y), this.velocity, 85, 1f);
										return;
									}
									Gore.NewGore(this.position, this.velocity, 78, 1f);
									Gore.NewGore(new Vector2(this.position.X, this.position.Y), this.velocity, 79, 1f);
									return;
								}
								else
								{
									if (this.type == 2)
									{
										if (this.life > 0)
										{
											int num39 = 0;
											while ((double)num39 < dmg / (double)this.lifeMax * 100.0)
											{
												Vector2 arg_133D_0 = this.position;
												int arg_133D_1 = this.width;
												int arg_133D_2 = this.height;
												int arg_133D_3 = 5;
												float arg_133D_4 = (float)hitDirection;
												float arg_133D_5 = -1f;
												int arg_133D_6 = 0;
												Color newColor = default(Color);
												Dust.NewDust(arg_133D_0, arg_133D_1, arg_133D_2, arg_133D_3, arg_133D_4, arg_133D_5, arg_133D_6, newColor, 1f);
												num39++;
											}
											return;
										}
										for (int num40 = 0; num40 < 50; num40++)
										{
											Vector2 arg_1393_0 = this.position;
											int arg_1393_1 = this.width;
											int arg_1393_2 = this.height;
											int arg_1393_3 = 5;
											float arg_1393_4 = (float)(2 * hitDirection);
											float arg_1393_5 = -2f;
											int arg_1393_6 = 0;
											Color newColor = default(Color);
											Dust.NewDust(arg_1393_0, arg_1393_1, arg_1393_2, arg_1393_3, arg_1393_4, arg_1393_5, arg_1393_6, newColor, 1f);
										}
										Gore.NewGore(this.position, this.velocity, 1, 1f);
										Gore.NewGore(new Vector2(this.position.X + 14f, this.position.Y), this.velocity, 2, 1f);
										return;
									}
									else
									{
										if (this.type == 133)
										{
											if (this.life <= 0)
											{
												for (int num41 = 0; num41 < 50; num41++)
												{
													Vector2 arg_14E2_0 = this.position;
													int arg_14E2_1 = this.width;
													int arg_14E2_2 = this.height;
													int arg_14E2_3 = 5;
													float arg_14E2_4 = (float)(2 * hitDirection);
													float arg_14E2_5 = -2f;
													int arg_14E2_6 = 0;
													Color newColor = default(Color);
													Dust.NewDust(arg_14E2_0, arg_14E2_1, arg_14E2_2, arg_14E2_3, arg_14E2_4, arg_14E2_5, arg_14E2_6, newColor, 1f);
												}
												Gore.NewGore(this.position, this.velocity, 155, 1f);
												Gore.NewGore(new Vector2(this.position.X, this.position.Y + 14f), this.velocity, 155, 1f);
												return;
											}
											int num42 = 0;
											while ((double)num42 < dmg / (double)this.lifeMax * 100.0)
											{
												Vector2 arg_143C_0 = this.position;
												int arg_143C_1 = this.width;
												int arg_143C_2 = this.height;
												int arg_143C_3 = 5;
												float arg_143C_4 = (float)hitDirection;
												float arg_143C_5 = -1f;
												int arg_143C_6 = 0;
												Color newColor = default(Color);
												Dust.NewDust(arg_143C_0, arg_143C_1, arg_143C_2, arg_143C_3, arg_143C_4, arg_143C_5, arg_143C_6, newColor, 1f);
												num42++;
											}
											if ((float)this.life < (float)this.lifeMax * 0.5f && this.localAI[0] == 0f)
											{
												this.localAI[0] = 1f;
												Gore.NewGore(this.position, this.velocity, 1, 1f);
												return;
											}
										}
										else
										{
											if (this.type == 69)
											{
												if (this.life > 0)
												{
													int num43 = 0;
													while ((double)num43 < dmg / (double)this.lifeMax * 100.0)
													{
														Vector2 arg_158D_0 = this.position;
														int arg_158D_1 = this.width;
														int arg_158D_2 = this.height;
														int arg_158D_3 = 5;
														float arg_158D_4 = (float)hitDirection;
														float arg_158D_5 = -1f;
														int arg_158D_6 = 0;
														Color newColor = default(Color);
														Dust.NewDust(arg_158D_0, arg_158D_1, arg_158D_2, arg_158D_3, arg_158D_4, arg_158D_5, arg_158D_6, newColor, 1f);
														num43++;
													}
													return;
												}
												for (int num44 = 0; num44 < 50; num44++)
												{
													Vector2 arg_15E3_0 = this.position;
													int arg_15E3_1 = this.width;
													int arg_15E3_2 = this.height;
													int arg_15E3_3 = 5;
													float arg_15E3_4 = (float)(2 * hitDirection);
													float arg_15E3_5 = -2f;
													int arg_15E3_6 = 0;
													Color newColor = default(Color);
													Dust.NewDust(arg_15E3_0, arg_15E3_1, arg_15E3_2, arg_15E3_3, arg_15E3_4, arg_15E3_5, arg_15E3_6, newColor, 1f);
												}
												Gore.NewGore(this.position, this.velocity, 97, 1f);
												Gore.NewGore(this.position, this.velocity, 98, 1f);
												return;
											}
											else
											{
												if (this.type == 61)
												{
													if (this.life > 0)
													{
														int num45 = 0;
														while ((double)num45 < dmg / (double)this.lifeMax * 100.0)
														{
															Vector2 arg_166D_0 = this.position;
															int arg_166D_1 = this.width;
															int arg_166D_2 = this.height;
															int arg_166D_3 = 5;
															float arg_166D_4 = (float)hitDirection;
															float arg_166D_5 = -1f;
															int arg_166D_6 = 0;
															Color newColor = default(Color);
															Dust.NewDust(arg_166D_0, arg_166D_1, arg_166D_2, arg_166D_3, arg_166D_4, arg_166D_5, arg_166D_6, newColor, 1f);
															num45++;
														}
														return;
													}
													for (int num46 = 0; num46 < 50; num46++)
													{
														Vector2 arg_16C3_0 = this.position;
														int arg_16C3_1 = this.width;
														int arg_16C3_2 = this.height;
														int arg_16C3_3 = 5;
														float arg_16C3_4 = (float)(2 * hitDirection);
														float arg_16C3_5 = -2f;
														int arg_16C3_6 = 0;
														Color newColor = default(Color);
														Dust.NewDust(arg_16C3_0, arg_16C3_1, arg_16C3_2, arg_16C3_3, arg_16C3_4, arg_16C3_5, arg_16C3_6, newColor, 1f);
													}
													Gore.NewGore(this.position, this.velocity, 86, 1f);
													Gore.NewGore(new Vector2(this.position.X + 14f, this.position.Y), this.velocity, 87, 1f);
													Gore.NewGore(new Vector2(this.position.X + 14f, this.position.Y), this.velocity, 88, 1f);
													return;
												}
												else
												{
													if (this.type == 65)
													{
														if (this.life > 0)
														{
															int num47 = 0;
															while ((double)num47 < dmg / (double)this.lifeMax * 150.0)
															{
																Vector2 arg_179C_0 = this.position;
																int arg_179C_1 = this.width;
																int arg_179C_2 = this.height;
																int arg_179C_3 = 5;
																float arg_179C_4 = (float)hitDirection;
																float arg_179C_5 = -1f;
																int arg_179C_6 = 0;
																Color newColor = default(Color);
																Dust.NewDust(arg_179C_0, arg_179C_1, arg_179C_2, arg_179C_3, arg_179C_4, arg_179C_5, arg_179C_6, newColor, 1f);
																num47++;
															}
															return;
														}
														for (int num48 = 0; num48 < 75; num48++)
														{
															Vector2 arg_17F2_0 = this.position;
															int arg_17F2_1 = this.width;
															int arg_17F2_2 = this.height;
															int arg_17F2_3 = 5;
															float arg_17F2_4 = (float)(2 * hitDirection);
															float arg_17F2_5 = -2f;
															int arg_17F2_6 = 0;
															Color newColor = default(Color);
															Dust.NewDust(arg_17F2_0, arg_17F2_1, arg_17F2_2, arg_17F2_3, arg_17F2_4, arg_17F2_5, arg_17F2_6, newColor, 1f);
														}
														Gore.NewGore(this.position, this.velocity * 0.8f, 89, 1f);
														Gore.NewGore(new Vector2(this.position.X + 14f, this.position.Y), this.velocity * 0.8f, 90, 1f);
														Gore.NewGore(new Vector2(this.position.X + 14f, this.position.Y), this.velocity * 0.8f, 91, 1f);
														Gore.NewGore(new Vector2(this.position.X + 14f, this.position.Y), this.velocity * 0.8f, 92, 1f);
														return;
													}
													else
													{
														if (this.type == 3 || this.type == 52 || this.type == 53 || this.type == 104 || this.type == 109 || this.type == 132)
														{
															if (this.life > 0)
															{
																int num49 = 0;
																while ((double)num49 < dmg / (double)this.lifeMax * 100.0)
																{
																	Vector2 arg_195B_0 = this.position;
																	int arg_195B_1 = this.width;
																	int arg_195B_2 = this.height;
																	int arg_195B_3 = 5;
																	float arg_195B_4 = (float)hitDirection;
																	float arg_195B_5 = -1f;
																	int arg_195B_6 = 0;
																	Color newColor = default(Color);
																	Dust.NewDust(arg_195B_0, arg_195B_1, arg_195B_2, arg_195B_3, arg_195B_4, arg_195B_5, arg_195B_6, newColor, 1f);
																	num49++;
																}
																return;
															}
															for (int num50 = 0; num50 < 50; num50++)
															{
																Vector2 arg_19B5_0 = this.position;
																int arg_19B5_1 = this.width;
																int arg_19B5_2 = this.height;
																int arg_19B5_3 = 5;
																float arg_19B5_4 = 2.5f * (float)hitDirection;
																float arg_19B5_5 = -2.5f;
																int arg_19B5_6 = 0;
																Color newColor = default(Color);
																Dust.NewDust(arg_19B5_0, arg_19B5_1, arg_19B5_2, arg_19B5_3, arg_19B5_4, arg_19B5_5, arg_19B5_6, newColor, 1f);
															}
															if (this.type == 104)
															{
																Gore.NewGore(this.position, this.velocity, 117, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 118, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 118, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 119, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 119, 1f);
																return;
															}
															if (this.type == 109)
															{
																Gore.NewGore(this.position, this.velocity, 121, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 122, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 122, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 123, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 123, 1f);
																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 46f), this.velocity, 120, 1f);
																return;
															}
															if (this.type == 132)
															{
																Gore.NewGore(this.position, this.velocity, 154, 1f);
															}
															else
															{
																Gore.NewGore(this.position, this.velocity, 3, 1f);
															}
															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 4, 1f);
															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 4, 1f);
															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 5, 1f);
															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 5, 1f);
															return;
														}
														else
														{
															if (this.type == 83 || this.type == 84)
															{
																if (this.life > 0)
																{
																	int num51 = 0;
																	while ((double)num51 < dmg / (double)this.lifeMax * 50.0)
																	{
																		Vector2 arg_1D4C_0 = this.position;
																		int arg_1D4C_1 = this.width;
																		int arg_1D4C_2 = this.height;
																		int arg_1D4C_3 = 31;
																		float arg_1D4C_4 = 0f;
																		float arg_1D4C_5 = 0f;
																		int arg_1D4C_6 = 0;
																		Color newColor = default(Color);
																		int num52 = Dust.NewDust(arg_1D4C_0, arg_1D4C_1, arg_1D4C_2, arg_1D4C_3, arg_1D4C_4, arg_1D4C_5, arg_1D4C_6, newColor, 1.5f);
																		Main.dust[num52].noGravity = true;
																		num51++;
																	}
																	return;
																}
																for (int num53 = 0; num53 < 20; num53++)
																{
																	Vector2 arg_1DB3_0 = this.position;
																	int arg_1DB3_1 = this.width;
																	int arg_1DB3_2 = this.height;
																	int arg_1DB3_3 = 31;
																	float arg_1DB3_4 = 0f;
																	float arg_1DB3_5 = 0f;
																	int arg_1DB3_6 = 0;
																	Color newColor = default(Color);
																	int num54 = Dust.NewDust(arg_1DB3_0, arg_1DB3_1, arg_1DB3_2, arg_1DB3_3, arg_1DB3_4, arg_1DB3_5, arg_1DB3_6, newColor, 1.5f);
																	Dust expr_1DC2 = Main.dust[num54];
																	expr_1DC2.velocity *= 2f;
																	Main.dust[num54].noGravity = true;
																}
																int num55 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 10f), new Vector2((float)Main.rand.Next(-2, 3), (float)Main.rand.Next(-2, 3)), 61, this.scale);
																Gore expr_1E54 = Main.gore[num55];
																expr_1E54.velocity *= 0.5f;
																num55 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 10f), new Vector2((float)Main.rand.Next(-2, 3), (float)Main.rand.Next(-2, 3)), 61, this.scale);
																Gore expr_1ECC = Main.gore[num55];
																expr_1ECC.velocity *= 0.5f;
																num55 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 10f), new Vector2((float)Main.rand.Next(-2, 3), (float)Main.rand.Next(-2, 3)), 61, this.scale);
																Gore expr_1F44 = Main.gore[num55];
																expr_1F44.velocity *= 0.5f;
																return;
															}
															else
															{
																if (this.type == 4 || this.type == 126 || this.type == 125)
																{
																	if (this.life > 0)
																	{
																		int num56 = 0;
																		while ((double)num56 < dmg / (double)this.lifeMax * 100.0)
																		{
																			Vector2 arg_1FB2_0 = this.position;
																			int arg_1FB2_1 = this.width;
																			int arg_1FB2_2 = this.height;
																			int arg_1FB2_3 = 5;
																			float arg_1FB2_4 = (float)hitDirection;
																			float arg_1FB2_5 = -1f;
																			int arg_1FB2_6 = 0;
																			Color newColor = default(Color);
																			Dust.NewDust(arg_1FB2_0, arg_1FB2_1, arg_1FB2_2, arg_1FB2_3, arg_1FB2_4, arg_1FB2_5, arg_1FB2_6, newColor, 1f);
																			num56++;
																		}
																		return;
																	}
																	for (int num57 = 0; num57 < 150; num57++)
																	{
																		Vector2 arg_2008_0 = this.position;
																		int arg_2008_1 = this.width;
																		int arg_2008_2 = this.height;
																		int arg_2008_3 = 5;
																		float arg_2008_4 = (float)(2 * hitDirection);
																		float arg_2008_5 = -2f;
																		int arg_2008_6 = 0;
																		Color newColor = default(Color);
																		Dust.NewDust(arg_2008_0, arg_2008_1, arg_2008_2, arg_2008_3, arg_2008_4, arg_2008_5, arg_2008_6, newColor, 1f);
																	}
																	for (int num58 = 0; num58 < 2; num58++)
																	{
																		Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 2, 1f);
																		Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 7, 1f);
																		Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 9, 1f);
																		if (this.type == 4)
																		{
																			Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 10, 1f);
																			Main.PlaySound(15, (int)this.position.X, (int)this.position.Y, 0);
																		}
																		else
																		{
																			if (this.type == 125)
																			{
																				Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 146, 1f);
																			}
																			else
																			{
																				if (this.type == 126)
																				{
																					Gore.NewGore(this.position, new Vector2((float)Main.rand.Next(-30, 31) * 0.2f, (float)Main.rand.Next(-30, 31) * 0.2f), 145, 1f);
																				}
																			}
																		}
																	}
																	if (this.type == 125 || this.type == 126)
																	{
																		for (int num59 = 0; num59 < 10; num59++)
																		{
																			Vector2 arg_2267_0 = new Vector2(this.position.X, this.position.Y);
																			int arg_2267_1 = this.width;
																			int arg_2267_2 = this.height;
																			int arg_2267_3 = 31;
																			float arg_2267_4 = 0f;
																			float arg_2267_5 = 0f;
																			int arg_2267_6 = 100;
																			Color newColor = default(Color);
																			int num60 = Dust.NewDust(arg_2267_0, arg_2267_1, arg_2267_2, arg_2267_3, arg_2267_4, arg_2267_5, arg_2267_6, newColor, 1.5f);
																			Dust expr_2276 = Main.dust[num60];
																			expr_2276.velocity *= 1.4f;
																		}
																		for (int num61 = 0; num61 < 5; num61++)
																		{
																			Vector2 arg_22E2_0 = new Vector2(this.position.X, this.position.Y);
																			int arg_22E2_1 = this.width;
																			int arg_22E2_2 = this.height;
																			int arg_22E2_3 = 6;
																			float arg_22E2_4 = 0f;
																			float arg_22E2_5 = 0f;
																			int arg_22E2_6 = 100;
																			Color newColor = default(Color);
																			int num62 = Dust.NewDust(arg_22E2_0, arg_22E2_1, arg_22E2_2, arg_22E2_3, arg_22E2_4, arg_22E2_5, arg_22E2_6, newColor, 2.5f);
																			Main.dust[num62].noGravity = true;
																			Dust expr_22FF = Main.dust[num62];
																			expr_22FF.velocity *= 5f;
																			Vector2 arg_2357_0 = new Vector2(this.position.X, this.position.Y);
																			int arg_2357_1 = this.width;
																			int arg_2357_2 = this.height;
																			int arg_2357_3 = 6;
																			float arg_2357_4 = 0f;
																			float arg_2357_5 = 0f;
																			int arg_2357_6 = 100;
																			newColor = default(Color);
																			num62 = Dust.NewDust(arg_2357_0, arg_2357_1, arg_2357_2, arg_2357_3, arg_2357_4, arg_2357_5, arg_2357_6, newColor, 1.5f);
																			Dust expr_2366 = Main.dust[num62];
																			expr_2366.velocity *= 3f;
																		}
																		Vector2 arg_23C1_0 = new Vector2(this.position.X, this.position.Y);
																		Vector2 vector = default(Vector2);
																		int num63 = Gore.NewGore(arg_23C1_0, vector, Main.rand.Next(61, 64), 1f);
																		Gore expr_23D0 = Main.gore[num63];
																		expr_23D0.velocity *= 0.4f;
																		Gore expr_23F2_cp_0 = Main.gore[num63];
																		expr_23F2_cp_0.velocity.X = expr_23F2_cp_0.velocity.X + 1f;
																		Gore expr_2410_cp_0 = Main.gore[num63];
																		expr_2410_cp_0.velocity.Y = expr_2410_cp_0.velocity.Y + 1f;
																		Vector2 arg_2459_0 = new Vector2(this.position.X, this.position.Y);
																		vector = default(Vector2);
																		num63 = Gore.NewGore(arg_2459_0, vector, Main.rand.Next(61, 64), 1f);
																		Gore expr_2468 = Main.gore[num63];
																		expr_2468.velocity *= 0.4f;
																		Gore expr_248A_cp_0 = Main.gore[num63];
																		expr_248A_cp_0.velocity.X = expr_248A_cp_0.velocity.X - 1f;
																		Gore expr_24A8_cp_0 = Main.gore[num63];
																		expr_24A8_cp_0.velocity.Y = expr_24A8_cp_0.velocity.Y + 1f;
																		Vector2 arg_24F1_0 = new Vector2(this.position.X, this.position.Y);
																		vector = default(Vector2);
																		num63 = Gore.NewGore(arg_24F1_0, vector, Main.rand.Next(61, 64), 1f);
																		Gore expr_2500 = Main.gore[num63];
																		expr_2500.velocity *= 0.4f;
																		Gore expr_2522_cp_0 = Main.gore[num63];
																		expr_2522_cp_0.velocity.X = expr_2522_cp_0.velocity.X + 1f;
																		Gore expr_2540_cp_0 = Main.gore[num63];
																		expr_2540_cp_0.velocity.Y = expr_2540_cp_0.velocity.Y - 1f;
																		Vector2 arg_2589_0 = new Vector2(this.position.X, this.position.Y);
																		vector = default(Vector2);
																		num63 = Gore.NewGore(arg_2589_0, vector, Main.rand.Next(61, 64), 1f);
																		Gore expr_2598 = Main.gore[num63];
																		expr_2598.velocity *= 0.4f;
																		Gore expr_25BA_cp_0 = Main.gore[num63];
																		expr_25BA_cp_0.velocity.X = expr_25BA_cp_0.velocity.X - 1f;
																		Gore expr_25D8_cp_0 = Main.gore[num63];
																		expr_25D8_cp_0.velocity.Y = expr_25D8_cp_0.velocity.Y - 1f;
																		return;
																	}
																}
																else
																{
																	if (this.type == 5)
																	{
																		if (this.life > 0)
																		{
																			int num64 = 0;
																			while ((double)num64 < dmg / (double)this.lifeMax * 50.0)
																			{
																				Vector2 arg_262E_0 = this.position;
																				int arg_262E_1 = this.width;
																				int arg_262E_2 = this.height;
																				int arg_262E_3 = 5;
																				float arg_262E_4 = (float)hitDirection;
																				float arg_262E_5 = -1f;
																				int arg_262E_6 = 0;
																				Color newColor = default(Color);
																				Dust.NewDust(arg_262E_0, arg_262E_1, arg_262E_2, arg_262E_3, arg_262E_4, arg_262E_5, arg_262E_6, newColor, 1f);
																				num64++;
																			}
																			return;
																		}
																		for (int num65 = 0; num65 < 20; num65++)
																		{
																			Vector2 arg_2684_0 = this.position;
																			int arg_2684_1 = this.width;
																			int arg_2684_2 = this.height;
																			int arg_2684_3 = 5;
																			float arg_2684_4 = (float)(2 * hitDirection);
																			float arg_2684_5 = -2f;
																			int arg_2684_6 = 0;
																			Color newColor = default(Color);
																			Dust.NewDust(arg_2684_0, arg_2684_1, arg_2684_2, arg_2684_3, arg_2684_4, arg_2684_5, arg_2684_6, newColor, 1f);
																		}
																		Gore.NewGore(this.position, this.velocity, 6, 1f);
																		Gore.NewGore(this.position, this.velocity, 7, 1f);
																		return;
																	}
																	else
																	{
																		if (this.type == 113 || this.type == 114)
																		{
																			if (this.life > 0)
																			{
																				for (int num66 = 0; num66 < 20; num66++)
																				{
																					Vector2 arg_2716_0 = this.position;
																					int arg_2716_1 = this.width;
																					int arg_2716_2 = this.height;
																					int arg_2716_3 = 5;
																					float arg_2716_4 = (float)hitDirection;
																					float arg_2716_5 = -1f;
																					int arg_2716_6 = 0;
																					Color newColor = default(Color);
																					Dust.NewDust(arg_2716_0, arg_2716_1, arg_2716_2, arg_2716_3, arg_2716_4, arg_2716_5, arg_2716_6, newColor, 1f);
																				}
																				return;
																			}
																			for (int num67 = 0; num67 < 50; num67++)
																			{
																				Vector2 arg_275A_0 = this.position;
																				int arg_275A_1 = this.width;
																				int arg_275A_2 = this.height;
																				int arg_275A_3 = 5;
																				float arg_275A_4 = (float)(2 * hitDirection);
																				float arg_275A_5 = -1f;
																				int arg_275A_6 = 0;
																				Color newColor = default(Color);
																				Dust.NewDust(arg_275A_0, arg_275A_1, arg_275A_2, arg_275A_3, arg_275A_4, arg_275A_5, arg_275A_6, newColor, 1f);
																			}
																			if (this.type == 114)
																			{
																				Gore.NewGore(new Vector2(this.position.X, this.position.Y), this.velocity, 137, this.scale);
																				Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2)), this.velocity, 139, this.scale);
																				Gore.NewGore(new Vector2(this.position.X + (float)(this.width / 2), this.position.Y), this.velocity, 139, this.scale);
																				Gore.NewGore(new Vector2(this.position.X + (float)(this.width / 2), this.position.Y + (float)(this.height / 2)), this.velocity, 137, this.scale);
																				return;
																			}
																			Gore.NewGore(new Vector2(this.position.X, this.position.Y), this.velocity, 137, this.scale);
																			Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2)), this.velocity, 138, this.scale);
																			Gore.NewGore(new Vector2(this.position.X + (float)(this.width / 2), this.position.Y), this.velocity, 138, this.scale);
																			Gore.NewGore(new Vector2(this.position.X + (float)(this.width / 2), this.position.Y + (float)(this.height / 2)), this.velocity, 137, this.scale);
																			if (Main.player[Main.myPlayer].position.Y / 16f > (float)(Main.maxTilesY - 250))
																			{
																				int num68 = (int)Main.screenPosition.Y;
																				int num69 = num68 + Main.screenWidth;
																				int num70 = (int)this.position.X;
																				if (this.direction > 0)
																				{
																					num70 -= 80;
																				}
																				int num71 = num70 + 140;
																				int num72 = num70;
																				for (int num73 = num68; num73 < num69; num73 += 50)
																				{
																					while (num72 < num71)
																					{
																						for (int num74 = 0; num74 < 5; num74++)
																						{
																							Vector2 arg_2A21_0 = new Vector2((float)num72, (float)num73);
																							int arg_2A21_1 = 32;
																							int arg_2A21_2 = 32;
																							int arg_2A21_3 = 5;
																							float arg_2A21_4 = (float)Main.rand.Next(-60, 61) * 0.1f;
																							float arg_2A21_5 = (float)Main.rand.Next(-60, 61) * 0.1f;
																							int arg_2A21_6 = 0;
																							Color newColor = default(Color);
																							Dust.NewDust(arg_2A21_0, arg_2A21_1, arg_2A21_2, arg_2A21_3, arg_2A21_4, arg_2A21_5, arg_2A21_6, newColor, 1f);
																						}
																						Vector2 vector2 = new Vector2((float)Main.rand.Next(-80, 81) * 0.1f, (float)Main.rand.Next(-60, 21) * 0.1f);
																						Gore.NewGore(new Vector2((float)num72, (float)num73), vector2, Main.rand.Next(140, 143), 1f);
																						num72 += 46;
																					}
																					num72 = num70;
																				}
																				return;
																			}
																		}
																		else
																		{
																			if (this.type == 115 || this.type == 116)
																			{
																				if (this.life > 0)
																				{
																					for (int num75 = 0; num75 < 5; num75++)
																					{
																						Vector2 arg_2B00_0 = this.position;
																						int arg_2B00_1 = this.width;
																						int arg_2B00_2 = this.height;
																						int arg_2B00_3 = 5;
																						float arg_2B00_4 = (float)hitDirection;
																						float arg_2B00_5 = -1f;
																						int arg_2B00_6 = 0;
																						Color newColor = default(Color);
																						Dust.NewDust(arg_2B00_0, arg_2B00_1, arg_2B00_2, arg_2B00_3, arg_2B00_4, arg_2B00_5, arg_2B00_6, newColor, 1f);
																					}
																					return;
																				}
																				if (this.type == 115 && Main.netMode != 1)
																				{
																					NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), 116, 0);
																					for (int num76 = 0; num76 < 10; num76++)
																					{
																						Vector2 arg_2B86_0 = this.position;
																						int arg_2B86_1 = this.width;
																						int arg_2B86_2 = this.height;
																						int arg_2B86_3 = 5;
																						float arg_2B86_4 = (float)hitDirection;
																						float arg_2B86_5 = -1f;
																						int arg_2B86_6 = 0;
																						Color newColor = default(Color);
																						Dust.NewDust(arg_2B86_0, arg_2B86_1, arg_2B86_2, arg_2B86_3, arg_2B86_4, arg_2B86_5, arg_2B86_6, newColor, 1f);
																					}
																					return;
																				}
																				for (int num77 = 0; num77 < 20; num77++)
																				{
																					Vector2 arg_2BC8_0 = this.position;
																					int arg_2BC8_1 = this.width;
																					int arg_2BC8_2 = this.height;
																					int arg_2BC8_3 = 5;
																					float arg_2BC8_4 = (float)hitDirection;
																					float arg_2BC8_5 = -1f;
																					int arg_2BC8_6 = 0;
																					Color newColor = default(Color);
																					Dust.NewDust(arg_2BC8_0, arg_2BC8_1, arg_2BC8_2, arg_2BC8_3, arg_2BC8_4, arg_2BC8_5, arg_2BC8_6, newColor, 1f);
																				}
																				Gore.NewGore(this.position, this.velocity, 132, this.scale);
																				Gore.NewGore(this.position, this.velocity, 133, this.scale);
																				return;
																			}
																			else
																			{
																				if (this.type >= 117 && this.type <= 119)
																				{
																					if (this.life > 0)
																					{
																						for (int num78 = 0; num78 < 5; num78++)
																						{
																							Vector2 arg_2C67_0 = this.position;
																							int arg_2C67_1 = this.width;
																							int arg_2C67_2 = this.height;
																							int arg_2C67_3 = 5;
																							float arg_2C67_4 = (float)hitDirection;
																							float arg_2C67_5 = -1f;
																							int arg_2C67_6 = 0;
																							Color newColor = default(Color);
																							Dust.NewDust(arg_2C67_0, arg_2C67_1, arg_2C67_2, arg_2C67_3, arg_2C67_4, arg_2C67_5, arg_2C67_6, newColor, 1f);
																						}
																						return;
																					}
																					for (int num79 = 0; num79 < 10; num79++)
																					{
																						Vector2 arg_2CA8_0 = this.position;
																						int arg_2CA8_1 = this.width;
																						int arg_2CA8_2 = this.height;
																						int arg_2CA8_3 = 5;
																						float arg_2CA8_4 = (float)hitDirection;
																						float arg_2CA8_5 = -1f;
																						int arg_2CA8_6 = 0;
																						Color newColor = default(Color);
																						Dust.NewDust(arg_2CA8_0, arg_2CA8_1, arg_2CA8_2, arg_2CA8_3, arg_2CA8_4, arg_2CA8_5, arg_2CA8_6, newColor, 1f);
																					}
																					Gore.NewGore(this.position, this.velocity, 134 + this.type - 117, this.scale);
																					return;
																				}
																				else
																				{
																					if (this.type == 6 || this.type == 94)
																					{
																						if (this.life > 0)
																						{
																							int num80 = 0;
																							while ((double)num80 < dmg / (double)this.lifeMax * 100.0)
																							{
																								Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -1f, this.alpha, this.color, this.scale);
																								num80++;
																							}
																							return;
																						}
																						for (int num81 = 0; num81 < 50; num81++)
																						{
																							Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -2f, this.alpha, this.color, this.scale);
																						}
																						int num82;
																						if (this.type == 94)
																						{
																							num82 = Gore.NewGore(this.position, this.velocity, 108, this.scale);
																							num82 = Gore.NewGore(this.position, this.velocity, 108, this.scale);
																							num82 = Gore.NewGore(this.position, this.velocity, 109, this.scale);
																							num82 = Gore.NewGore(this.position, this.velocity, 110, this.scale);
																							return;
																						}
																						num82 = Gore.NewGore(this.position, this.velocity, 14, this.scale);
																						Main.gore[num82].alpha = this.alpha;
																						num82 = Gore.NewGore(this.position, this.velocity, 15, this.scale);
																						Main.gore[num82].alpha = this.alpha;
																						return;
																					}
																					else
																					{
																						if (this.type == 101)
																						{
																							if (this.life > 0)
																							{
																								int num83 = 0;
																								while ((double)num83 < dmg / (double)this.lifeMax * 100.0)
																								{
																									Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -1f, this.alpha, this.color, this.scale);
																									num83++;
																								}
																								return;
																							}
																							for (int num84 = 0; num84 < 50; num84++)
																							{
																								Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -2f, this.alpha, this.color, this.scale);
																							}
																							Gore.NewGore(this.position, this.velocity, 110, this.scale);
																							Gore.NewGore(this.position, this.velocity, 114, this.scale);
																							Gore.NewGore(this.position, this.velocity, 114, this.scale);
																							Gore.NewGore(this.position, this.velocity, 115, this.scale);
																							return;
																						}
																						else
																						{
																							if (this.type == 7 || this.type == 8 || this.type == 9)
																							{
																								if (this.life > 0)
																								{
																									int num85 = 0;
																									while ((double)num85 < dmg / (double)this.lifeMax * 100.0)
																									{
																										Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -1f, this.alpha, this.color, this.scale);
																										num85++;
																									}
																									return;
																								}
																								for (int num86 = 0; num86 < 50; num86++)
																								{
																									Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -2f, this.alpha, this.color, this.scale);
																								}
																								int num87 = Gore.NewGore(this.position, this.velocity, this.type - 7 + 18, 1f);
																								Main.gore[num87].alpha = this.alpha;
																								return;
																							}
																							else
																							{
																								if (this.type == 98 || this.type == 99 || this.type == 100)
																								{
																									if (this.life > 0)
																									{
																										int num88 = 0;
																										while ((double)num88 < dmg / (double)this.lifeMax * 100.0)
																										{
																											Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -1f, this.alpha, this.color, this.scale);
																											num88++;
																										}
																										return;
																									}
																									for (int num89 = 0; num89 < 50; num89++)
																									{
																										Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -2f, this.alpha, this.color, this.scale);
																									}
																									int num90 = Gore.NewGore(this.position, this.velocity, 110, 1f);
																									Main.gore[num90].alpha = this.alpha;
																									return;
																								}
																								else
																								{
																									if (this.type == 10 || this.type == 11 || this.type == 12)
																									{
																										if (this.life > 0)
																										{
																											int num91 = 0;
																											while ((double)num91 < dmg / (double)this.lifeMax * 50.0)
																											{
																												Vector2 arg_31D0_0 = this.position;
																												int arg_31D0_1 = this.width;
																												int arg_31D0_2 = this.height;
																												int arg_31D0_3 = 5;
																												float arg_31D0_4 = (float)hitDirection;
																												float arg_31D0_5 = -1f;
																												int arg_31D0_6 = 0;
																												Color newColor = default(Color);
																												Dust.NewDust(arg_31D0_0, arg_31D0_1, arg_31D0_2, arg_31D0_3, arg_31D0_4, arg_31D0_5, arg_31D0_6, newColor, 1f);
																												num91++;
																											}
																											return;
																										}
																										for (int num92 = 0; num92 < 10; num92++)
																										{
																											Vector2 arg_322A_0 = this.position;
																											int arg_322A_1 = this.width;
																											int arg_322A_2 = this.height;
																											int arg_322A_3 = 5;
																											float arg_322A_4 = 2.5f * (float)hitDirection;
																											float arg_322A_5 = -2.5f;
																											int arg_322A_6 = 0;
																											Color newColor = default(Color);
																											Dust.NewDust(arg_322A_0, arg_322A_1, arg_322A_2, arg_322A_3, arg_322A_4, arg_322A_5, arg_322A_6, newColor, 1f);
																										}
																										Gore.NewGore(this.position, this.velocity, this.type - 7 + 18, 1f);
																										return;
																									}
																									else
																									{
																										if (this.type == 95 || this.type == 96 || this.type == 97)
																										{
																											if (this.life > 0)
																											{
																												int num93 = 0;
																												while ((double)num93 < dmg / (double)this.lifeMax * 50.0)
																												{
																													Vector2 arg_32B8_0 = this.position;
																													int arg_32B8_1 = this.width;
																													int arg_32B8_2 = this.height;
																													int arg_32B8_3 = 5;
																													float arg_32B8_4 = (float)hitDirection;
																													float arg_32B8_5 = -1f;
																													int arg_32B8_6 = 0;
																													Color newColor = default(Color);
																													Dust.NewDust(arg_32B8_0, arg_32B8_1, arg_32B8_2, arg_32B8_3, arg_32B8_4, arg_32B8_5, arg_32B8_6, newColor, 1f);
																													num93++;
																												}
																												return;
																											}
																											for (int num94 = 0; num94 < 10; num94++)
																											{
																												Vector2 arg_3312_0 = this.position;
																												int arg_3312_1 = this.width;
																												int arg_3312_2 = this.height;
																												int arg_3312_3 = 5;
																												float arg_3312_4 = 2.5f * (float)hitDirection;
																												float arg_3312_5 = -2.5f;
																												int arg_3312_6 = 0;
																												Color newColor = default(Color);
																												Dust.NewDust(arg_3312_0, arg_3312_1, arg_3312_2, arg_3312_3, arg_3312_4, arg_3312_5, arg_3312_6, newColor, 1f);
																											}
																											Gore.NewGore(this.position, this.velocity, this.type - 95 + 111, 1f);
																											return;
																										}
																										else
																										{
																											if (this.type == 13 || this.type == 14 || this.type == 15)
																											{
																												if (this.life > 0)
																												{
																													int num95 = 0;
																													while ((double)num95 < dmg / (double)this.lifeMax * 100.0)
																													{
																														Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -1f, this.alpha, this.color, this.scale);
																														num95++;
																													}
																													return;
																												}
																												for (int num96 = 0; num96 < 50; num96++)
																												{
																													Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -2f, this.alpha, this.color, this.scale);
																												}
																												if (this.type == 13)
																												{
																													Gore.NewGore(this.position, this.velocity, 24, 1f);
																													Gore.NewGore(this.position, this.velocity, 25, 1f);
																													return;
																												}
																												if (this.type == 14)
																												{
																													Gore.NewGore(this.position, this.velocity, 26, 1f);
																													Gore.NewGore(this.position, this.velocity, 27, 1f);
																													return;
																												}
																												Gore.NewGore(this.position, this.velocity, 28, 1f);
																												Gore.NewGore(this.position, this.velocity, 29, 1f);
																												return;
																											}
																											else
																											{
																												if (this.type == 17)
																												{
																													if (this.life > 0)
																													{
																														int num97 = 0;
																														while ((double)num97 < dmg / (double)this.lifeMax * 100.0)
																														{
																															Vector2 arg_34FF_0 = this.position;
																															int arg_34FF_1 = this.width;
																															int arg_34FF_2 = this.height;
																															int arg_34FF_3 = 5;
																															float arg_34FF_4 = (float)hitDirection;
																															float arg_34FF_5 = -1f;
																															int arg_34FF_6 = 0;
																															Color newColor = default(Color);
																															Dust.NewDust(arg_34FF_0, arg_34FF_1, arg_34FF_2, arg_34FF_3, arg_34FF_4, arg_34FF_5, arg_34FF_6, newColor, 1f);
																															num97++;
																														}
																														return;
																													}
																													for (int num98 = 0; num98 < 50; num98++)
																													{
																														Vector2 arg_3559_0 = this.position;
																														int arg_3559_1 = this.width;
																														int arg_3559_2 = this.height;
																														int arg_3559_3 = 5;
																														float arg_3559_4 = 2.5f * (float)hitDirection;
																														float arg_3559_5 = -2.5f;
																														int arg_3559_6 = 0;
																														Color newColor = default(Color);
																														Dust.NewDust(arg_3559_0, arg_3559_1, arg_3559_2, arg_3559_3, arg_3559_4, arg_3559_5, arg_3559_6, newColor, 1f);
																													}
																													Gore.NewGore(this.position, this.velocity, 30, 1f);
																													Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 31, 1f);
																													Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 31, 1f);
																													Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 32, 1f);
																													Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 32, 1f);
																													return;
																												}
																												else
																												{
																													if (this.type == 86)
																													{
																														if (this.life > 0)
																														{
																															int num99 = 0;
																															while ((double)num99 < dmg / (double)this.lifeMax * 100.0)
																															{
																																Vector2 arg_369A_0 = this.position;
																																int arg_369A_1 = this.width;
																																int arg_369A_2 = this.height;
																																int arg_369A_3 = 5;
																																float arg_369A_4 = (float)hitDirection;
																																float arg_369A_5 = -1f;
																																int arg_369A_6 = 0;
																																Color newColor = default(Color);
																																Dust.NewDust(arg_369A_0, arg_369A_1, arg_369A_2, arg_369A_3, arg_369A_4, arg_369A_5, arg_369A_6, newColor, 1f);
																																num99++;
																															}
																															return;
																														}
																														for (int num100 = 0; num100 < 50; num100++)
																														{
																															Vector2 arg_36F4_0 = this.position;
																															int arg_36F4_1 = this.width;
																															int arg_36F4_2 = this.height;
																															int arg_36F4_3 = 5;
																															float arg_36F4_4 = 2.5f * (float)hitDirection;
																															float arg_36F4_5 = -2.5f;
																															int arg_36F4_6 = 0;
																															Color newColor = default(Color);
																															Dust.NewDust(arg_36F4_0, arg_36F4_1, arg_36F4_2, arg_36F4_3, arg_36F4_4, arg_36F4_5, arg_36F4_6, newColor, 1f);
																														}
																														Gore.NewGore(this.position, this.velocity, 101, 1f);
																														Gore.NewGore(this.position, this.velocity, 102, 1f);
																														Gore.NewGore(this.position, this.velocity, 103, 1f);
																														Gore.NewGore(this.position, this.velocity, 103, 1f);
																														Gore.NewGore(this.position, this.velocity, 104, 1f);
																														Gore.NewGore(this.position, this.velocity, 104, 1f);
																														Gore.NewGore(this.position, this.velocity, 105, 1f);
																														return;
																													}
																													else
																													{
																														if (this.type >= 105 && this.type <= 108)
																														{
																															if (this.life > 0)
																															{
																																int num101 = 0;
																																while ((double)num101 < dmg / (double)this.lifeMax * 100.0)
																																{
																																	Vector2 arg_3808_0 = this.position;
																																	int arg_3808_1 = this.width;
																																	int arg_3808_2 = this.height;
																																	int arg_3808_3 = 5;
																																	float arg_3808_4 = (float)hitDirection;
																																	float arg_3808_5 = -1f;
																																	int arg_3808_6 = 0;
																																	Color newColor = default(Color);
																																	Dust.NewDust(arg_3808_0, arg_3808_1, arg_3808_2, arg_3808_3, arg_3808_4, arg_3808_5, arg_3808_6, newColor, 1f);
																																	num101++;
																																}
																																return;
																															}
																															for (int num102 = 0; num102 < 50; num102++)
																															{
																																Vector2 arg_3862_0 = this.position;
																																int arg_3862_1 = this.width;
																																int arg_3862_2 = this.height;
																																int arg_3862_3 = 5;
																																float arg_3862_4 = 2.5f * (float)hitDirection;
																																float arg_3862_5 = -2.5f;
																																int arg_3862_6 = 0;
																																Color newColor = default(Color);
																																Dust.NewDust(arg_3862_0, arg_3862_1, arg_3862_2, arg_3862_3, arg_3862_4, arg_3862_5, arg_3862_6, newColor, 1f);
																															}
																															if (this.type == 105 || this.type == 107)
																															{
																																Gore.NewGore(this.position, this.velocity, 124, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 125, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 125, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 126, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 126, 1f);
																																return;
																															}
																															Gore.NewGore(this.position, this.velocity, 127, 1f);
																															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 128, 1f);
																															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 128, 1f);
																															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 129, 1f);
																															Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 129, 1f);
																															return;
																														}
																														else
																														{
																															if (this.type == 123 || this.type == 124)
																															{
																																if (this.life > 0)
																																{
																																	int num103 = 0;
																																	while ((double)num103 < dmg / (double)this.lifeMax * 100.0)
																																	{
																																		Vector2 arg_3ABA_0 = this.position;
																																		int arg_3ABA_1 = this.width;
																																		int arg_3ABA_2 = this.height;
																																		int arg_3ABA_3 = 5;
																																		float arg_3ABA_4 = (float)hitDirection;
																																		float arg_3ABA_5 = -1f;
																																		int arg_3ABA_6 = 0;
																																		Color newColor = default(Color);
																																		Dust.NewDust(arg_3ABA_0, arg_3ABA_1, arg_3ABA_2, arg_3ABA_3, arg_3ABA_4, arg_3ABA_5, arg_3ABA_6, newColor, 1f);
																																		num103++;
																																	}
																																	return;
																																}
																																for (int num104 = 0; num104 < 50; num104++)
																																{
																																	Vector2 arg_3B14_0 = this.position;
																																	int arg_3B14_1 = this.width;
																																	int arg_3B14_2 = this.height;
																																	int arg_3B14_3 = 5;
																																	float arg_3B14_4 = 2.5f * (float)hitDirection;
																																	float arg_3B14_5 = -2.5f;
																																	int arg_3B14_6 = 0;
																																	Color newColor = default(Color);
																																	Dust.NewDust(arg_3B14_0, arg_3B14_1, arg_3B14_2, arg_3B14_3, arg_3B14_4, arg_3B14_5, arg_3B14_6, newColor, 1f);
																																}
																																Gore.NewGore(this.position, this.velocity, 151, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 152, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 152, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 153, 1f);
																																Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 153, 1f);
																																return;
																															}
																															else
																															{
																																if (this.type == 22)
																																{
																																	if (this.life > 0)
																																	{
																																		int num105 = 0;
																																		while ((double)num105 < dmg / (double)this.lifeMax * 100.0)
																																		{
																																			Vector2 arg_3C64_0 = this.position;
																																			int arg_3C64_1 = this.width;
																																			int arg_3C64_2 = this.height;
																																			int arg_3C64_3 = 5;
																																			float arg_3C64_4 = (float)hitDirection;
																																			float arg_3C64_5 = -1f;
																																			int arg_3C64_6 = 0;
																																			Color newColor = default(Color);
																																			Dust.NewDust(arg_3C64_0, arg_3C64_1, arg_3C64_2, arg_3C64_3, arg_3C64_4, arg_3C64_5, arg_3C64_6, newColor, 1f);
																																			num105++;
																																		}
																																		return;
																																	}
																																	for (int num106 = 0; num106 < 50; num106++)
																																	{
																																		Vector2 arg_3CBE_0 = this.position;
																																		int arg_3CBE_1 = this.width;
																																		int arg_3CBE_2 = this.height;
																																		int arg_3CBE_3 = 5;
																																		float arg_3CBE_4 = 2.5f * (float)hitDirection;
																																		float arg_3CBE_5 = -2.5f;
																																		int arg_3CBE_6 = 0;
																																		Color newColor = default(Color);
																																		Dust.NewDust(arg_3CBE_0, arg_3CBE_1, arg_3CBE_2, arg_3CBE_3, arg_3CBE_4, arg_3CBE_5, arg_3CBE_6, newColor, 1f);
																																	}
																																	Gore.NewGore(this.position, this.velocity, 73, 1f);
																																	Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 74, 1f);
																																	Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 74, 1f);
																																	Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 75, 1f);
																																	Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 75, 1f);
																																	return;
																																}
																																else
																																{
																																	if (this.type == 142)
																																	{
																																		if (this.life > 0)
																																		{
																																			int num107 = 0;
																																			while ((double)num107 < dmg / (double)this.lifeMax * 100.0)
																																			{
																																				Vector2 arg_3E02_0 = this.position;
																																				int arg_3E02_1 = this.width;
																																				int arg_3E02_2 = this.height;
																																				int arg_3E02_3 = 5;
																																				float arg_3E02_4 = (float)hitDirection;
																																				float arg_3E02_5 = -1f;
																																				int arg_3E02_6 = 0;
																																				Color newColor = default(Color);
																																				Dust.NewDust(arg_3E02_0, arg_3E02_1, arg_3E02_2, arg_3E02_3, arg_3E02_4, arg_3E02_5, arg_3E02_6, newColor, 1f);
																																				num107++;
																																			}
																																			return;
																																		}
																																		for (int num108 = 0; num108 < 50; num108++)
																																		{
																																			Vector2 arg_3E5C_0 = this.position;
																																			int arg_3E5C_1 = this.width;
																																			int arg_3E5C_2 = this.height;
																																			int arg_3E5C_3 = 5;
																																			float arg_3E5C_4 = 2.5f * (float)hitDirection;
																																			float arg_3E5C_5 = -2.5f;
																																			int arg_3E5C_6 = 0;
																																			Color newColor = default(Color);
																																			Dust.NewDust(arg_3E5C_0, arg_3E5C_1, arg_3E5C_2, arg_3E5C_3, arg_3E5C_4, arg_3E5C_5, arg_3E5C_6, newColor, 1f);
																																		}
																																		Gore.NewGore(this.position, this.velocity, 157, 1f);
																																		Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 158, 1f);
																																		Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 158, 1f);
																																		Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 159, 1f);
																																		Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 159, 1f);
																																		return;
																																	}
																																	else
																																	{
																																		if (this.type == 37 || this.type == 54)
																																		{
																																			if (this.life > 0)
																																			{
																																				int num109 = 0;
																																				while ((double)num109 < dmg / (double)this.lifeMax * 100.0)
																																				{
																																					Vector2 arg_3FB6_0 = this.position;
																																					int arg_3FB6_1 = this.width;
																																					int arg_3FB6_2 = this.height;
																																					int arg_3FB6_3 = 5;
																																					float arg_3FB6_4 = (float)hitDirection;
																																					float arg_3FB6_5 = -1f;
																																					int arg_3FB6_6 = 0;
																																					Color newColor = default(Color);
																																					Dust.NewDust(arg_3FB6_0, arg_3FB6_1, arg_3FB6_2, arg_3FB6_3, arg_3FB6_4, arg_3FB6_5, arg_3FB6_6, newColor, 1f);
																																					num109++;
																																				}
																																				return;
																																			}
																																			for (int num110 = 0; num110 < 50; num110++)
																																			{
																																				Vector2 arg_4010_0 = this.position;
																																				int arg_4010_1 = this.width;
																																				int arg_4010_2 = this.height;
																																				int arg_4010_3 = 5;
																																				float arg_4010_4 = 2.5f * (float)hitDirection;
																																				float arg_4010_5 = -2.5f;
																																				int arg_4010_6 = 0;
																																				Color newColor = default(Color);
																																				Dust.NewDust(arg_4010_0, arg_4010_1, arg_4010_2, arg_4010_3, arg_4010_4, arg_4010_5, arg_4010_6, newColor, 1f);
																																			}
																																			Gore.NewGore(this.position, this.velocity, 58, 1f);
																																			Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 59, 1f);
																																			Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 59, 1f);
																																			Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 60, 1f);
																																			Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 60, 1f);
																																			return;
																																		}
																																		else
																																		{
																																			if (this.type == 18)
																																			{
																																				if (this.life > 0)
																																				{
																																					int num111 = 0;
																																					while ((double)num111 < dmg / (double)this.lifeMax * 100.0)
																																					{
																																						Vector2 arg_4151_0 = this.position;
																																						int arg_4151_1 = this.width;
																																						int arg_4151_2 = this.height;
																																						int arg_4151_3 = 5;
																																						float arg_4151_4 = (float)hitDirection;
																																						float arg_4151_5 = -1f;
																																						int arg_4151_6 = 0;
																																						Color newColor = default(Color);
																																						Dust.NewDust(arg_4151_0, arg_4151_1, arg_4151_2, arg_4151_3, arg_4151_4, arg_4151_5, arg_4151_6, newColor, 1f);
																																						num111++;
																																					}
																																					return;
																																				}
																																				for (int num112 = 0; num112 < 50; num112++)
																																				{
																																					Vector2 arg_41AB_0 = this.position;
																																					int arg_41AB_1 = this.width;
																																					int arg_41AB_2 = this.height;
																																					int arg_41AB_3 = 5;
																																					float arg_41AB_4 = 2.5f * (float)hitDirection;
																																					float arg_41AB_5 = -2.5f;
																																					int arg_41AB_6 = 0;
																																					Color newColor = default(Color);
																																					Dust.NewDust(arg_41AB_0, arg_41AB_1, arg_41AB_2, arg_41AB_3, arg_41AB_4, arg_41AB_5, arg_41AB_6, newColor, 1f);
																																				}
																																				Gore.NewGore(this.position, this.velocity, 33, 1f);
																																				Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 34, 1f);
																																				Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 34, 1f);
																																				Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 35, 1f);
																																				Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 35, 1f);
																																				return;
																																			}
																																			else
																																			{
																																				if (this.type == 19)
																																				{
																																					if (this.life > 0)
																																					{
																																						int num113 = 0;
																																						while ((double)num113 < dmg / (double)this.lifeMax * 100.0)
																																						{
																																							Vector2 arg_42EC_0 = this.position;
																																							int arg_42EC_1 = this.width;
																																							int arg_42EC_2 = this.height;
																																							int arg_42EC_3 = 5;
																																							float arg_42EC_4 = (float)hitDirection;
																																							float arg_42EC_5 = -1f;
																																							int arg_42EC_6 = 0;
																																							Color newColor = default(Color);
																																							Dust.NewDust(arg_42EC_0, arg_42EC_1, arg_42EC_2, arg_42EC_3, arg_42EC_4, arg_42EC_5, arg_42EC_6, newColor, 1f);
																																							num113++;
																																						}
																																						return;
																																					}
																																					for (int num114 = 0; num114 < 50; num114++)
																																					{
																																						Vector2 arg_4346_0 = this.position;
																																						int arg_4346_1 = this.width;
																																						int arg_4346_2 = this.height;
																																						int arg_4346_3 = 5;
																																						float arg_4346_4 = 2.5f * (float)hitDirection;
																																						float arg_4346_5 = -2.5f;
																																						int arg_4346_6 = 0;
																																						Color newColor = default(Color);
																																						Dust.NewDust(arg_4346_0, arg_4346_1, arg_4346_2, arg_4346_3, arg_4346_4, arg_4346_5, arg_4346_6, newColor, 1f);
																																					}
																																					Gore.NewGore(this.position, this.velocity, 36, 1f);
																																					Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 37, 1f);
																																					Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 37, 1f);
																																					Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 38, 1f);
																																					Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 38, 1f);
																																					return;
																																				}
																																				else
																																				{
																																					if (this.type == 38)
																																					{
																																						if (this.life > 0)
																																						{
																																							int num115 = 0;
																																							while ((double)num115 < dmg / (double)this.lifeMax * 100.0)
																																							{
																																								Vector2 arg_4487_0 = this.position;
																																								int arg_4487_1 = this.width;
																																								int arg_4487_2 = this.height;
																																								int arg_4487_3 = 5;
																																								float arg_4487_4 = (float)hitDirection;
																																								float arg_4487_5 = -1f;
																																								int arg_4487_6 = 0;
																																								Color newColor = default(Color);
																																								Dust.NewDust(arg_4487_0, arg_4487_1, arg_4487_2, arg_4487_3, arg_4487_4, arg_4487_5, arg_4487_6, newColor, 1f);
																																								num115++;
																																							}
																																							return;
																																						}
																																						for (int num116 = 0; num116 < 50; num116++)
																																						{
																																							Vector2 arg_44E1_0 = this.position;
																																							int arg_44E1_1 = this.width;
																																							int arg_44E1_2 = this.height;
																																							int arg_44E1_3 = 5;
																																							float arg_44E1_4 = 2.5f * (float)hitDirection;
																																							float arg_44E1_5 = -2.5f;
																																							int arg_44E1_6 = 0;
																																							Color newColor = default(Color);
																																							Dust.NewDust(arg_44E1_0, arg_44E1_1, arg_44E1_2, arg_44E1_3, arg_44E1_4, arg_44E1_5, arg_44E1_6, newColor, 1f);
																																						}
																																						Gore.NewGore(this.position, this.velocity, 64, 1f);
																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 65, 1f);
																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 65, 1f);
																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 66, 1f);
																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 66, 1f);
																																						return;
																																					}
																																					else
																																					{
																																						if (this.type == 20)
																																						{
																																							if (this.life > 0)
																																							{
																																								int num117 = 0;
																																								while ((double)num117 < dmg / (double)this.lifeMax * 100.0)
																																								{
																																									Vector2 arg_4622_0 = this.position;
																																									int arg_4622_1 = this.width;
																																									int arg_4622_2 = this.height;
																																									int arg_4622_3 = 5;
																																									float arg_4622_4 = (float)hitDirection;
																																									float arg_4622_5 = -1f;
																																									int arg_4622_6 = 0;
																																									Color newColor = default(Color);
																																									Dust.NewDust(arg_4622_0, arg_4622_1, arg_4622_2, arg_4622_3, arg_4622_4, arg_4622_5, arg_4622_6, newColor, 1f);
																																									num117++;
																																								}
																																								return;
																																							}
																																							for (int num118 = 0; num118 < 50; num118++)
																																							{
																																								Vector2 arg_467C_0 = this.position;
																																								int arg_467C_1 = this.width;
																																								int arg_467C_2 = this.height;
																																								int arg_467C_3 = 5;
																																								float arg_467C_4 = 2.5f * (float)hitDirection;
																																								float arg_467C_5 = -2.5f;
																																								int arg_467C_6 = 0;
																																								Color newColor = default(Color);
																																								Dust.NewDust(arg_467C_0, arg_467C_1, arg_467C_2, arg_467C_3, arg_467C_4, arg_467C_5, arg_467C_6, newColor, 1f);
																																							}
																																							Gore.NewGore(this.position, this.velocity, 39, 1f);
																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 40, 1f);
																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 40, 1f);
																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 41, 1f);
																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 41, 1f);
																																							return;
																																						}
																																						else
																																						{
																																							if (this.type == 21 || this.type == 31 || this.type == 32 || this.type == 44 || this.type == 45 || this.type == 77 || this.type == 110)
																																							{
																																								if (this.life > 0)
																																								{
																																									int num119 = 0;
																																									while ((double)num119 < dmg / (double)this.lifeMax * 50.0)
																																									{
																																										Vector2 arg_47FA_0 = this.position;
																																										int arg_47FA_1 = this.width;
																																										int arg_47FA_2 = this.height;
																																										int arg_47FA_3 = 26;
																																										float arg_47FA_4 = (float)hitDirection;
																																										float arg_47FA_5 = -1f;
																																										int arg_47FA_6 = 0;
																																										Color newColor = default(Color);
																																										Dust.NewDust(arg_47FA_0, arg_47FA_1, arg_47FA_2, arg_47FA_3, arg_47FA_4, arg_47FA_5, arg_47FA_6, newColor, 1f);
																																										num119++;
																																									}
																																									return;
																																								}
																																								for (int num120 = 0; num120 < 20; num120++)
																																								{
																																									Vector2 arg_4855_0 = this.position;
																																									int arg_4855_1 = this.width;
																																									int arg_4855_2 = this.height;
																																									int arg_4855_3 = 26;
																																									float arg_4855_4 = 2.5f * (float)hitDirection;
																																									float arg_4855_5 = -2.5f;
																																									int arg_4855_6 = 0;
																																									Color newColor = default(Color);
																																									Dust.NewDust(arg_4855_0, arg_4855_1, arg_4855_2, arg_4855_3, arg_4855_4, arg_4855_5, arg_4855_6, newColor, 1f);
																																								}
																																								Gore.NewGore(this.position, this.velocity, 42, this.scale);
																																								if (this.type == 77)
																																								{
																																									Gore.NewGore(this.position, this.velocity, 106, this.scale);
																																								}
																																								if (this.type == 110)
																																								{
																																									Gore.NewGore(this.position, this.velocity, 130, this.scale);
																																								}
																																								Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 43, this.scale);
																																								Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 43, this.scale);
																																								if (this.type == 110)
																																								{
																																									Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 131, this.scale);
																																								}
																																								Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 44, this.scale);
																																								Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 44, this.scale);
																																								return;
																																							}
																																							else
																																							{
																																								if (this.type == 85)
																																								{
																																									int num121 = 7;
																																									if (this.ai[3] == 2f)
																																									{
																																										num121 = 10;
																																									}
																																									if (this.ai[3] == 3f)
																																									{
																																										num121 = 37;
																																									}
																																									if (this.life > 0)
																																									{
																																										int num122 = 0;
																																										while ((double)num122 < dmg / (double)this.lifeMax * 50.0)
																																										{
																																											Vector2 arg_4A55_0 = this.position;
																																											int arg_4A55_1 = this.width;
																																											int arg_4A55_2 = this.height;
																																											int arg_4A55_3 = num121;
																																											float arg_4A55_4 = 0f;
																																											float arg_4A55_5 = 0f;
																																											int arg_4A55_6 = 0;
																																											Color newColor = default(Color);
																																											Dust.NewDust(arg_4A55_0, arg_4A55_1, arg_4A55_2, arg_4A55_3, arg_4A55_4, arg_4A55_5, arg_4A55_6, newColor, 1f);
																																											num122++;
																																										}
																																										return;
																																									}
																																									for (int num123 = 0; num123 < 20; num123++)
																																									{
																																										Vector2 arg_4AAD_0 = this.position;
																																										int arg_4AAD_1 = this.width;
																																										int arg_4AAD_2 = this.height;
																																										int arg_4AAD_3 = num121;
																																										float arg_4AAD_4 = 0f;
																																										float arg_4AAD_5 = 0f;
																																										int arg_4AAD_6 = 0;
																																										Color newColor = default(Color);
																																										Dust.NewDust(arg_4AAD_0, arg_4AAD_1, arg_4AAD_2, arg_4AAD_3, arg_4AAD_4, arg_4AAD_5, arg_4AAD_6, newColor, 1f);
																																									}
																																									int num124 = Gore.NewGore(new Vector2(this.position.X, this.position.Y - 10f), new Vector2((float)hitDirection, 0f), 61, this.scale);
																																									Gore expr_4B03 = Main.gore[num124];
																																									expr_4B03.velocity *= 0.3f;
																																									num124 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 10f), new Vector2((float)hitDirection, 0f), 62, this.scale);
																																									Gore expr_4B66 = Main.gore[num124];
																																									expr_4B66.velocity *= 0.3f;
																																									num124 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)this.height - 10f), new Vector2((float)hitDirection, 0f), 63, this.scale);
																																									Gore expr_4BC7 = Main.gore[num124];
																																									expr_4BC7.velocity *= 0.3f;
																																									return;
																																								}
																																								else
																																								{
																																									if (this.type >= 87 && this.type <= 92)
																																									{
																																										if (this.life > 0)
																																										{
																																											int num125 = 0;
																																											while ((double)num125 < dmg / (double)this.lifeMax * 50.0)
																																											{
																																												Vector2 arg_4C36_0 = this.position;
																																												int arg_4C36_1 = this.width;
																																												int arg_4C36_2 = this.height;
																																												int arg_4C36_3 = 16;
																																												float arg_4C36_4 = 0f;
																																												float arg_4C36_5 = 0f;
																																												int arg_4C36_6 = 0;
																																												Color newColor = default(Color);
																																												int num126 = Dust.NewDust(arg_4C36_0, arg_4C36_1, arg_4C36_2, arg_4C36_3, arg_4C36_4, arg_4C36_5, arg_4C36_6, newColor, 1.5f);
																																												Dust expr_4C45 = Main.dust[num126];
																																												expr_4C45.velocity *= 1.5f;
																																												Main.dust[num126].noGravity = true;
																																												num125++;
																																											}
																																											return;
																																										}
																																										for (int num127 = 0; num127 < 10; num127++)
																																										{
																																											Vector2 arg_4CBA_0 = this.position;
																																											int arg_4CBA_1 = this.width;
																																											int arg_4CBA_2 = this.height;
																																											int arg_4CBA_3 = 16;
																																											float arg_4CBA_4 = 0f;
																																											float arg_4CBA_5 = 0f;
																																											int arg_4CBA_6 = 0;
																																											Color newColor = default(Color);
																																											int num128 = Dust.NewDust(arg_4CBA_0, arg_4CBA_1, arg_4CBA_2, arg_4CBA_3, arg_4CBA_4, arg_4CBA_5, arg_4CBA_6, newColor, 1.5f);
																																											Dust expr_4CC9 = Main.dust[num128];
																																											expr_4CC9.velocity *= 2f;
																																											Main.dust[num128].noGravity = true;
																																										}
																																										int num129 = Main.rand.Next(1, 4);
																																										for (int num130 = 0; num130 < num129; num130++)
																																										{
																																											int num131 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 10f), new Vector2((float)hitDirection, 0f), Main.rand.Next(11, 14), this.scale);
																																											Gore expr_4D65 = Main.gore[num131];
																																											expr_4D65.velocity *= 0.8f;
																																										}
																																										return;
																																									}
																																									else
																																									{
																																										if (this.type == 78 || this.type == 79 || this.type == 80)
																																										{
																																											if (this.life > 0)
																																											{
																																												int num132 = 0;
																																												while ((double)num132 < dmg / (double)this.lifeMax * 50.0)
																																												{
																																													Vector2 arg_4DE7_0 = this.position;
																																													int arg_4DE7_1 = this.width;
																																													int arg_4DE7_2 = this.height;
																																													int arg_4DE7_3 = 31;
																																													float arg_4DE7_4 = 0f;
																																													float arg_4DE7_5 = 0f;
																																													int arg_4DE7_6 = 0;
																																													Color newColor = default(Color);
																																													int num133 = Dust.NewDust(arg_4DE7_0, arg_4DE7_1, arg_4DE7_2, arg_4DE7_3, arg_4DE7_4, arg_4DE7_5, arg_4DE7_6, newColor, 1.5f);
																																													Dust expr_4DF6 = Main.dust[num133];
																																													expr_4DF6.velocity *= 2f;
																																													Main.dust[num133].noGravity = true;
																																													num132++;
																																												}
																																												return;
																																											}
																																											for (int num134 = 0; num134 < 20; num134++)
																																											{
																																												Vector2 arg_4E6B_0 = this.position;
																																												int arg_4E6B_1 = this.width;
																																												int arg_4E6B_2 = this.height;
																																												int arg_4E6B_3 = 31;
																																												float arg_4E6B_4 = 0f;
																																												float arg_4E6B_5 = 0f;
																																												int arg_4E6B_6 = 0;
																																												Color newColor = default(Color);
																																												int num135 = Dust.NewDust(arg_4E6B_0, arg_4E6B_1, arg_4E6B_2, arg_4E6B_3, arg_4E6B_4, arg_4E6B_5, arg_4E6B_6, newColor, 1.5f);
																																												Dust expr_4E7A = Main.dust[num135];
																																												expr_4E7A.velocity *= 2f;
																																												Main.dust[num135].noGravity = true;
																																											}
																																											int num136 = Gore.NewGore(new Vector2(this.position.X, this.position.Y - 10f), new Vector2((float)hitDirection, 0f), 61, this.scale);
																																											Gore expr_4EED = Main.gore[num136];
																																											expr_4EED.velocity *= 0.3f;
																																											num136 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 10f), new Vector2((float)hitDirection, 0f), 62, this.scale);
																																											Gore expr_4F50 = Main.gore[num136];
																																											expr_4F50.velocity *= 0.3f;
																																											num136 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)this.height - 10f), new Vector2((float)hitDirection, 0f), 63, this.scale);
																																											Gore expr_4FB1 = Main.gore[num136];
																																											expr_4FB1.velocity *= 0.3f;
																																											return;
																																										}
																																										else
																																										{
																																											if (this.type == 82)
																																											{
																																												if (this.life > 0)
																																												{
																																													int num137 = 0;
																																													while ((double)num137 < dmg / (double)this.lifeMax * 50.0)
																																													{
																																														Vector2 arg_5014_0 = this.position;
																																														int arg_5014_1 = this.width;
																																														int arg_5014_2 = this.height;
																																														int arg_5014_3 = 54;
																																														float arg_5014_4 = 0f;
																																														float arg_5014_5 = 0f;
																																														int arg_5014_6 = 50;
																																														Color newColor = default(Color);
																																														int num138 = Dust.NewDust(arg_5014_0, arg_5014_1, arg_5014_2, arg_5014_3, arg_5014_4, arg_5014_5, arg_5014_6, newColor, 1.5f);
																																														Dust expr_5023 = Main.dust[num138];
																																														expr_5023.velocity *= 2f;
																																														Main.dust[num138].noGravity = true;
																																														num137++;
																																													}
																																													return;
																																												}
																																												for (int num139 = 0; num139 < 20; num139++)
																																												{
																																													Vector2 arg_5099_0 = this.position;
																																													int arg_5099_1 = this.width;
																																													int arg_5099_2 = this.height;
																																													int arg_5099_3 = 54;
																																													float arg_5099_4 = 0f;
																																													float arg_5099_5 = 0f;
																																													int arg_5099_6 = 50;
																																													Color newColor = default(Color);
																																													int num140 = Dust.NewDust(arg_5099_0, arg_5099_1, arg_5099_2, arg_5099_3, arg_5099_4, arg_5099_5, arg_5099_6, newColor, 1.5f);
																																													Dust expr_50A8 = Main.dust[num140];
																																													expr_50A8.velocity *= 2f;
																																													Main.dust[num140].noGravity = true;
																																												}
																																												int num141 = Gore.NewGore(new Vector2(this.position.X, this.position.Y - 10f), new Vector2((float)hitDirection, 0f), 99, this.scale);
																																												Gore expr_511B = Main.gore[num141];
																																												expr_511B.velocity *= 0.3f;
																																												num141 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 15f), new Vector2((float)hitDirection, 0f), 99, this.scale);
																																												Gore expr_517E = Main.gore[num141];
																																												expr_517E.velocity *= 0.3f;
																																												num141 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)this.height - 20f), new Vector2((float)hitDirection, 0f), 99, this.scale);
																																												Gore expr_51DF = Main.gore[num141];
																																												expr_51DF.velocity *= 0.3f;
																																												return;
																																											}
																																											else
																																											{
																																												if (this.type == 140)
																																												{
																																													if (this.life <= 0)
																																													{
																																														for (int num142 = 0; num142 < 20; num142++)
																																														{
																																															Vector2 arg_5245_0 = this.position;
																																															int arg_5245_1 = this.width;
																																															int arg_5245_2 = this.height;
																																															int arg_5245_3 = 54;
																																															float arg_5245_4 = 0f;
																																															float arg_5245_5 = 0f;
																																															int arg_5245_6 = 50;
																																															Color newColor = default(Color);
																																															int num143 = Dust.NewDust(arg_5245_0, arg_5245_1, arg_5245_2, arg_5245_3, arg_5245_4, arg_5245_5, arg_5245_6, newColor, 1.5f);
																																															Dust expr_5254 = Main.dust[num143];
																																															expr_5254.velocity *= 2f;
																																															Main.dust[num143].noGravity = true;
																																														}
																																														int num144 = Gore.NewGore(new Vector2(this.position.X, this.position.Y - 10f), new Vector2((float)hitDirection, 0f), 99, this.scale);
																																														Gore expr_52C7 = Main.gore[num144];
																																														expr_52C7.velocity *= 0.3f;
																																														num144 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)(this.height / 2) - 15f), new Vector2((float)hitDirection, 0f), 99, this.scale);
																																														Gore expr_532A = Main.gore[num144];
																																														expr_532A.velocity *= 0.3f;
																																														num144 = Gore.NewGore(new Vector2(this.position.X, this.position.Y + (float)this.height - 20f), new Vector2((float)hitDirection, 0f), 99, this.scale);
																																														Gore expr_538B = Main.gore[num144];
																																														expr_538B.velocity *= 0.3f;
																																														return;
																																													}
																																												}
																																												else
																																												{
																																													if (this.type == 39 || this.type == 40 || this.type == 41)
																																													{
																																														if (this.life > 0)
																																														{
																																															int num145 = 0;
																																															while ((double)num145 < dmg / (double)this.lifeMax * 50.0)
																																															{
																																																Vector2 arg_53FB_0 = this.position;
																																																int arg_53FB_1 = this.width;
																																																int arg_53FB_2 = this.height;
																																																int arg_53FB_3 = 26;
																																																float arg_53FB_4 = (float)hitDirection;
																																																float arg_53FB_5 = -1f;
																																																int arg_53FB_6 = 0;
																																																Color newColor = default(Color);
																																																Dust.NewDust(arg_53FB_0, arg_53FB_1, arg_53FB_2, arg_53FB_3, arg_53FB_4, arg_53FB_5, arg_53FB_6, newColor, 1f);
																																																num145++;
																																															}
																																															return;
																																														}
																																														for (int num146 = 0; num146 < 20; num146++)
																																														{
																																															Vector2 arg_5456_0 = this.position;
																																															int arg_5456_1 = this.width;
																																															int arg_5456_2 = this.height;
																																															int arg_5456_3 = 26;
																																															float arg_5456_4 = 2.5f * (float)hitDirection;
																																															float arg_5456_5 = -2.5f;
																																															int arg_5456_6 = 0;
																																															Color newColor = default(Color);
																																															Dust.NewDust(arg_5456_0, arg_5456_1, arg_5456_2, arg_5456_3, arg_5456_4, arg_5456_5, arg_5456_6, newColor, 1f);
																																														}
																																														Gore.NewGore(this.position, this.velocity, this.type - 39 + 67, 1f);
																																														return;
																																													}
																																													else
																																													{
																																														if (this.type == 34)
																																														{
																																															if (this.life > 0)
																																															{
																																																int num147 = 0;
																																																while ((double)num147 < dmg / (double)this.lifeMax * 30.0)
																																																{
																																																	Vector2 arg_550B_0 = new Vector2(this.position.X, this.position.Y);
																																																	int arg_550B_1 = this.width;
																																																	int arg_550B_2 = this.height;
																																																	int arg_550B_3 = 15;
																																																	float arg_550B_4 = -this.velocity.X * 0.2f;
																																																	float arg_550B_5 = -this.velocity.Y * 0.2f;
																																																	int arg_550B_6 = 100;
																																																	Color newColor = default(Color);
																																																	int num148 = Dust.NewDust(arg_550B_0, arg_550B_1, arg_550B_2, arg_550B_3, arg_550B_4, arg_550B_5, arg_550B_6, newColor, 1.8f);
																																																	Main.dust[num148].noLight = true;
																																																	Main.dust[num148].noGravity = true;
																																																	Dust expr_5536 = Main.dust[num148];
																																																	expr_5536.velocity *= 1.3f;
																																																	Vector2 arg_55A8_0 = new Vector2(this.position.X, this.position.Y);
																																																	int arg_55A8_1 = this.width;
																																																	int arg_55A8_2 = this.height;
																																																	int arg_55A8_3 = 26;
																																																	float arg_55A8_4 = -this.velocity.X * 0.2f;
																																																	float arg_55A8_5 = -this.velocity.Y * 0.2f;
																																																	int arg_55A8_6 = 0;
																																																	newColor = default(Color);
																																																	num148 = Dust.NewDust(arg_55A8_0, arg_55A8_1, arg_55A8_2, arg_55A8_3, arg_55A8_4, arg_55A8_5, arg_55A8_6, newColor, 0.9f);
																																																	Main.dust[num148].noLight = true;
																																																	Dust expr_55C5 = Main.dust[num148];
																																																	expr_55C5.velocity *= 1.3f;
																																																	num147++;
																																																}
																																																return;
																																															}
																																															for (int num149 = 0; num149 < 15; num149++)
																																															{
																																																Vector2 arg_5662_0 = new Vector2(this.position.X, this.position.Y);
																																																int arg_5662_1 = this.width;
																																																int arg_5662_2 = this.height;
																																																int arg_5662_3 = 15;
																																																float arg_5662_4 = -this.velocity.X * 0.2f;
																																																float arg_5662_5 = -this.velocity.Y * 0.2f;
																																																int arg_5662_6 = 100;
																																																Color newColor = default(Color);
																																																int num150 = Dust.NewDust(arg_5662_0, arg_5662_1, arg_5662_2, arg_5662_3, arg_5662_4, arg_5662_5, arg_5662_6, newColor, 1.8f);
																																																Main.dust[num150].noLight = true;
																																																Main.dust[num150].noGravity = true;
																																																Dust expr_568D = Main.dust[num150];
																																																expr_568D.velocity *= 1.3f;
																																																Vector2 arg_56FF_0 = new Vector2(this.position.X, this.position.Y);
																																																int arg_56FF_1 = this.width;
																																																int arg_56FF_2 = this.height;
																																																int arg_56FF_3 = 26;
																																																float arg_56FF_4 = -this.velocity.X * 0.2f;
																																																float arg_56FF_5 = -this.velocity.Y * 0.2f;
																																																int arg_56FF_6 = 0;
																																																newColor = default(Color);
																																																num150 = Dust.NewDust(arg_56FF_0, arg_56FF_1, arg_56FF_2, arg_56FF_3, arg_56FF_4, arg_56FF_5, arg_56FF_6, newColor, 0.9f);
																																																Main.dust[num150].noLight = true;
																																																Dust expr_571C = Main.dust[num150];
																																																expr_571C.velocity *= 1.3f;
																																															}
																																															return;
																																														}
																																														else
																																														{
																																															if (this.type == 35 || this.type == 36)
																																															{
																																																if (this.life > 0)
																																																{
																																																	int num151 = 0;
																																																	while ((double)num151 < dmg / (double)this.lifeMax * 100.0)
																																																	{
																																																		Vector2 arg_5791_0 = this.position;
																																																		int arg_5791_1 = this.width;
																																																		int arg_5791_2 = this.height;
																																																		int arg_5791_3 = 26;
																																																		float arg_5791_4 = (float)hitDirection;
																																																		float arg_5791_5 = -1f;
																																																		int arg_5791_6 = 0;
																																																		Color newColor = default(Color);
																																																		Dust.NewDust(arg_5791_0, arg_5791_1, arg_5791_2, arg_5791_3, arg_5791_4, arg_5791_5, arg_5791_6, newColor, 1f);
																																																		num151++;
																																																	}
																																																	return;
																																																}
																																																for (int num152 = 0; num152 < 150; num152++)
																																																{
																																																	Vector2 arg_57EC_0 = this.position;
																																																	int arg_57EC_1 = this.width;
																																																	int arg_57EC_2 = this.height;
																																																	int arg_57EC_3 = 26;
																																																	float arg_57EC_4 = 2.5f * (float)hitDirection;
																																																	float arg_57EC_5 = -2.5f;
																																																	int arg_57EC_6 = 0;
																																																	Color newColor = default(Color);
																																																	Dust.NewDust(arg_57EC_0, arg_57EC_1, arg_57EC_2, arg_57EC_3, arg_57EC_4, arg_57EC_5, arg_57EC_6, newColor, 1f);
																																																}
																																																if (this.type == 35)
																																																{
																																																	Gore.NewGore(this.position, this.velocity, 54, 1f);
																																																	Gore.NewGore(this.position, this.velocity, 55, 1f);
																																																	return;
																																																}
																																																Gore.NewGore(this.position, this.velocity, 56, 1f);
																																																Gore.NewGore(this.position, this.velocity, 57, 1f);
																																																Gore.NewGore(this.position, this.velocity, 57, 1f);
																																																Gore.NewGore(this.position, this.velocity, 57, 1f);
																																																return;
																																															}
																																															else
																																															{
																																																if (this.type == 139)
																																																{
																																																	if (this.life <= 0)
																																																	{
																																																		for (int num153 = 0; num153 < 10; num153++)
																																																		{
																																																			Vector2 arg_5908_0 = new Vector2(this.position.X, this.position.Y);
																																																			int arg_5908_1 = this.width;
																																																			int arg_5908_2 = this.height;
																																																			int arg_5908_3 = 31;
																																																			float arg_5908_4 = 0f;
																																																			float arg_5908_5 = 0f;
																																																			int arg_5908_6 = 100;
																																																			Color newColor = default(Color);
																																																			int num154 = Dust.NewDust(arg_5908_0, arg_5908_1, arg_5908_2, arg_5908_3, arg_5908_4, arg_5908_5, arg_5908_6, newColor, 1.5f);
																																																			Dust expr_5917 = Main.dust[num154];
																																																			expr_5917.velocity *= 1.4f;
																																																		}
																																																		for (int num155 = 0; num155 < 5; num155++)
																																																		{
																																																			Vector2 arg_5983_0 = new Vector2(this.position.X, this.position.Y);
																																																			int arg_5983_1 = this.width;
																																																			int arg_5983_2 = this.height;
																																																			int arg_5983_3 = 6;
																																																			float arg_5983_4 = 0f;
																																																			float arg_5983_5 = 0f;
																																																			int arg_5983_6 = 100;
																																																			Color newColor = default(Color);
																																																			int num156 = Dust.NewDust(arg_5983_0, arg_5983_1, arg_5983_2, arg_5983_3, arg_5983_4, arg_5983_5, arg_5983_6, newColor, 2.5f);
																																																			Main.dust[num156].noGravity = true;
																																																			Dust expr_59A0 = Main.dust[num156];
																																																			expr_59A0.velocity *= 5f;
																																																			Vector2 arg_59F8_0 = new Vector2(this.position.X, this.position.Y);
																																																			int arg_59F8_1 = this.width;
																																																			int arg_59F8_2 = this.height;
																																																			int arg_59F8_3 = 6;
																																																			float arg_59F8_4 = 0f;
																																																			float arg_59F8_5 = 0f;
																																																			int arg_59F8_6 = 100;
																																																			newColor = default(Color);
																																																			num156 = Dust.NewDust(arg_59F8_0, arg_59F8_1, arg_59F8_2, arg_59F8_3, arg_59F8_4, arg_59F8_5, arg_59F8_6, newColor, 1.5f);
																																																			Dust expr_5A07 = Main.dust[num156];
																																																			expr_5A07.velocity *= 3f;
																																																		}
																																																		Vector2 arg_5A62_0 = new Vector2(this.position.X, this.position.Y);
																																																		Vector2 vector = default(Vector2);
																																																		int num157 = Gore.NewGore(arg_5A62_0, vector, Main.rand.Next(61, 64), 1f);
																																																		Gore expr_5A71 = Main.gore[num157];
																																																		expr_5A71.velocity *= 0.4f;
																																																		Gore expr_5A93_cp_0 = Main.gore[num157];
																																																		expr_5A93_cp_0.velocity.X = expr_5A93_cp_0.velocity.X + 1f;
																																																		Gore expr_5AB1_cp_0 = Main.gore[num157];
																																																		expr_5AB1_cp_0.velocity.Y = expr_5AB1_cp_0.velocity.Y + 1f;
																																																		Vector2 arg_5AFA_0 = new Vector2(this.position.X, this.position.Y);
																																																		vector = default(Vector2);
																																																		num157 = Gore.NewGore(arg_5AFA_0, vector, Main.rand.Next(61, 64), 1f);
																																																		Gore expr_5B09 = Main.gore[num157];
																																																		expr_5B09.velocity *= 0.4f;
																																																		Gore expr_5B2B_cp_0 = Main.gore[num157];
																																																		expr_5B2B_cp_0.velocity.X = expr_5B2B_cp_0.velocity.X - 1f;
																																																		Gore expr_5B49_cp_0 = Main.gore[num157];
																																																		expr_5B49_cp_0.velocity.Y = expr_5B49_cp_0.velocity.Y + 1f;
																																																		Vector2 arg_5B92_0 = new Vector2(this.position.X, this.position.Y);
																																																		vector = default(Vector2);
																																																		num157 = Gore.NewGore(arg_5B92_0, vector, Main.rand.Next(61, 64), 1f);
																																																		Gore expr_5BA1 = Main.gore[num157];
																																																		expr_5BA1.velocity *= 0.4f;
																																																		Gore expr_5BC3_cp_0 = Main.gore[num157];
																																																		expr_5BC3_cp_0.velocity.X = expr_5BC3_cp_0.velocity.X + 1f;
																																																		Gore expr_5BE1_cp_0 = Main.gore[num157];
																																																		expr_5BE1_cp_0.velocity.Y = expr_5BE1_cp_0.velocity.Y - 1f;
																																																		Vector2 arg_5C2A_0 = new Vector2(this.position.X, this.position.Y);
																																																		vector = default(Vector2);
																																																		num157 = Gore.NewGore(arg_5C2A_0, vector, Main.rand.Next(61, 64), 1f);
																																																		Gore expr_5C39 = Main.gore[num157];
																																																		expr_5C39.velocity *= 0.4f;
																																																		Gore expr_5C5B_cp_0 = Main.gore[num157];
																																																		expr_5C5B_cp_0.velocity.X = expr_5C5B_cp_0.velocity.X - 1f;
																																																		Gore expr_5C79_cp_0 = Main.gore[num157];
																																																		expr_5C79_cp_0.velocity.Y = expr_5C79_cp_0.velocity.Y - 1f;
																																																		return;
																																																	}
																																																}
																																																else
																																																{
																																																	if (this.type >= 134 && this.type <= 136)
																																																	{
																																																		if (this.type == 135 && this.life > 0 && Main.netMode != 1 && this.ai[2] == 0f && Main.rand.Next(25) == 0)
																																																		{
																																																			this.ai[2] = 1f;
																																																			int num158 = NPC.NewNPC((int)(this.position.X + (float)(this.width / 2)), (int)(this.position.Y + (float)this.height), 139, 0);
																																																			if (Main.netMode == 2 && num158 < 200)
																																																			{
																																																				NetMessage.SendData(23, -1, -1, "", num158, 0f, 0f, 0f, 0);
																																																			}
																																																			this.netUpdate = true;
																																																		}
																																																		if (this.life <= 0)
																																																		{
																																																			Gore.NewGore(this.position, this.velocity, 156, 1f);
																																																			if (Main.rand.Next(2) == 0)
																																																			{
																																																				for (int num159 = 0; num159 < 10; num159++)
																																																				{
																																																					Vector2 arg_5DEF_0 = new Vector2(this.position.X, this.position.Y);
																																																					int arg_5DEF_1 = this.width;
																																																					int arg_5DEF_2 = this.height;
																																																					int arg_5DEF_3 = 31;
																																																					float arg_5DEF_4 = 0f;
																																																					float arg_5DEF_5 = 0f;
																																																					int arg_5DEF_6 = 100;
																																																					Color newColor = default(Color);
																																																					int num160 = Dust.NewDust(arg_5DEF_0, arg_5DEF_1, arg_5DEF_2, arg_5DEF_3, arg_5DEF_4, arg_5DEF_5, arg_5DEF_6, newColor, 1.5f);
																																																					Dust expr_5DFE = Main.dust[num160];
																																																					expr_5DFE.velocity *= 1.4f;
																																																				}
																																																				for (int num161 = 0; num161 < 5; num161++)
																																																				{
																																																					Vector2 arg_5E6A_0 = new Vector2(this.position.X, this.position.Y);
																																																					int arg_5E6A_1 = this.width;
																																																					int arg_5E6A_2 = this.height;
																																																					int arg_5E6A_3 = 6;
																																																					float arg_5E6A_4 = 0f;
																																																					float arg_5E6A_5 = 0f;
																																																					int arg_5E6A_6 = 100;
																																																					Color newColor = default(Color);
																																																					int num162 = Dust.NewDust(arg_5E6A_0, arg_5E6A_1, arg_5E6A_2, arg_5E6A_3, arg_5E6A_4, arg_5E6A_5, arg_5E6A_6, newColor, 2.5f);
																																																					Main.dust[num162].noGravity = true;
																																																					Dust expr_5E87 = Main.dust[num162];
																																																					expr_5E87.velocity *= 5f;
																																																					Vector2 arg_5EDF_0 = new Vector2(this.position.X, this.position.Y);
																																																					int arg_5EDF_1 = this.width;
																																																					int arg_5EDF_2 = this.height;
																																																					int arg_5EDF_3 = 6;
																																																					float arg_5EDF_4 = 0f;
																																																					float arg_5EDF_5 = 0f;
																																																					int arg_5EDF_6 = 100;
																																																					newColor = default(Color);
																																																					num162 = Dust.NewDust(arg_5EDF_0, arg_5EDF_1, arg_5EDF_2, arg_5EDF_3, arg_5EDF_4, arg_5EDF_5, arg_5EDF_6, newColor, 1.5f);
																																																					Dust expr_5EEE = Main.dust[num162];
																																																					expr_5EEE.velocity *= 3f;
																																																				}
																																																				Vector2 arg_5F49_0 = new Vector2(this.position.X, this.position.Y);
																																																				Vector2 vector = default(Vector2);
																																																				int num163 = Gore.NewGore(arg_5F49_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_5F58 = Main.gore[num163];
																																																				expr_5F58.velocity *= 0.4f;
																																																				Gore expr_5F7A_cp_0 = Main.gore[num163];
																																																				expr_5F7A_cp_0.velocity.X = expr_5F7A_cp_0.velocity.X + 1f;
																																																				Gore expr_5F98_cp_0 = Main.gore[num163];
																																																				expr_5F98_cp_0.velocity.Y = expr_5F98_cp_0.velocity.Y + 1f;
																																																				Vector2 arg_5FE1_0 = new Vector2(this.position.X, this.position.Y);
																																																				vector = default(Vector2);
																																																				num163 = Gore.NewGore(arg_5FE1_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_5FF0 = Main.gore[num163];
																																																				expr_5FF0.velocity *= 0.4f;
																																																				Gore expr_6012_cp_0 = Main.gore[num163];
																																																				expr_6012_cp_0.velocity.X = expr_6012_cp_0.velocity.X - 1f;
																																																				Gore expr_6030_cp_0 = Main.gore[num163];
																																																				expr_6030_cp_0.velocity.Y = expr_6030_cp_0.velocity.Y + 1f;
																																																				Vector2 arg_6079_0 = new Vector2(this.position.X, this.position.Y);
																																																				vector = default(Vector2);
																																																				num163 = Gore.NewGore(arg_6079_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_6088 = Main.gore[num163];
																																																				expr_6088.velocity *= 0.4f;
																																																				Gore expr_60AA_cp_0 = Main.gore[num163];
																																																				expr_60AA_cp_0.velocity.X = expr_60AA_cp_0.velocity.X + 1f;
																																																				Gore expr_60C8_cp_0 = Main.gore[num163];
																																																				expr_60C8_cp_0.velocity.Y = expr_60C8_cp_0.velocity.Y - 1f;
																																																				Vector2 arg_6111_0 = new Vector2(this.position.X, this.position.Y);
																																																				vector = default(Vector2);
																																																				num163 = Gore.NewGore(arg_6111_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_6120 = Main.gore[num163];
																																																				expr_6120.velocity *= 0.4f;
																																																				Gore expr_6142_cp_0 = Main.gore[num163];
																																																				expr_6142_cp_0.velocity.X = expr_6142_cp_0.velocity.X - 1f;
																																																				Gore expr_6160_cp_0 = Main.gore[num163];
																																																				expr_6160_cp_0.velocity.Y = expr_6160_cp_0.velocity.Y - 1f;
																																																				return;
																																																			}
																																																		}
																																																	}
																																																	else
																																																	{
																																																		if (this.type == 127)
																																																		{
																																																			if (this.life <= 0)
																																																			{
																																																				Gore.NewGore(this.position, this.velocity, 149, 1f);
																																																				Gore.NewGore(this.position, this.velocity, 150, 1f);
																																																				for (int num164 = 0; num164 < 10; num164++)
																																																				{
																																																					Vector2 arg_620C_0 = new Vector2(this.position.X, this.position.Y);
																																																					int arg_620C_1 = this.width;
																																																					int arg_620C_2 = this.height;
																																																					int arg_620C_3 = 31;
																																																					float arg_620C_4 = 0f;
																																																					float arg_620C_5 = 0f;
																																																					int arg_620C_6 = 100;
																																																					Color newColor = default(Color);
																																																					int num165 = Dust.NewDust(arg_620C_0, arg_620C_1, arg_620C_2, arg_620C_3, arg_620C_4, arg_620C_5, arg_620C_6, newColor, 1.5f);
																																																					Dust expr_621B = Main.dust[num165];
																																																					expr_621B.velocity *= 1.4f;
																																																				}
																																																				for (int num166 = 0; num166 < 5; num166++)
																																																				{
																																																					Vector2 arg_6287_0 = new Vector2(this.position.X, this.position.Y);
																																																					int arg_6287_1 = this.width;
																																																					int arg_6287_2 = this.height;
																																																					int arg_6287_3 = 6;
																																																					float arg_6287_4 = 0f;
																																																					float arg_6287_5 = 0f;
																																																					int arg_6287_6 = 100;
																																																					Color newColor = default(Color);
																																																					int num167 = Dust.NewDust(arg_6287_0, arg_6287_1, arg_6287_2, arg_6287_3, arg_6287_4, arg_6287_5, arg_6287_6, newColor, 2.5f);
																																																					Main.dust[num167].noGravity = true;
																																																					Dust expr_62A4 = Main.dust[num167];
																																																					expr_62A4.velocity *= 5f;
																																																					Vector2 arg_62FC_0 = new Vector2(this.position.X, this.position.Y);
																																																					int arg_62FC_1 = this.width;
																																																					int arg_62FC_2 = this.height;
																																																					int arg_62FC_3 = 6;
																																																					float arg_62FC_4 = 0f;
																																																					float arg_62FC_5 = 0f;
																																																					int arg_62FC_6 = 100;
																																																					newColor = default(Color);
																																																					num167 = Dust.NewDust(arg_62FC_0, arg_62FC_1, arg_62FC_2, arg_62FC_3, arg_62FC_4, arg_62FC_5, arg_62FC_6, newColor, 1.5f);
																																																					Dust expr_630B = Main.dust[num167];
																																																					expr_630B.velocity *= 3f;
																																																				}
																																																				Vector2 arg_6366_0 = new Vector2(this.position.X, this.position.Y);
																																																				Vector2 vector = default(Vector2);
																																																				int num168 = Gore.NewGore(arg_6366_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_6375 = Main.gore[num168];
																																																				expr_6375.velocity *= 0.4f;
																																																				Gore expr_6397_cp_0 = Main.gore[num168];
																																																				expr_6397_cp_0.velocity.X = expr_6397_cp_0.velocity.X + 1f;
																																																				Gore expr_63B5_cp_0 = Main.gore[num168];
																																																				expr_63B5_cp_0.velocity.Y = expr_63B5_cp_0.velocity.Y + 1f;
																																																				Vector2 arg_63FE_0 = new Vector2(this.position.X, this.position.Y);
																																																				vector = default(Vector2);
																																																				num168 = Gore.NewGore(arg_63FE_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_640D = Main.gore[num168];
																																																				expr_640D.velocity *= 0.4f;
																																																				Gore expr_642F_cp_0 = Main.gore[num168];
																																																				expr_642F_cp_0.velocity.X = expr_642F_cp_0.velocity.X - 1f;
																																																				Gore expr_644D_cp_0 = Main.gore[num168];
																																																				expr_644D_cp_0.velocity.Y = expr_644D_cp_0.velocity.Y + 1f;
																																																				Vector2 arg_6496_0 = new Vector2(this.position.X, this.position.Y);
																																																				vector = default(Vector2);
																																																				num168 = Gore.NewGore(arg_6496_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_64A5 = Main.gore[num168];
																																																				expr_64A5.velocity *= 0.4f;
																																																				Gore expr_64C7_cp_0 = Main.gore[num168];
																																																				expr_64C7_cp_0.velocity.X = expr_64C7_cp_0.velocity.X + 1f;
																																																				Gore expr_64E5_cp_0 = Main.gore[num168];
																																																				expr_64E5_cp_0.velocity.Y = expr_64E5_cp_0.velocity.Y - 1f;
																																																				Vector2 arg_652E_0 = new Vector2(this.position.X, this.position.Y);
																																																				vector = default(Vector2);
																																																				num168 = Gore.NewGore(arg_652E_0, vector, Main.rand.Next(61, 64), 1f);
																																																				Gore expr_653D = Main.gore[num168];
																																																				expr_653D.velocity *= 0.4f;
																																																				Gore expr_655F_cp_0 = Main.gore[num168];
																																																				expr_655F_cp_0.velocity.X = expr_655F_cp_0.velocity.X - 1f;
																																																				Gore expr_657D_cp_0 = Main.gore[num168];
																																																				expr_657D_cp_0.velocity.Y = expr_657D_cp_0.velocity.Y - 1f;
																																																				return;
																																																			}
																																																		}
																																																		else
																																																		{
																																																			if (this.type >= 128 && this.type <= 131)
																																																			{
																																																				if (this.life <= 0)
																																																				{
																																																					Gore.NewGore(this.position, this.velocity, 147, 1f);
																																																					Gore.NewGore(this.position, this.velocity, 148, 1f);
																																																					for (int num169 = 0; num169 < 10; num169++)
																																																					{
																																																						Vector2 arg_663C_0 = new Vector2(this.position.X, this.position.Y);
																																																						int arg_663C_1 = this.width;
																																																						int arg_663C_2 = this.height;
																																																						int arg_663C_3 = 31;
																																																						float arg_663C_4 = 0f;
																																																						float arg_663C_5 = 0f;
																																																						int arg_663C_6 = 100;
																																																						Color newColor = default(Color);
																																																						int num170 = Dust.NewDust(arg_663C_0, arg_663C_1, arg_663C_2, arg_663C_3, arg_663C_4, arg_663C_5, arg_663C_6, newColor, 1.5f);
																																																						Dust expr_664B = Main.dust[num170];
																																																						expr_664B.velocity *= 1.4f;
																																																					}
																																																					for (int num171 = 0; num171 < 5; num171++)
																																																					{
																																																						Vector2 arg_66B7_0 = new Vector2(this.position.X, this.position.Y);
																																																						int arg_66B7_1 = this.width;
																																																						int arg_66B7_2 = this.height;
																																																						int arg_66B7_3 = 6;
																																																						float arg_66B7_4 = 0f;
																																																						float arg_66B7_5 = 0f;
																																																						int arg_66B7_6 = 100;
																																																						Color newColor = default(Color);
																																																						int num172 = Dust.NewDust(arg_66B7_0, arg_66B7_1, arg_66B7_2, arg_66B7_3, arg_66B7_4, arg_66B7_5, arg_66B7_6, newColor, 2.5f);
																																																						Main.dust[num172].noGravity = true;
																																																						Dust expr_66D4 = Main.dust[num172];
																																																						expr_66D4.velocity *= 5f;
																																																						Vector2 arg_672C_0 = new Vector2(this.position.X, this.position.Y);
																																																						int arg_672C_1 = this.width;
																																																						int arg_672C_2 = this.height;
																																																						int arg_672C_3 = 6;
																																																						float arg_672C_4 = 0f;
																																																						float arg_672C_5 = 0f;
																																																						int arg_672C_6 = 100;
																																																						newColor = default(Color);
																																																						num172 = Dust.NewDust(arg_672C_0, arg_672C_1, arg_672C_2, arg_672C_3, arg_672C_4, arg_672C_5, arg_672C_6, newColor, 1.5f);
																																																						Dust expr_673B = Main.dust[num172];
																																																						expr_673B.velocity *= 3f;
																																																					}
																																																					Vector2 arg_6796_0 = new Vector2(this.position.X, this.position.Y);
																																																					Vector2 vector = default(Vector2);
																																																					int num173 = Gore.NewGore(arg_6796_0, vector, Main.rand.Next(61, 64), 1f);
																																																					Gore expr_67A5 = Main.gore[num173];
																																																					expr_67A5.velocity *= 0.4f;
																																																					Gore expr_67C7_cp_0 = Main.gore[num173];
																																																					expr_67C7_cp_0.velocity.X = expr_67C7_cp_0.velocity.X + 1f;
																																																					Gore expr_67E5_cp_0 = Main.gore[num173];
																																																					expr_67E5_cp_0.velocity.Y = expr_67E5_cp_0.velocity.Y + 1f;
																																																					Vector2 arg_682E_0 = new Vector2(this.position.X, this.position.Y);
																																																					vector = default(Vector2);
																																																					num173 = Gore.NewGore(arg_682E_0, vector, Main.rand.Next(61, 64), 1f);
																																																					Gore expr_683D = Main.gore[num173];
																																																					expr_683D.velocity *= 0.4f;
																																																					Gore expr_685F_cp_0 = Main.gore[num173];
																																																					expr_685F_cp_0.velocity.X = expr_685F_cp_0.velocity.X - 1f;
																																																					Gore expr_687D_cp_0 = Main.gore[num173];
																																																					expr_687D_cp_0.velocity.Y = expr_687D_cp_0.velocity.Y + 1f;
																																																					Vector2 arg_68C6_0 = new Vector2(this.position.X, this.position.Y);
																																																					vector = default(Vector2);
																																																					num173 = Gore.NewGore(arg_68C6_0, vector, Main.rand.Next(61, 64), 1f);
																																																					Gore expr_68D5 = Main.gore[num173];
																																																					expr_68D5.velocity *= 0.4f;
																																																					Gore expr_68F7_cp_0 = Main.gore[num173];
																																																					expr_68F7_cp_0.velocity.X = expr_68F7_cp_0.velocity.X + 1f;
																																																					Gore expr_6915_cp_0 = Main.gore[num173];
																																																					expr_6915_cp_0.velocity.Y = expr_6915_cp_0.velocity.Y - 1f;
																																																					Vector2 arg_695E_0 = new Vector2(this.position.X, this.position.Y);
																																																					vector = default(Vector2);
																																																					num173 = Gore.NewGore(arg_695E_0, vector, Main.rand.Next(61, 64), 1f);
																																																					Gore expr_696D = Main.gore[num173];
																																																					expr_696D.velocity *= 0.4f;
																																																					Gore expr_698F_cp_0 = Main.gore[num173];
																																																					expr_698F_cp_0.velocity.X = expr_698F_cp_0.velocity.X - 1f;
																																																					Gore expr_69AD_cp_0 = Main.gore[num173];
																																																					expr_69AD_cp_0.velocity.Y = expr_69AD_cp_0.velocity.Y - 1f;
																																																					return;
																																																				}
																																																			}
																																																			else
																																																			{
																																																				if (this.type == 23)
																																																				{
																																																					if (this.life > 0)
																																																					{
																																																						int num174 = 0;
																																																						while ((double)num174 < dmg / (double)this.lifeMax * 100.0)
																																																						{
																																																							int num175 = 25;
																																																							if (Main.rand.Next(2) == 0)
																																																							{
																																																								num175 = 6;
																																																							}
																																																							Vector2 arg_6A1F_0 = this.position;
																																																							int arg_6A1F_1 = this.width;
																																																							int arg_6A1F_2 = this.height;
																																																							int arg_6A1F_3 = num175;
																																																							float arg_6A1F_4 = (float)hitDirection;
																																																							float arg_6A1F_5 = -1f;
																																																							int arg_6A1F_6 = 0;
																																																							Color newColor = default(Color);
																																																							Dust.NewDust(arg_6A1F_0, arg_6A1F_1, arg_6A1F_2, arg_6A1F_3, arg_6A1F_4, arg_6A1F_5, arg_6A1F_6, newColor, 1f);
																																																							Vector2 arg_6A80_0 = new Vector2(this.position.X, this.position.Y);
																																																							int arg_6A80_1 = this.width;
																																																							int arg_6A80_2 = this.height;
																																																							int arg_6A80_3 = 6;
																																																							float arg_6A80_4 = this.velocity.X * 0.2f;
																																																							float arg_6A80_5 = this.velocity.Y * 0.2f;
																																																							int arg_6A80_6 = 100;
																																																							newColor = default(Color);
																																																							int num176 = Dust.NewDust(arg_6A80_0, arg_6A80_1, arg_6A80_2, arg_6A80_3, arg_6A80_4, arg_6A80_5, arg_6A80_6, newColor, 2f);
																																																							Main.dust[num176].noGravity = true;
																																																							num174++;
																																																						}
																																																						return;
																																																					}
																																																					for (int num177 = 0; num177 < 50; num177++)
																																																					{
																																																						int num178 = 25;
																																																						if (Main.rand.Next(2) == 0)
																																																						{
																																																							num178 = 6;
																																																						}
																																																						Vector2 arg_6AFD_0 = this.position;
																																																						int arg_6AFD_1 = this.width;
																																																						int arg_6AFD_2 = this.height;
																																																						int arg_6AFD_3 = num178;
																																																						float arg_6AFD_4 = (float)(2 * hitDirection);
																																																						float arg_6AFD_5 = -2f;
																																																						int arg_6AFD_6 = 0;
																																																						Color newColor = default(Color);
																																																						Dust.NewDust(arg_6AFD_0, arg_6AFD_1, arg_6AFD_2, arg_6AFD_3, arg_6AFD_4, arg_6AFD_5, arg_6AFD_6, newColor, 1f);
																																																					}
																																																					for (int num179 = 0; num179 < 50; num179++)
																																																					{
																																																						Vector2 arg_6B72_0 = new Vector2(this.position.X, this.position.Y);
																																																						int arg_6B72_1 = this.width;
																																																						int arg_6B72_2 = this.height;
																																																						int arg_6B72_3 = 6;
																																																						float arg_6B72_4 = this.velocity.X * 0.2f;
																																																						float arg_6B72_5 = this.velocity.Y * 0.2f;
																																																						int arg_6B72_6 = 100;
																																																						Color newColor = default(Color);
																																																						int num180 = Dust.NewDust(arg_6B72_0, arg_6B72_1, arg_6B72_2, arg_6B72_3, arg_6B72_4, arg_6B72_5, arg_6B72_6, newColor, 2.5f);
																																																						Dust expr_6B81 = Main.dust[num180];
																																																						expr_6B81.velocity *= 6f;
																																																						Main.dust[num180].noGravity = true;
																																																					}
																																																					return;
																																																				}
																																																				else
																																																				{
																																																					if (this.type == 24)
																																																					{
																																																						if (this.life > 0)
																																																						{
																																																							int num181 = 0;
																																																							while ((double)num181 < dmg / (double)this.lifeMax * 100.0)
																																																							{
																																																								Vector2 arg_6C21_0 = new Vector2(this.position.X, this.position.Y);
																																																								int arg_6C21_1 = this.width;
																																																								int arg_6C21_2 = this.height;
																																																								int arg_6C21_3 = 6;
																																																								float arg_6C21_4 = this.velocity.X;
																																																								float arg_6C21_5 = this.velocity.Y;
																																																								int arg_6C21_6 = 100;
																																																								Color newColor = default(Color);
																																																								int num182 = Dust.NewDust(arg_6C21_0, arg_6C21_1, arg_6C21_2, arg_6C21_3, arg_6C21_4, arg_6C21_5, arg_6C21_6, newColor, 2.5f);
																																																								Main.dust[num182].noGravity = true;
																																																								num181++;
																																																							}
																																																							return;
																																																						}
																																																						for (int num183 = 0; num183 < 50; num183++)
																																																						{
																																																							Vector2 arg_6CAF_0 = new Vector2(this.position.X, this.position.Y);
																																																							int arg_6CAF_1 = this.width;
																																																							int arg_6CAF_2 = this.height;
																																																							int arg_6CAF_3 = 6;
																																																							float arg_6CAF_4 = this.velocity.X;
																																																							float arg_6CAF_5 = this.velocity.Y;
																																																							int arg_6CAF_6 = 100;
																																																							Color newColor = default(Color);
																																																							int num184 = Dust.NewDust(arg_6CAF_0, arg_6CAF_1, arg_6CAF_2, arg_6CAF_3, arg_6CAF_4, arg_6CAF_5, arg_6CAF_6, newColor, 2.5f);
																																																							Main.dust[num184].noGravity = true;
																																																							Dust expr_6CCC = Main.dust[num184];
																																																							expr_6CCC.velocity *= 2f;
																																																						}
																																																						Gore.NewGore(this.position, this.velocity, 45, 1f);
																																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 46, 1f);
																																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 46, 1f);
																																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 47, 1f);
																																																						Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 47, 1f);
																																																						return;
																																																					}
																																																					else
																																																					{
																																																						if (this.type == 25)
																																																						{
																																																							Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 10);
																																																							for (int num185 = 0; num185 < 20; num185++)
																																																							{
																																																								Vector2 arg_6E6C_0 = new Vector2(this.position.X, this.position.Y);
																																																								int arg_6E6C_1 = this.width;
																																																								int arg_6E6C_2 = this.height;
																																																								int arg_6E6C_3 = 6;
																																																								float arg_6E6C_4 = -this.velocity.X * 0.2f;
																																																								float arg_6E6C_5 = -this.velocity.Y * 0.2f;
																																																								int arg_6E6C_6 = 100;
																																																								Color newColor = default(Color);
																																																								int num186 = Dust.NewDust(arg_6E6C_0, arg_6E6C_1, arg_6E6C_2, arg_6E6C_3, arg_6E6C_4, arg_6E6C_5, arg_6E6C_6, newColor, 2f);
																																																								Main.dust[num186].noGravity = true;
																																																								Dust expr_6E89 = Main.dust[num186];
																																																								expr_6E89.velocity *= 2f;
																																																								Vector2 arg_6EFB_0 = new Vector2(this.position.X, this.position.Y);
																																																								int arg_6EFB_1 = this.width;
																																																								int arg_6EFB_2 = this.height;
																																																								int arg_6EFB_3 = 6;
																																																								float arg_6EFB_4 = -this.velocity.X * 0.2f;
																																																								float arg_6EFB_5 = -this.velocity.Y * 0.2f;
																																																								int arg_6EFB_6 = 100;
																																																								newColor = default(Color);
																																																								num186 = Dust.NewDust(arg_6EFB_0, arg_6EFB_1, arg_6EFB_2, arg_6EFB_3, arg_6EFB_4, arg_6EFB_5, arg_6EFB_6, newColor, 1f);
																																																								Dust expr_6F0A = Main.dust[num186];
																																																								expr_6F0A.velocity *= 2f;
																																																							}
																																																							return;
																																																						}
																																																						if (this.type == 33)
																																																						{
																																																							Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 10);
																																																							for (int num187 = 0; num187 < 20; num187++)
																																																							{
																																																								Vector2 arg_6FC2_0 = new Vector2(this.position.X, this.position.Y);
																																																								int arg_6FC2_1 = this.width;
																																																								int arg_6FC2_2 = this.height;
																																																								int arg_6FC2_3 = 29;
																																																								float arg_6FC2_4 = -this.velocity.X * 0.2f;
																																																								float arg_6FC2_5 = -this.velocity.Y * 0.2f;
																																																								int arg_6FC2_6 = 100;
																																																								Color newColor = default(Color);
																																																								int num188 = Dust.NewDust(arg_6FC2_0, arg_6FC2_1, arg_6FC2_2, arg_6FC2_3, arg_6FC2_4, arg_6FC2_5, arg_6FC2_6, newColor, 2f);
																																																								Main.dust[num188].noGravity = true;
																																																								Dust expr_6FDF = Main.dust[num188];
																																																								expr_6FDF.velocity *= 2f;
																																																								Vector2 arg_7052_0 = new Vector2(this.position.X, this.position.Y);
																																																								int arg_7052_1 = this.width;
																																																								int arg_7052_2 = this.height;
																																																								int arg_7052_3 = 29;
																																																								float arg_7052_4 = -this.velocity.X * 0.2f;
																																																								float arg_7052_5 = -this.velocity.Y * 0.2f;
																																																								int arg_7052_6 = 100;
																																																								newColor = default(Color);
																																																								num188 = Dust.NewDust(arg_7052_0, arg_7052_1, arg_7052_2, arg_7052_3, arg_7052_4, arg_7052_5, arg_7052_6, newColor, 1f);
																																																								Dust expr_7061 = Main.dust[num188];
																																																								expr_7061.velocity *= 2f;
																																																							}
																																																							return;
																																																						}
																																																						if (this.type == 26 || this.type == 27 || this.type == 28 || this.type == 29 || this.type == 73 || this.type == 111)
																																																						{
																																																							if (this.life > 0)
																																																							{
																																																								int num189 = 0;
																																																								while ((double)num189 < dmg / (double)this.lifeMax * 100.0)
																																																								{
																																																									Vector2 arg_70FD_0 = this.position;
																																																									int arg_70FD_1 = this.width;
																																																									int arg_70FD_2 = this.height;
																																																									int arg_70FD_3 = 5;
																																																									float arg_70FD_4 = (float)hitDirection;
																																																									float arg_70FD_5 = -1f;
																																																									int arg_70FD_6 = 0;
																																																									Color newColor = default(Color);
																																																									Dust.NewDust(arg_70FD_0, arg_70FD_1, arg_70FD_2, arg_70FD_3, arg_70FD_4, arg_70FD_5, arg_70FD_6, newColor, 1f);
																																																									num189++;
																																																								}
																																																								return;
																																																							}
																																																							for (int num190 = 0; num190 < 50; num190++)
																																																							{
																																																								Vector2 arg_7157_0 = this.position;
																																																								int arg_7157_1 = this.width;
																																																								int arg_7157_2 = this.height;
																																																								int arg_7157_3 = 5;
																																																								float arg_7157_4 = 2.5f * (float)hitDirection;
																																																								float arg_7157_5 = -2.5f;
																																																								int arg_7157_6 = 0;
																																																								Color newColor = default(Color);
																																																								Dust.NewDust(arg_7157_0, arg_7157_1, arg_7157_2, arg_7157_3, arg_7157_4, arg_7157_5, arg_7157_6, newColor, 1f);
																																																							}
																																																							Gore.NewGore(this.position, this.velocity, 48, this.scale);
																																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 49, this.scale);
																																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 20f), this.velocity, 49, this.scale);
																																																							if (this.type == 111)
																																																							{
																																																								Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 131, this.scale);
																																																							}
																																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 50, this.scale);
																																																							Gore.NewGore(new Vector2(this.position.X, this.position.Y + 34f), this.velocity, 50, this.scale);
																																																							return;
																																																						}
																																																						else
																																																						{
																																																							if (this.type == 30)
																																																							{
																																																								Main.PlaySound(2, (int)this.position.X, (int)this.position.Y, 10);
																																																								for (int num191 = 0; num191 < 20; num191++)
																																																								{
																																																									Vector2 arg_732D_0 = new Vector2(this.position.X, this.position.Y);
																																																									int arg_732D_1 = this.width;
																																																									int arg_732D_2 = this.height;
																																																									int arg_732D_3 = 27;
																																																									float arg_732D_4 = -this.velocity.X * 0.2f;
																																																									float arg_732D_5 = -this.velocity.Y * 0.2f;
																																																									int arg_732D_6 = 100;
																																																									Color newColor = default(Color);
																																																									int num192 = Dust.NewDust(arg_732D_0, arg_732D_1, arg_732D_2, arg_732D_3, arg_732D_4, arg_732D_5, arg_732D_6, newColor, 2f);
																																																									Main.dust[num192].noGravity = true;
																																																									Dust expr_734A = Main.dust[num192];
																																																									expr_734A.velocity *= 2f;
																																																									Vector2 arg_73BD_0 = new Vector2(this.position.X, this.position.Y);
																																																									int arg_73BD_1 = this.width;
																																																									int arg_73BD_2 = this.height;
																																																									int arg_73BD_3 = 27;
																																																									float arg_73BD_4 = -this.velocity.X * 0.2f;
																																																									float arg_73BD_5 = -this.velocity.Y * 0.2f;
																																																									int arg_73BD_6 = 100;
																																																									newColor = default(Color);
																																																									num192 = Dust.NewDust(arg_73BD_0, arg_73BD_1, arg_73BD_2, arg_73BD_3, arg_73BD_4, arg_73BD_5, arg_73BD_6, newColor, 1f);
																																																									Dust expr_73CC = Main.dust[num192];
																																																									expr_73CC.velocity *= 2f;
																																																								}
																																																								return;
																																																							}
																																																							if (this.type == 42)
																																																							{
																																																								if (this.life > 0)
																																																								{
																																																									int num193 = 0;
																																																									while ((double)num193 < dmg / (double)this.lifeMax * 100.0)
																																																									{
																																																										Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -1f, this.alpha, this.color, this.scale);
																																																										num193++;
																																																									}
																																																									return;
																																																								}
																																																								for (int num194 = 0; num194 < 50; num194++)
																																																								{
																																																									Dust.NewDust(this.position, this.width, this.height, 18, (float)hitDirection, -2f, this.alpha, this.color, this.scale);
																																																								}
																																																								Gore.NewGore(this.position, this.velocity, 70, this.scale);
																																																								Gore.NewGore(this.position, this.velocity, 71, this.scale);
																																																								return;
																																																							}
																																																							else
																																																							{
																																																								if (this.type == 43 || this.type == 56)
																																																								{
																																																									if (this.life > 0)
																																																									{
																																																										int num195 = 0;
																																																										while ((double)num195 < dmg / (double)this.lifeMax * 100.0)
																																																										{
																																																											Dust.NewDust(this.position, this.width, this.height, 40, (float)hitDirection, -1f, this.alpha, this.color, 1.2f);
																																																											num195++;
																																																										}
																																																										return;
																																																									}
																																																									for (int num196 = 0; num196 < 50; num196++)
																																																									{
																																																										Dust.NewDust(this.position, this.width, this.height, 40, (float)hitDirection, -2f, this.alpha, this.color, 1.2f);
																																																									}
																																																									Gore.NewGore(this.position, this.velocity, 72, 1f);
																																																									Gore.NewGore(this.position, this.velocity, 72, 1f);
																																																									return;
																																																								}
																																																								else
																																																								{
																																																									if (this.type == 48)
																																																									{
																																																										if (this.life > 0)
																																																										{
																																																											int num197 = 0;
																																																											while ((double)num197 < dmg / (double)this.lifeMax * 100.0)
																																																											{
																																																												Vector2 arg_7608_0 = this.position;
																																																												int arg_7608_1 = this.width;
																																																												int arg_7608_2 = this.height;
																																																												int arg_7608_3 = 5;
																																																												float arg_7608_4 = (float)hitDirection;
																																																												float arg_7608_5 = -1f;
																																																												int arg_7608_6 = 0;
																																																												Color newColor = default(Color);
																																																												Dust.NewDust(arg_7608_0, arg_7608_1, arg_7608_2, arg_7608_3, arg_7608_4, arg_7608_5, arg_7608_6, newColor, 1f);
																																																												num197++;
																																																											}
																																																											return;
																																																										}
																																																										for (int num198 = 0; num198 < 50; num198++)
																																																										{
																																																											Vector2 arg_765E_0 = this.position;
																																																											int arg_765E_1 = this.width;
																																																											int arg_765E_2 = this.height;
																																																											int arg_765E_3 = 5;
																																																											float arg_765E_4 = (float)(2 * hitDirection);
																																																											float arg_765E_5 = -2f;
																																																											int arg_765E_6 = 0;
																																																											Color newColor = default(Color);
																																																											Dust.NewDust(arg_765E_0, arg_765E_1, arg_765E_2, arg_765E_3, arg_765E_4, arg_765E_5, arg_765E_6, newColor, 1f);
																																																										}
																																																										Gore.NewGore(this.position, this.velocity, 80, 1f);
																																																										Gore.NewGore(this.position, this.velocity, 81, 1f);
																																																										return;
																																																									}
																																																									else
																																																									{
																																																										if (this.type == 62 || this.type == 66)
																																																										{
																																																											if (this.life > 0)
																																																											{
																																																												int num199 = 0;
																																																												while ((double)num199 < dmg / (double)this.lifeMax * 100.0)
																																																												{
																																																													Vector2 arg_76F2_0 = this.position;
																																																													int arg_76F2_1 = this.width;
																																																													int arg_76F2_2 = this.height;
																																																													int arg_76F2_3 = 5;
																																																													float arg_76F2_4 = (float)hitDirection;
																																																													float arg_76F2_5 = -1f;
																																																													int arg_76F2_6 = 0;
																																																													Color newColor = default(Color);
																																																													Dust.NewDust(arg_76F2_0, arg_76F2_1, arg_76F2_2, arg_76F2_3, arg_76F2_4, arg_76F2_5, arg_76F2_6, newColor, 1f);
																																																													num199++;
																																																												}
																																																												return;
																																																											}
																																																											for (int num200 = 0; num200 < 50; num200++)
																																																											{
																																																												Vector2 arg_7748_0 = this.position;
																																																												int arg_7748_1 = this.width;
																																																												int arg_7748_2 = this.height;
																																																												int arg_7748_3 = 5;
																																																												float arg_7748_4 = (float)(2 * hitDirection);
																																																												float arg_7748_5 = -2f;
																																																												int arg_7748_6 = 0;
																																																												Color newColor = default(Color);
																																																												Dust.NewDust(arg_7748_0, arg_7748_1, arg_7748_2, arg_7748_3, arg_7748_4, arg_7748_5, arg_7748_6, newColor, 1f);
																																																											}
																																																											Gore.NewGore(this.position, this.velocity, 93, 1f);
																																																											Gore.NewGore(this.position, this.velocity, 94, 1f);
																																																											Gore.NewGore(this.position, this.velocity, 94, 1f);
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					return;
				}
				if (this.life > 0)
				{
					int num201 = 0;
					while ((double)num201 < dmg / (double)this.lifeMax * 80.0)
					{
						Vector2 arg_C32_0 = this.position;
						int arg_C32_1 = this.width;
						int arg_C32_2 = this.height;
						int arg_C32_3 = 6;
						float arg_C32_4 = (float)(hitDirection * 2);
						float arg_C32_5 = -1f;
						int arg_C32_6 = this.alpha;
						Color newColor = default(Color);
						Dust.NewDust(arg_C32_0, arg_C32_1, arg_C32_2, arg_C32_3, arg_C32_4, arg_C32_5, arg_C32_6, newColor, 1.5f);
						num201++;
					}
					return;
				}
				for (int num202 = 0; num202 < 40; num202++)
				{
					Vector2 arg_C8D_0 = this.position;
					int arg_C8D_1 = this.width;
					int arg_C8D_2 = this.height;
					int arg_C8D_3 = 6;
					float arg_C8D_4 = (float)(hitDirection * 2);
					float arg_C8D_5 = -1f;
					int arg_C8D_6 = this.alpha;
					Color newColor = default(Color);
					Dust.NewDust(arg_C8D_0, arg_C8D_1, arg_C8D_2, arg_C8D_3, arg_C8D_4, arg_C8D_5, arg_C8D_6, newColor, 1.5f);
				}
				return;
			}
		}
		public static bool AnyNPCs(int Type)
		{
			for (int i = 0; i < 200; i++)
			{
				if (Main.npc[i].active && Main.npc[i].type == Type)
				{
					return true;
				}
			}
			return false;
		}
        public static void SpawnSkeletron()
        {
            bool flag1 = true;
            bool flag2 = false;
            Vector2 vector2 = new Vector2();
            int num1 = 0;
            int num2 = 0;
            for (int index = 0; index < 200; ++index)
            {
                if (Main.npc[index].active && Main.npc[index].type == 35)
                {
                    flag1 = false;
                    break;
                }
            }
            for (int number = 0; number < 200; ++number)
            {
                if (Main.npc[number].active && Main.npc[number].type == 37)
                {
                    flag2 = true;
                    Main.npc[number].ai[3] = 1f;
                    vector2 = Main.npc[number].position;
                    num1 = Main.npc[number].width;
                    num2 = Main.npc[number].height;
                    if (Main.netMode == 2)
                        NetMessage.SendData(23, -1, -1, "", number, 0.0f, 0.0f, 0.0f, 0);
                }
            }
            if (!flag1 || !flag2)
                return;
            int index1 = NPC.NewNPC((int)vector2.X + num1 / 2, (int)vector2.Y + num2 / 2, 35, 0);
            Main.npc[index1].netUpdate = true;
            string str = "Skeletron";
            if (Main.netMode == 0)
            {
                Main.NewText(str + " " + Lang.misc[16], (byte)175, (byte)75, byte.MaxValue);
            }
            else
            {
                if (Main.netMode != 2)
                    return;
                NetMessage.SendData(25, -1, -1, str + " " + Lang.misc[16], (int)byte.MaxValue, 175f, 75f, (float)byte.MaxValue, 0);
            }
        }
		public static bool NearSpikeBall(int x, int y)
		{
			Rectangle rectangle = new Rectangle(x * 16 - 300, y * 16 - 300, 600, 600);
			for (int i = 0; i < 200; i++)
			{
				if (Main.npc[i].active && Main.npc[i].aiStyle == 20)
				{
					Rectangle rectangle2 = new Rectangle((int)Main.npc[i].ai[1], (int)Main.npc[i].ai[2], 20, 20);
					if (rectangle.Intersects(rectangle2))
					{
						return true;
					}
				}
			}
			return false;
		}
        public void AddBuff(int type, int time, bool quiet = false)
        {
            if (this.buffImmune[type])
                return;
            if (!quiet)
            {
                if (Main.netMode == 1)
                    NetMessage.SendData(53, -1, -1, "", this.whoAmI, (float)type, (float)time, 0.0f, 0);
                else if (Main.netMode == 2)
                    NetMessage.SendData(54, -1, -1, "", this.whoAmI, 0.0f, 0.0f, 0.0f, 0);
            }
            int index1 = -1;
            for (int index2 = 0; index2 < 5; ++index2)
            {
                if (this.buffType[index2] == type)
                {
                    if (this.buffTime[index2] >= time)
                        return;
                    this.buffTime[index2] = time;
                    return;
                }
            }
            while (index1 == -1)
            {
                int b = -1;
                for (int index2 = 0; index2 < 5; ++index2)
                {
                    if (!Main.debuff[this.buffType[index2]])
                    {
                        b = index2;
                        break;
                    }
                }
                if (b == -1)
                    return;
                for (int index2 = b; index2 < 5; ++index2)
                {
                    if (this.buffType[index2] == 0)
                    {
                        index1 = index2;
                        break;
                    }
                }
                if (index1 == -1)
                    this.DelBuff(b);
            }
            this.buffType[index1] = type;
            this.buffTime[index1] = time;
        }
        public void DelBuff(int b)
        {
            this.buffTime[b] = 0;
            this.buffType[b] = 0;
            for (int index1 = 0; index1 < 4; ++index1)
            {
                if (this.buffTime[index1] == 0 || this.buffType[index1] == 0)
                {
                    for (int index2 = index1 + 1; index2 < 5; ++index2)
                    {
                        this.buffTime[index2 - 1] = this.buffTime[index2];
                        this.buffType[index2 - 1] = this.buffType[index2];
                        this.buffTime[index2] = 0;
                        this.buffType[index2] = 0;
                    }
                }
            }
            if (Main.netMode != 2)
                return;
            NetMessage.SendData(54, -1, -1, "", this.whoAmI, 0.0f, 0.0f, 0.0f, 0);
        }
        public void UpdateNPC(int i)
        {
            this.whoAmI = i;
            if (!this.active)
                return;
            if (this.displayName == "")
                this.displayName = this.name;
            if (this.townNPC && Main.chrName[this.type] != "")
                this.displayName = Main.chrName[this.type];
            this.lifeRegen = 0;
            this.poisoned = false;
            this.onFire = false;
            this.onFire2 = false;
            this.confused = false;
            for (int index = 0; index < 5; ++index)
            {
                if (this.buffType[index] > 0 && this.buffTime[index] > 0)
                {
                    --this.buffTime[index];
                    if (this.buffType[index] == 20)
                        this.poisoned = true;
                    else if (this.buffType[index] == 24)
                        this.onFire = true;
                    else if (this.buffType[index] == 31)
                        this.confused = true;
                    else if (this.buffType[index] == 39)
                        this.onFire2 = true;
                }
            }
            if (Main.netMode != 1)
            {
                for (int b = 0; b < 5; ++b)
                {
                    if (this.buffType[b] > 0 && this.buffTime[b] <= 0)
                    {
                        this.DelBuff(b);
                        if (Main.netMode == 2)
                            NetMessage.SendData(54, -1, -1, "", this.whoAmI, 0.0f, 0.0f, 0.0f, 0);
                    }
                }
            }
            if (!this.dontTakeDamage)
            {
                if (this.poisoned)
                    this.lifeRegen = -4;
                if (this.onFire)
                    this.lifeRegen = -8;
                if (this.onFire2)
                    this.lifeRegen = -12;
                this.lifeRegenCount += this.lifeRegen;
                while (this.lifeRegenCount >= 120)
                {
                    this.lifeRegenCount -= 120;
                    if (this.life < this.lifeMax)
                        ++this.life;
                    if (this.life > this.lifeMax)
                        this.life = this.lifeMax;
                }
                while (this.lifeRegenCount <= -120)
                {
                    this.lifeRegenCount += 120;
                    int number = this.whoAmI;
                    if (this.realLife >= 0)
                        number = this.realLife;
                    --Main.npc[number].life;
                    if (Main.npc[number].life <= 0)
                    {
                        Main.npc[number].life = 1;
                        if (Main.netMode != 1)
                        {
                            Main.npc[number].StrikeNPC(9999, 0.0f, 0, false, false);
                            if (Main.netMode == 2)
                                NetMessage.SendData(28, -1, -1, "", number, 9999f, 0.0f, 0.0f, 0);
                        }
                    }
                }
            }
            if (Main.netMode != 1 && Main.bloodMoon)
            {
                if (this.type == 46)
                    this.Transform(47);
                else if (this.type == 55)
                    this.Transform(57);
            }
            float num1 = 10f;
            float num2 = 0.3f;
            float num3 = (float)(Main.maxTilesX / 4200);
            float num4 = (float)(((double)this.position.Y / 16.0 - (60.0 + 10.0 * (double)(num3 * num3))) / (Main.worldSurface / 6.0));
            if ((double)num4 < 0.25)
                num4 = 0.25f;
            if ((double)num4 > 1.0)
                num4 = 1f;
            float num5 = num2 * num4;
            if (this.wet)
            {
                num5 = 0.2f;
                num1 = 7f;
            }
            if (this.soundDelay > 0)
                --this.soundDelay;
            if (this.life <= 0)
                this.active = false;
            this.oldTarget = this.target;
            this.oldDirection = this.direction;
            this.oldDirectionY = this.directionY;
            this.AI();
            if (this.type == 44)
                Lighting.addLight((int)((double)this.position.X + (double)(this.width / 2)) / 16, (int)((double)this.position.Y + 4.0) / 16, 0.9f, 0.75f, 0.5f);
            for (int index = 0; index < 256; ++index)
            {
                if (this.immune[index] > 0)
                    --this.immune[index];
            }
            if (!this.noGravity && !this.noTileCollide)
            {
                int index1 = (int)((double)this.position.X + (double)(this.width / 2)) / 16;
                int index2 = (int)((double)this.position.Y + (double)(this.height / 2)) / 16;
                if (Main.tile[index1, index2] == null)
                {
                    num5 = 0.0f;
                    this.velocity.X = 0.0f;
                    this.velocity.Y = 0.0f;
                }
            }
            if (!this.noGravity)
            {
                this.velocity.Y += num5;
                if ((double)this.velocity.Y > (double)num1)
                    this.velocity.Y = num1;
            }
            if ((double)this.velocity.X < 0.005 && (double)this.velocity.X > -0.005)
                this.velocity.X = 0.0f;
            if (Main.netMode != 1 && this.type != 37 && (this.friendly || this.type == 46 || (this.type == 55 || this.type == 74)))
            {
                if (this.life < this.lifeMax)
                {
                    ++this.friendlyRegen;
                    if (this.friendlyRegen > 300)
                    {
                        this.friendlyRegen = 0;
                        ++this.life;
                        this.netUpdate = true;
                    }
                }
                if (this.immune[(int)byte.MaxValue] == 0)
                {
                    Rectangle rectangle1 = new Rectangle((int)this.position.X, (int)this.position.Y, this.width, this.height);
                    for (int index = 0; index < 200; ++index)
                    {
                        if (Main.npc[index].active && !Main.npc[index].friendly && Main.npc[index].damage > 0)
                        {
                            Rectangle rectangle2 = new Rectangle((int)Main.npc[index].position.X, (int)Main.npc[index].position.Y, Main.npc[index].width, Main.npc[index].height);
                            if (rectangle1.Intersects(rectangle2))
                            {
                                int Damage = Main.npc[index].damage;
                                int num6 = 6;
                                int hitDirection = 1;
                                if ((double)Main.npc[index].position.X + (double)(Main.npc[index].width / 2) > (double)this.position.X + (double)(this.width / 2))
                                    hitDirection = -1;
                                Main.npc[i].StrikeNPC(Damage, (float)num6, hitDirection, false, false);
                                if (Main.netMode != 0)
                                    NetMessage.SendData(28, -1, -1, "", i, (float)Damage, (float)num6, (float)hitDirection, 0);
                                this.netUpdate = true;
                                this.immune[(int)byte.MaxValue] = 30;
                            }
                        }
                    }
                }
            }
            if (!this.noTileCollide)
            {
                bool flag1 = Collision.LavaCollision(this.position, this.width, this.height);
                if (flag1)
                {
                    this.lavaWet = true;
                    if (!this.lavaImmune && !this.dontTakeDamage && (Main.netMode != 1 && this.immune[(int)byte.MaxValue] == 0))
                    {
                        this.AddBuff(24, 420, false);
                        this.immune[(int)byte.MaxValue] = 30;
                        this.StrikeNPC(50, 0.0f, 0, false, false);
                        if (Main.netMode == 2 && Main.netMode != 0)
                            NetMessage.SendData(28, -1, -1, "", this.whoAmI, 50f, 0.0f, 0.0f, 0);
                    }
                }
                bool flag2;
                if (this.type == 72)
                {
                    flag2 = false;
                    this.wetCount = (byte)0;
                    flag1 = false;
                }
                else
                    flag2 = Collision.WetCollision(this.position, this.width, this.height);
                if (flag2)
                {
                    if (this.onFire && !this.lavaWet && Main.netMode != 1)
                    {
                        for (int b = 0; b < 5; ++b)
                        {
                            if (this.buffType[b] == 24)
                                this.DelBuff(b);
                        }
                    }
                    if (!this.wet && (int)this.wetCount == 0)
                    {
                        this.wetCount = (byte)10;
                        if (!flag1)
                        {
                            for (int index1 = 0; index1 < 30; ++index1)
                            {
                                int index2 = Dust.NewDust(new Vector2(this.position.X - 6f, (float)((double)this.position.Y + (double)(this.height / 2) - 8.0)), this.width + 12, 24, 33, 0.0f, 0.0f, 0, new Color(), 1f);
                                Main.dust[index2].velocity.Y -= 4f;
                                Main.dust[index2].velocity.X *= 2.5f;
                                Main.dust[index2].scale = 1.3f;
                                Main.dust[index2].alpha = 100;
                                Main.dust[index2].noGravity = true;
                            }
                            if (this.type != 1 && this.type != 59 && !this.noGravity)
                                Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 0);
                        }
                        else
                        {
                            for (int index1 = 0; index1 < 10; ++index1)
                            {
                                int index2 = Dust.NewDust(new Vector2(this.position.X - 6f, (float)((double)this.position.Y + (double)(this.height / 2) - 8.0)), this.width + 12, 24, 35, 0.0f, 0.0f, 0, new Color(), 1f);
                                Main.dust[index2].velocity.Y -= 1.5f;
                                Main.dust[index2].velocity.X *= 2.5f;
                                Main.dust[index2].scale = 1.3f;
                                Main.dust[index2].alpha = 100;
                                Main.dust[index2].noGravity = true;
                            }
                            if (this.type != 1 && this.type != 59 && !this.noGravity)
                                Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 1);
                        }
                    }
                    this.wet = true;
                }
                else if (this.wet)
                {
                    this.velocity.X *= 0.5f;
                    this.wet = false;
                    if ((int)this.wetCount == 0)
                    {
                        this.wetCount = (byte)10;
                        if (!this.lavaWet)
                        {
                            for (int index1 = 0; index1 < 30; ++index1)
                            {
                                int index2 = Dust.NewDust(new Vector2(this.position.X - 6f, (float)((double)this.position.Y + (double)(this.height / 2) - 8.0)), this.width + 12, 24, 33, 0.0f, 0.0f, 0, new Color(), 1f);
                                Main.dust[index2].velocity.Y -= 4f;
                                Main.dust[index2].velocity.X *= 2.5f;
                                Main.dust[index2].scale = 1.3f;
                                Main.dust[index2].alpha = 100;
                                Main.dust[index2].noGravity = true;
                            }
                            if (this.type != 1 && this.type != 59 && !this.noGravity)
                                Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 0);
                        }
                        else
                        {
                            for (int index1 = 0; index1 < 10; ++index1)
                            {
                                int index2 = Dust.NewDust(new Vector2(this.position.X - 6f, (float)((double)this.position.Y + (double)(this.height / 2) - 8.0)), this.width + 12, 24, 35, 0.0f, 0.0f, 0, new Color(), 1f);
                                Main.dust[index2].velocity.Y -= 1.5f;
                                Main.dust[index2].velocity.X *= 2.5f;
                                Main.dust[index2].scale = 1.3f;
                                Main.dust[index2].alpha = 100;
                                Main.dust[index2].noGravity = true;
                            }
                            if (this.type != 1 && this.type != 59 && !this.noGravity)
                                Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 1);
                        }
                    }
                }
                if (!this.wet)
                    this.lavaWet = false;
                if ((int)this.wetCount > 0)
                    --this.wetCount;
                bool flag3 = false;
                if (this.aiStyle == 10)
                    flag3 = true;
                if (this.aiStyle == 14)
                    flag3 = true;
                if (this.aiStyle == 3 && this.directionY == 1)
                    flag3 = true;
                this.oldVelocity = this.velocity;
                this.collideX = false;
                this.collideY = false;
                if (this.wet)
                {
                    Vector2 vector2_1 = this.velocity;
                    this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, flag3, flag3);
                    if (Collision.up)
                        this.velocity.Y = 0.01f;
                    Vector2 vector2_2 = this.velocity * 0.5f;
                    if ((double)this.velocity.X != (double)vector2_1.X)
                    {
                        vector2_2.X = this.velocity.X;
                        this.collideX = true;
                    }
                    if ((double)this.velocity.Y != (double)vector2_1.Y)
                    {
                        vector2_2.Y = this.velocity.Y;
                        this.collideY = true;
                    }
                    this.oldPosition = this.position;
                    this.position += vector2_2;
                }
                else
                {
                    if (this.type == 72)
                    {
                        Vector2 Position = new Vector2(this.position.X + (float)(this.width / 2), this.position.Y + (float)(this.height / 2));
                        int Width = 12;
                        int Height = 12;
                        Position.X -= (float)(Width / 2);
                        Position.Y -= (float)(Height / 2);
                        this.velocity = Collision.TileCollision(Position, this.velocity, Width, Height, true, true);
                    }
                    else
                        this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, flag3, flag3);
                    if (Collision.up)
                        this.velocity.Y = 0.01f;
                    if ((double)this.oldVelocity.X != (double)this.velocity.X)
                        this.collideX = true;
                    if ((double)this.oldVelocity.Y != (double)this.velocity.Y)
                        this.collideY = true;
                    this.oldPosition = this.position;
                    this.position += this.velocity;
                }
            }
            else
            {
                this.oldPosition = this.position;
                this.position += this.velocity;
            }
            if (Main.netMode != 1 && !this.noTileCollide && (this.lifeMax > 1 && Collision.SwitchTiles(this.position, this.width, this.height, this.oldPosition)) && this.type == 46)
            {
                this.ai[0] = 1f;
                this.ai[1] = 400f;
                this.ai[2] = 0.0f;
            }
            if (!this.active)
                this.netUpdate = true;
            if (Main.netMode == 2)
            {
                if (this.townNPC)
                    this.netSpam = 0;
                if (this.netUpdate2)
                    this.netUpdate = true;
                if (!this.active)
                    this.netSpam = 0;
                if (this.netUpdate)
                {
                    if (this.netSpam <= 180)
                    {
                        this.netSpam += 60;
                        NetMessage.SendData(23, -1, -1, "", i, 0.0f, 0.0f, 0.0f, 0);
                        this.netUpdate2 = false;
                    }
                    else
                        this.netUpdate2 = true;
                }
                if (this.netSpam > 0)
                    --this.netSpam;
                if (this.active && this.townNPC && NPC.TypeToNum(this.type) != -1)
                {
                    if (this.homeless != this.oldHomeless || this.homeTileX != this.oldHomeTileX || this.homeTileY != this.oldHomeTileY)
                    {
                        int num6 = 0;
                        if (this.homeless)
                            num6 = 1;
                        NetMessage.SendData(60, -1, -1, "", i, (float)Main.npc[i].homeTileX, (float)Main.npc[i].homeTileY, (float)num6, 0);
                    }
                    this.oldHomeless = this.homeless;
                    this.oldHomeTileX = this.homeTileX;
                    this.oldHomeTileY = this.homeTileY;
                }
            }
            this.FindFrame();
            this.CheckActive();
            this.netUpdate = false;
            this.justHit = false;
            if (this.type == 120 || this.type == 137 || this.type == 138)
            {
                for (int index = this.oldPos.Length - 1; index > 0; --index)
                {
                    this.oldPos[index] = this.oldPos[index - 1];
                    Lighting.addLight((int)this.position.X / 16, (int)this.position.Y / 16, 0.3f, 0.0f, 0.2f);
                }
                this.oldPos[0] = this.position;
            }
            else if (this.type == 94)
            {
                for (int index = this.oldPos.Length - 1; index > 0; --index)
                    this.oldPos[index] = this.oldPos[index - 1];
                this.oldPos[0] = this.position;
            }
            else
            {
                if (this.type != 125 && this.type != 126 && (this.type != (int)sbyte.MaxValue && this.type != 128) && (this.type != 129 && this.type != 130 && (this.type != 131 && this.type != 139)) && this.type != 140)
                    return;
                for (int index = this.oldPos.Length - 1; index > 0; --index)
                    this.oldPos[index] = this.oldPos[index - 1];
                this.oldPos[0] = this.position;
            }
        }
		public Color GetAlpha(Color newColor)
		{
			float num = (float)(255 - this.alpha) / 255f;
			int num2 = (int)((float)newColor.R * num);
			int num3 = (int)((float)newColor.G * num);
			int num4 = (int)((float)newColor.B * num);
			int num5 = (int)newColor.A - this.alpha;
			if (this.type == 25 || this.type == 30 || this.type == 33 || this.type == 59 || this.type == 60)
			{
				return new Color(200, 200, 200, 0);
			}
			if (this.type == 72)
			{
				num2 = (int)newColor.R;
				num3 = (int)newColor.G;
				num4 = (int)newColor.B;
			}
			else
			{
				if (this.type == 64 || this.type == 63 || this.type == 75 || this.type == 103)
				{
					num2 = (int)((double)newColor.R * 1.5);
					num3 = (int)((double)newColor.G * 1.5);
					num4 = (int)((double)newColor.B * 1.5);
					if (num2 > 255)
					{
						num2 = 255;
					}
					if (num3 > 255)
					{
						num3 = 255;
					}
					if (num4 > 255)
					{
						num4 = 255;
					}
				}
			}
			if (num5 < 0)
			{
				num5 = 0;
			}
			if (num5 > 255)
			{
				num5 = 255;
			}
			return new Color(num2, num3, num4, num5);
		}
		public Color GetColor(Color newColor)
		{
			int num = (int)(this.color.R - (255 - newColor.R));
			int num2 = (int)(this.color.G - (255 - newColor.G));
			int num3 = (int)(this.color.B - (255 - newColor.B));
			int num4 = (int)(this.color.A - (255 - newColor.A));
			if (num < 0)
			{
				num = 0;
			}
			if (num > 255)
			{
				num = 255;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 255)
			{
				num2 = 255;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num3 > 255)
			{
				num3 = 255;
			}
			if (num4 < 0)
			{
				num4 = 0;
			}
			if (num4 > 255)
			{
				num4 = 255;
			}
			return new Color(num, num2, num3, num4);
		}
        public string GetChat()
        {
            Recipe.FindRecipes();
            string str1 = Main.chrName[18];
            string str2 = Main.chrName[17];
            string str3 = Main.chrName[19];
            string str4 = Main.chrName[20];
            string str5 = Main.chrName[38];
            string str6 = Main.chrName[54];
            string str7 = Main.chrName[22];
            string str8 = Main.chrName[108];
            string str9 = Main.chrName[107];
            string str10 = Main.chrName[124];
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            bool flag4 = false;
            bool flag5 = false;
            bool flag6 = false;
            bool flag7 = false;
            bool flag8 = false;
            bool flag9 = false;
            for (int index = 0; index < 200; ++index)
            {
                if (Main.npc[index].active)
                {
                    if (Main.npc[index].type == 17)
                        flag1 = true;
                    else if (Main.npc[index].type == 18)
                        flag2 = true;
                    else if (Main.npc[index].type == 19)
                        flag3 = true;
                    else if (Main.npc[index].type == 20)
                        flag4 = true;
                    else if (Main.npc[index].type == 37)
                        flag5 = true;
                    else if (Main.npc[index].type == 38)
                        flag6 = true;
                    else if (Main.npc[index].type == 124)
                        flag7 = true;
                    else if (Main.npc[index].type == 107)
                        flag8 = true;
                    else if (Main.npc[index].type == 2)
                        flag9 = true;
                }
            }
            string str11 = "";
            if (this.type == 17)
            {
                if (!NPC.downedBoss1 && Main.rand.Next(3) == 0)
                    str11 = Main.player[Main.myPlayer].statLifeMax >= 200 ? (Main.player[Main.myPlayer].statDefense > 10 ? Lang.dialog(3) : Lang.dialog(2)) : Lang.dialog(1);
                else if (Main.dayTime)
                {
                    if (Main.time < 16200.0)
                    {
                        switch (Main.rand.Next(3))
                        {
                            case 0:
                                str11 = Lang.dialog(4);
                                break;
                            case 1:
                                str11 = Lang.dialog(5);
                                break;
                            default:
                                str11 = Lang.dialog(6);
                                break;
                        }
                    }
                    else if (Main.time > 37800.0)
                    {
                        switch (Main.rand.Next(3))
                        {
                            case 0:
                                str11 = Lang.dialog(7);
                                break;
                            case 1:
                                str11 = Lang.dialog(8);
                                break;
                            default:
                                str11 = Lang.dialog(9);
                                break;
                        }
                    }
                    else
                    {
                        switch (Main.rand.Next(3))
                        {
                            case 0:
                                str11 = Lang.dialog(10);
                                break;
                            case 1:
                                str11 = Lang.dialog(11);
                                break;
                            default:
                                str11 = Lang.dialog(12);
                                break;
                        }
                    }
                }
                else if (Main.bloodMoon)
                {
                    if (flag2 && flag7 && Main.rand.Next(3) == 0)
                    {
                        str11 = Lang.dialog(13);
                    }
                    else
                    {
                        switch (Main.rand.Next(4))
                        {
                            case 0:
                                str11 = Lang.dialog(14);
                                break;
                            case 1:
                                str11 = Lang.dialog(15);
                                break;
                            case 2:
                                str11 = Lang.dialog(16);
                                break;
                            default:
                                str11 = Lang.dialog(17);
                                break;
                        }
                    }
                }
                else if (Main.time < 9720.0)
                    str11 = Main.rand.Next(2) != 0 ? Lang.dialog(19) : Lang.dialog(18);
                else if (Main.time > 22680.0)
                {
                    str11 = Main.rand.Next(2) != 0 ? Lang.dialog(21) : Lang.dialog(20);
                }
                else
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(22);
                            break;
                        case 1:
                            str11 = Lang.dialog(23);
                            break;
                        default:
                            str11 = Lang.dialog(24);
                            break;
                    }
                }
            }
            else if (this.type == 18)
            {
                if (Main.bloodMoon)
                {
                    if ((double)Main.player[Main.myPlayer].statLife < (double)Main.player[Main.myPlayer].statLifeMax * 0.66)
                    {
                        switch (Main.rand.Next(3))
                        {
                            case 0:
                                str11 = Lang.dialog(25);
                                break;
                            case 1:
                                str11 = Lang.dialog(26);
                                break;
                            default:
                                str11 = Lang.dialog(27);
                                break;
                        }
                    }
                    else
                    {
                        switch (Main.rand.Next(4))
                        {
                            case 0:
                                str11 = Lang.dialog(28);
                                break;
                            case 1:
                                str11 = Lang.dialog(29);
                                break;
                            case 2:
                                str11 = Lang.dialog(30);
                                break;
                            default:
                                str11 = Lang.dialog(31);
                                break;
                        }
                    }
                }
                else if (Main.rand.Next(3) == 0 && !NPC.downedBoss3)
                    str11 = Lang.dialog(32);
                else if (flag6 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(33);
                else if (flag3 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(34);
                else if (flag9 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(35);
                else if ((double)Main.player[Main.myPlayer].statLife < (double)Main.player[Main.myPlayer].statLifeMax * 0.33)
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            str11 = Lang.dialog(36);
                            break;
                        case 1:
                            str11 = Lang.dialog(37);
                            break;
                        case 2:
                            str11 = Lang.dialog(38);
                            break;
                        case 3:
                            str11 = Lang.dialog(39);
                            break;
                        default:
                            str11 = Lang.dialog(40);
                            break;
                    }
                }
                else if ((double)Main.player[Main.myPlayer].statLife < (double)Main.player[Main.myPlayer].statLifeMax * 0.66)
                {
                    switch (Main.rand.Next(7))
                    {
                        case 0:
                            str11 = Lang.dialog(41);
                            break;
                        case 1:
                            str11 = Lang.dialog(42);
                            break;
                        case 2:
                            str11 = Lang.dialog(43);
                            break;
                        case 3:
                            str11 = Lang.dialog(44);
                            break;
                        case 4:
                            str11 = Lang.dialog(45);
                            break;
                        case 5:
                            str11 = Lang.dialog(46);
                            break;
                        default:
                            str11 = Lang.dialog(47);
                            break;
                    }
                }
                else
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            str11 = Lang.dialog(48);
                            break;
                        case 1:
                            str11 = Lang.dialog(49);
                            break;
                        case 2:
                            str11 = Lang.dialog(50);
                            break;
                        default:
                            str11 = Lang.dialog(51);
                            break;
                    }
                }
            }
            else if (this.type == 19)
            {
                if (NPC.downedBoss3 && !Main.hardMode)
                    str11 = Lang.dialog(58);
                else if (flag2 && Main.rand.Next(5) == 0)
                    str11 = Lang.dialog(59);
                else if (flag2 && Main.rand.Next(5) == 0)
                    str11 = Lang.dialog(60);
                else if (flag4 && Main.rand.Next(5) == 0)
                    str11 = Lang.dialog(61);
                else if (flag6 && Main.rand.Next(5) == 0)
                    str11 = Lang.dialog(62);
                else if (flag6 && Main.rand.Next(5) == 0)
                    str11 = Lang.dialog(63);
                else if (Main.bloodMoon)
                {
                    str11 = Main.rand.Next(2) != 0 ? Lang.dialog(65) : Lang.dialog(64);
                }
                else
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(66);
                            break;
                        case 1:
                            str11 = Lang.dialog(67);
                            break;
                        default:
                            str11 = Lang.dialog(68);
                            break;
                    }
                }
            }
            else if (this.type == 20)
            {
                if (!NPC.downedBoss2 && Main.rand.Next(3) == 0)
                    str11 = Lang.dialog(69);
                else if (flag3 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(70);
                else if (flag1 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(71);
                else if (flag5 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(72);
                else if (Main.bloodMoon)
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            str11 = Lang.dialog(73);
                            break;
                        case 1:
                            str11 = Lang.dialog(74);
                            break;
                        case 2:
                            str11 = Lang.dialog(75);
                            break;
                        default:
                            str11 = Lang.dialog(76);
                            break;
                    }
                }
                else
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            str11 = Lang.dialog(77);
                            break;
                        case 1:
                            str11 = Lang.dialog(78);
                            break;
                        case 2:
                            str11 = Lang.dialog(79);
                            break;
                        case 3:
                            str11 = Lang.dialog(80);
                            break;
                        default:
                            str11 = Lang.dialog(81);
                            break;
                    }
                }
            }
            else if (this.type == 37)
            {
                if (Main.dayTime)
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(82);
                            break;
                        case 1:
                            str11 = Lang.dialog(83);
                            break;
                        default:
                            str11 = Lang.dialog(84);
                            break;
                    }
                }
                else if (Main.player[Main.myPlayer].statLifeMax < 300 || Main.player[Main.myPlayer].statDefense < 10)
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            str11 = Lang.dialog(85);
                            break;
                        case 1:
                            str11 = Lang.dialog(86);
                            break;
                        case 2:
                            str11 = Lang.dialog(87);
                            break;
                        default:
                            str11 = Lang.dialog(88);
                            break;
                    }
                }
                else
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            str11 = Lang.dialog(89);
                            break;
                        case 1:
                            str11 = Lang.dialog(90);
                            break;
                        case 2:
                            str11 = Lang.dialog(91);
                            break;
                        default:
                            str11 = Lang.dialog(92);
                            break;
                    }
                }
            }
            else if (this.type == 38)
            {
                if (!NPC.downedBoss2 && Main.rand.Next(3) == 0)
                    Lang.dialog(93);
                if (Main.bloodMoon)
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(94);
                            break;
                        case 1:
                            str11 = Lang.dialog(95);
                            break;
                        default:
                            str11 = Lang.dialog(96);
                            break;
                    }
                }
                else if (flag3 && Main.rand.Next(5) == 0)
                    str11 = Lang.dialog(97);
                else if (flag3 && Main.rand.Next(5) == 0)
                    str11 = Lang.dialog(98);
                else if (flag2 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(99);
                else if (flag4 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(100);
                else if (!Main.dayTime)
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            str11 = Lang.dialog(101);
                            break;
                        case 1:
                            str11 = Lang.dialog(102);
                            break;
                        case 2:
                            str11 = Lang.dialog(103);
                            break;
                        default:
                            str11 = Lang.dialog(104);
                            break;
                    }
                }
                else
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            str11 = Lang.dialog(105);
                            break;
                        case 1:
                            str11 = Lang.dialog(106);
                            break;
                        case 2:
                            str11 = Lang.dialog(107);
                            break;
                        case 3:
                            str11 = Lang.dialog(108);
                            break;
                        default:
                            str11 = Lang.dialog(109);
                            break;
                    }
                }
            }
            else if (this.type == 54)
            {
                if (!flag7 && Main.rand.Next(2) == 0)
                    str11 = Lang.dialog(110);
                else if (Main.bloodMoon)
                    str11 = Lang.dialog(111);
                else if (flag2 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(112);
                else if (Main.player[Main.myPlayer].head == 24)
                {
                    str11 = Lang.dialog(113);
                }
                else
                {
                    switch (Main.rand.Next(6))
                    {
                        case 0:
                            str11 = Lang.dialog(114);
                            break;
                        case 1:
                            str11 = Lang.dialog(115);
                            break;
                        case 2:
                            str11 = Lang.dialog(116);
                            break;
                        case 3:
                            str11 = Lang.dialog(117);
                            break;
                        case 4:
                            str11 = Lang.dialog(118);
                            break;
                        default:
                            str11 = Lang.dialog(119);
                            break;
                    }
                }
            }
            else if (this.type == 105)
                str11 = Lang.dialog(120);
            else if (this.type == 107)
            {
                if (this.homeless)
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            str11 = Lang.dialog(121);
                            break;
                        case 1:
                            str11 = Lang.dialog(122);
                            break;
                        case 2:
                            str11 = Lang.dialog(123);
                            break;
                        case 3:
                            str11 = Lang.dialog(124);
                            break;
                        default:
                            str11 = Lang.dialog(125);
                            break;
                    }
                }
                else if (flag7 && Main.rand.Next(4) == 0)
                    str11 = Lang.dialog(126);
                else if (!Main.dayTime)
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            str11 = Lang.dialog((int)sbyte.MaxValue);
                            break;
                        case 1:
                            str11 = Lang.dialog(128);
                            break;
                        case 2:
                            str11 = Lang.dialog(129);
                            break;
                        case 3:
                            str11 = Lang.dialog(130);
                            break;
                        default:
                            str11 = Lang.dialog(131);
                            break;
                    }
                }
                else
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            str11 = Lang.dialog(132);
                            break;
                        case 1:
                            str11 = Lang.dialog(133);
                            break;
                        case 2:
                            str11 = Lang.dialog(134);
                            break;
                        case 3:
                            str11 = Lang.dialog(135);
                            break;
                        default:
                            str11 = Lang.dialog(136);
                            break;
                    }
                }
            }
            else if (this.type == 106)
                str11 = Lang.dialog(137);
            else if (this.type == 108)
            {
                if (this.homeless)
                {
                    int num = Main.rand.Next(3);
                    if (num == 0)
                        str11 = Lang.dialog(138);
                    else if (num == 1 && !Main.player[Main.myPlayer].male)
                        str11 = Lang.dialog(139);
                    else if (num == 1)
                        str11 = Lang.dialog(140);
                    else if (num == 2)
                        str11 = Lang.dialog(141);
                }
                else if (Main.player[Main.myPlayer].male && flag9 && Main.rand.Next(6) == 0)
                    str11 = Lang.dialog(142);
                else if (Main.player[Main.myPlayer].male && flag6 && Main.rand.Next(6) == 0)
                    str11 = Lang.dialog(143);
                else if (Main.player[Main.myPlayer].male && flag8 && Main.rand.Next(6) == 0)
                    str11 = Lang.dialog(144);
                else if (!Main.player[Main.myPlayer].male && flag2 && Main.rand.Next(6) == 0)
                    str11 = Lang.dialog(145);
                else if (!Main.player[Main.myPlayer].male && flag7 && Main.rand.Next(6) == 0)
                    str11 = Lang.dialog(146);
                else if (!Main.player[Main.myPlayer].male && flag4 && Main.rand.Next(6) == 0)
                    str11 = Lang.dialog(147);
                else if (!Main.dayTime)
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(148);
                            break;
                        case 1:
                            str11 = Lang.dialog(149);
                            break;
                        case 2:
                            str11 = Lang.dialog(150);
                            break;
                    }
                }
                else
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            str11 = Lang.dialog(151);
                            break;
                        case 1:
                            str11 = Lang.dialog(152);
                            break;
                        case 2:
                            str11 = Lang.dialog(153);
                            break;
                        case 3:
                            str11 = Lang.dialog(154);
                            break;
                        default:
                            str11 = Lang.dialog(155);
                            break;
                    }
                }
            }
            else if (this.type == 123)
                str11 = Lang.dialog(156);
            else if (this.type == 124)
            {
                if (this.homeless)
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            str11 = Lang.dialog(157);
                            break;
                        case 1:
                            str11 = Lang.dialog(158);
                            break;
                        case 2:
                            str11 = Lang.dialog(159);
                            break;
                        default:
                            str11 = Lang.dialog(160);
                            break;
                    }
                }
                else if (Main.bloodMoon)
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            str11 = Lang.dialog(161);
                            break;
                        case 1:
                            str11 = Lang.dialog(162);
                            break;
                        case 2:
                            str11 = Lang.dialog(163);
                            break;
                        default:
                            str11 = Lang.dialog(164);
                            break;
                    }
                }
                else if (flag8 && Main.rand.Next(6) == 0)
                    str11 = Lang.dialog(165);
                else if (flag3 && Main.rand.Next(6) == 0)
                {
                    str11 = Lang.dialog(166);
                }
                else
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(167);
                            break;
                        case 1:
                            str11 = Lang.dialog(168);
                            break;
                        default:
                            str11 = Lang.dialog(169);
                            break;
                    }
                }
            }
            else if (this.type == 22)
            {
                if (Main.bloodMoon)
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(170);
                            break;
                        case 1:
                            str11 = Lang.dialog(171);
                            break;
                        default:
                            str11 = Lang.dialog(172);
                            break;
                    }
                }
                else if (!Main.dayTime)
                {
                    str11 = Lang.dialog(173);
                }
                else
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            str11 = Lang.dialog(174);
                            break;
                        case 1:
                            str11 = Lang.dialog(175);
                            break;
                        default:
                            str11 = Lang.dialog(176);
                            break;
                    }
                }
            }
            else if (this.type == 142)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        str11 = Lang.dialog(224);
                        break;
                    case 1:
                        str11 = Lang.dialog(225);
                        break;
                    case 2:
                        str11 = Lang.dialog(226);
                        break;
                }
            }
            return str11;
        }
		public object Clone()
		{
			return base.MemberwiseClone();
		}
	}
}
